using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class StateTransitionCondition : MonoBehaviour
    {
        public abstract bool IsMet();
    }
}
