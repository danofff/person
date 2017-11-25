using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person.Education;

namespace person.ModelHuman
{
    public class KidsUnder16 : Person
    {
        public KidsUnder16()
        {
            sch = new List<School>(0);
        }
        private List<School> sch;
        public List<School> Sch
        {
            get { return sch; }
            set { sch = value; }
        }
    }
}
