using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class StateTransition : MonoBehaviour, IStateTransition
    {
        [SerializeField] private State nextState;

        public State NextState => nextState;

        public abstract bool ShouldTransition();
    }
}
