using DapperDino.DapperTools.Components.Inputs;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Dapper_Tools.Runtime.Components.Inputs
{
    [Serializable]
    public class InputActionResponse
    {
        [SerializeField] private InputAction action = null;
        [SerializeField] private UnityEvent onAction = null;

        public InputAction Action => action;
        public UnityEvent OnAction => onAction;
    }
}
