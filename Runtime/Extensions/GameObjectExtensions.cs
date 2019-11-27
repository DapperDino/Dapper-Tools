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
            if (gameObject.TryGetComponent<T>(out T requestedComponent))
            {
                return requestedComponent;
            }

            // Otherwise add a new instance of component, then return it
            return gameObject.AddComponent<T>();
        }
    }
}
