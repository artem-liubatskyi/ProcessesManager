using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessesManager
{
    class Manager
    {
        int orderIndex = 0;

        SortOrder direction = SortOrder.Ascending;

        public int OrderIndex
        {
            get
            {
                return orderIndex;
            }
            set
            {
                if(orderIndex==value)
                {
                   if(direction == SortOrder.Descending)
                        direction = SortOrder.Ascending;
                   else
                        direction = SortOrder.Descending;
                }
                orderIndex = value;
            }
        }
        public void Sort()
        {
            if (direction == SortOrder.Ascending)
            {
                switch (orderIndex)
                {
                    case 0:
                        processList = processList.OrderBy(n => n.ProcessName).ToList();
                        break;
                    case 1:
                        processList = processList.OrderBy(n => n.ProcessId).ToList();
                        break;
                    case 2:
                        processList = processList.OrderBy(n => n.ProcessRam).ToList();
                        break;
                    case 3:
                        processList = processList.OrderBy(n => n.ProcessCpuUsage).ToList();
                        break;
                    default:
                        break;
                }
            }
            if (direction == SortOrder.Descending)
            {
                switch (orderIndex)
                {
                    case 0:
                        processList = processList.OrderByDescending(n => n.ProcessName).ToList();
                        break;
                    case 1:
                        processList = processList.OrderByDescending(n => n.ProcessId).ToList();
                        break;
                    case 2:
                        processList = processList.OrderByDescending(n => n.ProcessRam).ToList();
                        break;
                    case 3:
                        processList = processList.OrderByDescending(n => n.ProcessCpuUsage).ToList();
                        break;
                    default:
                        break;
                }
            }
        }

        private List<MyProces> processList = new List<MyProces>();
        public List<MyProces> procList
        {
            get
            {
                return processList;
            }
            set
            {
                processList=value;
            }
        }

        public Manager()
        {
            Process[] procList = Process.GetProcesses();

            int n = procList.Length;
            processList.Capacity = n;

            foreach (Process proc in procList)
            {
                processList.Add(new MyProces(proc));
            }

            Sort();
        }
        private bool Exist(int id)
        {
            if(processList.Find(n => n.ProcessId == id)!=null)
                return true;
           
            return false;
        }
        public void Update()
        {
            Process[] procArr = Process.GetProcesses();

            processList.RemoveAll(n => n.ProcessRam == -1);

            foreach (Process proc in procArr)
            {
                if (!Exist(proc.Id))
                    processList.Add(new MyProces(proc));
            }

            foreach (MyProces proc in processList)
            {
                proc.Update();
            }

            Sort();
        }
    }
}
