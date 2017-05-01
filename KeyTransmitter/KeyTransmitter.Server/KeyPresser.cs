using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace KeyTransmitter.Server
{
    public class KeyPresser
    {
        private InputSimulator input = new InputSimulator();

        public void PressKey(ConsoleKey key)
        {
            input.Keyboard.KeyPress((VirtualKeyCode)key);
        }
    }
}
