using System;
using YLDTest.Class;

namespace YLDTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var evaluator = new Evaluator<int>();

            evaluator.Add((val, additionalVals) => val / 2); // 4
            evaluator.Add((val, additionalVals) => val + additionalVals[0], 5); // 9
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20); // 30
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3); // 22

            var ret = evaluator.Evaluate(8);

            Console.ReadLine();
        }
    }
}