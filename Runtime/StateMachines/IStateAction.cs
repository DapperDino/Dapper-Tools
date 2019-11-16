namespace DapperDino.DapperTools.StateMachines
{
    public interface IStateAction
    {
        void Enter();
        void Tick(float deltaTime);
        void Exit();
    }
}
