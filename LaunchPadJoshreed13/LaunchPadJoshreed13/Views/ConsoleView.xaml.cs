using LaunchPadJoshreed13.ViewModels;
using System.Windows.Controls;

namespace LaunchPadJoshreed13.Views
{
    /// <summary>
    /// Interaction logic for ConsoleView.xaml
    /// </summary>
    public partial class ConsoleView : UserControl
    {
        public ConsoleView()
        {
            InitializeComponent();
            this.DataContext = new ConsoleViewModel();
        }
    }
}
