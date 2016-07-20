using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            taskList.DoubleBuffering(true);
        }

        private List<CurProcess> processes = new List<CurProcess>();
        private PerformanceCounter cpuPC = new PerformanceCounter("Processor Information", "% Processor Time",
                "_Total");
        private PerformanceCounter memPC = new PerformanceCounter("Memory", "Available MBytes");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcesses();
            taskTimer.Start();
        }

        void GetAllProcesses()
        {
            List<Process> proc = Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();
            
            foreach (var p in proc)
            {
                if (!processes.Exists(pr => pr.process.Id == p.Id))
                {
                    processes.Add(new CurProcess(p, this));
                    
                    var item = new ListViewItem();
                    try
                    {
                        item = new ListViewItem(p.ProcessName);
                        item.Name = p.ProcessName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    item.SubItems.Add("");
                    item.SubItems.Add("");

                    try
                    {
                        if (p.ProcessName != "Idle")
                            item.SubItems.Add(p.StartTime.ToString());
                    }
                    catch 
                    {
                        item.SubItems.Add("Unavailable");
                    }

                    item.SubItems.Add(p.Id.ToString());
                    item.Name = p.Id.ToString();

                    taskList.Items.Add(item);
                }   
            }

            List<CurProcess> removeProc = processes.Where(cp => !proc.Exists(p => p.Id == cp.process.Id)).ToList();
            foreach (CurProcess rm in removeProc)
            {
                processes.Remove(rm);
            }

            foreach (ListViewItem i in taskList.Items)
            {
                if (!processes.Exists(p => p.process.ProcessName == i.SubItems[0].Text)) 
                {
                    taskList.Items.Remove(i);
                }
                try
                {
                    if (proc.Exists(p => p.Id.ToString() == i.Name))
                    {
                        Process pr = proc.FirstOrDefault(p => p.Id.ToString() == i.Name);
                        i.SubItems[2].Text = string.Format("{0:n0}K",
                            pr.WorkingSet64/1000);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Memroy Usage ERROR: " + ex.Message);
                }
            }
            
            txtCPU.Text = "Total CPU Usage: " + (int)cpuPC.NextValue() + "%";
            txtMem.Text = "Available Memory: " + memPC.NextValue() + "MBs";
            txtProc.Text = "Processes: " + processes.Count;
            taskList.Update();

        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem lvi in taskList.SelectedItems)
                {
                    CurProcess pr = processes.FirstOrDefault(p => p.process.ProcessName == lvi.Text);
                    processes.Remove(processes.FirstOrDefault(p => p.process.ProcessName == lvi.Text));
                    if (pr != null) pr.process.Kill();
                }
                GetAllProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RunTaskForm runForm = new RunTaskForm())
            {
                if (runForm.ShowDialog() == DialogResult.OK)
                    GetAllProcesses();
            }
        }

        private void taskTimer_Tick(object sender, EventArgs e)
        {
            GetAllProcesses();
            if (DateTime.Now.Second%2 == 0)
            {
                foreach (CurProcess cp in processes)
                {
                    cp.GetCpuUsage();
                }
            }
        }

        private void exitTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetCpuUsage(string text, Process p)
        {
            var lvi = taskList.FindItemWithText(p.Id.ToString());
            if (lvi != null)
            {
                lvi.SubItems[1].Text = text;
            }
        }
    }
}
