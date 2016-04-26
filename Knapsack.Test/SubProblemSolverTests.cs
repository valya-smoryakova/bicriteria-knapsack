using Knapsack.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Test
{
    [TestClass]
    public class SubProblemSolverTests
    {
/*
        private KnapsackProblem problem;
        private SubProblemSolver solver;
        private VectorSet[,] w;

        public SubProblemSolverTests()
        {
            string parameters = "4\n2 3 4 5\n12\n2 3 4 1\n3 2 1 3\n";
            Parser parser = new Parser();

            this.problem = parser.Parse(parameters);
            this.solver = new SubProblemSolver();
            this.w = new VectorSet[problem.N + 1, problem.B + 1];
        }

        [TestMethod]
        public void GivenFirstThingSmallBag_SubProblemSolverSolve_SolvesNextSubProblemSolution()
        {
            // Arrange (Подготовка)
            VectorSet expected = new VectorSet(new Vector[] { new Vector(0, 0) });

            // Act (Действие)
            VectorSet actual = solver.Solve(problem, w, 1, 1);

            // Assert (Проверка)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenFirstThingLargeBag_SubProblemSolverSolve_SolvesNextSubProblemSolution()
        {
            // Arrange (Подготовка)
            VectorSet expected = new VectorSet(new Vector[] { new Vector(2, 3) });
            
            // Act (Действие)
            VectorSet actual = solver.Solve(problem, w, 1, 2);

            // Assert (Проверка)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenSecondThingSmallBag_SubProblemSolverSolve_SolvesNextSubProblemSolution()
        {
            // Arrange (Подготовка)
            VectorSet expected = new VectorSet(new Vector[] {new Vector(8, 2)});
            w[1, 2] = expected;

            // Act (Действие)
            VectorSet actual = solver.Solve(problem, w, 2, 2);

            // Assert (Проверка)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenSecondThingLargeBag_SubProblemSolverSolve_SolvesNextSubProblemSolution()
        {
            // Arrange (Подготовка)
            var expected = new VectorSet(new Vector[] { new Vector(8, 4), new Vector(7, 5) });
            w[1, 5] = new VectorSet(new Vector[] { new Vector(8, 4) });
            w[1, 2] = new VectorSet(new Vector[] { new Vector(4, 3), new Vector(5, 1) });

            // Act (Действие)
            VectorSet actual = solver.Solve(problem, w, 2, 5);

            // Assert (Проверка)
            Assert.AreEqual(expected, actual);
        }
 */
    }
}
