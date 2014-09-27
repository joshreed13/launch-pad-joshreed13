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
            Text = "asdfjkl;";
        }

        public void Clear()
        {
            Text = string.Empty;
        }

        public void Connect()
        {
            Text += "Connected!" + System.Environment.NewLine;
        }

        public void Disconnect()
        {
            Text += "Disconnected!" + System.Environment.NewLine;
        }
    }
}
