using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class Vector3Extensions
    {
        /// <summary>
        /// Return a copy of this vector with an altered x and/or y and/or z component
        /// </summary>
        /// <param name="v"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
        {
            return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
        }

        /// <summary>
        /// Return a Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Vector3 source, Vector3 destination)
        {
            Debug.LogWarning("Change function call DirectionTo");
            return (destination - source);
        }

        /// <summary>
        /// Return a normalized Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Vector3 source, Vector3 destination)
        {
            return Vector3.Normalize(destination - source);
        }

        /// <summary>
        /// Return a Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Vector3 source, Transform destination)
        {
            return source.DirectionTo(destination.position);
        }


        /// <summary>
        /// Return a normalized Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Vector3 source, Transform destination)
        {
            return source.NormalDirectionTo(destination.position);
        }

        /// <summary>
        /// Return a Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Vector3 source, GameObject destination)
        {
            return source.DirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Return a normalized Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Vector3 source, GameObject destination)
        {
            return source.NormalDirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector3 source, Vector3 destination)
        {
            return Vector3.Magnitude(destination - source);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector3 source, Transform destination)
        {
            return Vector3.Magnitude(destination.position - source);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Vector3 source, GameObject destination)
        {
            return Vector3.Magnitude(destination.transform.position - source);
        }
    }
}
