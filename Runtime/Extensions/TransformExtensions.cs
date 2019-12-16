using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Destroy all children of this transform
        /// </summary>
        /// <param name="transform"></param>
        public static void DestroyChildren(this Transform transform)
        {
            foreach (Transform child in transform)
            {
                Object.Destroy(child.gameObject);
            }
        }

        /// <summary>
        /// Return a Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform source, Vector3 destination)
        {
            return source.position.DirectionTo(destination);
        }

        /// <summary>
        /// Return a normalized Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Transform source, Vector3 destination)
        {
            return source.position.NormalDirectionTo(destination);
        }

        /// <summary>
        /// Return a Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform source, Transform destination)
        {
            return source.DirectionTo(destination.position);
        }

        /// <summary>
        /// Return a normalized Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Transform source, Transform destination)
        {
            return source.NormalDirectionTo(destination.position);
        }

        /// <summary>
        /// Return a Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform source, GameObject destination)
        {
            return source.DirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Return a normalized Vector3, the direction from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NormalDirectionTo(this Transform source, GameObject destination)
        {
            return source.NormalDirectionTo(destination.transform.position);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Transform source, Vector3 destination)
        {
            return source.position.DistanceTo(destination);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Transform source, Transform destination)
        {
            return source.position.DistanceTo(destination.position);
        }

        /// <summary>
        /// Return a float. the distance between to points
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static float DistanceTo(this Transform source, GameObject destination)
        {
            return source.DistanceTo(destination.transform);
        }
    }
}
