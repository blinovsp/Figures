using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        abstract class Figura
        {
            private string name;   
            public Figura(string name)
            {
                this.name = name; 
            }
            public string Name    
            {
                get { return name; }
                set { name = value; }
            }
            public abstract double GetSquare(); 
            public abstract double GetPerimeter();
            public abstract double GetVolume();
            public virtual void Print()
            {
                Console.WriteLine("name = {0}", name);
            }
        }

        class Piramid : Figura
        {
            private double a, h;
            public Piramid(string name, double a, double h) : base(name)
            {
                this.a = a;
                this.h = h;
            }
            public override double GetSquare()
            {
                double s = a * (a + (2 * h));
                Console.WriteLine("Square = ", s);
                return s;
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine("a = ", a);
                Console.WriteLine("h = ", h);
            }
            public override double GetPerimeter()
            {
                double c = Math.Sqrt((a / 2) * (a / 2) + (a / 2) * (a / 2));
                double triangel_p = Math.Sqrt(c * c + h * h);
                double p = (triangel_p * 4) + a * 4;
                Console.WriteLine("Perimeter = ", p);
                return p;
            }

            public override double GetVolume()
            {
                double v = (1 / 3) * a * a * h;
                Console.WriteLine("Volume = ", v);
                return v;
            }
        }

        class Cube : Figura
        {
            private double a;
            public Cube(string name, double a) : base(name)
            {
                this.a = a; 
            }
            public override double GetSquare()
            {
                double s;
                s = 6 * (a * a);
                Console.WriteLine("Square = ", s);
                return s;
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine("a = ", a);
            }
            public override double GetPerimeter()
            {
                double p = a * 12;
                Console.WriteLine("Perimeter = ", p);
                return p;
            }

            public override double GetVolume()
            {
                double v = a * a * a;
                Console.WriteLine("Volume = ", v);
                return v;
            }
        }
        static void Main(string[] args)
        {

            Figura newFigure;

            Console.WriteLine("Выберите Фигуру: 0 - Правильная Пирамида    1 - Куб");

            string user_choose = Console.ReadLine();
            switch (user_choose)
            {
                case "0":
                    string name = null;
                    while (name == null)
                    {
                        Console.WriteLine("Введите Имя Пирамиды:");
                        name = Console.ReadLine();
                    }
                    int side = 0;
                    while (side <= 0)
                    {
                        Console.WriteLine("Введите Сторону пирамиды (>0):");
                        side = Console.Read();
                    }
                    int height = 0;

                    int bb = Console.Read();


                    while (height <= 0)
                    {
                        Console.WriteLine("Введите Высоту пирамиды (>0):");
                        height = Console.Read();
                    }
                    Piramid pi = new Piramid(name, side, height);
                    Console.WriteLine("Выберите Искомое значение: 0 - Площадь    1 - Периметр   2 - Объём   3 - Свойства");
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "0":
                            newFigure = pi;
                            newFigure.GetSquare();
                            break;
                        case "1":
                            newFigure = pi;
                            newFigure.GetPerimeter();
                            break;
                        case "2":
                            newFigure = pi;
                            newFigure.GetVolume();
                            break;
                        case "3":
                            newFigure = pi;
                            newFigure.Print();
                            break;
                        default:
                            Console.WriteLine("Неверное значение!");
                            break;
                    }

                    Console.ReadKey(true);
                    break;

                case "1":
                    string name_sq = null;
                    while (name_sq == null)
                    {
                        Console.WriteLine("Введите Имя Куба:");
                        name_sq = Console.ReadLine();
                    }
                    int side_sq = 0;
                    while (side_sq <= 0)
                    {
                        Console.WriteLine("Введите Сторону Куба (>0):");
                        side_sq = Convert.ToInt32(Console.ReadLine());
                    }
                    Cube cu = new Cube(name_sq, side_sq);
                    Console.WriteLine("Выберите Искомое значение: 0 - Площадь    1 - Периметр   2 - Объём   3 - Свойства");
                    string action_sq;
                    action_sq = Console.ReadLine();
                    switch (action_sq)
                    {
                        case "0":
                            newFigure = cu;
                            newFigure.GetSquare();
                            break;
                        case "1":
                            newFigure = cu;
                            newFigure.GetPerimeter();
                            break;
                        case "2":
                            newFigure = cu;
                            newFigure.GetVolume();
                            break;
                        case "3":
                            newFigure = cu;
                            newFigure.Print();
                            break;
                        default:
                            Console.WriteLine("Неверное значение!");
                            break;
                    }

                    Console.ReadKey(true);
                    break;

                default:
                    Console.WriteLine("Неверное значение!");
                    break;
            }
        }
    }
}
