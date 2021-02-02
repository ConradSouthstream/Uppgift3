using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Person
    {

        private int age;
        private string fName;
        private string lName;
       
        public int Age
        {
            get => age;
            set
            {                
                if (value == 0) { throw new ArgumentException("Age can't be 0"); }
                age = value;
            }
        }
        public string FName
        {
            get => fName;
            set
            {
                if (value.Length < 3) { throw new ArgumentException("Too short Name"); }
                fName = value;
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (value.Length < 3 || value.Length > 15) { throw new ArgumentException("Too short (less than 3 char) or long (more than 15 char) Lastname"); }
                lName = value;
            }
        }
        public float Height { get; set; }
        public float Weight { get; set; }
    }
}
