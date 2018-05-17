using System;


namespace Hello
{
    class Program1
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("minLong = " + minLong);
            Console.WriteLine("maxLong = " + maxLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisuje wiek użytkownika
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj swój wiek: ");
            //int age = int.Parse(Console.ReadLine());
            int age;
            bool wynik = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, jesteś pełnoletni możesz napić się browara!");
            }
            else if (wynik == false)
            {
                Console.WriteLine("Wprowadziłeś błędny wiek");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mogę Ci zaoferować sok");
            }
        }
        
        /// <summary>
        /// Wypisuje powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
