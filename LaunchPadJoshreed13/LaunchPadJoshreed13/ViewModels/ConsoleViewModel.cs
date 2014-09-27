using Caliburn.Micro;
using LaunchPadJoshreed13.Models;

namespace LaunchPadJoshreed13.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private MainWindowViewModel MainWindowVM;
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

        public ConsoleViewModel(MainWindowViewModel MainWinVM)
        {
            MainWindowVM = MainWinVM;
            Model = new ConsoleModel();
            WriteLine("asdfjkl;");
        }

        public void WriteLine(string text)
        {
            Text += text + System.Environment.NewLine;
        }

        public void Clear()
        {
            Text = string.Empty;
        }

        public void Connect()
        {
            MainWindowVM.Rover.IsConnected = true;
            WriteLine("Connected!");
        }

        public void Disconnect()
        {
            MainWindowVM.Rover.IsConnected = false;
            WriteLine("Disconnected!");
        }
    }
}
