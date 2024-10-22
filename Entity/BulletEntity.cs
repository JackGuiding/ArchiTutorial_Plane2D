using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 子弹
    public class BulletEntity {

        public int id;
        public bool isPlayer;
        public Vector2 pos;
        public Vector2 moveDir; // Direction
        public float moveSpeed;

        public ShapeType shapeType;
        public Vector2 size;

        public Color color;

        public BulletEntity() { }

        public void DrawShape() {
            DrawUtil.DrawShape(shapeType, pos, size, color);
        }

    }

}