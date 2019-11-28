using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.DapperTools.Inputs
{
    [CreateAssetMenu(fileName = "New Input Action", menuName = "Inputs/Input Action")]
    public class InputAction : ScriptableObject
    {
        [SerializeField] private InputActionReference inputAction = null;

        public bool Value => inputAction.action.triggered;
    }
}
