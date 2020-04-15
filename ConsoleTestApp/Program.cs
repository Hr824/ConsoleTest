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
            int result = Multiply(50, 72);
            int result1 = Multiply(5, 3);

            int result2 = Add(2, 8);
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }


        private static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private static string Hello(string nom)
        {
            return "Bonjour " + nom;
        }

        private static string Majuscule(string nom)
        {
            return nom.ToUpper();
        }
    }
}