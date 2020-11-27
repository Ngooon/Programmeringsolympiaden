using System;

namespace uppg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N ? ");
            long N = Convert.ToInt64(Console.ReadLine());
            Console.Write("K ? ");
            long K = Convert.ToInt64(Console.ReadLine());
            Console.Write("H ? ");
            long H = Convert.ToInt64(Console.ReadLine());

            int[] d = new int[N-1];
            for (int i = 1; i < N; i++)
            {
                Console.Write("d" + i + " ? ");
                d[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(d);
            long paddlar = 0;

            foreach (int length in d)
            {
                long temp = Convert.ToInt64(Math.Ceiling((length * H - (paddlar * (K - 1.00))) / K));
                if (temp >= 0)
                {
                    paddlar += temp;
                }
                //paddlar += Convert.ToInt64(Math.Ceiling((length*H - (paddlar * (K - 1.00))) / K));
            }

            Console.WriteLine("Svar: " + paddlar);


            //Array.Sort(d);

            //Console.WriteLine("N = " + N);
            //Console.WriteLine("K = " + K);
            //Console.WriteLine("H = " + H);
            //foreach  (int i in d)
            //{
            //    Console.WriteLine(i);
            //}
            
            
        }
    }
}
