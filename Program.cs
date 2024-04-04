using System;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 小飞机:
    // 1. 生成飞机、移动飞机、绘制飞机
    // 2. 生成子弹、移动子弹、绘制子弹
    // 3. 子弹与飞机的关系

    // 对象生成、存储、遍历
    public static class Program {

        public static void Main() {

            Raylib.InitWindow(800, 450, "Tutorial 2D");

            // 生成飞机
            PlaneEntity plane = GameFactory.Plane_Create(new Vector2(0, 0), 5, new Vector2(50, 50), Color.Blue);

            while (!Raylib.WindowShouldClose()) {

                Raylib.BeginDrawing();

                // 背景色
                Raylib.ClearBackground(Color.RayWhite);

                // 画飞机
                Raylib.DrawRectangleV(plane.pos, plane.size, plane.color);

                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();

        }
    }
}