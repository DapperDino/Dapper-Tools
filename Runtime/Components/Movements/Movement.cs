using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.Components.Movements
{
    public class Movement
    {
        private readonly CharacterController controller;
        private readonly List<IMovementModifier> modifiers;

        public Movement(CharacterController controller)
        {
            this.controller = controller;
            modifiers = new List<IMovementModifier>();
        }

        public void Tick(float deltaTime)
        {
            Vector3 movement = Vector3.zero;

            foreach (var modifier in modifiers)
            {
                movement += modifier.Value;
            }

            controller.Move(movement * deltaTime);
        }

        public void AddModifier(IMovementModifier modifier) => modifiers.Add(modifier);
        public void RemoveModifier(IMovementModifier modifier) => modifiers.Remove(modifier);
    }
}
