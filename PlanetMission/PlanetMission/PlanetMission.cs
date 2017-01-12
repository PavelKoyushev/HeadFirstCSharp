using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetMission
{
    abstract class PlanetMissions
    {
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;
        
        public abstract void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH);

        public long UnitsOfFuelNeeded()
        {
            return RocketFuelPerMile * MilesToPlanet;
        }
        public int TimeNeeded()
        {
            return MilesToPlanet / (int) RocketSpeedMPH;
        }
        public string FuelNeeded()
        {
            return "You'll need"
                + MilesToPlanet * RocketFuelPerMile
                + "units of fuel to get there. It'll take"
                + TimeNeeded() + " hours.";
        }
    }
}
