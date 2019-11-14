using DapperDino.DapperTools.Extensions;
using NUnit.Framework;
using UnityEngine;

namespace DapperDino.DapperTools.Tests.Extensions
{
    public class GameObjectExtensionsTests
    {
        [Test]
        public void GetOrAddComponentWithComponentAlreadyAdded_ComponentIsRetrieved()
        {
            var gameObject = new GameObject();
            var rb = gameObject.AddComponent<Rigidbody>();

            var fetch = gameObject.GetOrAddComponent<Rigidbody>();

            Assert.AreSame(rb, fetch);
        }

        [Test]
        public void GetOrAddComponentWithComponentNotAlreadyAttatched_ComponentAdded()
        {
            var gameObject = new GameObject();

            _ = gameObject.GetOrAddComponent<Rigidbody>();

            Assert.IsTrue(gameObject.HasComponent<Rigidbody>());
        }

        [Test]
        public void HasComponentWithComponent_ReturnsTrue()
        {
            var gameObject = new GameObject();

            _ = gameObject.AddComponent<Rigidbody>();

            Assert.IsTrue(gameObject.HasComponent<Rigidbody>());
        }

        [Test]
        public void HasComponentWithoutComponent_ReturnsFalse()
        {
            var gameObject = new GameObject();

            Assert.IsFalse(gameObject.HasComponent<Rigidbody>());
        }
    }
}
