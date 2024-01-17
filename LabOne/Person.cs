using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class Person
    {
        protected int personId;
        protected string? firstName;
        protected string? lastName;
        protected string? favouriteColour;
        protected int age;
        protected bool isWorking;
        public Person() { }

        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public int getAge()
        {
            return age;
        }
        public string getFavouriteColour()
        {
            return favouriteColour;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine(firstName + " " + lastName + "'s favourite colour is: " + favouriteColour);
        }

        public void ChangeFavouriteColour(string newColour)
        {
            this.favouriteColour = newColour;
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        override public string ToString()
        {
            string person = ("person id: " + personId + ", first name: " + firstName + ", last name: " + lastName + ", age: " + age + ", favourite colour: " + favouriteColour + ", is working: " + isWorking.ToString());
            return person;
        }
    }
}
