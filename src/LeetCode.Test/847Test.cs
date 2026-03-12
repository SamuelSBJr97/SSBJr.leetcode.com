using LeetCode.cs847;

namespace LeetCode.Test
{
    [TestClass]
    public class Test847Test
    {
        private static Type[] GetImplementations()
        {
            return typeof(Ics847).Assembly.GetTypes()
                .Where(t => typeof(Ics847).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }

        public static IEnumerable<object[]> Cases()
        {
            yield return new object[] { new int[][] {
                new[] { 1 },
                new[] { 0, 2, 4 },
                new[] { 1, 3, 4 },
                new[] { 2 },
                new[] { 1, 2 },
            }, 4 };
            
            yield return new object[] { new int[][] {
                new[] { 1, 2, 3 },
                new[] { 0 },
                new[] { 0 },
                new[] { 0 },
            }, 4 };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void ShortestPathLength_Implementations_ReturnExpected(int[][] graph, int expected)
        {
            var implementations = GetImplementations();
            Assert.IsTrue(implementations.Length > 0, "No implementations of Ics847 found.");

            foreach (var implType in implementations)
            {
                var solution = (Ics847)Activator.CreateInstance(implType);
                var result = solution.ShortestPathLength(graph);
                Assert.AreEqual(expected, result);
            }
        }
    }
}