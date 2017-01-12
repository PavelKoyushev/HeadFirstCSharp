using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLocation
{
    class Outside : Location
    {
        private bool hot;
        public bool Hot { get { return hot; } }
        public Outside(string name, bool hot) : base (name)
        {
            this.hot = hot;
        }
        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += "Очень жарко.";
                return NewDescription;
            }
        }
    }
}
