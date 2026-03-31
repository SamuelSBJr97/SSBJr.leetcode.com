namespace SSBJr.LeetCode.Test
{
    public class Test
    {
        public static Type[] GetImplementations<T>()
        {
            return typeof(T).Assembly.GetTypes()
                .Where(t => typeof(T).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }
    }
}