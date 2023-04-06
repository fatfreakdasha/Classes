using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Students
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int BaseClasses { get; set; }
        public Students(string name, string surname, int baseclasses)
        {
            Name = name;
            Surname = surname;
            BaseClasses = baseclasses;
        }
        public override string ToString()
        {
            return "имя студента: " + Name + ". фамилия студента: " + Surname + ". поступил на базе " + BaseClasses + " классов ";
        }
    }
}