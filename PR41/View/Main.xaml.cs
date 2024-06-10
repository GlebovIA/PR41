using PR41.ViewModell;
using System.Windows.Controls;

namespace PR41.View
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            DataContext = new VMStopwatch();
        }
    }
}
