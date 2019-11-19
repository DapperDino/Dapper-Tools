using System;
using UnityEngine;

namespace DapperDino.DapperTools.DataTypes
{
    [Serializable]
    public struct SerializableQuaternion
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public SerializableQuaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public override string ToString() => string.Format($"[{x}, {y}, {z}, {w}]");

        public static implicit operator Quaternion(SerializableQuaternion value) => new Quaternion(value.x, value.y, value.z, value.w);
        public static implicit operator SerializableQuaternion(Quaternion value) => new SerializableQuaternion(value.x, value.y, value.z, value.w);
    }
}
