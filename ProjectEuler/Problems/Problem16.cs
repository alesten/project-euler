using System;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem16 : IProblem
    {
        public string CalculateProblem()
        {
            var res = BigInteger.Pow(2, 1000);
            var numbers = res.ToString().ToCharArray();

            var result = 0;

            foreach (var number in numbers)
            {
                result += int.Parse(number.ToString());
            }

            return result.ToString();
        }
    }
}