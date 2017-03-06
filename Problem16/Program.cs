using System;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = BigInteger.Pow(2, 1000);
            var numbers = res.ToString().ToCharArray();

            var result = 0;

            foreach (var number in numbers)
            {
                result += int.Parse(number.ToString());
            }

            Console.WriteLine(result);
        }
    }
}
