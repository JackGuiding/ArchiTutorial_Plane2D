using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 飞机
    public class PlaneEntity {

        // Logic
        public int id;
        public bool isPlayer;
        public Vector2 pos;
        public float moveSpeed;
        public Vector2 faceDir;

        public ShapeType shapeType;
        public Vector2 size;

        // Draw
        public Color color;

        public PlaneEntity() {
            // 所有默认值都是0
        }

        public void Move(Vector2 dir, float dt) {
            pos += dir * moveSpeed * dt;
            if (dir != Vector2.Zero) {
                faceDir = dir;
            }
        }

    }

}