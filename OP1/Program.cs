using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OP1
{
    class Program
    {
        static void Main()
        {
            int choice1;
            Console.WriteLine("Метод взяття даних :  ");
            Console.WriteLine("1 - json файл ");
            Console.WriteLine("2 - через консоль");
            choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Polynome t = Polynomejson.Deserialize("C:/Users/Sasha/OneDrive/Desktop/Лабы/ОП/OP1/OP1/OP1/1.json");
                    Polynome o = Polynomejson.Deserialize("C:/Users/Sasha/OneDrive/Desktop/Лабы/ОП/OP1/OP1/OP1/2.json");
                    int choice;
                    Console.WriteLine();
                    Console.WriteLine("Данi успiшно взятi з json файлу");
                    Console.WriteLine();
                    Console.WriteLine("Зробiть вибiр");
                    Console.WriteLine(" 1 - Додати");
                    Console.WriteLine(" 2 - Вiдняти");
                    Console.WriteLine(" 3 - Помножити");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Polynome a = Polynome.AddPolynomes(t, o);
                        a.Display();
                        Console.WriteLine("Розрахувати? :");
                        Console.WriteLine("1-Так");
                        Console.WriteLine("2-Нi");

                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)

                        {
                            Console.WriteLine("Результат : ");
                            a.Obsh();
                            Console.WriteLine();
                            Console.WriteLine("Зберегти? 1 - Так, 0 - Нi");
                            string choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Polynomejson.Serialize(a);
                            }
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Кiнець ");
                        }
                    }
                    else if (choice == 2)
                    {
                        Polynome b = Polynome.SubstractPolynomes(t, o);
                        b.Display();
                        Console.WriteLine("Розрахувати? :");
                        Console.WriteLine("1-Так");
                        Console.WriteLine("2-Нi");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Результат : ");
                            b.Obsh();
                            Console.WriteLine();
                            Console.WriteLine("Зберегти? 1 - Так, 0 - Нi");
                            string choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Polynomejson.Serialize(b);
                            }
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Кiнець ");
                        }
                    }
                    else if (choice == 3)
                    {
                        Polynome c = Polynome.MyltiplyPolynomes(t, o);
                        c.Display();
                        Console.WriteLine("Розрахувати? :");
                        Console.WriteLine("1-Так");
                        Console.WriteLine("2-Нi");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Результат : ");
                            c.Obsh();
                            Console.WriteLine();
                            Console.WriteLine("Зберегти? 1 - Так, 0 - Нi");
                            string choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Polynomejson.Serialize(c);
                            }
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Кiнець ");
                        }
                    }

                    else if (choice != 1 && choice != 2 && choice != 3)
                    {
                        Console.WriteLine("Невiрнi данi");
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Polynome p = new ();
                    p.Display();
                    int ch;
                    Console.WriteLine("Розрахувати? :");
                    Console.WriteLine("1-Так");
                    Console.WriteLine("2-Нi");
                    Console.WriteLine("3 - Закрити програму ");
                    Console.WriteLine("Вибір : ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.WriteLine("Результат поліному 1: ");
                        p.Obsh();
                        Console.WriteLine();
                    }
                    else if (ch != 2)
                    {
                        break;

                    }
                    Console.WriteLine();
                    Polynome r = new ();
                    r.Display();
                    Console.WriteLine("Розрахувати? :");
                    Console.WriteLine("1-Так");
                    Console.WriteLine("2-Нi");
                    Console.WriteLine("3 - Закрити програму ");
                    Console.WriteLine("Вибір : ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.WriteLine("Результат поліному 2: ");
                        r.Obsh();
                        Console.WriteLine();

                    }
                    else if (ch != 2)
                    {
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Зробiть вибiр");
                    Console.WriteLine(" 1 - Додати");
                    Console.WriteLine(" 2 - Вiдняти");
                    Console.WriteLine(" 3 - Помножити");
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Polynome q = Polynome.AddPolynomes(p, r);
                        q.Display();
                        Console.WriteLine("Розрахувати? :");
                        Console.WriteLine("1-Так");
                        Console.WriteLine("2-Нi");

                        ch = Convert.ToInt32(Console.ReadLine());
                        if (ch == 1)

                        {
                            Console.WriteLine("Результат : ");
                            q.Obsh();
                            Console.WriteLine();
                            Console.WriteLine("Зберегти? 1 - Так, 0 - Нi");
                            string choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Polynomejson.Serialize(q);
                            }
                        }
                        else if (ch == 2)
                        {
                            Console.WriteLine("Кiнець ");
                        }
                    }
                    else if (ch == 2)
                    {
                        Polynome w = Polynome.SubstractPolynomes(p, r);
                        w.Display();
                        Console.WriteLine("Розрахувати? :");
                        Console.WriteLine("1-Так");
                        Console.WriteLine("2-Нi");

                        ch = Convert.ToInt32(Console.ReadLine());
                        if (ch == 1)
                        {
                            Console.WriteLine("Результат : ");
                            w.Obsh();
                            Console.WriteLine();
                            Console.WriteLine("Зберегти? 1 - Так, 0 - Нi");
                            string choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Polynomejson.Serialize(w);
                            }


                        }
                        else if (ch == 2)
                        {
                            Console.WriteLine("Кiнець ");

                        }

                    }
                    else if (ch == 3)
                    {
                        Polynome y = Polynome.MyltiplyPolynomes(p, r);
                        y.Display();
                        Console.WriteLine("Розрахувати? :");
                        Console.WriteLine("1-Так");
                        Console.WriteLine("2-Нi");
                        ch = Convert.ToInt32(Console.ReadLine());
                        if (ch == 1)
                        {
                            Console.WriteLine("Результат : ");
                            y.Obsh();
                            Console.WriteLine();
                            Console.WriteLine("Зберегти? 1 - Так, 0 - Нi");
                            string choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Polynomejson.Serialize(y);
                            }

                        }
                        else if (ch == 2)
                        {
                            Console.WriteLine("Кiнець ");

                        }
                    }

                    else if (ch != 1 && ch != 2 && ch != 3 && ch != 4)
                    {
                        break;
                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}
