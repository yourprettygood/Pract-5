using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int x = int.Parse(Console.ReadLine());
            switch(x)
            {
                case 1:
                    Console.Write("Введите количество месяцев, прошедших с неизвестной даты: ");
                    int m = int.Parse(Console.ReadLine());

                    DateTime currentDate = DateTime.Now;

                    DateTime unknownDate = currentDate.AddMonths(-m);

                    string monthName = unknownDate.ToString("MMMM");

                    Console.WriteLine($"Название месяца: {monthName}");
                    break;

                    case 2:
                    Console.Write("введитее 1 число: ");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.Write("введитее 2 число: ");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.Write("введитее 3 число: ");
                    int x3 = int.Parse(Console.ReadLine());

                    Console.Write("Введите начало отрезка (e): ");
                    int e = int.Parse(Console.ReadLine());

                    Console.Write("Введите начало отрезка (f): ");
                    int f = int.Parse(Console.ReadLine());

                    if (x1 >= e && x1 <= f)
                    {
                        Console.WriteLine(x1);
                    }
                    if (x2 >= e && x2 <= f)
                    {
                        Console.WriteLine(x2);
                    }
                    if (x3 >= e && x3 <= f)
                    {
                        Console.WriteLine(x3);
                    }
                    break;
            }
            
        

            Console.ReadLine();
        }
    }
}
