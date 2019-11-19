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
            if (axisValues.TryGetValue(axis, out InputValue<Vector2> value))
            {
                var axisValue = value.Value;
                axisValues[axis] = value;
                return axisValue;
            }

            return Vector2.zero;
        }

        public bool GetAction(InputAction action)
        {
            if (actionValues.TryGetValue(action, out InputValue<bool> value))
            {
                var actionValue = value.Value;
                actionValues[action] = value;
                return actionValue;
            }

            return false;
        }
    }
}
