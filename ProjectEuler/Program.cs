using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var problemNumber = 2;

            var problem = GetProblem(problemNumber);

            Console.WriteLine($"Result of problem {problemNumber} is: {problem.CalculateProblem()}");
        }

        private static IProblem GetProblem(int i)
        {
            switch (i)
            {
                case 1:
                    return new Problem1();
                case 2:
                    return new Problem2();
                case 10:
                    return new Problem10();
                case 16:
                    return new Problem16();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
