using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace project
{
    



    class hackathon
    {
        public static void Main(string[] args)
        {
            List<string> l = new List<string>();

            
            Console.WriteLine("Enter The Word");
            string word = Console.ReadLine();



            foreach (var i in word)
            {
                string[] main_sentence = new string[] { "the", "quick", "and", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

                if (i == ' ')
                {
                    l.Add("-");
                }

                for (int j = 0; j<10; j++ )
                {
                    
                 

                    if (main_sentence[j].Contains(i))
                    {
                        int first = j;
                        int second = main_sentence[j].IndexOf(i);

                        string h = first.ToString();
                        string o = second.ToString();

                        //int final = (first * 10) + second;



                        //int final_int = Convert.ToInt32(final);

                        string f = string.Concat(h,o);

                        l.Add(f);



                        break;
                    }
                }




            }


            string concat = string.Join(",", l.ToArray());
            Console.WriteLine(concat);
            Console.WriteLine();
        }
    }
}