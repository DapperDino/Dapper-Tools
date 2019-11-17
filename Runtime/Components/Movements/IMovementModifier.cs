using UnityEngine;

namespace DapperDino.DapperTools.Components.Movements
{
    public interface IMovementModifier
    {
        Vector3 Value { get; }
    }
}
