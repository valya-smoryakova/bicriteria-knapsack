using Knapsack.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Test
{
    [TestClass]
    public class WBuilderTests
    {
/*
        [TestMethod]
        public void GivenKnapsackProblemAndWBuilder_Build()
        {
            // Arrange (Подготовка)
            string parameters = "4\n2 3 4 5\n12\n2 3 4 1\n3 2 1 3\n";
            Parser parser = new Parser();

            KnapsackProblem problem = parser.Parse(parameters);
            WBuilder wBuilder = new WBuilder();

            Vector v1 = new Vector(0, 0);
            Vector v2 = new Vector(2, 3);
            Vector v3 = new Vector(3, 2);
            Vector v4 = new Vector(5, 5);
            Vector v5 = new Vector(4, 1);
            Vector v6 = new Vector(6, 4);
            Vector v7 = new Vector(7, 3);
            Vector v8 = new Vector(9, 6);
            Vector v9 = new Vector(3, 6);
            Vector v10 = new Vector(6, 8);
            Vector v11 = new Vector(7, 7);

            VectorSet vs1 = new VectorSet(new Vector[] { v1 });
            VectorSet vs2 = new VectorSet(new Vector[] { v2 });
            VectorSet vs3 = new VectorSet(new Vector[] { v2, v3 });
            VectorSet vs4 = new VectorSet(new Vector[] { v4 });
            VectorSet vs5 = new VectorSet(new Vector[] { v2, v3, v5 });
            VectorSet vs6 = new VectorSet(new Vector[] { v4, v6 });
            VectorSet vs7 = new VectorSet(new Vector[] { v4, v6, v7 });
            VectorSet vs8 = new VectorSet(new Vector[] { v8 });
            VectorSet vs9 = new VectorSet(new Vector[] { v4, v6, v7, v9 });
            VectorSet vs10 = new VectorSet(new Vector[] { v8, v10 });
            VectorSet vs11 = new VectorSet(new Vector[] { v8, v10, v11 });

            // Act (Действие)
            VectorSet[,] w = wBuilder.BuildW(problem);

            // Assert (Проверка)
            Assert.AreEqual(vs1, w[1, 0]);
            Assert.AreEqual(vs1, w[1, 1]);

            for (int i = 2; i <= 12; i++)
            {
                Assert.AreEqual(vs2, w[1, i]);
            }

            Assert.AreEqual(vs1, w[2, 0]);
            Assert.AreEqual(vs1, w[2, 1]);
            Assert.AreEqual(vs2, w[2, 2]);
            Assert.AreEqual(vs3, w[2, 3]);
            Assert.AreEqual(vs3, w[2, 4]);

            for (int i = 5; i <= 12; i++)
            {
                Assert.AreEqual(vs4, w[2, i]);
            }

            Assert.AreEqual(vs1, w[3, 0]);
            Assert.AreEqual(vs1, w[3, 1]);
            Assert.AreEqual(vs2, w[3, 2]);
            Assert.AreEqual(vs3, w[3, 3]);
            Assert.AreEqual(vs5, w[3, 4]);
            Assert.AreEqual(vs4, w[3, 5]);
            Assert.AreEqual(vs6, w[3, 6]);
            Assert.AreEqual(vs7, w[3, 7]);
            Assert.AreEqual(vs7, w[3, 8]);

            for (int i = 9; i <= 12; i++)
            {
                Assert.AreEqual(vs8, w[3, i]);
            }

            Assert.AreEqual(vs1, w[4, 0]);
            Assert.AreEqual(vs1, w[4, 1]);
            Assert.AreEqual(vs2, w[4, 2]);
            Assert.AreEqual(vs3, w[4, 3]);
            Assert.AreEqual(vs5, w[4, 4]);
            Assert.AreEqual(vs4, w[4, 5]);
            Assert.AreEqual(vs6, w[4, 6]);
            Assert.AreEqual(vs9, w[4, 7]);
            Assert.AreEqual(vs9, w[4, 8]);
            Assert.AreEqual(vs8, w[4, 9]);
            Assert.AreEqual(vs10, w[4, 10]);
            Assert.AreEqual(vs11, w[4, 11]);
            Assert.AreEqual(vs11, w[4, 12]);
        }
 */
    }
}