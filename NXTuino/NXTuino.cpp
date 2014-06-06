// Do not remove the include below
#include "NXTuino.h"

/////////////////////////Initialize DMP/////////////////////////
void dmpDataReady() {
	mpuInterrupt = true;
}

void setDMP() {
	// initialize device
	Serial.println(F("Initializing I2C devices..."));
	mpu.initialize();
	Serial.println(F("Testing device connections...")); // verify connection
	Serial.println(
			mpu.testConnection() ?
					F("MPU6050 connection successful") :
					F("MPU6050 connection failed"));
	// wait for ready
	while (Serial.available() && Serial.read())
		; // empty buffer

	// load and configure the DMP
	Serial.println(F("Initializing DMP..."));
	devStatus = mpu.dmpInitialize();

	mpu.setXGyroOffset(gX_offset); //20
	mpu.setYGyroOffset(gY_offset); //15
	mpu.setZGyroOffset(gZ_offset); // -85
	mpu.setZAccelOffset(aZ_offset); // 1688 factory default for my test chip

	// make sure it worked (returns 0 if so)
	if (devStatus == 0) {
		// turn on the DMP, now that it's ready
		Serial.println(F("Enabling DMP..."));
		mpu.setDMPEnabled(true);
		// enable Arduino interrupt detection
		Serial.println(
				F(
						"Enabling interrupt detection (Arduino external interrupt 0)..."));
		//attachInterrupt(0, dmpDataReady, RISING);
		PCintPort::attachInterrupt(2, &dmpDataReady, RISING);

		mpuIntStatus = mpu.getIntStatus();

		// set our DMP Ready flag so the main loop() function knows it's okay to use it
		Serial.println(F("DMP ready! Waiting for first interrupt..."));
		dmpReady = true;

		// get expected DMP packet size for later comparison
		packetSize = mpu.dmpGetFIFOPacketSize();

	} else {
		// ERROR!
		// 1 = initial memory load failed
		// 2 = DMP configuration updates failed
		// (if it's going to break, usually the code will be 1)
		Serial.print(F("DMP Initialization failed (code "));
		Serial.print(devStatus);
		Serial.println(F(")"));
	}

}
/////////////////////////Initialize DMP//////////////////////////

void serialOutGUI() {
	String printSerial = "";
	printSerial += ",";
	printSerial += "pT/";
	printSerial += myPID.GetPterm();
	printSerial += ",";
	printSerial += "iT/";
	printSerial += myPID.GetIterm();
	printSerial += ",";
	printSerial += "dT/";
	printSerial += myPID.GetDterm();

	printSerial += ",";
	printSerial += "output/";
	printSerial += output;

	printSerial += ",";
	printSerial += "Roll/";
	printSerial += input;
	printSerial += ",";
	printSerial += "Pitch/";
	printSerial += ypr[1] * 180 / M_PI;
	printSerial += ",";
	printSerial += "Yaw/";
	printSerial += ypr[0] * 180 / M_PI;
	printSerial += ",";

	Serial.println(printSerial);
}

void encode1() {		//interrupt rutine for Encoder
	motor1.update();
}
void encode2() {
	motor2.update();
}

void setup() {

#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
	Wire.begin();
	TWBR = 24; // 400kHz I2C clock (200kHz if CPU is 8MHz)
#endif
	Serial.begin(115200);

	/////////////////////////Calibrate OFFSET/////////////////////////
#ifdef CALIBRATE_OFFSET

	MPU6050CalibrationOffset accel;			//calculate offset
	accel.calculate(&gX_offset, &gY_offset, &gZ_offset, &aZ_offset);
	//Wire.endTransmission();
#endif
	/////////////////////////Calibrate OFFSET/////////////////////////

	setDMP(); 				//Initialize DMP

	myPID.SetMode(AUTOMATIC);
	myPID.SetOutputLimits(-255.0, 255.0);
	myPID.SetSampleTime(10);
	myPID.SetTunings(97, 33, 31.5);

	motor1.setMode(MANUAL);
	motor2.setMode(MANUAL);

	PCintPort::attachInterrupt(ATACHO0, &encode1, CHANGE);
	PCintPort::attachInterrupt(BTACHO0, &encode2, CHANGE);
}

void loop() {
	/*****************************MPU 6050*****************************/
	// if programming failed, don't try to do anything
	if (!dmpReady)
		return;
	// wait for MPU interrupt or extra packet(s) available
	while (!mpuInterrupt && fifoCount < packetSize) {

	}
	// reset interrupt flag and get INT_STATUS byte
	mpuInterrupt = false;
	mpuIntStatus = mpu.getIntStatus();

	// get current FIFO count
	fifoCount = mpu.getFIFOCount();

	// check for overflow (this should never happen unless our code is too inefficient)
	if ((mpuIntStatus & 0x10) || fifoCount == 1024) {
		// reset so we can continue cleanly
		mpu.resetFIFO();
		Serial.println(F("FIFO overflow!"));

		// otherwise, check for DMP data ready interrupt (this should happen frequently)
	} else if (mpuIntStatus & 0x02) {
		// wait for correct available data length, should be a VERY short wait
		while (fifoCount < packetSize)
			fifoCount = mpu.getFIFOCount();

		// read a packet from FIFO
		mpu.getFIFOBytes(fifoBuffer, packetSize);

		// track FIFO count here in case there is > 1 packet available
		// (this lets us immediately read more without waiting for an interrupt)
		fifoCount -= packetSize;

		// display Euler angles in degrees
		mpu.dmpGetQuaternion(&q, fifoBuffer);
		mpu.dmpGetGravity(&gravity, &q);
		mpu.dmpGetYawPitchRoll(ypr, &q, &gravity);
	}
	/*****************************MPU 6050*****************************/

	input = ((ypr[2]) * 180 / M_PI);

	if (abs(input) > 15) {
		myPID.SetMode(MANUAL);
		output = 0;
	} else {
		myPID.SetMode(AUTOMATIC);
		myPID.Compute();
	}
motor1.setMotor(-(output));
motor2.setMotor(-(output));

	if ((millis() - lastTime) >= timeToSendSerial) {
		serialOutGUI();


		lastTime = millis();
	}




	arduinoProcessing.serialIn_GUI_Csharp();

	if (arduinoProcessing.getKp() != myPID.GetKp()
			|| arduinoProcessing.getKi() != myPID.GetKi()
			|| arduinoProcessing.getKd() != myPID.GetKd()) {
		myPID.SetTunings(arduinoProcessing.getKp(), arduinoProcessing.getKi(),
				arduinoProcessing.getKd());
		String printSerial = "";
		printSerial += ",P/";
		printSerial += myPID.GetKp();
		printSerial += ",";
		printSerial += "I/";
		printSerial += myPID.GetKi();
		printSerial += ",";
		printSerial += "D/";
		printSerial += myPID.GetKd();
		printSerial += ",";
		Serial.println(printSerial);

	}

	if (arduinoProcessing.getSetpoint() != setpoint) {
		setpoint = arduinoProcessing.getSetpoint();

		String printSerial = "";
		printSerial += ",setpoint/";
		printSerial += setpoint;
		printSerial += ",";
		Serial.println(printSerial);
	}
//
//	if (arduinoProcessing.getK() != K)
//		K = arduinoProcessing.getK();

}
