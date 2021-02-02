using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Horse : Animal
    {
        public string Domesticated { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Gnägg");
        }     

        public Horse
            (string name, float weight, int age, int legcount, string domesticated) : 
            base(name, weight, age, legcount)
        {
            Domesticated = domesticated;
        }
        public override string Stats()
        {
            return 
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är {this.Domesticated}.";
        }
    }
    class Dog : Animal
    {
        public string Breed { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Woof");
        }
        public Dog
            (string name, float weight, int age, int legcount, string breed) : 
            base(name, weight, age, legcount)
        {
            Breed = breed;
        }
        public override string Stats()
        {
            return 
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är av rasen {this.Breed}.";
        }
        public void Piss()
        {
            Console.WriteLine("*tinkle*");
        }
    }
    class Hedgehog : Animal
    {
        public string IfBlue { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("GottaGoFast!");
        }
        public Hedgehog
            (string name, float weight, int age, int legcount, string ifblue) : 
            base(name, weight, age, legcount)
        {
            IfBlue = ifblue;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är {this.IfBlue}.";
        }
    }
    class Worm : Animal
    {
        public string Team17orReal { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("*tänt var det här*");
        }
        public Worm
            (string name, float weight, int age, int legcount, string team17orreal) : 
            base(name, weight, age, legcount)
        {
            Team17orReal = team17orreal;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är {this.Team17orReal}.";
        }
    }
    class Bird : Animal
    {
        public string Migrating { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Tweet");
        }
        public Bird
            (string name, float weight, int age, int legcount, string migrating) : 
            base(name, weight, age, legcount)
        {
            Migrating = migrating;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är {this.Migrating}.";
        }
    }
    class Wolf : Animal
    {
        public string LoneOrPack { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Awooo!");
        }
        public Wolf
            (string name, float weight, int age, int legcount, string loneorpack) : 
            base(name, weight, age, legcount)
        {
            LoneOrPack = loneorpack;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är en {this.LoneOrPack}.";
        }
    }
}
