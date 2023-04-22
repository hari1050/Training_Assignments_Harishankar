using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harishankar_Assignments
{
    class Assignment4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CTS equivalent of data type of the array");
            string typeName = Console.ReadLine();
            Type selectedType = Type.GetType(typeName, false, true);
            if (selectedType == null)
            {
                Console.WriteLine("Invalid cts type");
                return;
            }
            Array instance = Array.CreateInstance(selectedType, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value for the index {0} of the data type {1}", i, selectedType.Name);
                string input = Console.ReadLine();
                instance.SetValue(Convert.ChangeType(input, selectedType), i);
            }
            Console.WriteLine("Now its time to read the data");
            foreach (var item in instance)
                Console.WriteLine(item);
        }
    }
}
