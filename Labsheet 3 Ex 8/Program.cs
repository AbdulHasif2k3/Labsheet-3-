using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> team=new List<string>();

            Console.Write("Enter team member name, -1 to quit >> ");
            string input=Console.ReadLine();

            while (input != "-1")
            {
                team.Add(input);

                Console.Write("Enter team membername,-1 to quit >> ");
                input = Console.ReadLine();
            }

            foreach(string member in team)
            {
                Console.WriteLine(member);
            }

            team.Sort();

            foreach(string member in team)
            {
                Console.WriteLine(member);
            }
        }
    }
}
