using System;
using UnityEngine;
using UnityEngine.Events;

namespace DapperDino.DapperTools.Inputs
{
    [Serializable]
    public class InputAxisFloatResponse
    {
        [SerializeField] private InputAxisFloat axis = null;
        [SerializeField] private FloatEvent onAxis = null;

        public InputAxisFloat Axis => axis;
        public FloatEvent OnAction => onAxis;

        [Serializable]
        public class FloatEvent : UnityEvent<float> { }
    }
}
