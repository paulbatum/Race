using System;
using System.Collections.Generic;
using System.Linq;

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

        public static IEnumerable<T> Items<T>(this int count, Func<T> builder)
        {
            if (builder == null)
                yield break;
            
            for (int i = 1; i <= count; i++)
                yield return builder();
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