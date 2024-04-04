using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class InputController {

        public static void Tick(GameContext ctx, float dt) {

            InputEntity input = ctx.input;

            // Raylib.IsKeyDown(KeyboardKey.A); 按住
            // Raylib.IsKeyUp(KeyboardKey.A); 没按住
            // Raylib.IsKeyPressed(KeyboardKey.A); 按下
            // Raylib.IsKeyReleased(KeyboardKey.A); 弹起

            // if 里必须是 bool
            Vector2 moveDirTmp = Vector2.Zero;
            if (Raylib.IsKeyDown(KeyboardKey.A)) {
                moveDirTmp.X = -1;
            } else if (Raylib.IsKeyDown(KeyboardKey.D)) {
                moveDirTmp.X = 1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.W)) {
                moveDirTmp.Y = -1;
            } else if (Raylib.IsKeyDown(KeyboardKey.S)) {
                moveDirTmp.Y = 1;
            }

            input.moveDir = moveDirTmp;

        }

    }
}