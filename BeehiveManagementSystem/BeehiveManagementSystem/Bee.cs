using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Bee
    {
        public Bee(double weight)
        {
            this.weigth = weight;
        }

        public virtual int ShiftLeft
        {
            get { return 0; }

        }

        private double weigth;

        public virtual double GetHoneyConsumption()
        {
            double consumption;
            if (ShiftLeft == 0)
                consumption = 7.5;
            else
                consumption = 9 + ShiftLeft;
            if (weigth > 150)
                consumption *= 1.35;
            return consumption;
        }
    }
}
