using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.DapperTools.Inputs
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputActionAsset inputAsset = null;
        [SerializeField] private List<InputAxisFloat> inputAxesFloats = new List<InputAxisFloat>();
        [SerializeField] private List<InputAxisVector> inputAxesVectors = new List<InputAxisVector>();
        [SerializeField] private List<InputAction> inputActions = new List<InputAction>();

        private static readonly List<InputReceiver> receivers = new List<InputReceiver>();

        private readonly Dictionary<InputAxisFloat, InputValue<float>> axisFloatValues = new Dictionary<InputAxisFloat, InputValue<float>>();
        private readonly Dictionary<InputAxisVector, InputValue<Vector2>> axisVectorValues = new Dictionary<InputAxisVector, InputValue<Vector2>>();
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
            FillAxisFloatValues();
            FillAxisVectorValues();
            FillActionValues();

            // Return an instance of InputData with this frame's input values
            return new InputData(axisFloatValues, axisVectorValues, actionValues);
        }

        private void FillAxisFloatValues()
        {
            // Read all the the axis values
            foreach (var axis in inputAxesFloats)
            {
                axisFloatValues[axis] = new InputValue<float>(axis.GetValue());
            }
        }

        private void FillAxisVectorValues()
        {
            // Read all the the axis values
            foreach (var axis in inputAxesVectors)
            {
                axisVectorValues[axis] = new InputValue<Vector2>(axis.GetValue());
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
