using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age >> ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (ValidateAge(age))
                Console.WriteLine("You can access the site");
            else
                Console.WriteLine("Sorry, you can't access the site");
            Console.ReadLine();
        }

        
        static bool ValidateAge(int age)
        {
            bool validAge = false;

            if (age >= 18 && age <= 21)
                validAge = true;

            return validAge;
        }
    }
}
