using System;
using System.Collections.Generic;

namespace DapperDino.DapperTools.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Return a random item from the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T Random<T>(this IList<T> list)
        {
            // Pick a random item from the list and return it
            return list[UnityEngine.Random.Range(0, list.Count)];
        }

        /// <summary>
        /// Remove a random item from the list and returns it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T RemoveRandom<T>(this IList<T> list)
        {
            // Pick a random item from the list
            int indexToRemoveAt = UnityEngine.Random.Range(0, list.Count);
            var item = list[indexToRemoveAt];

            // Remove the item from the list
            list.RemoveAt(indexToRemoveAt);

            // Return the item that we removed
            return item;
        }

        /// <summary>
        /// Shuffle the list using the Fisher–Yates algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            // Algorithm used:
            // https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle

            var rng = new Random();

            for (int i = list.Count; i > 1; i--)
            {
                int k = rng.Next(i + 1);
                var value = list[k];
                list[k] = list[i];
                list[i] = value;
            }
        }
    }
}
