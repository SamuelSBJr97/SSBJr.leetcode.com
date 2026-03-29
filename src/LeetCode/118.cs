namespace LeetCode.cs118
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle
    /// </summary>
    public interface Ics118
    {
        IList<IList<int>> Generate(int numRows);
    }

    public class cs_1_118 : Ics118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> lst = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var row = new List<int>();

                for (int j = 1; j < (i + 1) * 2; j++)
                {
                    row.Add(j);
                }

                lst.Add(row);
            }

            return lst;
        }
    }
}