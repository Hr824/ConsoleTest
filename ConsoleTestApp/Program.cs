using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Multiply(5, 3);
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }


        private int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}