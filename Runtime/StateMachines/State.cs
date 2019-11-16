using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class State : MonoBehaviour, IState
    {
        [SerializeField] private List<Transition> transitions;

        private IEnumerable<ITransition> Transitions => transitions;

        public IState ProcessTransitions()
        {
            // Loop over all of the possible transitions from this state
            foreach (var transition in Transitions)
            {
                // Check to see if the particular transition conditions are met
                if (transition.ShouldTransition())
                {
                    // Let the caller know which state we should transition to
                    return transition.NextState;
                }
            }

            // No transitions have all of their conditions met
            return null;
        }

        public virtual void Enter() { }
        public virtual void Tick(float deltaTime) { }
        public virtual void Exit() { }
    }
}
