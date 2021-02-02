using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    abstract class Animal
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }
        public int Legcount { get; set; }
        
        public Animal(string name, float weight, int age, int legcount)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Legcount = legcount;
        }
        public abstract void DoSound();

        public abstract string Stats();
    }
}
