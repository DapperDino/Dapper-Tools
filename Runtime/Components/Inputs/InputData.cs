using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.Components.Inputs
{
    public struct InputData
    {
        private readonly Dictionary<InputAxis, InputValue<Vector2>> axisValues;
        private readonly Dictionary<InputAction, InputValue<bool>> actionValues;

        public InputData(
            Dictionary<InputAxis, InputValue<Vector2>> axisValues,
            Dictionary<InputAction, InputValue<bool>> actionValues)
        {
            this.axisValues = axisValues;
            this.actionValues = actionValues;
        }

        public Vector2 GetAxis(InputAxis axis)
        {
            // Make sure the input axis exist in the dictionary
            if (axisValues.TryGetValue(axis, out InputValue<Vector2> value))
            {
                // Read the value for the axis
                var axisValue = value.Value;

                // Set the value back (due to being a struct, this is necessary)
                axisValues[axis] = value;

                // Return the axis value that was read
                return axisValue;
            }

            // Return zero due to not being able to find the requested axis
            return Vector2.zero;
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

            // Return false due to not being able to find the requested action
            return false;
        }
    }
}
