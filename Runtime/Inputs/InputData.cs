using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.Inputs
{
    public struct InputData
    {
        private readonly Dictionary<InputAxisFloat, InputValue<float>> axisFloatValues;
        private readonly Dictionary<InputAxisVector, InputValue<Vector2>> axisVectorValues;
        private readonly Dictionary<InputAction, InputValue<bool>> actionValues;

        public InputData(
            Dictionary<InputAxisFloat, InputValue<float>> axisFloatValues,
            Dictionary<InputAxisVector, InputValue<Vector2>> axisVectorValues,
            Dictionary<InputAction, InputValue<bool>> actionValues)
        {
            this.axisFloatValues = axisFloatValues;
            this.axisVectorValues = axisVectorValues;
            this.actionValues = actionValues;
        }

        public Vector2 GetAxisVector(InputAxisVector axis)
        {
            // Make sure the input axis exist in the dictionary
            if (axisVectorValues.TryGetValue(axis, out InputValue<Vector2> value))
            {
                // Read the value for the axis
                var axisValue = value.Value;

                // Set the value back (due to being a struct, this is necessary)
                axisVectorValues[axis] = value;

                // Return the axis value that was read
                return axisValue;
            }

            // Throw exception due to not being able to find the requested axis
            throw new KeyNotFoundException($"Input axis {axis.name} has not been registered");
        }

        public float GetAxisFloat(InputAxisFloat axis)
        {
            // Make sure the input axis exist in the dictionary
            if (axisFloatValues.TryGetValue(axis, out InputValue<float> value))
            {
                // Read the value for the axis
                var axisValue = value.Value;

                // Set the value back (due to being a struct, this is necessary)
                axisFloatValues[axis] = value;

                // Return the axis value that was read
                return axisValue;
            }

            // Throw exception due to not being able to find the requested axis
            throw new KeyNotFoundException($"Input axis {axis.name} has not been registered");
        }

        public bool GetAction(InputAction action)
        {
            // Make sure the input actions exist in the dictionary
            if (actionValues.TryGetValue(action, out InputValue<bool> value))
            {
                // Read the value for the action
                var actionValue = value.Value;

                // Set the value back (due to being a struct, this is necessary)
                actionValues[action] = value;

                // Return the action value that was read
                return actionValue;
            }

            // Throw exception due to not being able to find the requested action
            throw new KeyNotFoundException($"Input action {action.name} has not been registered");
        }
    }
}
