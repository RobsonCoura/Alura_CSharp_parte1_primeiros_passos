using System;

namespace MaxMinDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal min1 = decimal.MinValue;
            decimal max1 = decimal.MaxValue;
            Console.WriteLine($"O intervalo do tipo decimal é {min1} para {max1}");
            Console.WriteLine();

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);
            Console.WriteLine();

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            Console.WriteLine();

            int min2 = int.MinValue;
            int max2 = int.MaxValue;
            Console.WriteLine($"O intervalo do tipo inteiro é {min2} para {max2}");
            Console.WriteLine();

            long min3 = long.MinValue;
            long max3 = long.MaxValue;
            Console.WriteLine($"O intervalo do tipo grande é {min3} para {max3}");
            Console.WriteLine();

            double min4 = double.MinValue;
            double max4 = double.MaxValue;
            Console.WriteLine($"O intervalo do tipo duplo é {min4} para {max4}");
            Console.WriteLine();

            short min5 = short.MinValue;
            short max5 = short.MaxValue;
            Console.WriteLine($"O intervalo do tipo baixo é {min5} para {max5}");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
