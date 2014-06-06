################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.init

RM := rm -rf

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir.mk
-include arduino/core/avr-libc/subdir.mk
-include arduino/core/subdir.mk
-include Libraries/Wire/utility/subdir.mk
-include Libraries/Wire/subdir.mk
-include Libraries/SerialArduinoProcessing/subdir.mk
-include Libraries/PinChangeInt/subdir.mk
-include Libraries/PID_v1/subdir.mk
-include Libraries/MotorNXT/subdir.mk
-include Libraries/MPU6050CalibrationOffset/subdir.mk
-include Libraries/MPU6050/subdir.mk
-include Libraries/I2Cdev/subdir.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
AR += \
C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/arduino.ar \

ELF += \
NXTuino.elf \

EEP += \
NXTuino.eep \

FLASH_IMAGE += \
NXTuino.hex \


# All Target
all: NXTuino

# Tool invocations
NXTuino: $(FLASH_IMAGE)
	@echo 'Building target: $@'
	@echo 'Printing size:'
	"C:/Programs/Arduino/hardware/tools/avr/bin/avr-size" -A "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/NXTuino.elf"
	@echo 'Finished building target: $@'
	@echo ' '

C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/arduino.ar: $(AR_OBJ)
	@echo 'Starting archiver'
	"C:/Programs/Arduino/hardware/tools/avr/bin/avr-ar" rcs "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/arduino.ar"   $(AR_OBJ)
	@echo 'Finished building: $@'
	@echo ' '

NXTuino.elf: $(LINK_OBJ) $(AR)
	@echo 'Starting combiner'
	"C:/Programs/Arduino/hardware/tools/avr/bin/avr-gcc" -Os -Wl,--gc-sections -mmcu=atmega328p -o "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/NXTuino.elf"   $(LINK_OBJ) $(AR)  "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/arduino.ar" "-LC:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release" -lm
	@echo 'Finished building: $@'
	@echo ' '

NXTuino.eep: $(ELF)
	@echo 'Create eeprom image'
	"C:/Programs/Arduino/hardware/tools/avr/bin/avr-objcopy" -O ihex -j .eeprom --set-section-flags=.eeprom=alloc,load --no-change-warnings --change-section-lma .eeprom=0 "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/NXTuino.elf" "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/NXTuino.eep"
	@echo 'Finished building: $@'
	@echo ' '

NXTuino.hex: $(EEP)
	@echo 'Create Flash image (ihex format)'
	"C:/Programs/Arduino/hardware/tools/avr/bin/avr-objcopy" -O ihex -R .eeprom "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/NXTuino.elf" "C:/Users/Duri/Documents/Workspace/Eclipse_C++_Arduino/NXTuino/Release/NXTuino.hex"
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(C_UPPER_DEPS)$(C_DEPS)$(AR)$(EEP)$(FLASH_IMAGE)$(CC_DEPS)$(AR_OBJ)$(C++_DEPS)$(LINK_OBJ)$(CXX_DEPS)$(ASM_DEPS)$(SIZEDUMMY)$(S_UPPER_DEPS)$(ELF)$(CPP_DEPS) NXTuino
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets
