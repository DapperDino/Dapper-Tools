using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public class State : MonoBehaviour, IState
    {
        [SerializeField] private List<StateAction> actions;
        [SerializeField] private List<StateTransition> transitions;

        private IEnumerable<IStateAction> Actions => actions;
        private IEnumerable<IStateTransition> Transitions => transitions;

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

        public void Enter()
        {
            foreach(var action in Actions)
            {
                action.Enter();
            }
        }
        public void Tick(float deltaTime)
        {
            foreach (var action in Actions)
            {
                action.Tick(deltaTime);
            }
        }
        public void Exit()
        {
            foreach (var action in Actions)
            {
                action.Exit();
            }
        }
    }
}
