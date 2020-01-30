using System;

namespace Eprov_Del_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Superhero superhero = new Superhero();

            Console.WriteLine("Hello and welcome to Superhero Academy!");
            Console.WriteLine("What superhero do you want to play as?");
            Console.WriteLine("Wizard? Alien? or Mutant?");
            Console.WriteLine("Press 1 for Wizard");
            Console.WriteLine("Press 2 for Alien");
            Console.WriteLine("Press 3 for Mutant");
            string input = Console.ReadLine();

            if(input == "1")
            {
                Console.WriteLine("You have chosen the powerful wizard");
            }
            else if(input == "2")
            {
                Console.WriteLine("You have chosen the intelligent alien");
            }
            else if(input == "3")
            {
                Console.WriteLine("You have chosen the great mutant");
            }
        }
    }
}
