namespace ProcessesManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStop = new System.Windows.Forms.Button();
            this.gridProcesses = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessCpuUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startMonitoringButton = new System.Windows.Forms.Button();
            this.startNewProcButton = new System.Windows.Forms.Button();
            this.changePriorityButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(881, 427);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(183, 60);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Process";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gridProcesses
            // 
            this.gridProcesses.AllowUserToAddRows = false;
            this.gridProcesses.AllowUserToDeleteRows = false;
            this.gridProcesses.AllowUserToResizeColumns = false;
            this.gridProcesses.AllowUserToResizeRows = false;
            this.gridProcesses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessId,
            this.ProcessRam,
            this.ProcessCpuUsage,
            this.ProcessPriority});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProcesses.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridProcesses.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProcesses.Location = new System.Drawing.Point(18, 16);
            this.gridProcesses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProcesses.MultiSelect = false;
            this.gridProcesses.Name = "gridProcesses";
            this.gridProcesses.ReadOnly = true;
            this.gridProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProcesses.Size = new System.Drawing.Size(845, 476);
            this.gridProcesses.TabIndex = 2;
            this.gridProcesses.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProcesses_ColumnHeaderMouseClick);
            this.gridProcesses.Columns[0].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridProcesses.Columns[4].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcessName.DataPropertyName = "ProcessName";
            this.ProcessName.HeaderText = "Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProcessId
            // 
            this.ProcessId.DataPropertyName = "ProcessId";
            this.ProcessId.HeaderText = "ID";
            this.ProcessId.Name = "ProcessId";
            this.ProcessId.ReadOnly = true;
            this.ProcessId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProcessRam
            // 
            this.ProcessRam.DataPropertyName = "ProcessRam";
            this.ProcessRam.HeaderText = "RAM";
            this.ProcessRam.Name = "ProcessRam";
            this.ProcessRam.ReadOnly = true;
            this.ProcessRam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProcessCpuUsage
            // 
            this.ProcessCpuUsage.DataPropertyName = "ProcessCpuUsage";
            this.ProcessCpuUsage.HeaderText = "CPU Usage";
            this.ProcessCpuUsage.Name = "ProcessCpuUsage";
            this.ProcessCpuUsage.ReadOnly = true;
            this.ProcessCpuUsage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProcessPriority
            // 
            this.ProcessPriority.DataPropertyName = "ProcessPriority";
            this.ProcessPriority.HeaderText = "Priority";
            this.ProcessPriority.Name = "ProcessPriority";
            this.ProcessPriority.ReadOnly = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // startMonitoringButton
            // 
            this.startMonitoringButton.BackColor = System.Drawing.Color.SkyBlue;
            this.startMonitoringButton.Location = new System.Drawing.Point(881, 13);
            this.startMonitoringButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startMonitoringButton.Name = "startMonitoringButton";
            this.startMonitoringButton.Size = new System.Drawing.Size(183, 60);
            this.startMonitoringButton.TabIndex = 3;
            this.startMonitoringButton.Text = "Start Monitoring";
            this.startMonitoringButton.UseVisualStyleBackColor = false;
            this.startMonitoringButton.Click += new System.EventHandler(this.startMonitoringButton_Click);
            // 
            // startNewProcButton
            // 
            this.startNewProcButton.BackColor = System.Drawing.Color.SkyBlue;
            this.startNewProcButton.Location = new System.Drawing.Point(881, 83);
            this.startNewProcButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startNewProcButton.Name = "startNewProcButton";
            this.startNewProcButton.Size = new System.Drawing.Size(183, 60);
            this.startNewProcButton.TabIndex = 4;
            this.startNewProcButton.Text = "Start New Process";
            this.startNewProcButton.UseVisualStyleBackColor = false;
            this.startNewProcButton.Click += new System.EventHandler(this.startNewProcButon_Click);
            // 
            // changePriorityButton
            // 
            this.changePriorityButton.BackColor = System.Drawing.Color.SkyBlue;
            this.changePriorityButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changePriorityButton.Location = new System.Drawing.Point(881, 151);
            this.changePriorityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changePriorityButton.Name = "changePriorityButton";
            this.changePriorityButton.Size = new System.Drawing.Size(183, 60);
            this.changePriorityButton.TabIndex = 5;
            this.changePriorityButton.Text = "Change Priority";
            this.changePriorityButton.UseVisualStyleBackColor = false;
            this.changePriorityButton.Click += new System.EventHandler(this.changePriorityButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1079, 503);
            this.Controls.Add(this.changePriorityButton);
            this.Controls.Add(this.startNewProcButton);
            this.Controls.Add(this.startMonitoringButton);
            this.Controls.Add(this.gridProcesses);
            this.Controls.Add(this.btnStop);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Processes Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView gridProcesses;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button startMonitoringButton;
        private System.Windows.Forms.Button startNewProcButton;
        private System.Windows.Forms.Button changePriorityButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessCpuUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessPriority;
    }
}

