using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class StateAction : MonoBehaviour, IStateAction
    {
        public virtual void Enter() { }
        public virtual void Tick(float deltaTime) { }
        public virtual void Exit() { }
    }
}
