using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Pelican : Bird
    {
        public int GulletVol { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("*Gulp*");
        }
        public Pelican
            (string name, float weight, int age, int legcount, string migrating, int gulletvol) : 
            base(name, weight, age, legcount, migrating)
        {
            GulletVol = gulletvol;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och har ett svalj volym på {this.GulletVol}.";
        }
    }
    class Flamingo : Bird
    {
        public string IfSleepMode { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("ZzzZzz");
        }
        public Flamingo
            (string name, float weight, int age, int legcount, string migrating, string ifsleepmode) : 
            base(name, weight, age, legcount, migrating)
        {
            IfSleepMode = ifsleepmode;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben " +
                $"och är för tillfället i {this.IfSleepMode}.";
        }
    }
    class Swan : Bird
    {
        public string IfUgly { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Hisss!");
        }
        public Swan
            (string name, float weight, int age, int legcount, string migrating, string ifugly) : 
            base(name, weight, age, legcount, migrating)
        {
            IfUgly = ifugly;
        }
        public override string Stats()
        {
            return
                $"Den här {this.Name}, " +
                $"väger {this.Weight} kilo, " +
                $"är {this.Age} år gammal, " +
                $"har {this.Legcount} ben, " +
                $"den {Migrating} " +
                $"och är {this.IfUgly}.";
        }
    }
}
