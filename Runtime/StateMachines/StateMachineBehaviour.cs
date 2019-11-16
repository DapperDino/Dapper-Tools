using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public class StateMachineBehaviour : MonoBehaviour
    {
        [SerializeField] private State startingState;

        private StateMachine stateMachine;

        private void Start() => stateMachine = new StateMachine(startingState);
        private void Update() => stateMachine.Tick(Time.deltaTime);
    }
}
