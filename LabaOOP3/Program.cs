using System;
using System.IO;

namespace LabaOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 1989;
            int A = Convert.ToInt32(Math.Pow(3.5, -4));
            bool L = true;
            string N = "Petrovich";
            float C = (float)-380.08;
            System.Console.WriteLine("I = " + I + "\n" + "A = " + A + "\n" + "L = " + L + "\n" + "N = " + N + "\n" + "C = " + C);
            System.Console.ReadKey();

            string s;
            double x, y;
            StreamWriter f = new StreamWriter("LAB2.RES");
            StreamReader f1 = new StreamReader("LAB2.TXT");
            f.WriteLine("           Таблица значений:\n");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = (Math.Pow(x, 2) - 5 * x + 4) / (Math.Pow(x, 2) + 1);
            f.WriteLine(" аргумент x = {0:F3}  y = {1:e3} \n, x, y");
            goto metka;
        metka1: f.WriteLine("       Составил Шейх Даниал {0} \n", s);
            f.Close();
            f1.Close();
        }
    }
}
