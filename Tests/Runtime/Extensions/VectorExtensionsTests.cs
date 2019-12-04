using DapperDino.DapperTools.Extensions;
using NUnit.Framework;
using UnityEngine;

namespace DapperDino.DapperTools.Tests.Extensions
{
    public class VectorExtensionsTests
    {
        [Test]
        public void ToVector2_ConvertsVector3ToVector2()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.ToVector2();

            Assert.AreEqual(new Vector2(1f, 1f), fetch);
        }

        [Test]
        public void Vector2ChangeX_XIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.ChangeX(2f);

            Assert.AreEqual(new Vector2(2f, 1f), fetch);
        }

        [Test]
        public void Vector2ChangeY_YIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.ChangeY(2f);

            Assert.AreEqual(new Vector2(1f, 2f), fetch);
        }

        [Test]
        public void Vector3ChangeX_XIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.ChangeX(2f);

            Assert.AreEqual(new Vector3(2f, 1f, 1f), fetch);
        }

        [Test]
        public void Vector3ChangeY_YIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.ChangeY(2f);

            Assert.AreEqual(new Vector3(1f, 2f, 1f), fetch);
        }

        [Test]
        public void Vector3ChangeZ_ZIsChanged()
        {
            var vector = new Vector3(1f, 1f, 1f);

            var fetch = vector.ChangeZ(2f);

            Assert.AreEqual(new Vector3(1f, 1f, 2f), fetch);
        }

        [Test]
        public void Vector3ChangeZFromVector2_ZIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.ChangeZ(2f);

            Assert.AreEqual(new Vector3(1f, 1f, 2f), fetch);
        }

        // Addition of Vector.With() tests
        [Test]
        public void Vector2With_XIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.With(x: 2f);

            Assert.AreEqual(new Vector2(2f, 1f), fetch);
        }

        [Test]
        public void Vector2With_YIsChanged()
        {
            var vector = new Vector2(1f, 1f);

            var fetch = vector.With(y: 2f);

            Assert.AreEqual(new Vector2(1f, 2f), fetch);
        }

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
    }
}
