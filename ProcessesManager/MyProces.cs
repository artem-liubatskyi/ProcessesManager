using System;
using System.Diagnostics;

namespace ProcessesManager
{
    class MyProces
    {
        string Name;
        int Id;

        double Ram;
        double Cpu;
        string Priority;

        PerformanceCounter RamCounter;
        PerformanceCounter CpuCounter;

        public MyProces(Process proc)
        {
            Id = proc.Id;
            Name = InstanceName.GetInstanceNameForProcessId(Id, proc.ProcessName);

            try
            {
                Priority = proc.PriorityClass.ToString();
            }
            catch
            {
                Priority = "Rejected";
            }
            try
            {
                RamCounter = new PerformanceCounter("Process", "Working Set - Private", Name);
                CpuCounter = new PerformanceCounter("Process", "% Processor Time", Name);
                CpuCounter.NextValue();
            }
            catch
            {
                Ram = -1;
                Cpu = -1;
            }
        }
        public void Update()
        {
            try
            {
                Ram = Math.Round(Convert.ToDouble(RamCounter.NextValue()) / (double)(1048576), 1);
                Cpu = Math.Round(Convert.ToDouble(CpuCounter.NextValue()) / Environment.ProcessorCount, 1);
            }
            catch
            {
                Ram = -1;
                Cpu = -1;
                Priority = "Rejected";
                return;
            }
            try
            {
                Priority = Process.GetProcessById(Id).PriorityClass.ToString();
            }
            catch
            {
                Priority = "Rejected";
            }
        }
        public string ProcessName
        {
            get
            {
                return Name;
            }
        }
        public int ProcessId
        {
            get
            {
                return Id;
            }
        }
        public double ProcessRam
        {
            get
            {
                return Ram;
            }
        }
        public double ProcessCpuUsage
        {
            get
            {
                return Cpu;
            }
        }
        public string ProcessPriority
        {
            get
            {
                return Priority;
            }
        }
    }
}
