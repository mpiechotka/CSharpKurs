using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAvarage();
            //float min = diary.GiveMinRating();
            //float max = diary.GiveMaxRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");
                float rating;
                bool result = float.TryParse( Console.ReadLine(), out rating);
                if (rating == 11)
                {
                    break;
                }
                if (result) // --> (result == true)
                {
                    if (rating >0 && rating <=10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine(" Niepoprawna liczba. Podaj liczbę z zakresu 1 - 10");
                    }
                }
            }

            Console.WriteLine("Średnia ocen: " + diary.CalculateAvarage());
            Console.WriteLine("Najniższa ocena: " + diary.GiveMinRating());
            Console.WriteLine("Najwyższa ocena: " + diary.GiveMaxRating());

            Console.ReadKey();

            Diary diary1 = new Diary();
            Diary diary2 = new Diary();
        }
    }
}
