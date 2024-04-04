using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    // 飞机逻辑
    public static class PlaneDomain {

        public static PlaneEntity Spawn(GameContext ctx, bool isPlayer, Vector2 pos, float moveSpeed, ShapeType shapeType, Vector2 size, Color color) {
            PlaneEntity plane = GameFactory.Plane_Create(ctx.idService, isPlayer, pos, moveSpeed, shapeType, size, color);
            ctx.planeRepository.Add(plane);
            return plane;
        }

        public static void Unspawn(GameContext ctx, PlaneEntity plane) {
            // 移除后, 循环就访问不到了
            ctx.planeRepository.Remove(plane);
        }

        public static void MoveByInput(GameContext ctx, PlaneEntity plane, float dt) {

            InputEntity input = ctx.input;
            Vector2 moveDir = input.moveDir;

            // (1, 1) => (0.7, 0.7)
            moveDir = Raymath.Vector2Normalize(moveDir);

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

        public static void FireByInput(GameContext ctx, PlaneEntity plane) {
            // 数据建模: 
            // 从哪里: plane.pos
            // 到哪里: plane.faceDir 一个方向, (一个目标)

            InputEntity input = ctx.input;
            if (input.isFire) {
                // 发射子弹
                Vector2 from = plane.pos;
                BulletDomain.Spawn(ctx, plane.isPlayer, from, plane.faceDir, 50, ShapeType.Circle, new Vector2(10, 10), Color.Red);
            }
        }

    }
}