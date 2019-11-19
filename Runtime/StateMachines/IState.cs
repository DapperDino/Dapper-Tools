namespace DapperDino.DapperTools.StateMachines
{
    public interface IState
    {
        IState ProcessTransitions();
        void Enter();
        void Exit();
    }
}
