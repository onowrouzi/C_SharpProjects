namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTaskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEndTask = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListView();
            this.taskCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpuCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskTimer = new System.Windows.Forms.Timer(this.components);
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitTaskManagerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // exitTaskManagerToolStripMenuItem
            // 
            this.exitTaskManagerToolStripMenuItem.Name = "exitTaskManagerToolStripMenuItem";
            this.exitTaskManagerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitTaskManagerToolStripMenuItem.Text = "Exit Task Manager";
            this.exitTaskManagerToolStripMenuItem.Click += new System.EventHandler(this.exitTaskManagerToolStripMenuItem_Click);
            // 
            // btnEndTask
            // 
            this.btnEndTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndTask.Location = new System.Drawing.Point(428, 403);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(75, 23);
            this.btnEndTask.TabIndex = 2;
            this.btnEndTask.Text = "End Task";
            this.btnEndTask.UseVisualStyleBackColor = true;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // taskList
            // 
            this.taskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList.BackColor = System.Drawing.SystemColors.Window;
            this.taskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskCol,
            this.cpuCol,
            this.memCol,
            this.timeCol,
            this.idCol});
            this.taskList.GridLines = true;
            this.taskList.Location = new System.Drawing.Point(0, 27);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(515, 370);
            this.taskList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.taskList.TabIndex = 3;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.Details;
            // 
            // taskCol
            // 
            this.taskCol.Text = "Task";
            this.taskCol.Width = 108;
            // 
            // cpuCol
            // 
            this.cpuCol.Text = "CPU";
            this.cpuCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // memCol
            // 
            this.memCol.Text = "Memory (Working Set)";
            this.memCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.memCol.Width = 122;
            // 
            // timeCol
            // 
            this.timeCol.Text = "Time Started";
            this.timeCol.Width = 133;
            // 
            // taskTimer
            // 
            this.taskTimer.Interval = 1000;
            this.taskTimer.Tick += new System.EventHandler(this.taskTimer_Tick);
            // 
            // idCol
            // 
            this.idCol.Text = "PID";
            this.idCol.Width = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(515, 438);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.btnEndTask);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.ColumnHeader taskCol;
        private System.Windows.Forms.ColumnHeader timeCol;
        private System.Windows.Forms.Timer taskTimer;
        private System.Windows.Forms.ColumnHeader memCol;
        private System.Windows.Forms.ColumnHeader cpuCol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitTaskManagerToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader idCol;
    }
}

