using System;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    [Serializable]
    public class StateTransition
    {
        [SerializeField] private State nextState = null;
        [SerializeField] private List<StateTransitionCondition> conditions = new List<StateTransitionCondition>();

        public State NextState => nextState;

        public bool ShouldTransition()
        {
            foreach (var condition in conditions)
            {
                if (!condition.IsMet())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
