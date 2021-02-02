using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class PersonHandler
    {
        public Person Createperson(int age, string fName, string lName, float height, float weight)
        {
            Person person = new Person();

            SetAge (person ,age);
            SetFName (person ,fName);
            SetLName (person ,lName);
            SetHeight (person ,height);
            SetWeight (person ,height);

            return person;
        }
        public void SetAge(Person person, int age) {person.Age = age;}
        public void SetFName(Person person, string fName) {person.FName = fName;}
        public void SetLName(Person person, string lName) {person.LName = lName;}
        public void SetHeight(Person person, float height) {person.Height = height;}
        public void SetWeight(Person person, float height) {person.Weight = height;}

    }
}
