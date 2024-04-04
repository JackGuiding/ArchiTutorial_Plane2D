using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class PlaneController {

        public static void Tick(GameContext ctx, float dt) {

            List<PlaneEntity> all = ctx.planeRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                PlaneEntity plane = all[i];

                if (plane.isPlayer) {
                    // 根据输入移动
                    PlaneDomain.MoveByInput(ctx, plane, dt);
                    PlaneDomain.FireByInput(ctx, plane);
                } else {
                    // 自动移动
                    PlaneDomain.AutoMove(plane, dt);
                }

                // 发射子弹

                // 碰撞检测

            }
        }

        public static void DrawAll(GameContext ctx) {
            List<PlaneEntity> all = ctx.planeRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                PlaneEntity plane = all[i];
                DrawUtil.DrawShape(plane.shapeType, plane.pos, plane.size, plane.color);
            }
        }

    }
}