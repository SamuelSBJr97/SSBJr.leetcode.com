using SSBJr.LeetCode.cs6;

namespace SSBJr.LeetCode.Test
{
    [TestClass]
    public class Test6Test : Test
    {

        public static IEnumerable<object[]> Cases()
        {
            yield return new object[] { "PAYPALISHIRING", 3, "PAHNAPLSIIGYIR" };

            yield return new object[] { "PAYPALISHIRING", 4, "PINALSIGYAHRPI" };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void Convert_Implementations_ReturnExpected(string s, int numRows, string expected)
        {
            var implementations = GetImplementations<Ics6>();
            Assert.IsTrue(implementations.Length > 0, "No implementations of Ics6 found.");

            foreach (var implType in implementations)
            {
                var solution = (Ics6)Activator.CreateInstance(implType);
                var result = solution.Convert(s, numRows);
                Assert.AreEqual(expected, result);
            }
        }
    }
}