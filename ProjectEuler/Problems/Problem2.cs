
namespace ProjectEuler.Problems
{
    public class Problem2 : IProblem
    {
        public string CalculateProblem()
        {
            var sum = 0;
            var i = 1;
            var j = 2;

            while (j < 4_000_000)
            {
                if (j % 2 == 0)
                    sum += j;

                var t = i + j;
                i = j;
                j = t;
            }

            return sum.ToString();
        }
    }
}