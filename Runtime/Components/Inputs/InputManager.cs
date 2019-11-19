using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.DapperTools.Components.Inputs
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputActionAsset inputAsset = null;
        [SerializeField] private List<InputAxis> inputAxes = new List<InputAxis>();
        [SerializeField] private List<InputAction> inputActions = new List<InputAction>();

        private static readonly List<InputReceiver> receivers = new List<InputReceiver>();

        private readonly Dictionary<InputAxis, InputValue<Vector2>> axisValues = new Dictionary<InputAxis, InputValue<Vector2>>();
        private readonly Dictionary<InputAction, InputValue<bool>> actionValues = new Dictionary<InputAction, InputValue<bool>>();

        private void OnEnable() => inputAsset.Enable();
        private void Update() => HandleInput();
        private void OnDisable() => inputAsset.Disable();

        public static void AddReceiver(InputReceiver receiver)
        {
            int index = receivers.BinarySearch(receiver, new ByPriority());
            if (index < 0) { index = ~index; }
            receivers.Insert(index, receiver);
        }

        public static void RemoveReceiver(InputReceiver receiver)
        {
            receivers.Remove(receiver);
        }

        private void HandleInput()
        {
            var inputData = GetInputData();

            foreach (var receiver in receivers)
            {
                inputData = receiver.ProcessInput(inputData);
            }
        }

        private InputData GetInputData()
        {
            FillAxisValues();
            FillActionValues();

            return new InputData(axisValues, actionValues);
        }

        private void FillAxisValues()
        {
            foreach (var axis in inputAxes)
            {
                axisValues[axis] = new InputValue<Vector2>(axis.GetValue());
            }
        }

        private void FillActionValues()
        {
            foreach (var action in inputActions)
            {
                actionValues[action] = new InputValue<bool>(action.Value);
            }
        }

        private class ByPriority : IComparer<InputReceiver>
        {
            public int Compare(InputReceiver x, InputReceiver y)
            {
                if (x.Priority > y.Priority) { return -1; }
                if (x.Priority < y.Priority) { return 1; }
                return 0;
            }
        }
    }
}
