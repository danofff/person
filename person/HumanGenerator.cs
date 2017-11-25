using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
using person.ModelHuman;

namespace person
{
    public class HumanGenerator
    {
        private Random rnd = new Random();
        public Adult AdultGenerator()
        {
            Adult randAdult = new Adult();
            randAdult.Age = rnd.Next(16, 100);
            DateTime yearOfBurth = DateTime.Now.AddYears(-randAdult.Age);
            GenerateBirthDate(randAdult);
            Generator g = new Generator();
            randAdult.Name = g.GenerateDefault(Gender.man);
            randAdult.Name = randAdult.Name.Replace("<center><b><font size=7>", "").Replace("\n", "").Replace("</font></b></center>", "");
            randAdult.Name = randAdult.Name.Substring(1, randAdult.Name.Length - 1);
            return randAdult;
        }
        public DateTime GenerateBirthDate(Adult adult)
        {
            DateTime date = new DateTime();
            date = DateTime.Now.AddYears(-adult.Age);
            adult.DateOfBurth = date;
            return date;
        }
    }
}
