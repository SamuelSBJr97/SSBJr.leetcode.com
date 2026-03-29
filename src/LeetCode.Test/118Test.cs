using LeetCode.cs118;

namespace LeetCode.Test
{
    [TestClass]
    public class Test118Test
    {
        private static Type[] GetImplementations()
        {
            return typeof(Ics118).Assembly.GetTypes()
                .Where(t => typeof(Ics118).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }

        public static IEnumerable<object[]> Cases()
        {
            yield return new object[] { 5,
            new int[][]{
                new[] { 1 },
                new[] { 1, 1 },
                new[] { 1,2,1 },
                new[] { 1,3,3,1 },
                new[] { 1,4,6,4,1 },
            } };

            yield return new object[] { 1,
            new int[][] {
                new[] { 1 },
            }};
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void Generate_Implementations_ReturnExpected(int nunRows, int[][] row)
        {
            var implementations = GetImplementations();
            Assert.IsTrue(implementations.Length > 0, "No implementations of Ics118 found.");

            foreach (var implType in implementations)
            {
                var solution = (Ics118)Activator.CreateInstance(implType);
                var result = solution.Generate(nunRows);
                Assert.AreEqual(row, result.ToArray());
            }
        }
    }
}