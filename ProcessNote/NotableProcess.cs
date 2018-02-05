using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessNote
{
    class NotableProcess : Process
    {
        private string note = "";

        public string Note { get => note; set => note = value; }

        public override int GetHashCode()
        {
            return ProcessName.GetHashCode() + Id * 31;
        }
    }
}
