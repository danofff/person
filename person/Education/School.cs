using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Education
{
    public enum level { first,secon,third}
    public class School:Education
    {
        private level lev;

        public level Lev
        {
            get { return lev; }
            set { lev = value; }
        }

    }
}
