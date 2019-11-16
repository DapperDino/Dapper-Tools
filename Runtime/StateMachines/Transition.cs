using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class Transition : MonoBehaviour, ITransition
    {
        [SerializeField] private State nextState;

        public IState NextState => nextState;

        public abstract bool ShouldTransition();
    }
}
