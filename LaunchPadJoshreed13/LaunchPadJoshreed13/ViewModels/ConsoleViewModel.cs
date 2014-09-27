using Caliburn.Micro;
using LaunchPadJoshreed13.Models;

namespace LaunchPadJoshreed13.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;

        public ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }
    }
}
