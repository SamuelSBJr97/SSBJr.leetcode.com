using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using LeetCode.c3443;

namespace LeetCode.Test
{
    [TestClass]
    public class Test3443Test
    {
        private static Type[] GetImplementations()
        {
            return typeof(Ics3443).Assembly.GetTypes()
                .Where(t => typeof(Ics3443).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }

        [TestMethod]
        [DataRow("NSWWEW", 3, 6)]
        [DataRow("NWSE", 1, 3)]
        public void MaxDistance_Implementations_ReturnExpected(string directions, int start, int expected)
        {
            var implementations = GetImplementations();
            Assert.IsTrue(implementations.Length > 0, "No implementations of Ics3443 found.");

            foreach (var implType in implementations)
            {
                var solution = (Ics3443)Activator.CreateInstance(implType);
                var result = solution.MaxDistance(directions, start);
                Assert.AreEqual(expected, result, $"Failed for {implType.Name} with input '{directions}', start {start}");
            }
        }
    }
}