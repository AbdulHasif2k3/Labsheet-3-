using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] filmReviews = new int[][]
            {
                new int[](3,4),
                new int[](1,2,1,3),
                new int[]{5,4,2}
            };

            double[] averages = new double[3];

            int total;

            for (int i=0; i<filmReviews.GetLength(0); i++)
            {
                total = 0;
                for (int j = 0; j < filmReviews[i].Length;j++)
                {
                    total += filmReviews[i][j];
                }
                averages[i] = (double)total / filmReviews[i].Length;
            }
            foreach (double average in averages)
            {
                Console.WriteLine($"Average is {average:F2}");
                Console.ReadLine();
            }
        }


    }
}
