using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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


        private string armPlace = "2";

        public string ArmPlace
        {
            get { return this.armPlace; }
            set
            {
                if (value == armPlace)
                    return;
                this.armPlace = value;
                NotifyOfPropertyChange(() => ArmPlace);
            }
        }
        private bool armNow;
        public bool ArmNow
        {
            get
            {
                return this.armNow;
            }
            set
            {
                this.armNow = value;
                NotifyOfPropertyChange(() => ArmNow);
              


            }
        }
        private string rad = "30";
        

        public string Rad
        {
            get { return rad; }
            set
            {
                if (value == rad)
                    return;
                rad = value;//.Replace(',', '.') ;
                NotifyOfPropertyChange(() => Rad);
            }
        }
    }
}
