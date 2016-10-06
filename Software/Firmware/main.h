#ifndef _MAIN_H_
#define _MAIN_H_

    
	/* Includes */
	    #include <avr/io.h>
	    #include <avr/wdt.h>
	    #include <avr/interrupt.h>
	    #include <util/delay.h>
	    #include <avr/eeprom.h>

	    #include <avr/pgmspace.h>
	    #include "usbdrv.h"

		#include "tempmonitor.h"
	    #include "shiftout.h"

	
	/* Function protypes */
		void TempMonitorSetup(void);

#endif
