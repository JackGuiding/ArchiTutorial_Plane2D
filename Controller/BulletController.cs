using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class BulletController {

        public static void Tick(GameContext ctx, float dt) {
            List<BulletEntity> all = ctx.bulletRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                BulletEntity bullet = all[i];

                // 飞行
                BulletDomain.Fly(ctx, bullet, dt);

                // 碰撞检测
                BulletDomain.CheckCollision(ctx, bullet, dt);

            }
        }

        public static void DrawAll(GameContext ctx) {
            List<BulletEntity> all = ctx.bulletRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                BulletEntity bullet = all[i];
                DrawUtil.DrawShape(bullet.shapeType, bullet.pos, bullet.size, bullet.color);
            }
        }
    }
}