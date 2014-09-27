using Caliburn.Micro;
using LaunchPadJoshreed13.Models;

namespace LaunchPadJoshreed13.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;

        public string Text
        {
            get
            {
                return Model.text;
            }
            set
            {
                Model.text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }

        public ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }
    }
}
