using Assets.Dapper_Tools.Runtime.Components.Inputs;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.Components.Inputs
{
    public class InputReceiver : MonoBehaviour
    {
        [SerializeField] private int priority = 0;
        [SerializeField] private List<InputAxisResponse> axisResponses = new List<InputAxisResponse>();
        [SerializeField] private List<InputActionResponse> actionResponses = new List<InputActionResponse>();

        public int Priority => priority;

        private void OnEnable() => InputManager.AddReceiver(this);
        private void OnDisable() => InputManager.RemoveReceiver(this);

        public InputData ProcessInput(InputData inputData)
        {
            // Raise an event with the axis values for all of the axis responses
            foreach (var axisResponse in axisResponses)
            {
                axisResponse.OnAction.Invoke(inputData.GetAxis(axisResponse.Axis));
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
