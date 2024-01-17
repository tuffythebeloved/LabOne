using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class Relation
    {
        protected string[] relationShipTypes = { "Mother", "Father", "Sister", "Brother", "Child" };

        private Person? p1;
        private Person? p2;

        private string? relationP1;
        private string? relationP2;
        public Relation() { }

        //valid char inputs: b(brother), s(sister), m(mother), f(father), c(Child)
        public Relation(Person p1, Person p2, char relationToP2, char relationToP1)
        {
            this.p1 = p1;
            this.p2 = p2;

            if ((relationToP1 == 'c' && relationToP2 == 'c') || (relationToP1 == 'f' && relationToP2 == 'f') || (relationToP1 == 'm' && relationToP2 == 'm'))
            {
                Console.WriteLine("Error: Invalid Relation type.");
                Environment.Exit(0);
            }
            else if ((relationToP1 == 'f' && relationToP2 == 'm') || (relationToP1 == 'm' && relationToP2 == 'f'))
            {
                Console.WriteLine("Error: Invalid Relation type.");
                Environment.Exit(0);
            }
            else if ((relationToP1 == 'f' && relationToP2 == 's') || (relationToP1 == 's' && relationToP2 == 'f') || (relationToP1 == 'm' && relationToP2 == 's') || (relationToP1 == 's' && relationToP2 == 'm'))
            {
                Console.WriteLine("Error: Invalid Relation type.");
                Environment.Exit(0);
            }
            else if ((relationToP1 == 'f' && relationToP2 == 'b') || (relationToP1 == 'b' && relationToP2 == 'f') || (relationToP1 == 'm' && relationToP2 == 'b') || (relationToP1 == 'b' && relationToP2 == 'm'))
            {
                Console.WriteLine("Error: Invalid Relation type.");
                Environment.Exit(0);
            }

            switch (relationToP2) 
            {
                case 'b':
                    this.relationP1 = relationShipTypes[3];
                    break;
                case 's':
                    this.relationP1 = relationShipTypes[2];
                    break;
                case 'f':
                    this.relationP1 = relationShipTypes[1];
                    break;
                case 'm':
                    this.relationP1 = relationShipTypes[0];
                    break;
                case 'c':
                    this.relationP1 = relationShipTypes[4];
                    break;
            }
            switch (relationToP1)
            {
                case 'b':
                    this.relationP2 = relationShipTypes[3];
                    break;
                case 's':
                    this.relationP2 = relationShipTypes[2];
                    break;
                case 'f':
                    this.relationP2 = relationShipTypes[1];
                    break;
                case 'm':
                    this.relationP2 = relationShipTypes[0];
                    break;
                case 'c':
                    this.relationP2 = relationShipTypes[4];
                    break;
            }
        }

        public void ShowRelationShip(Person person1, Person person2)
        {
            if((person1 != p1 && person2 == p2) || (person1 != p2 && person2 == p1))
            {
                Console.WriteLine("Error: person " + person1.getFirstName() + " " + person1.getLastName() + " isnt in this relation");
            }
            else if((person2 != p1 && person1 == p2) || (person2 != p2 && person1 == p1))
            {
                Console.WriteLine("Error: person " + person2.getFirstName() + " " + person2.getLastName() + " isnt in this relation");
            }
            else if(person1 == p1 && person2 == p2)
            {
                Console.WriteLine(person1.getFirstName() + " " + person1.getLastName() + " is " + person2.getFirstName() + " " + person2.getLastName() + "'s " + relationP1 );
            }
            else if (person1 == p2 && person2 == p1)
            {
                Console.WriteLine(person1.getFirstName() + " " + person1.getLastName() + " is " + person2.getFirstName() + " " + person2.getLastName() + "'s " + relationP2);
            }
            else
            {
                Console.WriteLine("Error: invalid person combination");
            }
        }
    }
}
