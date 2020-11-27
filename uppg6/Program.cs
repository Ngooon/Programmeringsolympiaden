using System;

namespace uppg6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Antal skivor M ? ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antal segment M ? ");
            int M = Convert.ToInt32(Console.ReadLine());
            string[] skivor = new string[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Skiva" + i + 1 + " ? ");
                skivor[i] = Console.ReadLine();
            }

            int antal = 0;

            char[][] skivorChar = new char[N][];

            for (int i = 0; i < N; i++)
            {
                skivorChar[i] = skivor[i].ToCharArray();
            }



            Console.WriteLine("Antal sätt: " + antal);

        }
    }
}
