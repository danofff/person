using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.ModelHuman
{
    class Invalid:Adult
    {
        private double benefit;
        public double Benefit
        {
            get { return benefit; }
            set { benefit = value; }
        }

        public Invalid():this(invalid.none) { }
        public Invalid(invalid inv):this(inv,0)
        {
        }
        public Invalid(invalid inv, double benefit)
        {
            base.Inv = inv;
            this.Benefit = benefit;
        }

    }
}
