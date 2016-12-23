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

#ifndef _TEMPMONITOR_H_
#define _TEMPMONITOR_H_

/* IO configuration */
    #define SHIFT_PORT	PORTB
    #define SHIFT_DDR   DDRB

    #define CLOCK_PIN	PINB4
    #define LATCH_PIN	PINB3
    #define DATA_PIN	PINB0

/* Includes */
    #include <avr/io.h>
    #include <avr/wdt.h>
    #include <avr/interrupt.h>
    #include <util/delay.h>

    #include <avr/pgmspace.h>
    #include "usbdrv.h"

    #include "resources/shiftout.h"
    #include "resources/display.h"


#endif // _TEMPMONITOR_H_
