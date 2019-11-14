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
    }
}
