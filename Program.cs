using System;

namespace MethodOverloading
{
    internal class MethodOverloading
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool boolVal)
        {
            var sum = a + b;
            if (boolVal == true)
            {
                return sum == 1 ? $"{sum} dollar" : $"{sum} dollars";
            }
            else {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            //return types in order:
            //1. int add method,
            //2. dec add method,
            //3. string add method for a single dollar,
            //4. string add method for multiple dollars,
            //5. string add method for bool false
            Console.WriteLine($"{Add(1, 1)}, {Add(1.1m, 1.1m)}, {Add(0, 1, true)}, {Add(1, 1, true)}, {Add(1, 1, false)}");
        }
    }
}