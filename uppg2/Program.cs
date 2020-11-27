using System;

namespace uppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nummer ? ");
            string input = Console.ReadLine();

            int year = Convert.ToInt32(input.Substring(0, 2));
            string sign = input.Substring(6, 1);

            int startYear = new int();

            if (sign == "-")
            {
                if (year > 20)
                {
                    startYear = 19;
                }
                else
                {
                    startYear = 20;
                }
            }
            else if (sign == "+")
            {
                if (year >= 40)
                {
                    startYear = 18;
                }
                else
                {
                    startYear = 19;
                }
            }

            string fullNumber = startYear.ToString() + input.Substring(0, 6) + input.Substring(7, 4);
            Console.WriteLine("Svar: " + fullNumber);
        }
    }
}
