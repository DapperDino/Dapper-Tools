using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Return a component after either finding it on the game object or otherwise attaching it
        /// </summary>
        /// <typeparam name="T">Component To Attatch</typeparam>
        /// <param name="gameObject"></param>
        /// <returns>Instance of the component</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            // Get the component if it exists on the game object and return it
            var requestedComponent = gameObject.GetComponent<T>();
            if (requestedComponent != null)
            {
                return requestedComponent;
            }

            // Otherwise add a new instance of component, then return it
            return gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Return the result of checking whether the game object has a component of type T attached
        /// </summary>
        /// <typeparam name="T">Component to check for</typeparam>
        /// <param name="gameObject"></param>
        /// <returns>True if the component is attatched</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            // Try to get the supplied component from this game object and return the result
            return gameObject.GetComponent<T>() != null;
        }
    }
}
