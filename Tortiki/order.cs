using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace tortiki
{
    internal class Order
    {



        public static void SpisokMenu()
        {
            Console.WriteLine("Добро пожаловать в заказ тортиков\n-----------");
            Console.WriteLine("  1.Форма");
            Console.WriteLine("  2.Размер");
            Console.WriteLine("  3.вкус");
            Console.WriteLine("  4.Количество");
            Console.WriteLine("  5.Глазурь");
            Console.WriteLine("  6.Декор");

        }


        public static void FirstMenu()
        {
            Console.Clear();
            Console.WriteLine("Торт от Spirit breaker - пивной) ");
            Console.WriteLine(" -форма(корпус нашего мальчика)");
            Console.WriteLine(" -размер(диаметр колёс)");
            Console.WriteLine(" -вкус коржей(турбированный V16, KAYA AND SANGE");
            Console.WriteLine(" -количество в шт(балтику и гг)");
            Console.WriteLine(" -глазурь ( ну крч турбонадув ЕУЛА)");
            Console.WriteLine(" -декор (тюниниг тачки бара)");
            Console.WriteLine(" -конец заказа (конец забега) ");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine(Tort.Form + Tort.Size + Tort.Vkus + Tort.Count + Tort.Glazur + Tort.Dekor);
            Console.WriteLine("Цена: " + Tort.price);
            SecondMenu();
        }

        private static void SecondMenu()
        {
            int pos = Strelki.strelki(1, 7);

            switch (pos)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("форма");
                    Console.WriteLine("  1.овал (круглые колёса) - 1000\n  2.круг(ну крч вы сами поняли) - 1200\n  3.полусфера - 2000");
                    int position = Strelki.strelki(1, 3);
                    if (position == 1)
                    {
                        Tort.Form = " овальный ";
                        Tort.price += 1000;
                        FirstMenu();
                    }
                    if (position == 2)
                    {
                        Tort.Form = " круглый ";
                        Tort.price += 1200;
                        FirstMenu();
                    }
                    if (position == 3)
                    {
                        Tort.Form = " полусфера ";
                        Tort.price += 2000;
                        FirstMenu();
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("размер");
                    Console.WriteLine("  1.большой - 5000\n  2.средний - 2500\n  3.маленький - 1000");
                    position = Strelki.strelki(1, 3);
                    switch (position)
                    {
                        case 1:
                            Tort.Size = " большой размер ";
                            Tort.price += 5000;
                            FirstMenu();
                            break;
                        case 2:
                            Tort.Size = " средний размер ";
                            Tort.price += 2500;
                            FirstMenu();
                            break;
                        case 3:
                            Tort.Size = " маленький размер ";
                            Tort.price += 1000;
                            FirstMenu();
                            break;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("вкус торта");
                    Console.WriteLine("  1.вкусно - 1000\n  2.э,нормально же есть - 700\n  3.пудж одобряет - 50");
                    position = Strelki.strelki(1, 3);
                    switch (position)
                    {
                        case 1:
                            Tort.Vkus = " вкусно ";
                            Tort.price += 1000;
                            FirstMenu();
                            break;

                        case 2:
                            Tort.Vkus = " э,нормально же есть ";
                            Tort.price += 700;
                            FirstMenu();
                            break;
                        case 3:
                            Tort.Vkus = " пудж одобряет ";
                            Tort.price += 50;
                            FirstMenu();
                            break;
                    }
                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("сколько тортиков");
                    Console.WriteLine("  1.много - 200\n  2.мало - 300\n  3.чуток - 100");
                    position = Strelki.strelki(1, 3);
                    switch (position)
                    {
                        case 1:
                            Tort.Count = "1";
                            Tort.price += 200;
                            FirstMenu();
                            break;
                        case 2:
                            Tort.Count = "2";
                            Tort.price += 300;
                            FirstMenu();
                            break;
                        case 3:
                            Tort.Count = "3";
                            Tort.price += 100;
                            FirstMenu();
                            break;
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("глазурь");
                    Console.WriteLine("  1.шоколад молочная - 300\n  2.шоколад белая - 400\n  3.темная шоколадка - 100");
                    position = Strelki.strelki(1, 3);
                    switch (position)
                    {
                        case 1:
                            Tort.Glazur = " шоколад молочная ";
                            Tort.price += 300;
                            FirstMenu();
                            break;
                        case 2:
                            Tort.Glazur = " шоколад белая ";
                            Tort.price += 400;
                            FirstMenu();
                            break;
                        case 3:
                            Tort.Glazur = " темная шоколадка";
                            Tort.price += 100;
                            FirstMenu();
                            break;
                    }
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("декор");
                    Console.WriteLine("  1.не шарю в тортах - 2500\n  2.придумать не могу - 0\n  3.АНДРЕЙ САНСТРАЙК - 200");
                    position = Strelki.strelki(1, 3);
                    switch (position)
                    {
                        case 1:
                            Tort.Dekor = " не шарю в тортах ";
                            Tort.price += 2500;
                            FirstMenu();
                            break;
                        case 2:
                            Tort.Dekor = " придумать не могу ";
                            Tort.price += 10;
                            FirstMenu();
                            break;
                        case 3:
                            Tort.Dekor = " Андрей санстрайк ";
                            Tort.price += 200;
                            FirstMenu();
                            break;
                    }
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Составить счет");
                    Console.WriteLine("цена: " + Tort.price);
                    Console.WriteLine("вот какой получился торт:" + Tort.Form + Tort.Size + Tort.Vkus + Tort.Count + Tort.Glazur + Tort.Dekor);
                    save();
                    Console.WriteLine("\n\nЕсли вы хотите сделать еще один заказ, нажмите Enter, если хотите выйти из программы, нажмите Escape");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Tort.Form = " ";
                        Tort.Size = " ";
                        Tort.Vkus = " ";
                        Tort.Count = " ";
                        Tort.Glazur = " ";
                        Tort.Dekor = " ";
                        Tort.price = 0;
                        FirstMenu();
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    break;

            }
        }
        static void save()
        {
            DateTime date = DateTime.Now;
            File.WriteAllText("ЗаказнойТортик.txt", "\nзаказ от " + date + "\nДетали заказа: " + Tort.Form + Tort.Size + Tort.Vkus + Tort.Count + Tort.Glazur + Tort.Dekor + "\nЦена заказа: " + Tort.price);
        }
    }
}