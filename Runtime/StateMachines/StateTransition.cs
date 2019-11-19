using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class StateTransition : MonoBehaviour, IStateTransition
    {
        [SerializeField] private State nextState = null;

        public State NextState => nextState;

        public abstract bool ShouldTransition();
    }
}
