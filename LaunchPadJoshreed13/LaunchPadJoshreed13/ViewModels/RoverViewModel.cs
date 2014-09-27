using Caliburn.Micro;
using LaunchPadJoshreed13.Models;
using System.Threading.Tasks;

namespace LaunchPadJoshreed13.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
        private RoverModel Model;

        public string RoverName
        {
            get
            {
                return Model.roverName;
            }
            set
            {
                Model.roverName = value;
                NotifyOfPropertyChange(() => RoverName);
            }
        }

        public int Speed
        {
            get
            {
                return Model.speed;
            }
            set
            {
                Model.speed = value;
                NotifyOfPropertyChange(() => Speed);
            }
        }

        public double Temperature
        {
            get
            {
                return Model.temperature;
            }
            set
            {
                Model.temperature = value;
                NotifyOfPropertyChange(() => Temperature);
            }
        }

        public bool IsConnected
        {
            get
            {
                return Model.isConnected;
            }
            set
            {
                Model.isConnected = value;
                NotifyOfPropertyChange(() => IsConnected);
            }
        }

        public RoverViewModel()
        {
            Model = new RoverModel();
            RoverName = "Phoenix 1.5";
        }

        public void Rove()
        {
            if (IsConnected)
            {
                Task.Run(async () =>
                {
                    Speed = 0;
                    Temperature = 50;
                    for (var i = 0; i < 15; i++)
                    {
                        Speed = i;
                        Temperature += Speed / 4;
                        await Task.Delay(200);
                    }
                    for (var i = 14; i >= 0; i--)
                    {
                        Speed = i;
                        Temperature -= Speed / 4;
                        await Task.Delay(200);
                    }
                });
            }
        }
    }
}