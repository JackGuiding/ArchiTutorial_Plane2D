using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class BulletDomain {

        public static BulletEntity Spawn(GameContext ctx, bool isPlayer, Vector2 pos, Vector2 moveDir, float moveSpeed, ShapeType shapeType, Vector2 size, Color color) {
            BulletEntity bullet = GameFactory.Bullet_Create(ctx.idService, isPlayer, pos, moveDir, moveSpeed, shapeType, size, color);
            ctx.bulletRepository.Add(bullet);
            return bullet;
        }

        public static void Unspawn(GameContext ctx, BulletEntity bullet) {
            ctx.bulletRepository.Remove(bullet);
        }

        public static void Fly(GameContext ctx, BulletEntity bullet, float dt) {
            bullet.pos += bullet.moveDir * bullet.moveSpeed * dt;
            // bullet.pos = bullet.pos + bullet.moveDir * bullet.moveSpeed * dt;
        }

        public static void CheckCollision(GameContext ctx, BulletEntity bullet, float dt) {
            List<PlaneEntity> planes = ctx.planeRepository.GetAll();
            for (int i = 0; i < planes.Count; i += 1) {
                PlaneEntity plane = planes[i];
                bool isCollision = PhysicsUtil.CheckCollision(bullet.shapeType, bullet.pos, bullet.size, plane.shapeType, plane.pos, plane.size);
                if (isCollision) {
                    
                    if (plane.isPlayer == bullet.isPlayer) {
                        continue;
                    }

                    // 碰撞: 
                    // 飞机死亡
                    PlaneDomain.Unspawn(ctx, plane);
                    // 子弹消失
                    BulletDomain.Unspawn(ctx, bullet);
                }
            }
        }

    }
}