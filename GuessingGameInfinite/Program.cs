using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit, 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis  umbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit vaid ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Number on õige, teie võitsite!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Number on vale, proovige uuesti.");
                }
            }
        }
    }
}
