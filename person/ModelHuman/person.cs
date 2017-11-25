using person.ModelIdentity;
using person.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.ModelHuman
{
    public enum sex { male,female};
    public enum invalid { first,second,third,none};
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private DateTime dateOfBurth;

        public DateTime DateOfBurth
        {
            get { return dateOfBurth; }
            set { dateOfBurth = value; }
        }
        private sex gender;

        public sex Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private invalid inv;

        public invalid Inv
        {
            get { return inv; }
            set { inv = value; }
        }
        private List<ID> ids;

        public List<ID> Ids
        {
            get { return ids; }
            set { ids = value; }
        }
        private List<Adult> parents;

        public List<Adult> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

    }
}
