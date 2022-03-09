
using ECS;
using System.Numerics;

namespace DataPacking.Components.WorldObjects
{
    public class TransformComponent : Component
    {
        public Vector2 Position;
        public Quaternion Rotation;
    }
}
