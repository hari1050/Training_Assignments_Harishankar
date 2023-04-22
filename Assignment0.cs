using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harishankar_Assignments
{

    enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday
    }
    class Assignment0
    {
        static void Main(String[] args)
        {
            //AccountType acc = AccountType.RDAccount;
            //Console.WriteLine("The account type is" + acc);
            //Console.WriteLine(acc.GetTypeCode());

            Console.WriteLine("Enter the day");
            Array a = Enum.GetValues(typeof(Day));
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a.GetValue(i));
            }
            //string input = Console.ReadLine();
            //object selectedType = Enum.Parse(typeof(AccountType), input, true);
            //AccountType selected = (AccountType)selectedType;
            Day selected = (Day)Enum.Parse(typeof(Day), Console.ReadLine());
            Console.WriteLine("the selected day is" + selected);
        }
    }
}
