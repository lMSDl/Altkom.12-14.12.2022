using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    internal class GardenCommand : ICommand
    {
        private readonly Garden _garden;
        private readonly string _plantName;
        private readonly GardenActions _gardenAction;

        public GardenCommand(Garden garden, string plantName, GardenActions gardenAction)
        {
            _garden = garden;
            _plantName = plantName;
            _gardenAction = gardenAction;
        }

        public bool Execute()
        {
            switch(_gardenAction) {
                case GardenActions.Plant:
                    return _garden.Add(_plantName);
                case GardenActions.Remove:
                    return _garden.Remove(_plantName);
            }
            return false;
        }

        public void Reverse()
        {
            switch (_gardenAction)
            {
                case GardenActions.Remove:
                    _garden.Add(_plantName);
                    break;
                case GardenActions.Plant:
                    _garden.Remove(_plantName);
                    break;
            }
        }
    }
}
