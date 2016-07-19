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
            cpuLoad = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
            GetCpuUsage();
        }

        public void GetCpuUsage()
        {
            try
            {
                if (process.ProcessName != "dllhost" && process.ProcessName != "taskmgr")
                {
                    var cpuUsage = (int) cpuLoad.NextValue()/Environment.ProcessorCount + "%";
                    form.SetCpuUsage(cpuUsage, process);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GET CPU USAGE ERROR: " + ex.Message);
            }
        }
    }
}
