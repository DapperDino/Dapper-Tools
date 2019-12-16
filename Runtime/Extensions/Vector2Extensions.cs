using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Return a copy of this vector with an altered x and/or y component
        /// </summary>
        /// <param name="v"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 With(this Vector2 original, float? x = null, float? y = null)
        {
            return new Vector2(x ?? original.x, y ?? original.y);
        }

        /// <summary>
        /// Return a Vector2, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 DirectionTo(this Vector2 source, Vector2 destination)
        {
            Debug.LogWarning("Change function call DirectionTo");
            return destination - source;
        }

        /// <summary>
        /// Return a normalized Vector2, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 NormalDirectionTo(this Vector2 source, Vector2 destination)
        {
            Vector2 dir = destination - source;
            return dir.normalized;
        }

        /// <summary>
        /// Return a Vector2, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 DirectionTo(this Vector2 source, Transform destination)
        {
            return source.DirectionTo(destination.position);
        }

        /// <summary>
        /// Return a normalized Vector2, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 NormalDirectionTo(this Vector2 source, Transform destination)
        {
            return source.NormalDirectionTo(destination.position);
        }

        /// <summary>
        /// Return a Vector2, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 DirectionTo(this Vector2 source, GameObject destination)
        {
            return source.DirectionTo(destination.transform);
        }

        /// <summary>
        /// Return a normalized Vector2, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector2 NormalDirectionTo(this Vector2 source, GameObject destination)
        {
            return source.NormalDirectionTo(destination.transform);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector2 source, Vector2 destination)
        {
            return Vector2.Distance(destination, source);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector2 source, Transform destination)
        {
            return Vector2.Distance(destination.position, source);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector2 source, GameObject destination)
        {
            return Vector2.Distance(destination.transform.position, source);
        }
    }
}
