using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class ComponentExtensions
    {
        /// <summary>
        /// Return a component after attatching it to the given component's game object 
        /// </summary>
        /// <typeparam name="T">Component to attatch</typeparam>
        /// <param name="component"></param>
        /// <returns>Instance of new component</returns>
        public static T AddComponent<T>(this Component component) where T : Component
        {
            // Add the component to this component's game object, then return it
            return component.gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Return a component after either finding it on the component's game object or otherwise attaching it
        /// </summary>
        /// <typeparam name="T">Component to attatch</typeparam>
        /// <param name="component"></param>
        /// <returns>Instance of the component</returns>
        public static T GetOrAddComponent<T>(this Component component) where T : Component
        {
            // Get the component if it exists on the component's game object and return it
            var requestedComponent = component.GetComponent<T>();
            if (requestedComponent != null)
            {
                return requestedComponent;
            }

            // Otherwise add a new instance of component, then return it
            return component.AddComponent<T>();
        }

        /// <summary>
        /// Return the result of checking whether the component's game object has a component of type T attached
        /// </summary>
        /// <typeparam name="T">Component to check for</typeparam>
        /// <param name="component"></param>
        /// <returns>True if the component is attatched</returns>
        public static bool HasComponent<T>(this Component component) where T : Component
        {
            // Try to get the supplied component from this component's game object and return the result
            return component.GetComponent<T>() != null;
        }
    }
}
