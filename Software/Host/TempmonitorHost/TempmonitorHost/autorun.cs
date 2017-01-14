using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;

namespace TempmonitorHost
{
    class Autostart
    {
        public void CreateTask()
        {
            TaskService ts = new TaskService();
            TaskDefinition td = ts.NewTask();

            td.RegistrationInfo.Description = "Autorun Temp monitor host application";
            td.Triggers.Add(new LogonTrigger());
            td.Actions.Add(new ExecAction(System.Reflection.Assembly.GetExecutingAssembly().Location));
            td.Principal.RunLevel = TaskRunLevel.Highest;
            td.Settings.DisallowStartIfOnBatteries = false;

            ts.RootFolder.RegisterTaskDefinition("Temp monitor", td);
        }

        public void RemoveTask()
        {
            TaskService ts = new TaskService();
            ts.RootFolder.DeleteTask("Temp monitor");
        }

    }
}
