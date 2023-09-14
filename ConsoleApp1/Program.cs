using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task27);
        }

        static bool Task27(int n)
        {
            return n % 2 == 0;
        }
        static void Task19(int a, int b) 
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a: " + a + " b: " + b);
        }
        static void Task17()
        {
            int a = 456;
            int b = a % 10;
            Console.WriteLine(b);
        }

        static void Task16()
        {
            int fourthy = Convert.ToInt32(Console.ReadLine());
            int first = fourthy / 1000;
            int second = fourthy / 100;
            int third = fourthy / 10;
            int fourth = fourthy % 10;
            int sum = first + second + third + fourth;
            int product = first * second * third * fourth; 
            Console.WriteLine("Summ: " + sum + " Product: " + product);
        }
        static void Task15()
        {
            int twice = Convert.ToInt32(Console.ReadLine());
            int a = twice / 10;
            int b = twice % 10;
            int c = a + b;
            int d = a * b;
            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
        static void Task14() 
        {
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("weeks: " + days / 7);
        }
        static void Task13()
        {
            double cm = Convert.ToInt32(Console.ReadLine());
            double m = cm * 0.01;
            Console.WriteLine(m);
        }
        static void Task12()
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            double l = 2 * 3.14 * radius;
            double S = 3.14 * (radius * radius);
            Console.WriteLine("l: " + l + " S:" + S);
        }
        static void Task11()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 7 * (x * x * x) - 3 * x + 4;
            Console.WriteLine(y);
        }
        static void Task10()
        {
            for (int i = 20; i < 36; i++) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i < b; i++) 
            {
                Console.Write((i*i) + " ");
            }

            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < 50; i++)
            {
                Console.Write((i * i * i) + " ");
            }

            int a2, b2;
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.Write((i) + " ");
            }

        }
        static void Task9()
        {
            double rezist1 = Convert.ToInt32(Console.ReadLine());
            double rezist2 = Convert.ToInt32(Console.ReadLine());
            double volt1 = Convert.ToInt32(Console.ReadLine());
            double volt2 = Convert.ToInt32(Console.ReadLine());
            double I1 = volt1 / rezist1;
            double I2 = volt2 / rezist2;
            if (I1 < I2)
            {
                Console.WriteLine("I1 less: " + I1);
            }
            else if (I2 < I1)
            {
                Console.WriteLine("I2 less: " + I2);
            }
            else
            {
                Console.WriteLine("power is equal");
            }
        }
        static void Task8()
        {
            double v1 = Convert.ToInt32(Console.ReadLine());
            double v2 = Convert.ToInt32(Console.ReadLine());
            double m1 = Convert.ToInt32(Console.ReadLine());
            double m2 = Convert.ToInt32(Console.ReadLine());
            double p1 = m1 * v1;
            double p2 = m2 * v2;

            if (p1 > p2)
            {
                Console.WriteLine("Material 1 better: " + p1);
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Material 2 better: " + p2);
            }
            else
            {
                Console.WriteLine("materials density is equal");
            }
        }

        static void Task7()
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            int storona = Convert.ToInt32(Console.ReadLine());
            double pr2 = 3.14 * (radius * radius);
            double storona2 = storona * storona;
            if(pr2 > storona2)
            {
                Console.WriteLine("Circle: " + pr2);
            } else if(pr2 < storona2)
            {
                Console.WriteLine("Square: " + storona2);
            } else
            {
                Console.WriteLine("equal");
            }
            
        }
     
        static void Task6()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            bool a = A || B;
            bool b = A && B;
            bool c = B || C;
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void Task5()
        {
            int twice = Convert.ToInt32(Console.ReadLine());
            int a = twice / 10;
            int b = twice % 10;
            int c = a + b;
            int d = a * b;
            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
        static void Task4()
        {
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("weeks: " + days / 7);
        }
        static void Task3()
        {
            int cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m: " + cm / 100);
        }
        static void Task2and1()
        {
            Console.WriteLine(" 1 2 3 ");
            Console.Write("5");
            Console.Write("10");
            Console.Write("15");

        }
        static void Example6()
        {
            User[] users = new User[2];
            users[0] = new User();

            foreach (var item in users)
            {
                Console.WriteLine(item.Age);
            }

            for (int i = 0; i < 10; i++)
            {
                
            }
            int k = 0;

            while(k < 5)
            {
                k++;
            }
        }
        static void Example5()
        {
            int a = Convert.ToInt32("Hello");
            int b = 555;
            a = Int32.Parse("5");

            Int32.TryParse("55", out b);

        }
        static void Example4() //присваивание в виде матрешки от большого к меньшему
        {
            int a = 1;
            short b = 2;
            long c = 3;

            a = b;
            c = a;

            b = (short)c; //явное преобразованмие типов
        }
        static void Example3()
        {
            DateTime date = new DateTime(2023, 01, 01);
            var dt = DateTime.Now;
            Console.WriteLine("{0:dd:MM} - {1}", dt, "hola");
            Console.WriteLine("Today {0}", dt.DayOfWeek);
            dt = dt.AddDays(40);
            TimeSpan ts = new TimeSpan(4, 30, 0);
        }
        static void Exampel2()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.ReadLine();

        }
        static void Example()
        {
            string name = "", surname = "";
            Console.Write("Write your name?");
            name = Console.ReadLine();
            Console.Write("Write your surname");
            surname = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Your name & surname " + name + surname);

            Console.ReadLine();
        }
    }
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}