namespace ProjectEuler.Problems
{
    public class Problem1 : IProblem
    {
        public string CalculateProblem()
        {
            var sum = 0;
            var i = 0;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

                i++;
            }

            return sum.ToString();
        }
    }
}