using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPadJoshreed13.Models;
using Caliburn.Micro;

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
