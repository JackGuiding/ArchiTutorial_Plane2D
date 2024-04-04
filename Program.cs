using System;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 小飞机:
    // 1. 生成飞机、移动飞机、绘制飞机
    // 2. 生成子弹、移动子弹、绘制子弹
    // 3. 子弹与飞机的关系: 发射、击中

    // 对象生成、存储、遍历
    public static class Program {

        // 每个持续程序:
        // 1. 用户输入
        // 2. 逻辑处理
        // 3. (大多数)绘制
        public static void Main() {

            Raylib.InitWindow(1280, 720, "Tutorial 2D");
            Raylib.SetTargetFPS(60);
            Raylib.SetExitKey(KeyboardKey.Null);

            // Context
            GameContext ctx = new GameContext();

            // 进入游戏
            EnterGame(ctx);

            while (!Raylib.WindowShouldClose()) {

                Raylib.BeginDrawing();

                float dt = Raylib.GetFrameTime(); // 1 / 60

                // 背景色
                Raylib.ClearBackground(Color.RayWhite);

                // 1. 用户输入
                InputController.Tick(ctx, dt);
                Raylib.DrawText($"Move: {ctx.input.moveDir}", 10, 10, 20, Color.Black);
                Raylib.DrawText($"Fire: {ctx.input.isFire}", 10, 30, 20, Color.Black);

                // 2. 飞机逻辑 / 子弹逻辑 ....
                PlaneController.Tick(ctx, dt); // 逻辑处理
                BulletController.Tick(ctx, dt);

                // 3. 画飞机 / 画子弹 ....
                PlaneController.DrawAll(ctx);
                BulletController.DrawAll(ctx);

                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();

        }

        static void EnterGame(GameContext ctx) {

            // 生成飞机
            PlaneDomain.Spawn(ctx, true, new Vector2(0, 0), 25, new Vector2(50, 50), Color.Blue);
            PlaneDomain.Spawn(ctx, false, new Vector2(100, 100), 25, new Vector2(50, 50), Color.Yellow);
            PlaneDomain.Spawn(ctx, false, new Vector2(180, 180), 25, new Vector2(50, 50), Color.Red);

            // 测试: 生成子弹
            BulletDomain.Spawn(ctx, true, new Vector2(640, 360), new Vector2(0, -1), 100, new Vector2(10, 10), Color.Black);

        }

    }
}