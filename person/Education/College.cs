using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Education
{
    public class College:Education
    {
        private string prof;

        public string Prof
        {
            get { return prof; }
            set { prof = value; }
        }
        private string faculty;

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
    }
}
