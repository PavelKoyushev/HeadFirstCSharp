using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetMission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Venus : PlanetMissions
        {
            public override SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
            {
                this.MilesToPlanet = milesToPlanet;
                this.RocketFuelPerMile = rocketFuelPerMile;
                this.RocketSpeedMPH = rocketSpeedMPH;
            }
            public Venus()
            {
                SetMissionInfo(40000000, 100000, 25000);
            }
        }

        class Mars : PlanetMissions
        {  
            public override SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
            {
                this.MilesToPlanet = milesToPlanet;
                this.RocketFuelPerMile = rocketFuelPerMile;
                this.RocketSpeedMPH = rocketSpeedMPH;
            }
            public Mars()
            {
                SetMissionInfo(75000000, 100000, 25000);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Mars mars = new Mars();
            MessageBox.Show(mars.FuelNeeded());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venus venus = new Venus();
            MessageBox.Show(venus.FuelNeeded());
        }

       /* private void button3_Click(object sender, EventArgs e)
        {
            PlanetMissions planet = new PlanetMissions();
            MessageBox.Show(planet.FuelNeeded());
        }*/
    }
}
