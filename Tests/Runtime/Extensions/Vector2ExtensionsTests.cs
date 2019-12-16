using DapperDino.DapperTools.Extensions;
using UnityEngine;
using NUnit.Framework;

namespace DapperDino.DapperTools.Tests.Extensions
{

    public class Vector2ExtensionsTests
    {
        [Test]
        public void Vector2DirectionTo_Vector2_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new Vector2(4f, 4f);
            var fetch = source.DirectionTo(destination);

            var correct = (destination - source);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2NormalDirectionTo_Vector2_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new Vector2(4f, 4f);
            var fetch = source.NormalDirectionTo(destination);

            var correct = (destination - source).normalized;
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2DirectionTo_Transform_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 0f);

            var fetch = source.DirectionTo(destination.transform);

            var correct = ((Vector2)destination.transform.position - source);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2NormalDirectionTo_Transform_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new GameObject();
            var fetch = source.NormalDirectionTo(destination.transform);

            var correct = ((Vector2)destination.transform.position - source).normalized;
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2DirectionTo_GameObject_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 0f);

            var fetch = source.DirectionTo(destination);

            var correct = ((Vector2)destination.transform.position - source);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2NormalDirectionTo_GameObject_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f,4f,0f);

            var fetch   = source.NormalDirectionTo(destination);
            var correct = ((Vector2)destination.transform.position - source).normalized;

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2DistanceTo_Vector2_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new Vector2(4f, 4f);

            var fetch = source.DistanceTo(destination);

            var correct = Vector2.Distance(destination, source);

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2DistanceTo_Transfrom_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 0f);

            var fetch   = source.DistanceTo(destination.transform);
            var correct = Vector2.Distance(destination.transform.position, source);

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2DistanceTo_GameObject_Test()
        {
            var source = new Vector2(1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 0f);

            var fetch   = source.DistanceTo(destination);
            var correct = Vector2.Distance(destination.transform.position, source);

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector2With_XIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.With(x:2f);

            Assert.AreEqual(new Vector2(2f, 1f), fetch);
        }

        [Test]
        public void Vector2With_YIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.With(y:2f);

            Assert.AreEqual(new Vector2(1f, 2f), fetch);
        }
    }
}