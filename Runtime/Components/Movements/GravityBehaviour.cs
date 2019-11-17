using UnityEngine;

namespace DapperDino.DapperTools.Components.Movements
{
    public class GravityBehaviour : MonoBehaviour
    {
        [SerializeField] private MovementBehaviour movementBehaviour;
        [SerializeField] private CharacterController controller;

        private Gravity gravity;
        private Gravity Gravity
        {
            get
            {
                if (gravity != null) { return gravity; }
                gravity = new Gravity(controller, Physics.gravity.y);
                return gravity;
            }
        }

        private void OnEnable() => movementBehaviour.Movement.AddModifier(Gravity);
        private void OnDisable() => movementBehaviour.Movement.RemoveModifier(Gravity);
        private void Update() => Gravity.Tick(Time.deltaTime);
    }
}
