using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public class StateMachineBehaviour : MonoBehaviour
    {
        [SerializeField] private State startingState = null;

        private StateMachine stateMachine;
        private StateMachine StateMachine
        {
            get
            {
                if (stateMachine != null) { return stateMachine; }
                stateMachine = new StateMachine(startingState);
                return stateMachine;
            }
        }

        private void Update() => StateMachine.Tick();

        public void ChangeState(State state) => StateMachine.ChangeState(state);
    }
}
