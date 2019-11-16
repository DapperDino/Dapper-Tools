namespace DapperDino.DapperTools.StateMachines
{
    public interface ITransition
    {
        IState NextState { get; }

        bool ShouldTransition();
    }
}
