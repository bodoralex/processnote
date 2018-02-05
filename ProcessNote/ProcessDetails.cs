using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessNote
{
    public partial class ProcessDetails : Form
    {
        private MainWindow mainWindow;
        private int pid;
        private Process myProcess;
        private CPUUsageCalculator cpuUsageCalculator;
        public ProcessDetails()
        {
            InitializeComponent();
        }

        public ProcessDetails(MainWindow mainWindow, int pid)
        {
            this.mainWindow = mainWindow;
            this.pid = pid;
            myProcess = Process.GetProcessById(pid);
            InitializeComponent();
            Name = $"{myProcess.Id}: {myProcess.ProcessName}";
            Text = Name;
            startTimeLabel.Text = myProcess.StartTime.ToLocalTime().ToString("HH:mm:ss MMMM dd");
            cpuUsageCalculator = new CPUUsageCalculator(pid);
            noteTextBox.Text = mainWindow.processNotes.ContainsKey(pid) ? mainWindow.processNotes[pid] : null;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) 
        {
            myProcess = Process.GetProcessById(pid);
            memoryUsageLabel.Text = ((int) (myProcess.PeakWorkingSet64/1024)) + " KBytes" ;
            runningTimeLabel.Text = (DateTime.Now - myProcess.StartTime).ToString(@"hh\:mm\:ss");
            cpuUsageLabel.Text = cpuUsageCalculator.PrecentageSinceLastRequest() + " %";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void SaveNote()
        {
            mainWindow.processNotes.Remove(pid);
            mainWindow.processNotes.Add(pid, noteTextBox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            noteTextBox.Text = mainWindow.processNotes.ContainsKey(pid) ? mainWindow.processNotes[pid] : null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            mainWindow.processNotes.Remove(pid);
            noteTextBox.Text = "";
        }
        private void SaveDialog()
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save now?", "Notes are not saved.", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            SaveNote();
        }

        private void ProcessDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool boxIsNotEmptyAndNoSuchAKey = !String.IsNullOrEmpty(noteTextBox.Text) && !mainWindow.processNotes.ContainsKey(pid);
            bool boxAndValueNotEquals = mainWindow.processNotes[pid] != noteTextBox.Text;
            if (boxIsNotEmptyAndNoSuchAKey)
                SaveDialog();
            
        }
    }
}
