using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var generator = new SequenceGenerator<int>(1, 1, (a, b) => a + b);
            Assert.AreEqual(expected, generator.Generate(10));
        }

        [Test]
        public void Generator_ForSequence1Error()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            var generator = new SequenceGenerator<int>(1, 1, (a, b) => a + b);
            Assert.AreEqual(expected, generator.Generate(10));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, -10, 92, -796, 6920, -60136, 522608, -4541680, 39469088 };
            var generator = new SequenceGenerator<int>(1, 2, (a, b) => 6 * a - 8 * b);
            Assert.AreEqual(expected, generator.Generate(10));
        }

        [Test]
        public void Generator_ForSequence2Error()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            var generator = new SequenceGenerator<int>(1, 2, (a, b) => 6 * a - 8 * b);
            Assert.AreEqual(expected, generator.Generate(10));
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 3, 3.5, 4.16666666666667, 4.69047619047619, 5.29238095238095, 5.81880106357264, 6.39184849183592, 6.91728310858544 };
            var generator = new SequenceGenerator<int>(1, 2, (a, b) => a + b / a);
            Assert.AreEqual(expected, generator.Generate(10));
        }

        [Test]
        public void Generator_ForSequence3Error()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            var generator = new SequenceGenerator<double>(1, 2, (a, b) => a + b / a);
            Assert.AreEqual(expected, generator.Generate(10));
        }
    }
}
