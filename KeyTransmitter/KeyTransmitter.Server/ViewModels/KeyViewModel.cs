using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTransmitter.Server.ViewModels
{
    public class KeyViewModel : PropertyChangedBase
    {
        private string key = "None";

        public string Key
        {
            get { return key; }
            set
            {
                if (value == key)
                    return;
                key = value;
                NotifyOfPropertyChange(() => Key);
            }
        }
    }
}
