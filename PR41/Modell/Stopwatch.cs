using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PR41.Modell
{
    class Stopwatch : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public string Timer
        {
            get
            {
                float Hour = (Time / 60f / 60f);
                float Minute = (Time / 60f) - ((int)Hour * 60f);
                float Second = Time - (int)Hour * 60f * 60f - (int)Minute * 60f;
                string sHour = ((int)Hour).ToString();
                string sMinute = ((int)Minute).ToString();
                string sSecond = ((int)Second).ToString();
                if (Hour < 10) sHour = "0" + ((int)Hour).ToString();
                if (Minute < 10) sMinute = "0" + ((int)Minute).ToString();
                if (Second < 10) sSecond = "0" + ((int)Second).ToString();
                return $"{sHour}:{sMinute}:{sSecond}";
            }
        }
        private int time;
        public int Time
        {
            get { return time; }
            set
            {
                time = value;
                OnPropertyChanged("Timer");
            }
        }

    }
}
