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

unsigned char display_raw_buffer[5];
unsigned char display_values[4];
unsigned char display_column = 0;

void DisplayInit()
{
    //Configure interrupts
    //Configure timer0
}

void DisplayWrite(unsigned char display_number, unsigned int value)
{

}

void DisplayUpdateBuffer()
{

}

ISR(TIMER0_OVF_vect)
{
    //Update display
}

#endif // _DISPLAY_H_
