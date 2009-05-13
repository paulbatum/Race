using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public static class MyExtensions
    {
        public static void Times(this int count, Action action)
        {
            if (action != null)
            {
                for (int i = 1; i <= count; i++)
                    action();
            }
        }

        public static void Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            if (items != null && action != null)
            {                
                foreach (var item in items)
                    action(item);
            }
        }
    }
}