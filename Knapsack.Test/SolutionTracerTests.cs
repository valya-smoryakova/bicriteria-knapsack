using Knapsack.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Test
{
    [TestClass]
    public class SolutionTracerTests
    {
/*
        [TestMethod]
        public void GivenSigmaAndEffectiveVector_SolutionTracer_FindSolution()
        {
            string parameters = "4\n2 3 4 5\n12\n2 3 4 1\n3 2 1 3\n";
            Parser parser = new Parser();

            KnapsackProblem problem = parser.Parse(parameters);
            WBuilder wBuilder = new WBuilder();
            VectorSet[,] w = wBuilder.BuildW(problem);
            SigmaBuilder sigmaBuilder = new SigmaBuilder();
            SigmaTable sigma = sigmaBuilder.Build(w, problem);
            SolutionTracer solutionTracer = new SolutionTracer();
            
            // Act (Действие)
            Solution solution = solutionTracer.Trace(problem, sigma, new Vector(9, 6));

            // Assert (Проверка)
            Assert.AreEqual(1, solution[0]);
            Assert.AreEqual(1, solution[1]);
            Assert.AreEqual(1, solution[2]);
            Assert.AreEqual(0, solution[3]);
            
            Assert.AreEqual("1, 1, 1, 0", solution.ToString());
        }
*/
    }
}