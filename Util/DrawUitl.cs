using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class DrawUtil {

        public static void DrawShape(ShapeType shapeType, Vector2 pos, Vector2 size, Color color) {
            if (shapeType == ShapeType.Circle) {
                Raylib.DrawCircleV(pos, size.X, color);
            } else if (shapeType == ShapeType.Rectangle) {
                pos -= size / 2;
                Raylib.DrawRectangleV(pos, size, color);
            }
        }
    }
}