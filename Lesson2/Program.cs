using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите номер задания(от 1 до 9): ");
            int number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1: 
                    Console.WriteLine("Введите число: ");
                    int number1_1 = int.Parse(Console.ReadLine());
                    if (number1_1 > 0)
                    {
                        Console.WriteLine(number1_1 + 5);
                    }
                    else
                    {
                        Console.WriteLine(number1_1 - 5);
                    }
                    break;

                case 2:
                    Console.WriteLine("Введите первое число:");
                    int num2_1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    int num2_2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите третье число:");
                    int num2_3 = int.Parse(Console.ReadLine());

                    int max = num2_1;

                    if (num2_2 > max)
                    {
                        max = num2_2;
                    }

                    if (num2_3 > max)
                    {
                        max = num2_3;
                    }

                    Console.WriteLine("Наибольшее число: " + max);

                    break;

                case 3:
                    Console.WriteLine("Введите первое число:");
                    int num3_1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    int num3_2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите третье число:");
                    int num3_3 = int.Parse(Console.ReadLine());
                    int sum = 0;
                    if(num3_1 > 0)
                    {
                        Console.WriteLine(sum += num3_1);
                    }
                    if ( num3_2 > 0)
                    {
                        Console.WriteLine(sum += num3_2);
                    }
                    if (num3_3 > 0)
                    {
                        Console.WriteLine( sum += num3_3);
                    }
                   
                    else
                    {
                        Console.WriteLine("Все числа отрицательные");
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите x:");
                    int x = int.Parse(Console.ReadLine());
                    if (x > 10)
                    {
                        Console.WriteLine($"Удвоенное значение: {x * 2}");
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите день недели");
                    int day = int.Parse(Console.ReadLine());
                        switch (day)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Суббота");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;

                    }

                    break;
                case 6:
                    int num6_1 = 200;
                  while (num6_1 % 17 !=0)
                    {
                        num6_1++;
                    }
                    Console.WriteLine(num6_1);
                    break;
                case 7:
                    double distance = 10;
                    int count = 0;
                    double current_distance = 10;
                    while (distance  < 21) 
                    {
                        distance += (distance / 100 * 5);
                      
                        count++;
                    }
                    while(current_distance >= 100)
                    {
                        current_distance += distance;
                    }
                    Console.WriteLine($"Человек пробежит 20 км в {count} день");
                    Console.WriteLine($"Сумма пробега будет больше 100км в {current_distance} день");
                        break;
                case 8:
                    Console.WriteLine("Введите число для нахождения факториала: ");
                    int num8_1 = int.Parse(Console.ReadLine());
                    int factorial = 1;
                    for(int i = 1; i <=num8_1; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Факториал числа {num8_1} равен {factorial}");
                    break;
                case 9:
                    Console.Write("Введите натуральное число: ");
                    int num = int.Parse(Console.ReadLine());

                    int delitel = 2;
                    while (num % delitel != 0)
                    {
                        delitel++;
                    }

                    Console.WriteLine($"Наименьший делитель числа {num} (отличный от 1) равен {delitel}");

                    break;
            }
            Console.ReadKey();
        }
    }
}
