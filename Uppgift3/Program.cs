using System;
using System.Collections.Generic;

namespace Uppgift3
{
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                PersonHandler ph = new PersonHandler();
                Person APerson = ph.Createperson(31, "Conny", "Söderström", 184, 115);
                Console.WriteLine(APerson.Age);

                ph.SetAge(APerson, 32);
                Console.WriteLine(APerson.Age);
                Person AnotherPerson = ph.Createperson(1, "Con", "Söderströmeris", 184, 115);

                ////Test för ingen ålder
                //ph.SetAge(APerson, 0);
                //Console.WriteLine(APerson.Age);

                ////Test för kort namn
                //ph.SetFName(APerson, "Co");
                //Console.WriteLine(APerson.FName);

                ////Test för kort efternamn
                //ph.SetLName(APerson, "Sö");
                //Console.WriteLine(APerson.LName);

                ////Test för långt efternamn
                //ph.SetLName(APerson, "Söderströmerister");
                //Console.WriteLine(APerson.LName);
                
                List <Animal> ListofAnimals = new List<Animal>();
                List<Dog> ListofDogs = new List<Dog>();

                ListofAnimals.Add(new Dog("Hunden", 20, 14, 4, "labradoodle"));
                ListofAnimals.Add(new Wolf("Vargen", 60, 18, 4, "Ensam Varg"));
                ListofAnimals.Add(new Wolfman("Vargmannen", 95, 39, 2, "lite full av månsken"));
                ListofAnimals.Add(new Swan("Svanen", 2, 4, 2, "Migrerar" ,"Vacker men argsint"));
                
                ListofDogs.Add(new Dog("Hunden", 20, 14, 4, "labradoodle"));
                ListofDogs.Add(new Dog("Hundan", 15, 21, 4, "Pudel"));
                ListofDogs.Add(new Dog("Hundini", 17, 5, 4, "labradiddle"));
                ListofDogs.Add(new Dog("Vovven", 8, 3, 4, "Donnini"));
                
                foreach (var Animal in ListofAnimals)
                {
                    Animal.DoSound();
                    Console.WriteLine(Animal.Stats());
                    if (Animal is IPerson)
                    {
                        //Lägg "var is klass" på minnet
                        var person = (IPerson)Animal;                        
                        person.Talk();                        
                    }
                }
                //3.3 punkt 8
                Console.WriteLine("\n");
                foreach (var dog in ListofDogs)
                {
                    Console.WriteLine(dog.Stats());
                }
                //3.3 punkt 14
                foreach (var dog in ListofAnimals)
                {                                       
                    if (dog is Dog)
                    {
                        
                        var doggie = (Dog)dog;
                        //3.3 punkt 16
                        //dog.Piss();
                        //3.3 punkt 17
                        //Kommer inte åt den för att Animal objektet 
                        //inte har referens till Dog's unika metoder och egenskaper

                        //3.3 punkt 18
                        //Static Piss() method
                        //Dog.Piss();
                        doggie.Piss();
                        Console.WriteLine(doggie.Stats());
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<UserError> ListofErrors = new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
                new LostInputError(),
                new BreakintheLawInputError(),
                new GRatedInputError()
            };

            foreach (var Error in ListofErrors)
            {
                Console.WriteLine(Error.UEMessage());
            }

        }
    }
}
