using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj03
{
    public class Program
    {
        public static void Main()
        {
            Random arrayFiller = new Random();
            int[] grades = new int[100];
            int[] studentGradeTally = new int[5];
            int evenNumCount = 0;
            int oddNumCount = 0;

            for(int i = 0; i < grades.Length; i++)
            {
                grades[i] = arrayFiller.Next(101);
            }


            for(int i = 0; i < grades.Length; i++)
            {
                if (grades[i] % 2 == 0)
                    evenNumCount++;
                else
                    oddNumCount++;

                if (grades[i] >= 90 && grades[i] <= 100) studentGradeTally[0]++;
                else if (grades[i] >= 80 && grades[i] < 90) studentGradeTally[1]++;
                else if (grades[i] >= 70 && grades[i] < 80) studentGradeTally[2]++;
                else if (grades[i] >= 60 && grades[i] < 70) studentGradeTally[3]++;
                else if (grades[i] >= 00 && grades[i] < 60) studentGradeTally[4]++;

            }


            System.Console.WriteLine("The even number count is: " + evenNumCount);
            System.Console.WriteLine("The odd number count is: " + oddNumCount + '\n');

            System.Console.WriteLine("The number of A's is: " + studentGradeTally[0]);
            System.Console.WriteLine("The number of B's is: " + studentGradeTally[1]);
            System.Console.WriteLine("The number of C's is: " + studentGradeTally[2]);
            System.Console.WriteLine("The number of D's is: " + studentGradeTally[3]);
            System.Console.WriteLine("The number of F's is: " + studentGradeTally[4] + '\n');


            for(int i = 0; i < grades.Length; i++)
            {
                System.Console.Write(grades[i] + "\t");
            }


            System.Console.ReadLine();
        }
    }
}
