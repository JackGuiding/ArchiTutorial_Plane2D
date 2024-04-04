using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class PlaneController {

        public static void Tick(GameContext ctx, float dt) {

            List<PlaneEntity> all = ctx.planeRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                PlaneEntity plane = all[i];

                // 根据输入移动
                PlaneDomain.MoveByInput(ctx, plane, dt);

                // 自动移动
                // PlaneDomain.AutoMove(plane, dt);

                // 发射子弹

                // 碰撞检测

            }
        }

        public static void DrawAll(GameContext ctx) {
            List<PlaneEntity> all = ctx.planeRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                PlaneEntity plane = all[i];
                Raylib.DrawRectangleV(plane.pos, plane.size, plane.color);
            }
        }

    }
}