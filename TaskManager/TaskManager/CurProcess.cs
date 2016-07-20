using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    class CurProcess
    {
        public Process process;
        private PerformanceCounter cpuLoad;
        private Form1 form;

        public CurProcess(Process p, Form1 f)
        {
            this.process = p;
            this.form = f;
            cpuLoad = new PerformanceCounter("Process", "% Processor Time", GetProcessInstanceName(p.Id));
            GetCpuUsage();
        }

        public void GetCpuUsage()
        {
            try
            {
                var cpuUsage = (int) cpuLoad.NextValue()/Environment.ProcessorCount + "%";
                form.SetCpuUsage(cpuUsage, process);
            }
            catch (Exception ex)
            {
                Console.WriteLine("GET CPU USAGE ERROR: " + ex.Message);
            }
        }

        //Source for code below: http://stackoverflow.com/questions/113930/get-performance-counter-instance-name-w3wpxx-from-asp-net-worker-process-id/491022#491022
        private static string GetProcessInstanceName(int pid)
        {
            PerformanceCounterCategory cat = new PerformanceCounterCategory("Process");

            string[] instances = cat.GetInstanceNames();
            foreach (string instance in instances)
            {

                using (PerformanceCounter cnt = new PerformanceCounter("Process",
                     "ID Process", instance, true))
                {
                    int val = (int)cnt.RawValue;
                    if (val == pid)
                    {
                        return instance;
                    }
                }
            }
            throw new Exception("Could not find performance counter " +
                "instance name for current process. This is truly strange ...");
        }
    }
}
