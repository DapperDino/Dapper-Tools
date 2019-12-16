using DapperDino.DapperTools.Extensions;
using UnityEngine;
using NUnit.Framework;

namespace DapperDino.DapperTools.Tests.Extensions
{

    public class Vector3ExtensionsTests
    {
        [Test]
        public void Vector3With_XIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(x: 2f);

            Assert.AreEqual(new Vector3(2f, 1f, 1f), fetch);
        }

        [Test]
        public void Vector3With_YIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(y: 2f);

            Assert.AreEqual(new Vector3(1f, 2f, 1f), fetch);
        }

        [Test]
        public void Vector3With_ZIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(z: 2f);

            Assert.AreEqual(new Vector3(1f, 1f, 2f), fetch);
        }

        [Test]
        public void Vector3With_YZIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(y: 2f, z: 2f);

            Assert.AreEqual(new Vector3(1f, 2f, 2f), fetch);
        }

        [Test]
        public void Vector3With_XZIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(x: 2f, z: 2f);

            Assert.AreEqual(new Vector3(2f, 1f, 2f), fetch);
        }

        [Test]
        public void Vector3With_XYIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(x: 2f, y: 2f);

            Assert.AreEqual(new Vector3(2f, 2f, 1f), fetch);
        }

        [Test]
        public void Vector3With_XYZIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.With(x: 2f, y: 2f, z: 2f);

            Assert.AreEqual(new Vector3(2f, 2f, 2f), fetch);
        }

        [Test]
        public void Vector3DirectionTo_Vector3_Vector3_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new Vector3(4f, 4f, 4f);
            var fetch = source.DirectionTo(destination);

            var correct = (destination - source);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3NormalDirectionTo_Vector3_Vector3_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new Vector3(4f, 4f, 4f);
            var fetch = source.NormalDirectionTo(destination);

            var correct = (destination - source).normalized;
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3DirectionTo_Vector3_Transform_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 4f);

            var fetch = source.DirectionTo(destination.transform);

            var correct = (destination.transform.position - source);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3NormalDirectionTo_Vector3_Transform_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new GameObject();
            var fetch = source.NormalDirectionTo(destination.transform);

            var correct = (destination.transform.position - source).normalized;
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3DirectionTo_Vector3_GameObject_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 0f);

            var fetch = source.DirectionTo(destination);

            var correct = (destination.transform.position - source);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3NormalDirectionTo_Vector3_GameObject_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 4f);

            var fetch = source.NormalDirectionTo(destination);
            var correct = (destination.transform.position - source).normalized;

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3DistanceTo_Vector3_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new Vector3(4f, 4f, 4f);

            var fetch = source.DistanceTo(destination);

            var correct = Vector3.Distance(destination, source);

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3DistanceTo_Transfrom_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 4f);

            var fetch = source.DistanceTo(destination.transform);
            var correct = Vector3.Distance(destination.transform.position, source);

            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void Vector3DistanceTo_GameObject_Test()
        {
            var source = new Vector3(1f, 1f, 1f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(4f, 4f, 4f);

            var fetch = source.DistanceTo(destination);
            var correct = Vector3.Distance(destination.transform.position, source);

            Assert.AreEqual(correct, fetch);
        }
    }
}