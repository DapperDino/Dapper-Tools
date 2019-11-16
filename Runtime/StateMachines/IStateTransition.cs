namespace DapperDino.DapperTools.StateMachines
{
    public interface IStateTransition
    {
        State NextState { get; }

        bool ShouldTransition();
    }
}
