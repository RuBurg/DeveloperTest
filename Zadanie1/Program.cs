using System;// В исходном коде отсутсвовала директива  using System.
using System.Linq;// В исходном коде отсутсвовала директива  using System.Linq
/*
1. В иходном коде не было метода Main и класса Program. 
2. В исходном коде не было директив System и System.Linq
3. Проект был представлен как набор файлов
4. Классы можно было бы разбить по разным файлам для лучшей структуризации
5. Был реализован функционал для выбора задания и выхода из программы.
6. Ошибка в ZadanieTwo. Была возможность ввести число = 3, по заданию число должно быть больше 3. 
7. Был добавлен отлов исключений в ZdanieOne и ZadanieTwo 
*/
namespace Library
{
    class Program //Также классы можно было бы разбить по разным файлам для лучшей структуризации.
    {
        static void Main(string[] args) //Добавлен метод Main и класс Program
        {
            Console.WriteLine("Нажмите Esc для завершения программы");
            while (true)
            {
                Console.Write("Введите номер задания: ");//Был реализован функционал пользователя.
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    int k = 0;
                    try
                    {
                        k = int.Parse(Console.ReadLine());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                    if (k == 1)
                    {
                        ZadanieOne zadanieOne = new ZadanieOne(); zadanieOne.One();
                    }
                    if (k == 2)
                    {
                        ZadanieTwo.Two();
                    }
                }
            }

        }

    }

    public class ZadanieOne
    {
        static int n = 0;
        public void One()
        {
            //Был добавлен отлов исключений
            //Была добалена проверка на значение > 0 

            Console.Write("Введите число N: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            if (n < 0 || n == 0)
            {
                Console.WriteLine("Вы ввели неверное значение, число n должно быть больше 0 ");
            }
            else
            {
                string result = string.Join(", ", Enumerable.Range(1, n));
                Console.WriteLine(result);
            }
        }
    }

    public class ZadanieTwo
    {
        static int n = 0;
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            try //Добавлен отлов исключений
                //Была добавлена проверка на значение > 3
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            if (n > 3)
            {
                if ((n & 1) == 0) // Был добавлен пообитовый сдвиг вместо %2, т.к. побитовый сдвиг является более оптимизированным
                {
                    Console.WriteLine("Вы ввели четное N.");
                    return;
                }
                else
                {
                    for (int row = 1; row <= n; row++)
                    {
                        for (int col = 1; col <= n; col++)
                        {
                            if (row == n / 2 + 1 && col == n / 2 + 1) Console.Write(" ");
                            else Console.Write("#");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение. Число N должно быть больше 3.");
            }

        }
    }
}