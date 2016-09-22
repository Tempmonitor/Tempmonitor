EESchema Schematic File Version 2
LIBS:power
LIBS:device
LIBS:transistors
LIBS:conn
LIBS:linear
LIBS:regul
LIBS:74xx
LIBS:cmos4000
LIBS:adc-dac
LIBS:memory
LIBS:xilinx
LIBS:microcontrollers
LIBS:dsp
LIBS:microchip
LIBS:analog_switches
LIBS:motorola
LIBS:texas
LIBS:intel
LIBS:audio
LIBS:interface
LIBS:digital-audio
LIBS:philips
LIBS:display
LIBS:cypress
LIBS:siliconi
LIBS:opto
LIBS:atmel
LIBS:contrib
LIBS:valves
LIBS:74xgxx
LIBS:ac-dc
LIBS:actel
LIBS:Altera
LIBS:analog_devices
LIBS:brooktre
LIBS:cmos_ieee
LIBS:dc-dc
LIBS:diode
LIBS:elec-unifil
LIBS:ESD_Protection
LIBS:ftdi
LIBS:gennum
LIBS:graphic
LIBS:hc11
LIBS:ir
LIBS:Lattice
LIBS:logo
LIBS:maxim
LIBS:microchip_dspic33dsc
LIBS:microchip_pic10mcu
LIBS:microchip_pic12mcu
LIBS:microchip_pic16mcu
LIBS:microchip_pic18mcu
LIBS:microchip_pic32mcu
LIBS:motor_drivers
LIBS:msp430
LIBS:nordicsemi
LIBS:nxp_armmcu
LIBS:onsemi
LIBS:Oscillators
LIBS:Power_Management
LIBS:powerint
LIBS:pspice
LIBS:references
LIBS:relays
LIBS:rfcom
LIBS:sensors
LIBS:silabs
LIBS:stm8
LIBS:stm32
LIBS:supertex
LIBS:switches
LIBS:transf
LIBS:ttl_ieee
LIBS:video
LIBS:Xicor
LIBS:Zilog
LIBS:Tempmonitor-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 1
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
Text Notes 7350 7500 0    60   ~ 0
TempMonitor
Text Notes 8150 7650 0    60   ~ 0
2016/09/06
Text Notes 10600 7650 0    60   ~ 0
0.2
$Comp
L DRIVER-TM1637_SOP20_ U2
U 1 1 57A746BE
P 3700 1500
F 0 "U2" H 3450 2150 45  0000 L BNN
F 1 "DRIVER-TM1637_SOP20_" H 3200 910 45  0000 L BNN
F 2 "Seeed-IC-2016:SOP20-1.27-12.7X7.65MM" H 3730 1650 20  0001 C CNN
F 3 "" H 3700 1500 60  0000 C CNN
	1    3700 1500
	1    0    0    -1  
$EndComp
$Comp
L MICRO-USB-SMD-B-_10118193-0001LF_ USB1
U 1 1 57A7594F
P 7850 1700
F 0 "USB1" H 7500 2000 45  0000 L BNN
F 1 "MICRO-USB-SMD-B-_10118193-0001LF_" H 6350 1300 45  0000 L BNN
F 2 "Seeed-Connector -2016:MICRO-USB5+6P-SMD-0.65-B" H 7880 1850 20  0001 C CNN
F 3 "" H 7850 1700 60  0000 C CNN
	1    7850 1700
	1    0    0    -1  
$EndComp
$Comp
L SMD-PPTC-500MA_1206_ F1
U 1 1 57A75A12
P 8700 1500
F 0 "F1" H 8700 1400 45  0000 L BNN
F 1 "SMD-PPTC-500MA_1206_" H 8300 1550 45  0000 L BNN
F 2 "Seeed-Fuse-2016:F1206" H 8730 1650 20  0001 C CNN
F 3 "" H 8700 1500 60  0000 C CNN
	1    8700 1500
	1    0    0    -1  
$EndComp
$Comp
L TANTALUM-SMD-47UF-6.3V_AVX-A_ C1
U 1 1 57A75B0B
P 8900 1750
F 0 "C1" V 8800 1850 45  0000 L BNN
F 1 "TANTALUM-SMD-47UF-6.3V_AVX-A_" V 9050 1850 45  0000 L BNN
F 2 "Seeed-Capacitor-2016:AVX-A" H 8930 1900 20  0001 C CNN
F 3 "" H 8900 1750 60  0000 C CNN
	1    8900 1750
	0    1    1    0   
$EndComp
$Comp
L SMD-RES-22R-1%-1_16W_0402_ R9
U 1 1 57A7613C
P 8700 4350
F 0 "R9" H 8650 4250 45  0000 L BNN
F 1 "SMD-RES-22R-1%-1_16W_0402_" H 7350 4250 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0402" H 8730 4500 20  0001 C CNN
F 3 "" H 8700 4350 60  0000 C CNN
	1    8700 4350
	-1   0    0    1   
$EndComp
$Comp
L SMD-RES-22R-1%-1_16W_0402_ R11
U 1 1 57A76353
P 8700 4450
F 0 "R11" H 8600 4500 45  0000 L BNN
F 1 "SMD-RES-22R-1%-1_16W_0402_" H 7350 4500 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0402" H 8730 4600 20  0001 C CNN
F 3 "" H 8700 4450 60  0000 C CNN
	1    8700 4450
	-1   0    0    1   
$EndComp
$Comp
L LED-4-BETY-7-SEG_2X7P-30X14MM_ U1
U 1 1 57A779DC
P 1250 1450
F 0 "U1" H 575 1775 45  0000 L BNN
F 1 "LED-4-BETY-7-SEG_2X7P-30X14MM_" H 1550 1025 45  0000 L BNN
F 2 "Seeed-Display-2016:LCD12-2.54-30.0X14.0X7.3MM" H 1280 1600 20  0001 C CNN
F 3 "" H 1250 1450 60  0000 C CNN
	1    1250 1450
	1    0    0    -1  
$EndComp
$Comp
L LED-4-BETY-7-SEG_2X7P-30X14MM_ U3
U 1 1 57A77A45
P 1250 2950
F 0 "U3" H 575 3275 45  0000 L BNN
F 1 "LED-4-BETY-7-SEG_2X7P-30X14MM_" H 1550 2525 45  0000 L BNN
F 2 "Seeed-Display-2016:LCD12-2.54-30.0X14.0X7.3MM" H 1280 3100 20  0001 C CNN
F 3 "" H 1250 2950 60  0000 C CNN
	1    1250 2950
	1    0    0    -1  
$EndComp
$Comp
L LED-4-BETY-7-SEG_2X7P-30X14MM_ U6
U 1 1 57A77B44
P 1250 4450
F 0 "U6" H 575 4775 45  0000 L BNN
F 1 "LED-4-BETY-7-SEG_2X7P-30X14MM_" H 1550 4025 45  0000 L BNN
F 2 "Seeed-Display-2016:LCD12-2.54-30.0X14.0X7.3MM" H 1280 4600 20  0001 C CNN
F 3 "" H 1250 4450 60  0000 C CNN
	1    1250 4450
	1    0    0    -1  
$EndComp
$Comp
L LED-4-BETY-7-SEG_2X7P-30X14MM_ U8
U 1 1 57A77B92
P 1250 5950
F 0 "U8" H 575 6275 45  0000 L BNN
F 1 "LED-4-BETY-7-SEG_2X7P-30X14MM_" H 1550 5525 45  0000 L BNN
F 2 "Seeed-Display-2016:LCD12-2.54-30.0X14.0X7.3MM" H 1280 6100 20  0001 C CNN
F 3 "" H 1250 5950 60  0000 C CNN
	1    1250 5950
	1    0    0    -1  
$EndComp
$Comp
L DRIVER-TM1637_SOP20_ U4
U 1 1 57A78092
P 3700 3000
F 0 "U4" H 3450 3650 45  0000 L BNN
F 1 "DRIVER-TM1637_SOP20_" H 3200 2410 45  0000 L BNN
F 2 "Seeed-IC-2016:SOP20-1.27-12.7X7.65MM" H 3730 3150 20  0001 C CNN
F 3 "" H 3700 3000 60  0000 C CNN
	1    3700 3000
	1    0    0    -1  
$EndComp
$Comp
L DRIVER-TM1637_SOP20_ U7
U 1 1 57A780DA
P 3700 4500
F 0 "U7" H 3450 5150 45  0000 L BNN
F 1 "DRIVER-TM1637_SOP20_" H 3200 3910 45  0000 L BNN
F 2 "Seeed-IC-2016:SOP20-1.27-12.7X7.65MM" H 3730 4650 20  0001 C CNN
F 3 "" H 3700 4500 60  0000 C CNN
	1    3700 4500
	1    0    0    -1  
$EndComp
$Comp
L DRIVER-TM1637_SOP20_ U9
U 1 1 57A78405
P 3700 6000
F 0 "U9" H 3450 6650 45  0000 L BNN
F 1 "DRIVER-TM1637_SOP20_" H 3200 5410 45  0000 L BNN
F 2 "Seeed-IC-2016:SOP20-1.27-12.7X7.65MM" H 3730 6150 20  0001 C CNN
F 3 "" H 3700 6000 60  0000 C CNN
	1    3700 6000
	1    0    0    -1  
$EndComp
$Comp
L CERAMIC-10PF-50V-5%-NPO_0603_ C3
U 1 1 57A79E61
P 5800 3650
F 0 "C3" H 5650 3550 45  0000 L BNN
F 1 "CERAMIC-10PF-50V-5%-NPO_0603_" H 4850 3700 45  0000 L BNN
F 2 "Seeed-Capacitor-2016:C0603" H 5830 3800 20  0001 C CNN
F 3 "" H 5800 3650 60  0000 C CNN
	1    5800 3650
	1    0    0    -1  
$EndComp
$Comp
L CERAMIC-10PF-50V-5%-NPO_0603_ C4
U 1 1 57A79F31
P 5800 3950
F 0 "C4" H 5650 4000 45  0000 L BNN
F 1 "CERAMIC-10PF-50V-5%-NPO_0603_" H 4850 3850 45  0000 L BNN
F 2 "Seeed-Capacitor-2016:C0603" H 5830 4100 20  0001 C CNN
F 3 "" H 5800 3950 60  0000 C CNN
	1    5800 3950
	1    0    0    -1  
$EndComp
$Comp
L SMD-CRYSTAL-16MHZ-8PF-20PPM-40R_2P-5.0X3.2MM_ Y1
U 1 1 57A79F81
P 5950 3800
F 0 "Y1" H 5850 3900 45  0000 L BNN
F 1 "SMD-CRYSTAL-16MHZ-8PF-20PPM-40R_2P-5.0X3.2MM_" V 5650 2200 45  0000 L BNN
F 2 "Seeed-Crystal Oscillator-2016:X2-SMD-5.0X3.2X1.3MM" H 5980 3950 20  0001 C CNN
F 3 "" H 5950 3800 60  0000 C CNN
	1    5950 3800
	0    1    1    0   
$EndComp
$Comp
L GND #PWR01
U 1 1 57A7BFEF
P 2600 1050
F 0 "#PWR01" H 2600 800 50  0001 C CNN
F 1 "GND" H 2600 900 50  0000 C CNN
F 2 "" H 2600 1050 50  0000 C CNN
F 3 "" H 2600 1050 50  0000 C CNN
	1    2600 1050
	1    0    0    -1  
$EndComp
Text GLabel 3100 1100 0    60   Input ~ 0
A1
Text GLabel 3100 1300 0    60   Input ~ 0
C1
Text GLabel 3100 1200 0    60   Input ~ 0
B1
Text GLabel 3100 1400 0    60   Input ~ 0
D1
Text GLabel 3100 1500 0    60   Input ~ 0
E1
Text GLabel 3100 1600 0    60   Input ~ 0
F1
Text GLabel 3100 1700 0    60   Input ~ 0
G1
Text GLabel 3100 1800 0    60   Input ~ 0
DP1
NoConn ~ 3100 1900
NoConn ~ 4300 1900
NoConn ~ 4300 1000
NoConn ~ 4300 1100
Text GLabel 4300 1200 2    60   Input ~ 0
CLK1
Text GLabel 4300 1300 2    60   Input ~ 0
DATA1
Text GLabel 4300 1500 2    60   Input ~ 0
GR11
Text GLabel 4300 1600 2    60   Input ~ 0
GR21
Text GLabel 4300 1700 2    60   Input ~ 0
GR31
Text GLabel 4300 1800 2    60   Input ~ 0
GR41
Text GLabel 3100 2600 0    60   Input ~ 0
A2
Text GLabel 3100 2700 0    60   Input ~ 0
B2
Text GLabel 3100 2800 0    60   Input ~ 0
C2
Text GLabel 3100 2900 0    60   Input ~ 0
D2
Text GLabel 3100 3000 0    60   Input ~ 0
E2
Text GLabel 3100 3100 0    60   Input ~ 0
F2
Text GLabel 3100 3200 0    60   Input ~ 0
G2
Text GLabel 3100 3300 0    60   Input ~ 0
DP2
Text GLabel 3100 4100 0    60   Input ~ 0
A3
Text GLabel 3100 4200 0    60   Input ~ 0
B3
Text GLabel 3100 4300 0    60   Input ~ 0
C3
Text GLabel 3100 4400 0    60   Input ~ 0
D3
Text GLabel 3100 4500 0    60   Input ~ 0
E3
Text GLabel 3100 4600 0    60   Input ~ 0
F3
Text GLabel 3100 4700 0    60   Input ~ 0
G3
Text GLabel 3100 4800 0    60   Input ~ 0
DP3
Text GLabel 3100 5600 0    60   Input ~ 0
A4
Text GLabel 3100 5700 0    60   Input ~ 0
B4
Text GLabel 3100 5800 0    60   Input ~ 0
C4
Text GLabel 3100 5900 0    60   Input ~ 0
D4
Text GLabel 3100 6000 0    60   Input ~ 0
E4
Text GLabel 3100 6100 0    60   Input ~ 0
F4
Text GLabel 3100 6200 0    60   Input ~ 0
G4
Text GLabel 3100 6300 0    60   Input ~ 0
DP4
NoConn ~ 3100 6400
NoConn ~ 4300 6400
NoConn ~ 4300 5500
NoConn ~ 4300 5600
NoConn ~ 3100 4900
NoConn ~ 4300 4900
NoConn ~ 4300 4000
NoConn ~ 4300 4100
NoConn ~ 3100 3400
NoConn ~ 4300 3400
NoConn ~ 4300 2500
NoConn ~ 4300 2600
$Comp
L GND #PWR02
U 1 1 57A7FF6E
P 2600 1050
F 0 "#PWR02" H 2600 800 50  0001 C CNN
F 1 "GND" H 2600 900 50  0000 C CNN
F 2 "" H 2600 1050 50  0000 C CNN
F 3 "" H 2600 1050 50  0000 C CNN
	1    2600 1050
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR03
U 1 1 57A8047E
P 2600 2550
F 0 "#PWR03" H 2600 2300 50  0001 C CNN
F 1 "GND" H 2600 2400 50  0000 C CNN
F 2 "" H 2600 2550 50  0000 C CNN
F 3 "" H 2600 2550 50  0000 C CNN
	1    2600 2550
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR04
U 1 1 57A804C3
P 2600 4050
F 0 "#PWR04" H 2600 3800 50  0001 C CNN
F 1 "GND" H 2600 3900 50  0000 C CNN
F 2 "" H 2600 4050 50  0000 C CNN
F 3 "" H 2600 4050 50  0000 C CNN
	1    2600 4050
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR05
U 1 1 57A807CB
P 2600 5550
F 0 "#PWR05" H 2600 5300 50  0001 C CNN
F 1 "GND" H 2600 5400 50  0000 C CNN
F 2 "" H 2600 5550 50  0000 C CNN
F 3 "" H 2600 5550 50  0000 C CNN
	1    2600 5550
	1    0    0    -1  
$EndComp
$Comp
L VCC #PWR06
U 1 1 57A80C2C
P 4800 1350
F 0 "#PWR06" H 4800 1200 50  0001 C CNN
F 1 "VCC" H 4800 1500 50  0000 C CNN
F 2 "" H 4800 1350 50  0000 C CNN
F 3 "" H 4800 1350 50  0000 C CNN
	1    4800 1350
	1    0    0    -1  
$EndComp
Text GLabel 4300 2700 2    60   Input ~ 0
CLK2
Text GLabel 4300 3000 2    60   Input ~ 0
GR12
Text GLabel 4300 3100 2    60   Input ~ 0
GR22
Text GLabel 4300 3200 2    60   Input ~ 0
GR32
Text GLabel 4300 3300 2    60   Input ~ 0
GR42
Text GLabel 4300 2800 2    60   Input ~ 0
DATA2
$Comp
L VCC #PWR07
U 1 1 57A80DF8
P 4800 2850
F 0 "#PWR07" H 4800 2700 50  0001 C CNN
F 1 "VCC" H 4800 3000 50  0000 C CNN
F 2 "" H 4800 2850 50  0000 C CNN
F 3 "" H 4800 2850 50  0000 C CNN
	1    4800 2850
	1    0    0    -1  
$EndComp
Text GLabel 4300 4200 2    60   Input ~ 0
CLK3
Text GLabel 4300 4300 2    60   Input ~ 0
DATA3
Text GLabel 4300 4500 2    60   Input ~ 0
GR13
Text GLabel 4300 4600 2    60   Input ~ 0
GR23
Text GLabel 4300 4700 2    60   Input ~ 0
GR33
Text GLabel 4300 4800 2    60   Input ~ 0
GR43
$Comp
L VCC #PWR08
U 1 1 57A81A70
P 4800 4350
F 0 "#PWR08" H 4800 4200 50  0001 C CNN
F 1 "VCC" H 4800 4500 50  0000 C CNN
F 2 "" H 4800 4350 50  0000 C CNN
F 3 "" H 4800 4350 50  0000 C CNN
	1    4800 4350
	1    0    0    -1  
$EndComp
Text GLabel 4300 5700 2    60   Input ~ 0
CLK4
Text GLabel 4300 5800 2    60   Input ~ 0
DATA4
Text GLabel 4300 6000 2    60   Input ~ 0
GR14
Text GLabel 4300 6100 2    60   Input ~ 0
GR24
Text GLabel 4300 6200 2    60   Input ~ 0
GR34
Text GLabel 4300 6300 2    60   Input ~ 0
GR44
$Comp
L VCC #PWR09
U 1 1 57A81D07
P 4800 5850
F 0 "#PWR09" H 4800 5700 50  0001 C CNN
F 1 "VCC" H 4800 6000 50  0000 C CNN
F 2 "" H 4800 5850 50  0000 C CNN
F 3 "" H 4800 5850 50  0000 C CNN
	1    4800 5850
	1    0    0    -1  
$EndComp
Text GLabel 1100 1000 1    60   Input ~ 0
A1
Text GLabel 1200 1000 1    60   Input ~ 0
F1
Text GLabel 1300 1000 1    60   Input ~ 0
GR21
Text GLabel 1400 1000 1    60   Input ~ 0
GR31
Text GLabel 1500 1000 1    60   Input ~ 0
B1
Text GLabel 1000 1000 1    60   Input ~ 0
GR11
Text GLabel 1000 1900 3    60   Input ~ 0
E1
Text GLabel 1100 1900 3    60   Input ~ 0
D1
Text GLabel 1200 1900 3    60   Input ~ 0
DP1
Text GLabel 1300 1900 3    60   Input ~ 0
C1
Text GLabel 1400 1900 3    60   Input ~ 0
G1
Text GLabel 1500 1900 3    60   Input ~ 0
GR41
Text GLabel 1000 2500 1    60   Input ~ 0
GR12
Text GLabel 1100 2500 1    60   Input ~ 0
A2
Text GLabel 1200 2500 1    60   Input ~ 0
F2
Text GLabel 1300 2500 1    60   Input ~ 0
GR22
Text GLabel 1400 2500 1    60   Input ~ 0
GR32
Text GLabel 1500 2500 1    60   Input ~ 0
B2
Text GLabel 1000 3400 3    60   Input ~ 0
E2
Text GLabel 1100 3400 3    60   Input ~ 0
D2
Text GLabel 1200 3400 3    60   Input ~ 0
DP2
Text GLabel 1300 3400 3    60   Input ~ 0
C2
Text GLabel 1400 3400 3    60   Input ~ 0
G2
Text GLabel 1500 3400 3    60   Input ~ 0
GR42
Text GLabel 1000 4000 1    60   Input ~ 0
GR13
Text GLabel 1100 4000 1    60   Input ~ 0
A3
Text GLabel 1200 4000 1    60   Input ~ 0
F3
Text GLabel 1300 4000 1    60   Input ~ 0
GR23
Text GLabel 1400 4000 1    60   Input ~ 0
GR33
Text GLabel 1500 4000 1    60   Input ~ 0
B3
Text GLabel 1000 4900 3    60   Input ~ 0
E3
Text GLabel 1100 4900 3    60   Input ~ 0
D3
Text GLabel 1200 4900 3    60   Input ~ 0
DP3
Text GLabel 1300 4900 3    60   Input ~ 0
C3
Text GLabel 1400 4900 3    60   Input ~ 0
G3
Text GLabel 1500 4900 3    60   Input ~ 0
GR43
Text GLabel 1000 5500 1    60   Input ~ 0
GR14
Text GLabel 1100 5500 1    60   Input ~ 0
A4
Text GLabel 1200 5500 1    60   Input ~ 0
F4
Text GLabel 1300 5500 1    60   Input ~ 0
GR24
Text GLabel 1400 5500 1    60   Input ~ 0
GR34
Text GLabel 1500 5500 1    60   Input ~ 0
B4
Text GLabel 1000 6400 3    60   Input ~ 0
E4
Text GLabel 1100 6400 3    60   Input ~ 0
D4
Text GLabel 1200 6400 3    60   Input ~ 0
DP4
Text GLabel 1300 6400 3    60   Input ~ 0
C4
Text GLabel 1400 6400 3    60   Input ~ 0
G4
Text GLabel 1500 6400 3    60   Input ~ 0
GR44
$Comp
L GND #PWR010
U 1 1 57A8A978
P 7950 1950
F 0 "#PWR010" H 7950 1700 50  0001 C CNN
F 1 "GND" H 7950 1800 50  0000 C CNN
F 2 "" H 7950 1950 50  0000 C CNN
F 3 "" H 7950 1950 50  0000 C CNN
	1    7950 1950
	1    0    0    -1  
$EndComp
NoConn ~ 8400 1800
$Comp
L VCC #PWR011
U 1 1 57A8ACD3
P 9500 1500
F 0 "#PWR011" H 9500 1350 50  0001 C CNN
F 1 "VCC" H 9500 1650 50  0000 C CNN
F 2 "" H 9500 1500 50  0000 C CNN
F 3 "" H 9500 1500 50  0000 C CNN
	1    9500 1500
	1    0    0    -1  
$EndComp
$Comp
L VCC #PWR012
U 1 1 57A8AE40
P 8600 2750
F 0 "#PWR012" H 8600 2600 50  0001 C CNN
F 1 "VCC" H 8600 2900 50  0000 C CNN
F 2 "" H 8600 2750 50  0000 C CNN
F 3 "" H 8600 2750 50  0000 C CNN
	1    8600 2750
	1    0    0    -1  
$EndComp
Wire Wire Line
	2600 1000 2600 1050
Wire Wire Line
	2600 1000 3100 1000
Wire Wire Line
	3100 5500 2600 5500
Wire Wire Line
	2600 5500 2600 5550
Wire Wire Line
	3100 4000 2600 4000
Wire Wire Line
	2600 4000 2600 4050
Wire Wire Line
	3100 2500 2600 2500
Wire Wire Line
	2600 2500 2600 2550
Wire Wire Line
	4800 2850 4800 2900
Wire Wire Line
	4800 2900 4300 2900
Wire Wire Line
	4800 4350 4800 4400
Wire Wire Line
	4800 4400 4300 4400
Wire Wire Line
	4800 5850 4800 5900
Wire Wire Line
	4800 5900 4300 5900
Wire Wire Line
	8400 1900 8900 1900
$Comp
L CERAMIC-1UF-25V-10%-X7R_0603_ C2
U 1 1 57A8B289
P 8600 3250
F 0 "C2" H 8450 3150 45  0000 L BNN
F 1 "CERAMIC-1UF-25V-10%-X7R_0603_" H 7650 3300 45  0000 L BNN
F 2 "Seeed-Capacitor-2016:C0603" H 8630 3400 20  0001 C CNN
F 3 "" H 8600 3250 60  0000 C CNN
	1    8600 3250
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR013
U 1 1 57A8B48A
P 8750 3250
F 0 "#PWR013" H 8750 3000 50  0001 C CNN
F 1 "GND" H 8750 3100 50  0000 C CNN
F 2 "" H 8750 3250 50  0000 C CNN
F 3 "" H 8750 3250 50  0000 C CNN
	1    8750 3250
	1    0    0    -1  
$EndComp
Text GLabel 9000 4450 2    60   Input ~ 0
D+
Text GLabel 9000 4350 2    60   Input ~ 0
D-
Text GLabel 8400 1600 2    60   Input ~ 0
D-
Text GLabel 8400 1700 2    60   Input ~ 0
D+
NoConn ~ 7350 1550
NoConn ~ 7350 1650
NoConn ~ 7350 1750
NoConn ~ 7350 1850
Wire Wire Line
	8550 4450 8450 4450
Wire Wire Line
	8450 4350 8550 4350
Wire Wire Line
	9000 4450 8850 4450
Wire Wire Line
	9000 4350 8850 4350
Wire Wire Line
	6350 3650 5950 3650
Wire Wire Line
	5950 3950 6350 3950
$Comp
L GND #PWR014
U 1 1 57A8D2A6
P 5450 3800
F 0 "#PWR014" H 5450 3550 50  0001 C CNN
F 1 "GND" H 5450 3650 50  0000 C CNN
F 2 "" H 5450 3800 50  0000 C CNN
F 3 "" H 5450 3800 50  0000 C CNN
	1    5450 3800
	1    0    0    -1  
$EndComp
Wire Wire Line
	8500 1500 8400 1500
Wire Wire Line
	8900 1500 9500 1500
Wire Wire Line
	5650 3650 5650 3950
Wire Wire Line
	5450 3800 5650 3800
Connection ~ 5650 3800
Wire Wire Line
	8900 1600 8900 1500
Text GLabel 10850 3750 2    60   Input ~ 0
CLK4
Text GLabel 10850 3850 2    60   Input ~ 0
DATA1
Text GLabel 10850 3950 2    60   Input ~ 0
DATA2
Text GLabel 10850 4050 2    60   Input ~ 0
DATA3
Text GLabel 10850 4150 2    60   Input ~ 0
DATA4
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R1
U 1 1 57A905C5
P 9000 3250
F 0 "R1" H 8850 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 8850 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 9030 3400 20  0001 C CNN
F 3 "" H 9000 3250 60  0000 C CNN
	1    9000 3250
	0    -1   -1   0   
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R2
U 1 1 57A90729
P 9250 3250
F 0 "R2" H 9100 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 9100 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 9280 3400 20  0001 C CNN
F 3 "" H 9250 3250 60  0000 C CNN
	1    9250 3250
	0    -1   -1   0   
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R10
U 1 1 57A91085
P 6700 4450
F 0 "R10" H 6600 4500 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 5700 4350 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 6730 4600 20  0001 C CNN
F 3 "" H 6700 4450 60  0000 C CNN
	1    6700 4450
	1    0    0    -1  
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R3
U 1 1 57A910F4
P 9500 3250
F 0 "R3" H 9350 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 9350 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 9530 3400 20  0001 C CNN
F 3 "" H 9500 3250 60  0000 C CNN
	1    9500 3250
	0    -1   -1   0   
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R4
U 1 1 57A91150
P 9750 3250
F 0 "R4" H 9600 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 9600 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 9780 3400 20  0001 C CNN
F 3 "" H 9750 3250 60  0000 C CNN
	1    9750 3250
	0    -1   -1   0   
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R5
U 1 1 57A911A7
P 10000 3250
F 0 "R5" H 9850 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 9850 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 10030 3400 20  0001 C CNN
F 3 "" H 10000 3250 60  0000 C CNN
	1    10000 3250
	0    -1   -1   0   
$EndComp
Wire Wire Line
	9000 2850 9000 3100
Wire Wire Line
	8450 2850 10750 2850
Wire Wire Line
	10000 2850 10000 3100
Wire Wire Line
	9750 3100 9750 2850
Connection ~ 9750 2850
Wire Wire Line
	9500 2850 9500 3100
Connection ~ 9500 2850
Wire Wire Line
	9250 3100 9250 2850
Connection ~ 9250 2850
Wire Wire Line
	9000 3450 9000 3400
Connection ~ 9000 3450
Wire Wire Line
	10000 3850 10000 3400
Connection ~ 10000 3850
Wire Wire Line
	9750 3750 9750 3400
Connection ~ 9750 3750
Wire Wire Line
	9250 3400 9250 3550
Connection ~ 9250 3550
Wire Wire Line
	9500 3650 9500 3400
Connection ~ 9500 3650
$Comp
L Pad P1
U 1 1 57A7AA3E
P 6600 3350
F 0 "P1" H 6500 3400 60  0000 C CNN
F 1 "Pad" H 6750 3450 60  0000 C CNN
F 2 "Homebrew:Pad" H 6600 3350 60  0001 C CNN
F 3 "" H 6600 3350 60  0000 C CNN
	1    6600 3350
	-1   0    0    1   
$EndComp
$Comp
L ProgrammingPad P11
U 1 1 57A7AAC9
P 9850 5550
F 0 "P11" H 9700 6200 60  0000 C CNN
F 1 "ProgrammingPad" H 9800 5500 60  0000 C CNN
F 2 "Homebrew:ProgrammingPad" H 9750 5600 60  0001 C CNN
F 3 "" H 9750 5600 60  0000 C CNN
	1    9850 5550
	1    0    0    -1  
$EndComp
Wire Wire Line
	8600 2750 8600 3050
Wire Wire Line
	8600 3050 8450 3050
Wire Wire Line
	8450 2950 8600 2950
Connection ~ 8600 2950
Connection ~ 8600 2850
Connection ~ 9000 2850
Wire Wire Line
	8450 3450 10850 3450
Wire Wire Line
	8450 3550 10850 3550
Wire Wire Line
	8450 3650 10850 3650
Wire Wire Line
	8450 3750 10850 3750
Wire Wire Line
	8450 3850 10850 3850
$Comp
L GND #PWR015
U 1 1 57A8895C
P 8600 5300
F 0 "#PWR015" H 8600 5050 50  0001 C CNN
F 1 "GND" H 8600 5150 50  0000 C CNN
F 2 "" H 8600 5300 50  0000 C CNN
F 3 "" H 8600 5300 50  0000 C CNN
	1    8600 5300
	1    0    0    -1  
$EndComp
Wire Wire Line
	8600 5250 8450 5250
Wire Wire Line
	8600 5050 8600 5300
Wire Wire Line
	8600 5150 8450 5150
Wire Wire Line
	8600 5050 8450 5050
Connection ~ 8600 5150
$Comp
L VCC #PWR016
U 1 1 57A88EAA
P 6200 4450
F 0 "#PWR016" H 6200 4300 50  0001 C CNN
F 1 "VCC" H 6200 4600 50  0000 C CNN
F 2 "" H 6200 4450 50  0000 C CNN
F 3 "" H 6200 4450 50  0000 C CNN
	1    6200 4450
	1    0    0    -1  
$EndComp
Wire Wire Line
	6350 4350 7250 4350
Wire Wire Line
	6350 3250 6350 3650
Wire Wire Line
	6350 3250 7250 3250
Wire Wire Line
	6350 3950 6350 4350
Wire Wire Line
	6850 4450 7250 4450
$Comp
L Pad P2
U 1 1 57A8B05A
P 6600 3750
F 0 "P2" H 6500 3800 60  0000 C CNN
F 1 "Pad" H 6750 3850 60  0000 C CNN
F 2 "Homebrew:Pad" H 6600 3750 60  0001 C CNN
F 3 "" H 6600 3750 60  0000 C CNN
	1    6600 3750
	-1   0    0    1   
$EndComp
$Comp
L Pad P3
U 1 1 57A8B0CC
P 7000 3850
F 0 "P3" H 6900 3900 60  0000 C CNN
F 1 "Pad" H 7150 3950 60  0000 C CNN
F 2 "Homebrew:Pad" H 7000 3850 60  0001 C CNN
F 3 "" H 7000 3850 60  0000 C CNN
	1    7000 3850
	-1   0    0    1   
$EndComp
$Comp
L Pad P4
U 1 1 57A8B141
P 6600 3950
F 0 "P4" H 6500 4000 60  0000 C CNN
F 1 "Pad" H 6750 4050 60  0000 C CNN
F 2 "Homebrew:Pad" H 6600 3950 60  0001 C CNN
F 3 "" H 6600 3950 60  0000 C CNN
	1    6600 3950
	-1   0    0    1   
$EndComp
$Comp
L Pad P5
U 1 1 57A8B1BD
P 7000 4050
F 0 "P5" H 6900 4100 60  0000 C CNN
F 1 "Pad" H 7150 4150 60  0000 C CNN
F 2 "Homebrew:Pad" H 7000 4050 60  0001 C CNN
F 3 "" H 7000 4050 60  0000 C CNN
	1    7000 4050
	-1   0    0    1   
$EndComp
Wire Wire Line
	6850 3450 7250 3450
Wire Wire Line
	6850 3850 7250 3850
Wire Wire Line
	7250 4050 6850 4050
Wire Wire Line
	6550 4450 6200 4450
$Comp
L VCC #PWR017
U 1 1 57A8CBC6
P 9300 5000
F 0 "#PWR017" H 9300 4850 50  0001 C CNN
F 1 "VCC" H 9300 5150 50  0000 C CNN
F 2 "" H 9300 5000 50  0000 C CNN
F 3 "" H 9300 5000 50  0000 C CNN
	1    9300 5000
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR018
U 1 1 57A8CC1C
P 9300 5500
F 0 "#PWR018" H 9300 5250 50  0001 C CNN
F 1 "GND" H 9300 5350 50  0000 C CNN
F 2 "" H 9300 5500 50  0000 C CNN
F 3 "" H 9300 5500 50  0000 C CNN
	1    9300 5500
	1    0    0    -1  
$EndComp
Wire Wire Line
	9300 5000 9400 5000
Wire Wire Line
	9400 5500 9300 5500
Text GLabel 6900 4450 3    60   Input ~ 0
RESET
Text GLabel 9400 5100 0    60   Input ~ 0
RESET
Text GLabel 9400 5200 0    60   Input ~ 0
MOSI
Text GLabel 9400 5300 0    60   Input ~ 0
MISO
Text GLabel 9400 5400 0    60   Input ~ 0
SCK
Text GLabel 7250 3550 0    60   Input ~ 0
SCK
Text GLabel 7250 3650 0    60   Input ~ 0
MOSI
Text GLabel 7250 3750 0    60   Input ~ 0
MISO
$Comp
L Pad P6
U 1 1 57B88BB6
P 6650 4800
F 0 "P6" H 6550 4850 60  0000 C CNN
F 1 "Pad" H 6800 4900 60  0000 C CNN
F 2 "Homebrew:Pad" H 6650 4800 60  0001 C CNN
F 3 "" H 6650 4800 60  0000 C CNN
	1    6650 4800
	-1   0    0    1   
$EndComp
$Comp
L Pad P7
U 1 1 57B88CA7
P 6650 4950
F 0 "P7" H 6550 5000 60  0000 C CNN
F 1 "Pad" H 6800 5050 60  0000 C CNN
F 2 "Homebrew:Pad" H 6650 4950 60  0001 C CNN
F 3 "" H 6650 4950 60  0000 C CNN
	1    6650 4950
	-1   0    0    1   
$EndComp
$Comp
L Pad P8
U 1 1 57B88D25
P 6650 5100
F 0 "P8" H 6550 5150 60  0000 C CNN
F 1 "Pad" H 6800 5200 60  0000 C CNN
F 2 "Homebrew:Pad" H 6650 5100 60  0001 C CNN
F 3 "" H 6650 5100 60  0000 C CNN
	1    6650 5100
	-1   0    0    1   
$EndComp
$Comp
L Pad P9
U 1 1 57B88EA2
P 6650 5250
F 0 "P9" H 6550 5300 60  0000 C CNN
F 1 "Pad" H 6800 5350 60  0000 C CNN
F 2 "Homebrew:Pad" H 6650 5250 60  0001 C CNN
F 3 "" H 6650 5250 60  0000 C CNN
	1    6650 5250
	-1   0    0    1   
$EndComp
$Comp
L Pad P10
U 1 1 57B88F1A
P 6650 5400
F 0 "P10" H 6550 5450 60  0000 C CNN
F 1 "Pad" H 6800 5500 60  0000 C CNN
F 2 "Homebrew:Pad" H 6650 5400 60  0001 C CNN
F 3 "" H 6650 5400 60  0000 C CNN
	1    6650 5400
	-1   0    0    1   
$EndComp
Wire Wire Line
	7250 4550 7000 4550
Wire Wire Line
	7000 4550 7000 4900
Wire Wire Line
	7000 4900 6900 4900
Wire Wire Line
	7250 4650 7050 4650
Wire Wire Line
	7050 4650 7050 5050
Wire Wire Line
	7050 5050 6900 5050
Wire Wire Line
	7250 4750 7100 4750
Wire Wire Line
	7100 4750 7100 5200
Wire Wire Line
	7100 5200 6900 5200
Wire Wire Line
	7250 4850 7150 4850
Wire Wire Line
	7150 4850 7150 5350
Wire Wire Line
	7150 5350 6900 5350
Wire Wire Line
	7250 4950 7200 4950
Wire Wire Line
	7200 4950 7200 5500
Wire Wire Line
	7200 5500 6900 5500
Wire Wire Line
	4800 1350 4800 1400
Wire Wire Line
	4800 1400 4300 1400
Connection ~ 8600 5250
Text GLabel 10850 3450 2    60   Input ~ 0
CLK1
Text GLabel 10850 3550 2    60   Input ~ 0
CLK2
Text GLabel 10850 3650 2    60   Input ~ 0
CLK3
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R6
U 1 1 57CED67E
P 10250 3250
F 0 "R6" H 10100 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 10100 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 10280 3400 20  0001 C CNN
F 3 "" H 10250 3250 60  0000 C CNN
	1    10250 3250
	0    -1   -1   0   
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R7
U 1 1 57CED890
P 10500 3250
F 0 "R7" H 10350 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 10350 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 10530 3400 20  0001 C CNN
F 3 "" H 10500 3250 60  0000 C CNN
	1    10500 3250
	0    -1   -1   0   
$EndComp
$Comp
L SMD-RES-10K-1%-1_8W_0805_ R8
U 1 1 57CEDB94
P 10750 3250
F 0 "R8" H 10600 3300 45  0000 L BNN
F 1 "SMD-RES-10K-1%-1_8W_0805_" H 10600 3150 45  0000 L BNN
F 2 "Seeed-Resistor-2016:R0805" H 10780 3400 20  0001 C CNN
F 3 "" H 10750 3250 60  0000 C CNN
	1    10750 3250
	0    -1   -1   0   
$EndComp
Wire Wire Line
	10250 2850 10250 3100
Connection ~ 10000 2850
Wire Wire Line
	10500 2850 10500 3100
Connection ~ 10250 2850
Wire Wire Line
	10750 2850 10750 3100
Connection ~ 10500 2850
$Comp
L ATMEGA16U2-MU U5
U 1 1 57A85457
P 7850 4050
F 0 "U5" H 7450 5390 50  0000 L CNN
F 1 "ATMEGA16U2-MU" H 7450 2610 50  0000 L CNN
F 2 "ATMEGA16U2-MU:QFN50P500X500X100-33N" H 7850 4050 50  0001 L CNN
F 3 "" H 7850 4050 60  0000 C CNN
	1    7850 4050
	1    0    0    -1  
$EndComp
Wire Wire Line
	8450 3950 10850 3950
Wire Wire Line
	8450 4050 10850 4050
Wire Wire Line
	8450 4150 10850 4150
Wire Wire Line
	10250 3400 10250 3950
Connection ~ 10250 3950
Wire Wire Line
	10500 3400 10500 4050
Connection ~ 10500 4050
Wire Wire Line
	10750 3400 10750 4150
Connection ~ 10750 4150
$EndSCHEMATC
