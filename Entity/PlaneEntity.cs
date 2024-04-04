using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 飞机
    public class PlaneEntity {

        // Logic
        public Vector2 pos;
        public float moveSpeed;
        public Vector2 size;

        // Draw
        public Color color;

        public PlaneEntity() {
            // 所有默认值都是0
        }

    }

}