using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenHardwareMonitor.Collections;
using OpenHardwareMonitor.Hardware;

namespace HID
{
    class ComputerInfo
    {

        private Computer computer = new Computer();

        private int CPUTemp, CPULoad, GPUTemp, GPULoad, RAMUsage;

        //Constructor
        public ComputerInfo()
        {
            computer.GPUEnabled = true;
            computer.CPUEnabled = true;
            computer.RAMEnabled = true;
            computer.FanControllerEnabled = true;

            computer.Open();
        }

        //Destructor
        ~ComputerInfo()
        {
            computer.Close();
        }

        public void Update()
        {
            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();

                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Index == 0)
                            CPUTemp = (int)sensor.Value.GetValueOrDefault();

                        else if (sensor.SensorType == SensorType.Load && sensor.Index == 0)
                            CPULoad = (int)sensor.Value.GetValueOrDefault();
                    }
                }
                else if (hardware.HardwareType == HardwareType.RAM)
                {
                    float UsedRAM = 0, AvailableRAM = 0;

                    foreach (var sensor in hardware.Sensors)

                        if (sensor.SensorType == SensorType.Data)
                        {
                            switch (sensor.Index)
                            {
                                case 0:
                                    UsedRAM = sensor.Value.GetValueOrDefault();
                                    break;

                                case 1:
                                    AvailableRAM = sensor.Value.GetValueOrDefault();
                                    break;
                            }
                        }

                    RAMUsage = (int)((UsedRAM / (UsedRAM + AvailableRAM)) * 100);
                }
            }
        }

        public int GetCPUTemp()
        {
            return CPUTemp;
        }

        public int GetCPULoad()
        {
            return CPULoad;
        }

        public int GetGPUTemp()
        {
            return GPUTemp;
        }

        public int GetGPULoad()
        {
            return GPULoad;
        }

        public int GetRamUsage()
        {
            return RAMUsage;
        }
    }
}
