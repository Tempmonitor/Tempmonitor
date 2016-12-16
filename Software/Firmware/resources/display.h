/*--------------------------------------------------------------------------
Copyright (C) 2016  Temp monitor UF

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along
with this program; if not, write to the Free Software Foundation, Inc.,
51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
--------------------------------------------------------------------------*/

#ifndef _DISPLAY_H_
#define _DISPLAY_H_

#include <avr/interrupt.h>

#include "shiftout.h"

const uchar display_map[] = {0b01111110, 0b01000010, 0b00110111, 0b01100111,0b01001011, 0b01101101, 0b01111101, 0b01000110, 0b01111111, 0b01001111};

unsigned char display_raw_buffer[5];
unsigned char display_buffer[12];
unsigned char display_column = 2;

void DisplayInit()
{
    //Configure interrupts
    //Configure timer0
}

void DisplayWrite(unsigned char display_number, unsigned int value)
{

}

void DisplayUpdateRawBuffer()
{
    //Copies values from display buffer to raw buffer
    for(uint8_t row = 0; row != 4; row++)
    {
        display_raw_buffer[row] = display_buffer[(row * 3) + display_column];
    }

    //Connect correct column to ground
    display_raw_buffer[4] = 1 << display_column;

    //loop display column 2 to 0
    if(display_column != 0)
        display_column--;
    else
        display_column = 2;
}

ISR(TIMER0_OVF_vect)
{
    //Shift out raw buffer
    ShiftOutBytes(display_raw_buffer, 5);
}

#endif // _DISPLAY_H_
