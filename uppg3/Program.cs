using System;

namespace uppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Priset N ? ");
            int price = Convert.ToInt32(Console.ReadLine());

            int rest = new int();
            int antal = Math.DivRem(price, 111111111, out rest);
            antal += Math.DivRem(rest, 11111111, out rest);
            antal += Math.DivRem(rest, 1111111, out rest);
            antal += Math.DivRem(rest, 111111, out rest);
            antal += Math.DivRem(rest, 11111, out rest);
            antal += Math.DivRem(rest, 1111, out rest);
            antal += Math.DivRem(rest, 111, out rest);
            antal += Math.DivRem(rest, 11, out rest);
            antal += Math.DivRem(rest, 1, out rest);
            Console.WriteLine("Antal sedlar: " + antal);
        }
    }
}
