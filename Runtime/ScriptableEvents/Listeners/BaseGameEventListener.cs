using DapperDino.DapperTools.ScriptableEvents.Events;
using UnityEngine;
using UnityEngine.Events;

namespace DapperDino.DapperTools.ScriptableEvents.Listeners
{
    public class BaseGameEventListener<T, E, UER> : MonoBehaviour,
    IGameEventListener<T> where E : BaseGameEvent<T> where UER : UnityEvent<T>
    {
        [SerializeField] private E gameEvent = null;
        [SerializeField] private UER unityEventResponse = null;

        private void OnEnable()
        {
            if (gameEvent == null) { return; }

            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null) return;

            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            if (unityEventResponse == null) { return; }

            unityEventResponse.Invoke(item);
        }
    }
}
