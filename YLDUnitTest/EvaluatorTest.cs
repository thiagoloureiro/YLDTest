using Xunit;
using YLDTest.Class;

namespace YLDUnitTest
{
    public class EvaluatorTest
    {
        [Fact]
        public void EvaluateTest_Success()
        {
            // Arrange
            var evaluator = new Evaluator<int>();

            // Act
            evaluator.Add((val, additionalVals) => val / 2);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], 5);
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20);
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3);

            // Assert
            var ret = evaluator.Evaluate(8);

            Assert.True(ret[0] == 4);
            Assert.True(ret[1] == 13);
            Assert.True(ret[2] == 29);
            Assert.True(ret[3] == 0);
        }
    }
}