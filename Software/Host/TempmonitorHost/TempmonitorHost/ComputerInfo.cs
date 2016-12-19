using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenHardwareMonitor.Hardware; 

namespace TempmonitorHost
{
    class ComputerInfo
    {

        private Computer computer = new Computer();

        private float CPUTemp, CPULoad, GPUTemp, GPULoad, RAMUsage;

        public ComputerInfo()
        {
            computer.CPUEnabled = true;
            computer.RAMEnabled = true;
            computer.GPUEnabled = true;
            computer.Open();
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
                        {
                            CPUTemp = sensor.Value.GetValueOrDefault();
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Index == 0)
                        {
                            CPULoad = (int)sensor.Value.GetValueOrDefault();
                        }
                    }
                }
                else if (hardware.HardwareType == HardwareType.RAM)
                {
                    hardware.Update();

                    float UsedRAM = 0, AvailableRAM = 0;

                    foreach (var sensor in hardware.Sensors)

                        if (sensor.SensorType == SensorType.Data)
                            switch (sensor.Index)
                            {
                                case 0:
                                    UsedRAM = sensor.Value.GetValueOrDefault();
                                    break;

                                case 1:
                                    AvailableRAM = sensor.Value.GetValueOrDefault();
                                    break;
                            }

                    RAMUsage = (UsedRAM / (UsedRAM + AvailableRAM)) * 100;
                }
            }
        }


        public float GetCPUTemp()
        {
            return CPUTemp;
        }
        public float GetCPULoad()
        {
            return CPULoad;
        }
        public float GetRAMUsage()
        {
            return RAMUsage;
        }


    }
}
