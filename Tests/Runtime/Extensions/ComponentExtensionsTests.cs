using DapperDino.DapperTools.Extensions;
using NUnit.Framework;
using UnityEngine;

namespace DapperDino.DapperTools.Tests.Extensions
{
    public class ComponentExtensionsTests
    {
        [Test]
        public void AddComponentToComponent_ComponentIsAdded()
        {
            var gameObject = new GameObject();
            var rb = gameObject.AddComponent<Rigidbody>();

            rb.AddComponent<BoxCollider>();

            Assert.IsTrue(rb.HasComponent<BoxCollider>());
        }

        [Test]
        public void GetOrAddComponentWithComponentAlreadyAdded_ComponentIsRetrieved()
        {
            var gameObject = new GameObject();
            var rb = gameObject.AddComponent<Rigidbody>();

            var fetch = rb.GetOrAddComponent<Rigidbody>();

            Assert.AreSame(rb, fetch);
        }

        [Test]
        public void GetOrAddComponentWithComponentNotAlreadyAttatched_ComponentAdded()
        {
            var gameObject = new GameObject();
            var rb = gameObject.AddComponent<Rigidbody>();

            _  = rb.GetOrAddComponent<BoxCollider>();

            var components = rb.gameObject.GetComponents(typeof(Component));

            Assert.IsTrue(rb.HasComponent<BoxCollider>());
        }

        [Test]
        public void HasComponentWithComponent_ReturnsTrue()
        {
            var gameObject = new GameObject();
            var rb = gameObject.AddComponent<Rigidbody>();

            _ = rb.AddComponent<BoxCollider>();

            Assert.IsTrue(rb.HasComponent<BoxCollider>());
        }

        [Test]
        public void HasComponentWithoutComponent_ReturnsFalse()
        {
            var gameObject = new GameObject();
            var rb = gameObject.AddComponent<Rigidbody>();

            Assert.IsFalse(rb.HasComponent<BoxCollider>());
        }
    }
}
