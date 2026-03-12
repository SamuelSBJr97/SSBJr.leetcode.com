namespace LeetCode.cs847
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-path-visiting-all-nodes/description/
    /// </summary>
    public interface Ics847
    {
        int ShortestPathLength(int[][] graph);
    }

    public class cs_1_847 : Ics847
    {
        private int v;
        private int[] c;

        public int ShortestPathLength(int[][] graph)
        {
            var lst = new cs_1_847[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                var v = new cs_1_847
                {
                    v = i,
                    c = new int[graph[i].Length]
                };

                for (int j = 0; j < graph[i].Length; j++)
                {
                    v.c[j] = graph[i][j];
                }

                lst[i] = v;
            }

            return spl(lst);
        }

        private static int spl(cs_1_847[] graph)
        {
            return graph.Length;
        }
    }

}