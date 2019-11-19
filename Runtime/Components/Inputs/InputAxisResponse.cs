using DapperDino.DapperTools.DataTypes;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace DapperDino.DapperTools.Components.Inputs
{
    [Serializable]
    public class InputAxisResponse
    {
        [SerializeField] private InputAxis axis = null;
        [SerializeField] private Vector2Event onAxis = null;

        public InputAxis Axis => axis;
        public Vector2Event OnAction => onAxis;

        [Serializable]
        public class Vector2Event : UnityEvent<SerializableVector2> { }
    }
}
