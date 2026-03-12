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
        private int[][] Graph { get; set; }

        public int ShortestPathLength(int[][] graph)
        {
            Graph = graph;

            return rotas();
        }

        public int rotas(int? i = null, int? j = null)
        {
            int? r = null;

            if (!i.HasValue)
            {
                for (int k = 0; k < Graph.Length; k++)
                {
                    var rr = rotas(k);

                    if (!r.HasValue || r > rr)
                    {
                        r = rr;
                    }
                }

                return r.Value;
            }

            r = 0;

            for (int k = 0; k < Graph.Length; k++)
            {
                if (k == i)
                {
                    continue;
                }

                for (int l = 0; l < Graph[k].Length; l++)
                {
                    r += rotas(Graph[k][l], l) + 1;
                }
            }

            return r.Value;
        }
    }

}