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
    public partial class MainWindow : Form
    {
        internal Dictionary<int, string> processNotes = new Dictionary<int, string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer.Start();
            RefreshProcesses();
        }
        private void RefreshProcesses()
        {
            Process[] processes = Process.GetProcesses();
            this.RefreshListView(processes);
        }
        private void RefreshListView(Process[] processes)
        {
            Array.Sort(processes, new ProcessComparer());
            processList.Items.Clear();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.Id.ToString());
                item.SubItems.Add(process.ProcessName);
                processList.Items.Add(item);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void ProcessList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = processList.SelectedItems[0];
            if (selectedItem == null) return;
            ProcessDetails processDetails  = new ProcessDetails(this, int.Parse(selectedItem.Text));
            processDetails.Show();
        }
    }
}
