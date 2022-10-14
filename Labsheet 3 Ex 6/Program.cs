using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] fileReviews = new int[,]
            {
                {3,4,5 },
                {1,2,1 },
                {5,4,2 },
            };

            double[] averages = new double[3];

            int total;

            for(int i =0; i<fileReviews.GetLength(0); i++)//Goes through rows
            {
                total = 0;
                for(int j = 0; j<fileReviews.GetLength(1); j++)//Goes through collumns
                {
                    total += fileReviews[i,j];
                }
                averages[i] = (double)total / 3;
            }

            foreach (double average in averages)
            {
                Console.WriteLine($"Average is {average:F2}");
            }
            Console.ReadLine();
        }
    }
}
