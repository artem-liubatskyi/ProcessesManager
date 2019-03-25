using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessesManager
{
    public partial class MainForm : Form
    {
        BindingSource binding = new BindingSource();
        Manager m;
        public MainForm()
        {
            InitializeComponent();
            m = new Manager();
            binding.DataSource = m.procList;
            gridProcesses.DataSource = binding;
        }
        private void startMonitoringButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            startMonitoringButton.Enabled = false;
        }
        
        private void gridProcesses_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            m.OrderIndex = e.ColumnIndex;
            m.Sort();
            binding.DataSource = m.procList;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridProcesses["ProcessId",gridProcesses.SelectedCells[0].RowIndex].Value);//Convert.ToInt32(gridProcesses.SelectedRows[0].Cells[1]);

            try
            {
                var proc = Process.GetProcessById(id);
                proc.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Action act = () => {
                int vscroll = gridProcesses.FirstDisplayedScrollingRowIndex;
                int hscroll = gridProcesses.FirstDisplayedScrollingColumnIndex;

                binding.DataSource = m.procList;
                int l = binding.Count;
                gridProcesses.FirstDisplayedScrollingRowIndex = vscroll;
                gridProcesses.FirstDisplayedScrollingColumnIndex = hscroll;
            };
                while (true)
                {
                    m.Update();
                    Invoke(act);
                    Thread.Sleep(1500);
                }
        }
        private void startNewProcButon_Click(object sender, EventArgs e)
        {
            string _file;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files|*.exe";
            openFileDialog.Title = "Select an execute file File";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _file = openFileDialog.FileName;
                try
                {
                    Process.Start(_file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void changePriorityButton_Click(object sender, EventArgs e)
        {
            int id =
                Convert.ToInt32(gridProcesses["ProcessId", gridProcesses.SelectedCells[0].RowIndex].Value);

            if (m.procList.Find(n => n.ProcessId == id).ProcessPriority == "Rejected")
            {
                MessageBox.Show("Access denied");
                return;
            }

            ChangePriority p = new ChangePriority(Process.GetProcessById(id));
            p.Show();
        }
    }
}
