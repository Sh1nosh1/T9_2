using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9_2
{
    internal class Program
    {
        //Task 2
        static void Output(List<string> books)
        {
            foreach(var elem in books)
            {
                Write($"{elem};\t");
            }
            WriteLine();
        }

        
        
        static void Main(string[] args)
        {
            try
            {
                //Task 1
                var books = new List<string>() { "Мертвые души", "Горе от ума", "Евгений Онегин","Герой нашего времени","Недоросль","Жизнь на продажу" };

                //Task 2
                Output(books);

                //Task 3,4
                foreach(var elem in books)
                {
                    Write($"{elem.ToUpper()}\t");
                }

                //Task 5
                WriteLine($"\n{books.Count}");

                //Task 6
                books.Add("Книжечка");

                //Task 7
                Output(books);

                //Task 8
                books.Insert(0,"FFFFFF");

                //Tassk9
                Output(books);

                //Task 10
                books.RemoveAt(3);

                //Task 11
                Output(books);

                //Task 12
                books.Reverse();
                Output(books);

                



            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
