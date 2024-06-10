using PR41.Modell;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace PR41.ViewModell
{
    public class VMStopwatch : INotifyPropertyChanged
    {
        public Stopwatch Stopwatch { get; set; }
        public DispatcherTimer Timer = new DispatcherTimer()
        {
            Interval = new System.TimeSpan(0, 0, 1)
        };
        public VMStopwatch()
        {
            Stopwatch = new Stopwatch() { Work = false, Time = 0 };
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
        private void Time_Tick(object sender, System.EventArgs e)
        {
            if (Stopwatch.Work)
                Stopwatch.Time++;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
