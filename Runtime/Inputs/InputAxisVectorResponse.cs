using DapperDino.DapperTools.DataTypes;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace DapperDino.DapperTools.Inputs
{
    [Serializable]
    public class InputAxisVectorResponse
    {
        [SerializeField] private InputAxisVector axis = null;
        [SerializeField] private Vector2Event onAxis = null;

        public InputAxisVector Axis => axis;
        public Vector2Event OnAction => onAxis;

        [Serializable]
        public class Vector2Event : UnityEvent<SerializableVector2> { }
    }
}
