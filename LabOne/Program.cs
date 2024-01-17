/**
*Creates People as Classes and shows there relationships
*Author:Thalia Munroe
*Version: January 17th, 2024 - V1.0
**/
namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            p2.DisplayPersonInfo();

            Console.WriteLine(p3.ToString());

            p1.ChangeFavouriteColour("White");
            p1.DisplayPersonInfo();

            Console.WriteLine("Mary's age in ten years is: " + p4.GetAgeInTenYears());

            Relation r1 = new Relation(p2, p4, 's', 's');
            Relation r2 = new Relation(p1, p3, 'b', 'b');

            r1.ShowRelationShip(p2, p4);
            r2.ShowRelationShip(p1, p3);

            List<Person> list = new List<Person>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);

            int totalAge = 0;
            foreach(Person p in list)
            {
                totalAge += p.getAge();
            }
            double averageAge = Convert.ToDouble(totalAge) / Convert.ToDouble(list.Count());

            Console.WriteLine("the average age of people in the list is: " + averageAge);

            Person youngestPerson = new Person(0, null, null, null, int.MaxValue, false);
            Person oldestPerson = new Person();
            foreach(Person p in list)
            {
                if(p.getAge() < youngestPerson.getAge())
                {
                    youngestPerson = p;
                }
                if(p.getAge() > oldestPerson.getAge())
                {
                    oldestPerson = p;
                }
            }
            Console.WriteLine("The oldest person is: " + oldestPerson.getFirstName() + " at " + oldestPerson.getAge() + " years old");
            Console.WriteLine("The youngest person is: " + youngestPerson.getFirstName() + " at " + youngestPerson.getAge() + " years old");

            Console.WriteLine("people with names that start with M are: ");
            foreach(Person p in list)
            {
                if(p.getFirstName().First() == 'M')
                {
                    Console.WriteLine(p.getFirstName() + " " + p.getLastName());
                }
            }

            Console.WriteLine("The person whos favourite colour is blue, is: ");
            foreach(Person p in list)
            {
                if(p.getFavouriteColour() == "Blue")
                {
                    Console.WriteLine(p.getFirstName() + " " + p.getLastName());
                }
            }
        }
    }
}