using System.Collections.Generic;

namespace DapperDino.DapperTools
{
    public static class ListExtensions
    {
        public static T First<T>(this List<T> list) => list[0];
        public static T Last<T>(this List<T> list) => list[list.Count - 1];
    }
}
