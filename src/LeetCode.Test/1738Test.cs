using LeetCode.cs1738;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test
{
    [TestClass]
    public class Test1738Test
    {
        private static Type[] GetImplementations()
        {
            return typeof(Ics1738).Assembly.GetTypes()
                .Where(t => typeof(Ics1738).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }

        public static IEnumerable<object[]> Cases()
        {
            yield return new object[] { new int[][] { new[] { 5, 2 }, new[] { 1, 6 } }, 1, 7 };
            yield return new object[] { new int[][] { new[] { 5, 2 }, new[] { 1, 6 } }, 2, 5 };
            yield return new object[] { new int[][] { new[] { 5, 2 }, new[] { 1, 6 } }, 3, 4 };
            yield return new object[] { new int[][] { new[] { 5, 2 }, new[] { 1, 6 } }, 4, 0 };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void KthLargestValue_Implementations_ReturnExpected(int[][] matrix, int k, int expected)
        {
            var implementations = GetImplementations();
            Assert.IsTrue(implementations.Length > 0, "No implementations of Ics1738 found.");

            foreach (var implType in implementations)
            {
                var solution = (Ics1738)Activator.CreateInstance(implType);
                var result = solution.KthLargestValue(matrix, k);
                Assert.AreEqual(expected, result, $"Failed for {implType.Name} with input matrix and k={k}. Expected {expected} returned {result}.");
            }
        }
    }
}