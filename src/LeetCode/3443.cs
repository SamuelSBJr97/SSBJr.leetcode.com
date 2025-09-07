namespace LeetCode.c3443;

/// <summary>
/// Maximum Manhattan Distance After K Changes
/// https://leetcode.com/problems/maximum-manhattan-distance-after-k-changes/description/
/// </summary>
public interface Ics3443
{
    int MaxDistance(string s, int k);
}

public class cs_1_3443 : Ics3443
{
    /// <summary>
    /// MaxDistance possível considerando k mudanças de direção em s
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaxDistance(string s, int k)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        var xy = new int[4];

        foreach (var _ in s)
        {
            // switch para incrementar o xy com base em N, S, E, W
            switch (_)
            {
                case 'N':
                    xy[0]++;
                    break;
                case 'S':
                    xy[1]++;
                    break;
                case 'E':
                    xy[2]++;
                    break;
                case 'W':
                    xy[3]++;
                    break;
            }
        }

        // faz k aumentos de direção para aumentar o xy[i] maior e decrementar o xy[i] menor
        while (k > 0)
        {
            var xy_mm = new int?[4];

            for (int i = 0; i < xy.Length; i++)
            {
                if (xy[i] > 0
                && (xy[i] > xy_mm[0]
                    || !xy_mm[0].HasValue)
                )
                {
                    xy_mm[0] = xy[i];
                    xy_mm[1] = i;
                }

                if (xy[i] > 0
                && (xy[i] < xy_mm[2]
                    || !xy_mm[2].HasValue
                    || xy_mm[1] == xy_mm[3])
                )
                {
                    xy_mm[2] = xy[i];
                    xy_mm[3] = i;
                }
            }

            if (xy_mm[0].HasValue && xy_mm[0] > 0
                && xy_mm[2].HasValue && xy_mm[2] > 0)
            {
                xy[xy_mm[1].Value]++;
                xy[xy_mm[3].Value]--;

                k--;
            }
            else
            {
                break;
            }
        }

        return Math.Abs(xy[0] - xy[1]) + Math.Abs(xy[2] - xy[3]);
    }
}