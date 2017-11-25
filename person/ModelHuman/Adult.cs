using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person.Education;

namespace person.ModelHuman
{
    public class Adult:Person
    {
        private List<KidsUnder16> kids;

        public List<KidsUnder16> Kids
        {
            get { return kids; }
            set { kids = value; }
        }
        private bool isMarried;

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }
        private bool isWorking;

        public bool IsWorking
        {
            get { return isWorking; }
            set { isWorking = value; }
        }
        private List<School> schools;

        public List<School> Schools
        {
            get { return schools; }
            set { schools = value; }
        }
        private List<College> colleges;
        public List<College> Colleges
        {
            get { return colleges; }
            set { colleges = value; }
        }
        //конструктор
        public Adult():this(new List<School>())
        {
            Kids = new List<KidsUnder16>();
        }
        public Adult(List<School> schools):this(schools,new List<College>())
        {
            this.Schools = schools;
        }
        public Adult(List<School> schools, List<College> colleges)
        {
            this.Colleges = colleges;
        }
        public static bool operator ==(Adult a, Adult b)
        {
            return a.Age == b.Age;
        }
        public static bool operator !=(Adult a, Adult b)
        {
            return a.Age != b.Age;
        }
    }
}
