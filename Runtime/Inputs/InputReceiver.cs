using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.Inputs
{
    public class InputReceiver : MonoBehaviour
    {
        [SerializeField] private int priority = 0;
        [SerializeField] private List<InputAxisFloatResponse> axisFloatResponses = new List<InputAxisFloatResponse>();
        [SerializeField] private List<InputAxisVectorResponse> axisVectorResponses = new List<InputAxisVectorResponse>();
        [SerializeField] private List<InputActionResponse> actionResponses = new List<InputActionResponse>();

        public int Priority => priority;

        private void OnEnable() => InputManager.AddReceiver(this);
        private void OnDisable() => InputManager.RemoveReceiver(this);

        public InputData ProcessInput(InputData inputData)
        {
            // Raise an event with the axis values for all of the float axis responses
            foreach (var axisResponse in axisFloatResponses)
            {
                axisResponse.OnAction.Invoke(inputData.GetAxisFloat(axisResponse.Axis));
            }

            // Raise an event with the axis values for all of the vector axis responses
            foreach (var axisResponse in axisVectorResponses)
            {
                axisResponse.OnAction.Invoke(inputData.GetAxisVector(axisResponse.Axis));
            }

            // Raise an event for each of the action responses that had their action triggered this frame
            foreach (var actionResponse in actionResponses)
            {
                if (inputData.GetAction(actionResponse.Action))
                {
                    actionResponse.OnAction.Invoke();
                }
            }

            // Return the input data to be passed onto the next input receiver
            return inputData;
        }
    }
}
