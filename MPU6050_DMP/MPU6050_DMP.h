// Only modify this file to include
// - function definitions (prototypes)
// - include files
// - extern variable definitions
// In the appropriate section

#ifndef _MPU6050_DMP_H_
#define _MPU6050_DMP_H_

#include "I2Cdev.h"
#include "MPU6050_6Axis_MotionApps20.h"

#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
    #include "Wire.h"
#endif

#include "MotorNXT.h"
#include "MPU6050CalibrationOffset.h"

#include "PinChangeInt.h"

#include "SerialArduinoProcessing.h"
#include "Config.h"

#include "PID_v1.h"

//end of add your includes here
#ifdef __cplusplus
extern "C" {
#endif

void loop();
void setup();


#ifdef __cplusplus
} // extern "C"
#endif
//add your function definitions for the project MPU6050DMP here

/////////////////////////FEATURES/////////////////////////

//#define CALIBRATE_OFFSET

/////////////////////////FEATURES/////////////////////////

MPU6050 mpu;

bool dmpReady = false;  // set true if DMP init was successful
volatile bool mpuInterrupt = false;     // indicates whether MPU interrupt pin has gone high

uint8_t mpuIntStatus;   // holds actual interrupt status byte from MPU
uint8_t devStatus;      // return status after each device operation (0 = success, !0 = error)
uint16_t packetSize;    // expected DMP packet size (default is 42 bytes)
uint16_t fifoCount;     // count of all bytes currently in FIFO
uint8_t fifoBuffer[64]; // FIFO storage buffer

// orientation/motion vars
Quaternion q;           // [w, x, y, z]         quaternion container
VectorFloat gravity;    // [x, y, z]            gravity vector
float ypr[3];           // [yaw, pitch, roll]   yaw/pitch/roll container and gravity vector

/////////////////////////Calibrate OFFSET/////////////////////////
int gX_offset = 37;
int gY_offset = -4;
int gZ_offset = -26;
int aZ_offset = 1615;
/////////////////////////Calibrate OFFSET/////////////////////////

//////////////////PID//////////////////
double output;
double input;
double setpoint = 2;
double pTerm_Wheel=0, dTerm_Wheel=0;
long count, last_count;

PID myPID(&input, &output, &setpoint,59,69,10, DIRECT);
//////////////////PID//////////////////

/////////////////////////NXT Motor/////////////////////////

MotorNXT motor1(AMOTORIN1, AMOTORIN2, AENEBLEPIN, ATACHO0, ATACHO1);
MotorNXT motor2(BMOTORIN1, BMOTORIN2, BENEBLEPIN, BTACHO0, BTACHO1);

/////////////////////////NXT Motor/////////////////////////
unsigned long timeToSendSerial = 40;
unsigned long lastTime = 0;
SerialArduinoProcessing arduinoProcessing;

//Do not add code below this line
#endif /* _MPU6050_DMP_H_ */
