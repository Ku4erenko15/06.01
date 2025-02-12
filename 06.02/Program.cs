using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc1 = new Calculate();
            Calculate calc2 = new Calculate(4);
            Calculate calc3 = new Calculate(3, 12);

            Console.WriteLine(calc1);
            Console.WriteLine(calc2);
            Console.WriteLine(calc3);

            Console.WriteLine("Корень из произведения: " + new Func<double>(() => Math.Sqrt(calc3.num1 * calc3.num2))());
            Console.ReadKey();
        }
        class Calculate
        {
            public double num1;
            public double num2;

            public Calculate() : this(0, 0) { }

            public Calculate(double num) : this(num, num) { }
            public Calculate(double num1, double num2)
            {
                this.num1 = num1;
                this.num2= num2;
            }

            public override string ToString()
            {
                return $"Num1: {num1}, Num2: {num2}";
            }

            public double CalculateRoot()
            {
                return Math.Sqrt(num1 * num2);
            }
        }
    }
}
