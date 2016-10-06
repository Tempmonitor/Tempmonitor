#ifndef _SHIFTOUT_H_
#define _SHIFTOUT_H_

	#include "tempmonitor.h"

	volatile unsigned char bitsToSend = 8;
	volatile unsigned char dataBuffer;

	void ShiftOutInit(unsigned int speed)
	{
		//Set timer overflow
	}

	void ShiftOut(unsigned char data)
	{
		//Start timer
		dataBuffer = data;
		bitsToSend = 8;

		while(bitsToSend != 0)
		{
			//Sleep
		}
	}

	ISR(TIMER0_OVF_Vect)
	{
		if(dataBuffer | 1)
		{
			SHIFTPORT |= 1 << DATA_PIN;
		}
		else
		{
			SHIFTPORT &= ~(1 << DATA_PIN);
		}

		dataBuffer = dataBuffer >> 1;

	}


#endif