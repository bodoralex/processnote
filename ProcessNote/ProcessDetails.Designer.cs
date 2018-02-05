namespace ProcessNote
{
    partial class ProcessDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.staticCPUUsage = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.memoryUsageLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Memory Usage";
            // 
            // staticCPUUsage
            // 
            this.staticCPUUsage.AutoSize = true;
            this.staticCPUUsage.Location = new System.Drawing.Point(41, 32);
            this.staticCPUUsage.Name = "staticCPUUsage";
            this.staticCPUUsage.Size = new System.Drawing.Size(81, 17);
            this.staticCPUUsage.TabIndex = 2;
            this.staticCPUUsage.Text = "CPU Usage";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(44, 214);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(352, 95);
            this.noteTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(431, 214);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(431, 249);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(431, 286);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // memoryUsageLabel
            // 
            this.memoryUsageLabel.AutoSize = true;
            this.memoryUsageLabel.Location = new System.Drawing.Point(173, 75);
            this.memoryUsageLabel.Name = "memoryUsageLabel";
            this.memoryUsageLabel.Size = new System.Drawing.Size(46, 17);
            this.memoryUsageLabel.TabIndex = 11;
            this.memoryUsageLabel.Text = "label5";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(173, 32);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(46, 17);
            this.cpuUsageLabel.TabIndex = 10;
            this.cpuUsageLabel.Text = "label6";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(173, 160);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(46, 17);
            this.startTimeLabel.TabIndex = 15;
            this.startTimeLabel.Text = "label1";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Location = new System.Drawing.Point(173, 117);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(46, 17);
            this.runningTimeLabel.TabIndex = 14;
            this.runningTimeLabel.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Running Time";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ProcessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 340);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.runningTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.memoryUsageLabel);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staticCPUUsage);
            this.Name = "ProcessDetails";
            this.Text = "processDetailsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label staticCPUUsage;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label memoryUsageLabel;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label runningTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
    }
}