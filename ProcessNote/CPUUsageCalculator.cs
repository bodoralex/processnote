using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessNote
{
    class CPUUsageCalculator
    {
        private TimeSpan previousTotalTime;
        private DateTime previousMeasureTime;
        private int pID;

        public CPUUsageCalculator(int pID)
        {
            previousTotalTime = Process.GetProcessById(pID).TotalProcessorTime;
            previousMeasureTime = DateTime.Now;
            this.pID = pID;
        }
        public int PrecentageSinceLastRequest()
        {
            DateTime now = DateTime.Now;
            TimeSpan totalProcessorTime = Process.GetProcessById(pID).TotalProcessorTime;
            int usage = (int) (100 * ((totalProcessorTime - previousTotalTime).Ticks) / (now - previousMeasureTime).Ticks);
            previousTotalTime = totalProcessorTime;
            previousMeasureTime = now;
            return usage;
        }
    }
}
