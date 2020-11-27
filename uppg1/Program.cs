using System;

namespace uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Äpplen ? ");
            int applen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Päron ? ");
            int paron = Convert.ToInt32(Console.ReadLine());

            int axel = applen * 7;
            int petra = paron * 13;

            if (axel > petra)
            {
                Console.WriteLine("Svar: Axel");
            }
            else if (petra > axel)
            {
                Console.WriteLine("Svar: Petra");
            }
            else
            {
                Console.WriteLine("Svar: lika");
            }
        }
    }
}
