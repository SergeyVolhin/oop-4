using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_4
{
    class Health
    {
        public int temperature;
        public int Temp
        {
            get
            {
                return temperature;
            }

            set
            {
                if ((value >= 34) && (value <= 41))
                {
                    temperature = value;
                }

                else
                {
                    temperature = 34;
                    Console.WriteLine("Значение находится вне диапозона, поэтому присвоено минимальное значение");
                }
            }
        }
    }
    class Book
    {
        private int releaseYear;
        public int ReleaseYear
        {
            get
            {
                return releaseYear;
            }

            set
            {
                if ((value >= 1940) && (value <= 2020))
                {
                    releaseYear = value;
                }

                else
                {
                    releaseYear = 1940;
                    Console.WriteLine("Значение находится вне диапозона, поэтому присвоено минимальное значение");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Health health = new Health();

        health:
            Console.WriteLine("Введите температуру тела от 34 до 41");

            try
            {
                health.Temp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Температура тела - " + health.Temp);
            }
            catch
            {
                Console.WriteLine("Неккорректный тип данных");
                goto health;
            }

            Console.WriteLine("");


            Book book = new Book();

        book:
            Console.WriteLine("Введите год выпуска от 1940 до 2020");

            try
            {

                book.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Год выпуска - " + book.ReleaseYear);

            }
            catch
            {
                Console.WriteLine("Неккорректный тип данных");

            }
            goto book;

            Console.ReadKey();
        }
    }
}
