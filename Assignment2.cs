using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Harishankar_Assignments
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            Console.WriteLine("enter elements");
            for (int k = 0; k < array.Length; k++)
            {
                array[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even number");
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Odd number");
            foreach (int j in array)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}