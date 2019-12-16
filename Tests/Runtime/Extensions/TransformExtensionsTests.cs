using DapperDino.DapperTools.Extensions;
using NUnit.Framework;
using UnityEngine;

namespace DapperDino.DapperTools.Tests.Extensions
{
    public class TransformExtensionsTests
    {
        [Test]
        public void TransformDirectionTo_Vector3_Test()
        {

            var source = new GameObject();
            source.transform.position = new Vector3(4f,4f,4f);
            var destination = new Vector3(1f, 1f, 1f);
            
            var fetch   = source.transform.DirectionTo(destination);
            var correct = (destination - source.transform.position);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void TransformNormalDirectionTo_Vector3_Test()
        {

            var source = new GameObject();
            source.transform.position = new Vector3(4f, 4f, 4f);
            var destination = new Vector3(1f, 1f, 1f);

            var fetch = source.transform.NormalDirectionTo(destination);
            var correct = (destination - source.transform.position).normalized;
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void TransformDirectionTo_Transform_Test()
        {
            var source = new GameObject();
            source.transform.position = new Vector3(4f, 4f, 4f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(1f, 1f, 1f);

            var fetch   = source.transform.DirectionTo(destination.transform);
            var correct = (destination.transform.position - source.transform.position);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void TransformNormalDirectionTo_Transform_Test()
        {
            var source = new GameObject();
            source.transform.position = new Vector3(4f, 4f, 4f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(1f, 1f, 1f);

            var fetch = source.transform.NormalDirectionTo(destination.transform);
            var correct = (destination.transform.position - source.transform.position).normalized;
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void TransformDirectionTo_GameObject_Test()
        {
            var source = new GameObject();
            source.transform.position = new Vector3(4f, 4f, 4f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(1f, 1f, 1f);
            
            var fetch   = source.transform.DirectionTo(destination);
            var correct = (destination.transform.position - source.transform.position);
            Assert.AreEqual(correct, fetch);
        }

        [Test]
        public void TransformNormalDirectionTo_GameObject_Test()
        {
            var source = new GameObject();
            source.transform.position = new Vector3(4f, 4f, 4f);
            var destination = new GameObject();
            destination.transform.position = new Vector3(1f, 1f, 1f);

            var fetch = source.transform.NormalDirectionTo(destination);
            var correct = (destination.transform.position - source.transform.position).normalized;
            Assert.AreEqual(correct, fetch);
        }
    }
}