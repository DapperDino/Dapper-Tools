namespace DapperDino.DapperTools.ScriptableEvents.Listeners
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}
