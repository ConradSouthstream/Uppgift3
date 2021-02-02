using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Wolfman : Wolf,IPerson
    {
        public override void DoSound()
        {
            Console.WriteLine("Arf");
        }
        public void Talk()
        {
            Console.WriteLine($"{this.Name} säger: Sicken fin måne!");
        }
        public Wolfman
            (string name, float weight, int age, int legcount, string loneorpack) :
            base(name, weight, age, legcount, loneorpack)
        { }
        public override string Stats() 
        {
            return
                    $"Den här {this.Name}, " +
                    $"väger {this.Weight} kilo, " +
                    $"är {this.Age} år gammal, " +
                    $"har {this.Legcount} ben " +
                    $"och är {this.LoneOrPack}.";
        }
        
    }
}
