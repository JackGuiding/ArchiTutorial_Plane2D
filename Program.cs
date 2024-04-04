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

            // Context
            GameContext ctx = new GameContext();

            // 生成飞机
            PlaneEntity plane = PlaneDomain.Spawn(ctx, new Vector2(0, 0), 5, new Vector2(50, 50), Color.Blue);
            PlaneEntity plane2 = PlaneDomain.Spawn(ctx, new Vector2(100, 100), 5, new Vector2(50, 50), Color.Yellow);
            PlaneEntity plane3 = PlaneDomain.Spawn(ctx, new Vector2(180, 180), 5, new Vector2(50, 50), Color.Yellow);

            while (!Raylib.WindowShouldClose()) {

                Raylib.BeginDrawing();

                // 背景色
                Raylib.ClearBackground(Color.RayWhite);

                // 画飞机
                // 遍历
                List<PlaneEntity> allPlane = ctx.planeRepository.GetAll();
                for (int i = 0; i < allPlane.Count; i += 1) {
                    PlaneEntity p = allPlane[i];
                    Raylib.DrawRectangleV(p.pos, p.size, p.color);
                }

                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();

        }
    }
}