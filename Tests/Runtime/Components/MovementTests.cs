using DapperDino.DapperTools.Components.Movements;
using Moq;
using NUnit.Framework;
using UnityEngine;

namespace DapperDino.DapperTools.Tests.Components
{
    public class MovementTests
    {
        [Test]
        public void OneModifierIsAdded_ControllerMovesCorrectly()
        {
            var controller = new GameObject().AddComponent<CharacterController>();
            var movement = new Movement(controller);

            var mock = new Mock<IMovementModifier>();
            mock.Setup(x => x.Value).Returns(new Vector3(1f, 1f, 1f));

            movement.AddModifier(mock.Object);
            movement.Tick(1f);

            Assert.AreEqual(new Vector3(1f, 1f, 1f), controller.transform.position);

            Object.DestroyImmediate(controller.gameObject);
        }

        [Test]
        public void MultipleModifiersAreAdded_ControllerMovesCorrectly()
        {
            var controller = new GameObject().AddComponent<CharacterController>();
            var movement = new Movement(controller);

            var mockOne = new Mock<IMovementModifier>();
            mockOne.Setup(x => x.Value).Returns(new Vector3(1f, 1f, 1f));

            var mockTwo = new Mock<IMovementModifier>();
            mockTwo.Setup(x => x.Value).Returns(new Vector3(4f, -3f, 7f));

            movement.AddModifier(mockOne.Object);
            movement.AddModifier(mockTwo.Object);

            movement.Tick(1f);

            Assert.AreEqual(new Vector3(5f, -2f, 8f), controller.transform.position);

            Object.DestroyImmediate(controller.gameObject);
        }

        [Test]
        public void GravityTicksOne_ValueIsCorrect()
        {
            var controller = new GameObject().AddComponent<CharacterController>();
            var gravity = new Gravity(controller, -1f);

            gravity.Tick(1f);

            Assert.AreEqual(new Vector3(0f, -1f, 0f), gravity.Value);

            Object.DestroyImmediate(controller.gameObject);
        }

        [Test]
        public void GravityTicksMultipleTimes_ValueIsCorrect()
        {
            var controller = new GameObject().AddComponent<CharacterController>();
            var gravity = new Gravity(controller, -1f);

            gravity.Tick(1f);
            gravity.Tick(1f);

            Assert.AreEqual(new Vector3(0f, -2f, 0f), gravity.Value);

            Object.DestroyImmediate(controller.gameObject);
        }

        [Test]
        public void GravityAsModifierTicksOnce_ControllerMovesCorrectly()
        {
            var controller = new GameObject().AddComponent<CharacterController>();
            var movement = new Movement(controller);
            var gravity = new Gravity(controller, -1f);

            movement.AddModifier(gravity);

            gravity.Tick(1f);
            movement.Tick(1f);

            Assert.AreEqual(new Vector3(0f, -1f, 0f), controller.transform.position);

            Object.DestroyImmediate(controller.gameObject);
        }

        [Test]
        public void GravityAsModifierTicksMultipleTimes_ControllerMovesCorrectly()
        {
            var controller = new GameObject().AddComponent<CharacterController>();
            var movement = new Movement(controller);
            var gravity = new Gravity(controller, -1f);

            movement.AddModifier(gravity);

            gravity.Tick(1f);
            movement.Tick(1f);
            gravity.Tick(1f);
            movement.Tick(1f);

            Assert.AreEqual(new Vector3(0f, -3f, 0f), controller.transform.position);

            Object.DestroyImmediate(controller.gameObject);
        }
    }
}
