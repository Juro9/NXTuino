################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../MPU6050_DMP.cpp 

LINK_OBJ += \
./MPU6050_DMP.cpp.o 

CPP_DEPS += \
./MPU6050_DMP.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
MPU6050_DMP.cpp.o: ../MPU6050_DMP.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:/Programs/Arduino/hardware/tools/avr/bin/avr-g++" -c -g -Os -fno-exceptions -ffunction-sections -fdata-sections -MMD -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=156-r2 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR    -I"C:\Programs\Arduino\hardware\arduino\avr\cores\arduino" -I"C:\Programs\Arduino\hardware\arduino\avr\variants\standard" -I"C:\Programs\Arduino\libraries\I2Cdev" -I"C:\Programs\Arduino\libraries\MPU6050" -I"C:\Programs\Arduino\hardware\arduino\avr\libraries\Wire" -I"C:\Programs\Arduino\hardware\arduino\avr\libraries\Wire\utility" -I"C:\Programs\Arduino\libraries\MPU6050CalibrationOffset" -I"C:\Programs\Arduino\libraries\PinChangeInt" -I"C:\Programs\Arduino\libraries\SerialArduinoProcessing" -I"C:\Programs\Arduino\libraries\MotorNXT" -I"C:\Programs\Arduino\libraries\PID_v1" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"   -w
	@echo 'Finished building: $<'
	@echo ' '


