namespace ProcessNote
{
    partial class MainWindow
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
            this.processList = new System.Windows.Forms.ListView();
            this.processID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processID,
            this.processName});
            this.processList.Location = new System.Drawing.Point(55, 46);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(814, 338);
            this.processList.TabIndex = 1;
            this.processList.UseCompatibleStateImageBehavior = false;
            this.processList.View = System.Windows.Forms.View.Details;
            this.processList.DoubleClick += new System.EventHandler(this.ProcessList_DoubleClick);
            // 
            // processID
            // 
            this.processID.Text = "Process ID";
            this.processID.Width = 100;
            // 
            // processName
            // 
            this.processName.Text = "ProcessName";
            this.processName.Width = 500;
            // 
            // timer
            // 
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 449);
            this.Controls.Add(this.processList);
            this.Name = "mainWindow";
            this.Text = "ProcessNote";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView processList;
        private System.Windows.Forms.ColumnHeader processID;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.Timer timer;
    }
}

