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

The base usb framework for this software is based of the V-USB example
project hid-data written by Christian Starkjohann and licensed with GNU GPL v2.
--------------------------------------------------------------------------*/

#include "main.h"


/* USB interface */

#define HID_INBUFFER_SIZE 32


PROGMEM const char usbHidReportDescriptor[USB_CFG_HID_REPORT_DESCRIPTOR_LENGTH] = {    /* USB report descriptor */
    0x06, 0x00, 0xff,              // USAGE_PAGE (Generic Desktop)
    0x09, 0x01,                    // USAGE (Vendor Usage 1)
    0xa1, 0x01,                    // COLLECTION (Application)
    0x15, 0x00,                    //   LOGICAL_MINIMUM (0)
    0x26, 0xff, 0x00,              //   LOGICAL_MAXIMUM (255)
    0x75, 0x08,                    //   REPORT_SIZE (8)
    0x95, 0x08,                    //   REPORT_COUNT (8)
    0x09, 0x00,                    //   USAGE (Undefined)
    0x82, 0x02, 0x01,              //   INPUT (Data,Var,Abs,Buf)
    0x95, HID_INBUFFER_SIZE, //   REPORT_COUNT (32)
    0x09, 0x00,                    //   USAGE (Undefined)
    0xb2, 0x02, 0x01,              //   FEATURE (Data,Var,Abs,Buf)
    0xc0                           // END_COLLECTION
};

static uchar received = 0;
static uchar inBuffer[HID_INBUFFER_SIZE];
static uchar reportId = 0;
static uchar bytesRemaining;
static uchar* pos;

static uchar    bytesRemaining;

/* Called when host requests data */
uchar   usbFunctionRead(uchar *data, uchar len)
{
    return 0;
}

/* Called when host sends data */
uchar   usbFunctionWrite(uchar *data, uchar len)
{
    if (reportId == 0) {
        int i;
        if(len > bytesRemaining)
            len = bytesRemaining;
        bytesRemaining -= len;
        for(i=0;i<len;i++) {
            if (data[i]!=0) {
                *pos++ = data[i];
             }
        }
        if (bytesRemaining == 0) {
            received = 1;
            *pos++ = 0;
            return 1;
        } else {
            return 0;
        }
    } else {
        return 1;
    }
}

usbMsgLen_t usbFunctionSetup(uchar data[8])
{
    usbRequest_t    *rq = (usbRequest_t *)data;
    reportId = rq->wValue.bytes[0];
    if((rq->bmRequestType & USBRQ_TYPE_MASK) == USBRQ_TYPE_CLASS){    /* HID class request */
        if(rq->bRequest == USBRQ_HID_GET_REPORT){
          /* wValue: ReportType (highbyte), ReportID (lowbyte) */
            /* since we have only one report type, we can ignore the report-ID */
            return USB_NO_MSG;  /* use usbFunctionRead() to obtain data */
        }else if(rq->bRequest == USBRQ_HID_SET_REPORT){
            /* since we have only one report type, we can ignore the report-ID */
            pos = inBuffer;
            bytesRemaining = rq->wLength.word;
            if(bytesRemaining > sizeof(inBuffer))
                bytesRemaining = sizeof(inBuffer);
            return USB_NO_MSG;  /* use usbFunctionWrite() to receive data from host */
        }
    }else{
        /* ignore vendor type requests, we don't use any */
    }
    return 0;
}

void USBDisconnect()
{
    uchar   i;
    usbDeviceDisconnect();  /* enforce re-enumeration, do this while interrupts are disabled! */
    i = 0;
    while(--i){             /* fake USB disconnect for > 250 ms */
        wdt_reset();
        _delay_ms(1);
    }
}


int main(void)
{
    wdt_enable(WDTO_1S);

    //Init IO
	SHIFT_DDR |= 1 << CLOCK_PIN | 1 << DATA_PIN | 1 << LATCH_PIN;

    usbInit();

    USBDisconnect();

    usbDeviceConnect();
    sei();

	received = 0;

    for(;;){
        wdt_reset();

        if(received != 0)
        {
            /*// Process recived data from host
            ShiftOutByte(display_map[inBuffer[0] - '0']);
            ShiftOutUpdate();*/
        }

        usbPoll();
    }
    return 0;
}

//Add calibration for internal PLL @ 16.5 MHz
void hadUsbReset()
{

}
