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
            // Increase yVelocity due to acceleration
            yVelocity += magnitude * deltaTime;

            // If we are on the ground but also have a negative yVelocity
            if (characterController.isGrounded && yVelocity < 0f)
            {
                // Stop the yVelocity from decreasing any further
                yVelocity = 0f;

                // Store our value as no movement
                // I use -0.1f to keep the controller on the ground due to some inconsistency with ground detection in Unity
                Value = new Vector3(0f, -0.1f, 0f);

                // We have finished calculating our movement value since we are on the ground
                return;
            }

            // Store our value as our current yVelocity
            Value = new Vector3(0f, yVelocity, 0f);
        }
    }
}
