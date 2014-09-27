using Caliburn.Micro;
using LaunchPadJoshreed13.Models;

namespace LaunchPadJoshreed13.ViewModels
{
    class MainWindowViewModel : PropertyChangedBase
    {
        private MainWindowModel Model;

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
        }
    }
}
