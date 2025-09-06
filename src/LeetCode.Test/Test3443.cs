namespace LeetCode.Test
{
    [TestClass]
    public class Test3443
    {
        [TestMethod]
        [DataRow("NSWWEW", 3, 6)]
        [DataRow("NSWWEW", 3, 6)]
        public void Test3443_MaxDistance_ReturnsExpected(string directions, int start, int expected)
        {
            // Arrange
            var solution = new LeetCode.c3443.Solution();

            // Act
            var result = solution.MaxDistance(directions, start);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}