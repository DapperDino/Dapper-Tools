using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.Components.Movements
{
    public class Movement
    {
        private readonly CharacterController controller;
        private readonly List<IMovementModifier> modifiers = new List<IMovementModifier>();

        public Movement(CharacterController controller) => this.controller = controller;

        public void Tick(float deltaTime)
        {
            // Initiate this frame's movement to be zero (0, 0, 0)
            var movement = Vector3.zero;

            // Add on each modifier's movement value
            foreach (var modifier in modifiers)
            {
                movement += modifier.Value;
            }

            // Move the character controller by the calculated movement
            controller.Move(movement * deltaTime);
        }

        public void AddModifier(IMovementModifier modifier) => modifiers.Add(modifier);
        public void RemoveModifier(IMovementModifier modifier) => modifiers.Remove(modifier);
    }
}
