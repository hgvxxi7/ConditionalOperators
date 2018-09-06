using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_types = "";
            
            do
            {
                Console.Write("\n       Пожалуйста выберите задачу. (введите номер задачи, которая вас заинтересовала, затем нажмите Enter)\n\n");
                Console.Write("       Это список задач:\n\n");
                Console.Write("    1. Задача на проверку четности множимого;\n");
                Console.Write("    2. Задача на проверку какой четверти принадлежит точка (x,y);\n");
                Console.Write("    3. Задача найти сумму только положительных из трех чисел;\n");
                Console.Write("    4. Просчитать выражение max(a*b*c; a+b+c)+3;\n");
                Console.Write("    5. Программа определения оценки студента относительно его рейтинга;\n");
                Console.Write("\n       Для выхода введите слово - exit\n\n");
                Console.Write("       ");
                user_types = Console.ReadLine();

                if (user_types == "1")

                    {
                        Console.Write("\n    Правильный выбор\n");
                        Console.Write("    Вы выбрали задание на проверку четности множимого\n\n");
                        Console.Write("    Теперь вводите чему равно целое множимое А = ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n");
                        Console.Write("    Теперь вводите чему равен множитель (вводите тоже целое число) B = ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n");

                    if (a%2==0)
                            {
                                Console.Write("    Да! Вы ввели четное множимое А = " + a +"\n");
                                Console.Write("    В этом случае мы можем решить арифметическое выражение (A * B =) где " + a + " * " + b + " = " +a*b+ "\n\n");
                                Console.Write("    Что-бы продолжить нажмите на любую кнопку\n");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("    Так! Вы ввели нечетное множимое А = " + a + "\n");
                                Console.Write("    И в этом случае мы можем решить арифметическое выражение (A + B =) где " + a + " + " + b + " = " + (a + b) + "\n\n");
                                Console.Write("    Что-бы продолжить нажмите на любую кнопку\n");
                                Console.ReadKey();
                            }
                    }
                else if (user_types == "2")

                    {
                    Console.Write("\n    Тю.., но Вы ведь не похожи ни на одного из родственников Декарта, ну да ладно, два так два.\n\n");
                    Console.Write("    Тогда вводите чему равна координата X = ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("    Теперь вводите чему равна координата Y = ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                    Console.Write("    Что-бы продолжить и определить какой черверти принадлежит точка с координатами (Х,Y) -> ("+x+","+y+") нажмите на любую кнопку\n");
                    Console.ReadKey();

                    if (x < 0 & y < 0){ Console.Write("     3-четверть\n"); Console.ReadKey();}
                    else if (x < 0 & y > 0) { Console.Write("     2-четверть\n"); Console.ReadKey(); }
                    else if (x > 0 & y > 0) { Console.Write("     1-четверть\n"); Console.ReadKey(); }
                    else if (x > 0 & y < 0) { Console.Write("     4-четверть\n"); Console.ReadKey(); }
                    else if (x == 0 & y < 0 || y > 0) { Console.Write("     точка расположена на оси Y\n"); Console.ReadKey(); }
                    else if (y == 0 & x < 0 || x > 0) { Console.Write("     точка расположена на оси X\n"); Console.ReadKey(); }
                }

                else if (user_types == "3")

                {
                    Console.Write("\n    Задача найти сумму только положительных из трех чисел\n\n");
                    Console.Write("    Введите первое число А = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n    Введите второе число B = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n    Введите третье число C = ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.ReadKey();

                    if (a>0 || a==0 & b>0 || b == 0 & c>0 || c == 0) { Console.Write("\n    Сумма положительных чисел = "+(a + b + c)+"\n"); Console.ReadKey();}
                    else if (a < 0 & b > 0 || b == 0 & c > 0 || c == 0) { Console.Write("\n    Сумма положительных чисел = "+(b + c)+"\n"); Console.ReadKey(); }
                    else if (a > 0 || a == 0 & b < 0 & c > 0 || c == 0) { Console.Write("\n    Сумма положительных чисел = "+(a + c)+"\n"); Console.ReadKey(); }
                    else if (a > 0 || a == 0 & b > 0 || b == 0 & c < 0) { Console.Write("\n    Сумма положительных чисел = "+(a + b)+"\n"); Console.ReadKey(); }
                }

                else if (user_types == "4")

                {
                    Console.Write("\n    Просчитать максимум из множества -> выражение: max(a*b*c; a+b+c)+3\n\n");
                    Console.Write("    Введите первое число a = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n    Введите второе число b = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n    Введите третье число c = ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.ReadKey();
                    if (a*b*c > a+b+c) {Console.Write("\n    max() = ("+a+ "*" +b+ "*" +c+ ") + 3 = "+((a*b*c)+3)+"\n"); Console.ReadKey(); }
                    else {Console.Write("\n    max() = ("+a+"+"+b+"+"+c+") + 3 = "+((a + b + c) + 3)+"\n"); Console.ReadKey(); }
                }

                else if (user_types == "5")

                {
                    Console.Write("\n    Программа определения оценки студента относительно его рейтинга:\n\n");
                    Console.Write("    Рейтинг 0-19   -> Оценка F\n");
                    Console.Write("    Рейтинг 20-39  -> Оценка E\n");
                    Console.Write("    Рейтинг 40-59  -> Оценка D\n");
                    Console.Write("    Рейтинг 60-74  -> Оценка C\n");
                    Console.Write("    Рейтинг 75-89  -> Оценка B\n");
                    Console.Write("    Рейтинг 90-100 -> Оценка A\n\n");
                    int rating;
                    Console.Write("\n    ");

                    do {
                        Console.Write("    Введите целое число от 0 до 100\n");
                        Console.Write("    ->");
                        rating = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n    ");
                    }
                    while (rating <= -1 || rating > 100);
                    if (rating == 0 || rating <= 19) { Console.Write("    Введеный Вами рейтинг = "+rating+" -> Оценка = F\n"); Console.ReadKey(); }
                    else if (rating == 20 || rating <= 39) { Console.Write("    Введеный Вами рейтинг = " + rating + " -> Оценка = F\n"); Console.ReadKey(); }
                    else if (rating == 40 || rating <= 59) { Console.Write("    Введеный Вами рейтинг = " + rating + " -> Оценка = E\n"); Console.ReadKey(); }
                    else if (rating == 60 || rating <= 74) { Console.Write("    Введеный Вами рейтинг = " + rating + " -> Оценка = D\n"); Console.ReadKey(); }
                    else if (rating == 75 || rating <= 89) { Console.Write("    Введеный Вами рейтинг = " + rating + " -> Оценка = B\n"); Console.ReadKey(); }
                    else if (rating == 90 || rating <= 100) { Console.Write("    Введеный Вами рейтинг = " + rating + " -> Оценка = A\n"); Console.ReadKey(); }
                }
            }
            while (user_types != "exit");

        }
    }
}
