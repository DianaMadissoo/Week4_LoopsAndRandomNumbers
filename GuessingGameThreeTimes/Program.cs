using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit, 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis  umbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme korraga numbrit ära arvata siis arvuti on võitnud;
            //programm genereerib juhuslikku numbrit vaid ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Number on õige, teie võitsite!");
                    break;
                }
                else
                {

                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on veel.");
                }
            }
        }
    }
}
