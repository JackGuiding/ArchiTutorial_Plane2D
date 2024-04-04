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

            // 矢量
            plane.pos += moveDir * plane.moveSpeed * dt;

        }

        public static void AutoMove(PlaneEntity plane, float dt) {
            plane.pos.X += plane.moveSpeed * dt;
        }

    }
}