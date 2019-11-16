using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Destroys all children of the transform
        /// </summary>
        /// <param name="transform"></param>
        public static void DestroyChildren(this Transform transform)
        {
            foreach (Transform child in transform)
            {
                Object.Destroy(child.gameObject);
            }
        }
    }
}
