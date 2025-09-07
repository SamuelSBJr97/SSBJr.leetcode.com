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
    struct XY
    {
        int x = 0;
        int y = 0;

        public int mxd { get; private set; } = 0;

        public XY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Mover(char c)
        {
            var xy = new XY(x, y);

            switch (c)
            {
                case 'N':
                    y++;
                    break;
                case 'S':
                    y--;
                    break;
                case 'E':
                    x++;
                    break;
                case 'W':
                    x--;
                    break;
            }

            var d = xy.Distancia(this);

            if (mxd < d)
                mxd = d;
        }

        public int Distancia(XY xy)
        {
            int dx = Math.Abs(x - xy.x);
            int dy = Math.Abs(y - xy.y);
            return (int)Math.Sqrt(dx * dx + dy * dy);
        }
    }

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

        var _s = s.ToCharArray();

        if (k > 0)
        {
            while (k > 0)
            {
                var m = new int[4, 2];

                for (int i = 0; i < _s.Length; i++)
                {
                    switch (_s[i])
                    {
                        case 'N':
                            m[0, 0]++;
                            m[0, 1] = i;
                            break;
                        case 'S':
                            m[1, 0]++;
                            m[1, 1] = i;
                            break;
                        case 'E':
                            m[2, 0]++;
                            m[2, 1] = i;
                            break;
                        case 'W':
                            m[3, 0]++;
                            m[3, 1] = i;
                            break;
                    }
                }

                var _m = new int?[2, 2];

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if ((_m[0, 0] > m[i, 0]
                        || !_m[0, 0].HasValue)
                        && m[i, 0] > 0
                        )
                        {
                            _m[0, 0] = m[i, 0];
                            _m[0, 1] = m[i, j];
                        }

                        if ((_m[1, 0] < m[i, 0]
                        || !_m[1, 0].HasValue
                        || _m[1, 1] == _m[0, 1])
                        && m[i, 0] > 0
                        )
                        {
                            _m[1, 0] = m[i, 0];
                            _m[1, 1] = m[i, j];
                        }
                    }
                }

                if (_m[0, 1] > 0
                    && _m[1, 1] > 0
                    && _m[0, 1] != _m[1, 1]
                )
                {
                    var p = _m[1, 1].Value;

                    _s[p] = _s[_m[0, 1].Value];
                }
                else
                {
                    break;
                }

                k--;
            }
        }

        var xy = new XY();

        foreach (var _ in _s)
        {
            xy.Mover(_);
        }

        return xy.mxd;
    }
}