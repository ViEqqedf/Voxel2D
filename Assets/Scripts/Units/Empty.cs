using UnityEngine;

namespace Voxel2D {
    public class Empty : BaseUnit {
        public Empty() : base(UnitType.Empty) {
            color = Color.black;
        }
    }
}