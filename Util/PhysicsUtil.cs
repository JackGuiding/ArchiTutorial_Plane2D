using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class PhysicsUtil {

        public static bool CheckCollision(ShapeType aShape, Vector2 aCenter, Vector2 aSize, ShapeType bShape, Vector2 bCenter, Vector2 bSize) {
            if (aShape == ShapeType.Circle && bShape == ShapeType.Circle) {
                // 圆和圆
                return Raylib.CheckCollisionCircles(aCenter, aSize.X, bCenter, bSize.X);
            } else if (aShape == ShapeType.Rectangle && bShape == ShapeType.Rectangle) {
                // 矩形 和 矩形
                Rectangle aRec = new Rectangle(aCenter - aSize / 2, aSize);
                Rectangle bRec = new Rectangle(bCenter - bSize / 2, bSize);
                return Raylib.CheckCollisionRecs(aRec, bRec);
            } else if (aShape == ShapeType.Rectangle && bShape == ShapeType.Circle) {
                // 矩形 和 圆
                Rectangle aRec = new Rectangle(aCenter - aSize / 2, aSize);
                return Raylib.CheckCollisionCircleRec(bCenter, bSize.X, aRec);
            } else if (aShape == ShapeType.Circle && bShape == ShapeType.Rectangle) {
                // 圆 和 矩形
                Rectangle bRec = new Rectangle(bCenter - bSize / 2, bSize);
                return Raylib.CheckCollisionCircleRec(aCenter, aSize.X, bRec);
            } else {
                System.Console.WriteLine($"未知的碰撞检测类型a:{aShape} b:{bShape}");
                return false;
            }
        }

    }
}