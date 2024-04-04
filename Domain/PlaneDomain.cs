using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class PlaneDomain {

        public static PlaneEntity Spawn(GameContext ctx, Vector2 pos, float moveSpeed, Vector2 size, Color color) {
            PlaneEntity plane = GameFactory.Plane_Create(ctx.idService, pos, moveSpeed, size, color);
            ctx.planeRepository.Add(plane);
            return plane;
        }

    }
}