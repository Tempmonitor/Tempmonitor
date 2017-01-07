using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using HidLibrary;

namespace HID
{
    class Program
    {
        static void Main(string[] args)
        {

            HidDevice device = HidDevices.Enumerate(0x16c0, 0x05df).FirstOrDefault();

            ComputerInfo pc = new ComputerInfo();

            Console.CursorVisible = false;

            if (device != null)
            {
                Console.WriteLine("Found devices.");
                Console.WriteLine("Connecting to " + device.DevicePath.ToString());

                device.OpenDevice();

                Thread.Sleep(1000);

                if(device.IsConnected)
                {

                    bool state = true;
                    while(state)
                    {
                        byte[] outdata = new byte[8];
                        pc.Update();

                        outdata[1] = (byte) pc.GetCPUTemp();
                        outdata[2] = (byte) pc.GetCPULoad();
                        outdata[3] = (byte) pc.GetRamUsage();
                        outdata[4] = (byte) 23;

                        Console.Clear();
                        
                        Console.WriteLine("CPU Temp: " + pc.GetCPUTemp().ToString() + "*C");
                        Console.WriteLine("CPU Load: " + pc.GetCPULoad().ToString() + "%");
                        Console.WriteLine("RAM Usage: " + pc.GetRamUsage().ToString() + "%");
                       
                        HidReport report = new HidReport(8, new HidDeviceData(outdata, HidDeviceData.ReadStatus.NotConnected));
                        state = device.WriteFeatureData(outdata);
                        Thread.Sleep(500);
                    }


                    device.CloseDevice();
                }
                else
                {
                    Console.WriteLine("Connection failed.");
                }              
            }

            Console.Clear();
            Console.WriteLine("Disconnected.");

            Console.ReadKey();
        }

    }

   
}
