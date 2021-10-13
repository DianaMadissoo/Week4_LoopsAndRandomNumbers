using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhuslikku numbrit 1 kuni 10;
            //kui genereeritud number on viis, programm lõpetab töö ja soovib kasutajale "kena päeva";
            //Kui genereeritud number on midagi muud siis programm töötab edasi;

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
