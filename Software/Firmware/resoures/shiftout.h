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

#ifndef _SHIFTOUT_H_
#define _SHIFTOUT_H_

/* Shift out one byte */
void ShiftOutByte(unsigned char data)
{
	for(unsigned char x = 0; x != 8; x++)
	{
		if(data & (1 << 7))
			SHIFT_PORT |= 1 << DATA_PIN;

		_delay_us(1);
		SHIFT_PORT |= 1 << CLOCK_PIN;
		_delay_us(1);
		SHIFT_PORT &= ~(1 << CLOCK_PIN) & ~(1 << DATA_PIN);
		data = data << 1;
	}
}

/* Toggle latch pin to update shift registers */
void ShiftOutUpdate(void)
{
	SHIFT_PORT |= 1 << LATCH_PIN;
	_delay_us(1);
	SHIFT_PORT &= ~(1 << LATCH_PIN);
	_delay_us(1);
}

/* Shift out an array of bytes */
void ShiftOutBytes(unsigned char *data, unsigned char bytes)
{
    for(unsigned char counter = 0; counter != bytes; counter++)
    {
        ShiftOutByte(data[counter]);
    }
}
#endif // _SHIFTOUT_H_
