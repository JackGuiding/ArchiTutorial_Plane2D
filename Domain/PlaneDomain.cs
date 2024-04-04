using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 飞机逻辑
    public static class PlaneDomain {

        public static PlaneEntity Spawn(GameContext ctx, Vector2 pos, float moveSpeed, Vector2 size, Color color) {
            PlaneEntity plane = GameFactory.Plane_Create(ctx.idService, pos, moveSpeed, size, color);
            ctx.planeRepository.Add(plane);
            return plane;
        }

        public static void AutoMove(PlaneEntity plane, float dt) {
            plane.pos.X += plane.moveSpeed * dt;
        }

    }
}