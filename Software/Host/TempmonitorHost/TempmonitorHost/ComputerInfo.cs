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
            // More to be added
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
                            CPUTemp = sensor.Value.GetValueOrDefault();     // CPU Temperature value
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Index == 0)
                        {
                            CPULoad = (int)sensor.Value.GetValueOrDefault();       // CPU Load value
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

                    RAMUsage = (UsedRAM / (UsedRAM + AvailableRAM)) * 100;    // RAM Usage value
                }
                else if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Index == 0)
                        {
                            GPUTemp = sensor.Value.GetValueOrDefault();     // GPU Temperature value
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Index == 0)
                        {
                            GPULoad = (int)sensor.Value.GetValueOrDefault();       // GPU Load value
                        }
                    }
                }
                else if (hardware.HardwareType == HardwareType.GpuAti)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Index == 0)
                        {
                            GPUTemp = sensor.Value.GetValueOrDefault();     // GPU Temperature value
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Index == 0)
                        {
                            GPULoad = (int)sensor.Value.GetValueOrDefault();       // GPU Load value
                        }
                    }
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

        public float get_value(string resource, int display)
        {
            switch (resource)
            {
                case "CPU temp":
                    return CPUTemp;

                case "CPU load":
                    return CPULoad;

                case "GPU load":
                    break;

                case "GPU temp":
                    break;

                case "RAM usage":
                    return RAMUsage;

                case "Disc usage":
                    break;

                case "Fan speed":
                    break;
            }
            return 0;
        }
    }
}
