using System;

namespace uppg5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Energiförbrukning N ? ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int antal = 0;

            int oldi1 = 0;
            int oldi2 = 0;
            int oldi3 = 0;

            for (int i1 = 0; i1 < 24; i1++)
            {
                for (int i2 = 0; i2 < 60; i2++)
                {
                    for (int i3 = 0; i3 < 60; i3++)
                    {
                        if (sum == 0)
                        {
                            oldi1 = i1;
                            oldi2 = i2;
                            oldi3 = i3;
                        }
                        sum += energySum(i1, i2, i3);
                        if (sum == N)
                        {
                            antal++;
                            sum = 0;
                            i1 = oldi1;
                            i2 = oldi2;
                            i3 = oldi3;
                        }
                        else if (sum>N)
                        {
                            sum = 0;
                            i1 = oldi1;
                            i2 = oldi2;
                            i3 = oldi3;
                        }
                    }
                }
            }

            

            Console.WriteLine("Antal möjligheter : " + antal);

           
            
            int energySum(int T1, int T2, int T3)
            {
                int[] energyNumber = new int[] { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };

                char[] T1S;
                char[] T2S;
                char[] T3S;

                if (T1 < 10)
                {
                    T1S = ("0" + T1.ToString()).ToCharArray();
                }
                else
                {
                    T1S = T1.ToString().ToCharArray();
                }

                if (T2 < 10)
                {
                    T2S = ("0" + T2.ToString()).ToCharArray();
                }
                else
                {
                    T2S = T2.ToString().ToCharArray();
                }

                if (T3 < 10)
                {
                    T3S = ("0" + T3.ToString()).ToCharArray();
                }
                else
                {
                    T3S = T3.ToString().ToCharArray();
                }

                int S1 = Convert.ToInt32(T1S[0].ToString());
                int S2 = Convert.ToInt32(T1S[1].ToString());
                int S3 = Convert.ToInt32(T2S[0].ToString());
                int S4 = Convert.ToInt32(T2S[1].ToString());
                int S5 = Convert.ToInt32(T3S[0].ToString());
                int S6 = Convert.ToInt32(T3S[1].ToString());

                //Console.WriteLine(S1 + ", " + S2 + ", " + S3 + ", " + S4 + ", " + S5 + ", " + S6);

                int sum = energyNumber[S1] + energyNumber[S2] + energyNumber[S3] + energyNumber[S4] + energyNumber[S5] + energyNumber[S6];
                return sum;
            }
        }
    }
}
