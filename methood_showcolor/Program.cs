﻿
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace methood_showcolor
{
    internal class Program
    {
   
        static string? ShowColor()
        { Console.WriteLine("напишите свой любимый цвет на англ с маленькой буквы");
            var color = Console.ReadLine();


            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        public static void Main(string[] args) 
        {

            (string name, int age) anketa;


            Console.Write("введите имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите возраст цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

                        ShowColor();
            Colors();

        }

        private static void Colors()
        {
            
            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            { favcolors[i] = ShowColor(); }

            Console.WriteLine("ваши любимые цвета: ");
            foreach (var color in favcolors)
            { Console.WriteLine(color); }
            Console.ReadKey();
        }
      
    }
}
