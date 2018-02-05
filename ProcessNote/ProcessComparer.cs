using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote
{
    class ProcessComparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.ProcessName.CompareTo(y.ProcessName);
        }
    }
}
