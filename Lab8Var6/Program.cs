using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Var6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[15];
            int[] r = new int[15];
            Console.Write("Введите число элементов массива n =");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int sum = 1;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                s[i] = rnd.Next(-10, 10);
                r[i] = rnd.Next(-10, 10);
            }
            for (int i = 0; i < n; i++)
            {

                if (s[i] > 0)
                {
                    sum *= s[i];
                    count++;
                }
            }
            Console.WriteLine($"Произведение положительных элементов массива: {sum}");
            Console.WriteLine($"Количество положительных элементов массива: {count}");
            for (int i = 0; i < n; i++)
            {
                r[i] = 4 * s[i] + 1;
                Console.WriteLine("r[" + (i + 1) + "]=" + r[i]);
            }
            int summ = 0;
            int countt = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] < 0)
                {
                    summ += s[i];
                    countt++;
                }
                if (r[i] < 0)
                {
                    summ += s[i];
                    countt++;
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов массива s[i] и r[i] {summ} ");
            Console.WriteLine($"Колличество отрицательных элементов массива s[i] и r[i] {countt} ");
        }
    }
}
