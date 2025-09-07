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
        var xy = new int[2, 4];

        foreach (var _ in s)
        {
            // switch para incrementar o xy com base em N, S, E, W
            switch (_)
            {
                case 'N':
                    xy[0, 0]++;
                    break;
                case 'S':
                    xy[0, 1]++;
                    break;
                case 'E':
                    xy[1, 2]++;
                    break;
                case 'W':
                    xy[1, 3]++;
                    break;
            }
        }

        // faz k aumentos de direção para aumentar o xy[i] maior e decrementar o xy[i] menor
        for (int axis = 0; axis < 2; axis++)
        {
            
        }


    }
}