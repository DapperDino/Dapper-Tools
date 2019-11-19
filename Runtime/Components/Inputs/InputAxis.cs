using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.DapperTools.Components.Inputs
{
    [CreateAssetMenu(fileName = "New Input Axis", menuName = "Inputs/Input Axis")]
    public class InputAxis : ScriptableObject
    {
        [SerializeField] private InputActionReference inputAction = null;

        public Vector2 GetValue() => inputAction.action.ReadValue<Vector2>();
    }
}
