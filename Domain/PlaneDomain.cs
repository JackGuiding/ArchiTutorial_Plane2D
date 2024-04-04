using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 飞机逻辑
    public static class PlaneDomain {

        public static PlaneEntity Spawn(GameContext ctx, bool isPlayer, Vector2 pos, float moveSpeed, Vector2 size, Color color) {
            PlaneEntity plane = GameFactory.Plane_Create(ctx.idService, isPlayer, pos, moveSpeed, size, color);
            ctx.planeRepository.Add(plane);
            return plane;
        }

        public static void MoveByInput(GameContext ctx, PlaneEntity plane, float dt) {

            InputEntity input = ctx.input;
            Vector2 moveDir = input.moveDir;

            // 单个数值
            // plane.pos.X += moveDir.X * plane.moveSpeed * dt;
            // plane.pos.Y += moveDir.Y * plane.moveSpeed * dt;

            plane.Move(moveDir, dt);

        }

        public static void AutoMove(PlaneEntity plane, float dt) {
            // 自动向右
            Vector2 moveDir = new Vector2(1, 0);
            plane.Move(moveDir, dt);
        }

        public static void Fire(GameContext ctx, PlaneEntity plane) {
            // 数据建模: 
            // 从哪里: plane.pos
            // 到哪里: plane.faceDir 一个方向, (一个目标)
        }

    }
}