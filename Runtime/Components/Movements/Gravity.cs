using UnityEngine;

namespace DapperDino.DapperTools.Components.Movements
{
    public class Gravity : IMovementModifier
    {
        private readonly CharacterController characterController;
        private readonly float magnitude;

        private float yVelocity;

        public Gravity(CharacterController characterController, float magnitude)
        {
            this.characterController = characterController;
            this.magnitude = magnitude;
        }

        public Vector3 Value { get; private set; }

        public void Tick(float deltaTime)
        {
            yVelocity += magnitude * deltaTime;

            if (characterController.isGrounded && yVelocity < 0f)
            {
                yVelocity = 0f;
                Value = new Vector3(0f, -0.1f, 0f);
                return;
            }

            Value = new Vector3(0f, yVelocity, 0f);
        }
    }
}
