using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.InteropServices;

namespace ParallelPortControl
{
    class PortControl
    {
        [DllImport("Inpout32.dll")]
        public static extern short Inp32(int address);
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int adress, int value); // decimal
    }
}
