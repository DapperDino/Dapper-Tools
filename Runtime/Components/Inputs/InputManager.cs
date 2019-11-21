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
            // Add the receiver in priority order
            int index = receivers.BinarySearch(receiver, new ByPriority());
            if (index < 0) { index = ~index; }
            receivers.Insert(index, receiver);
        }

        public static void RemoveReceiver(InputReceiver receiver) => receivers.Remove(receiver);

        private void HandleInput()
        {
            // Get the input data for this frame
            var inputData = GetInputData();

            // Let each receiver (in priority order) process the input data
            foreach (var receiver in receivers)
            {
                inputData = receiver.ProcessInput(inputData);
            }
        }

        private InputData GetInputData()
        {
            // Read all of the input that we care about
            FillAxisValues();
            FillActionValues();

            // Return an instance of InputData with this frame's input values
            return new InputData(axisValues, actionValues);
        }

        private void FillAxisValues()
        {
            // Read all the the axis values
            foreach (var axis in inputAxes)
            {
                axisValues[axis] = new InputValue<Vector2>(axis.GetValue());
            }
        }

        private void FillActionValues()
        {
            // Read all the the action values
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
