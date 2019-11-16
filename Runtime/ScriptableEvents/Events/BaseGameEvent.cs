using DapperDino.DapperTools.ScriptableEvents.Listeners;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.ScriptableEvents.Events
{
    public abstract class BaseGameEvent<T> : ScriptableObject
    {
        private readonly List<IGameEventListener<T>> eventListeners = new List<IGameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--) { eventListeners[i].OnEventRaised(item); }
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!eventListeners.Contains(listener)) { eventListeners.Add(listener); }
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (eventListeners.Contains(listener)) { eventListeners.Remove(listener); }
        }
    }
}
