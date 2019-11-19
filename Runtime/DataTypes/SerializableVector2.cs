using System;
using UnityEngine;

namespace DapperDino.DapperTools.DataTypes
{
    [Serializable]
    public struct SerializableVector2
    {
        public float x;
        public float y;

        public SerializableVector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => string.Format($"[{x}, {y}]");

        public static implicit operator Vector2(SerializableVector2 value) => new Vector2(value.x, value.y);
        public static implicit operator SerializableVector2(Vector2 value) => new SerializableVector2(value.x, value.y);
    }
}
