﻿using Caliburn.Micro;
using LaunchPadJoshreed13.Models;

namespace LaunchPadJoshreed13.ViewModels
{
    class MainWindowViewModel : PropertyChangedBase
    {
        private MainWindowModel Model;

        public ConsoleViewModel Console
        {
            get
            {
                return Model.console;
            }
            set
            {
                Model.console = value;
                NotifyOfPropertyChange(() => Console);
            }
        }

        public RoverViewModel Rover
        {
            get
            {
                return Model.rover;
            }
            set
            {
                Model.rover = value;
                NotifyOfPropertyChange(() => Rover);
            }
        }

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
            Model.console = new ConsoleViewModel(this);
            Model.rover = new RoverViewModel(this);
        }
    }
}
