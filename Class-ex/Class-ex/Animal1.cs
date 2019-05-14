using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ex
{
    class Animal1
    { //attributes
        string name, sound;

        //getters and setters
        public string Name { get { return name; } set { name = value; } }
        public string Sound { get { return sound; } set { sound = value; } }

        //method
        public string AnimalSays()
        { return $"The {Name} says {Sound}"; }

        //constructor
        public Animal1(string _name, string _sound)
        {
            Name = _name;
            Sound = _sound;
        }

    }
}
