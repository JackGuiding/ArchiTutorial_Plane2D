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
            // 注: 正序遍历时不能移除 List 里的元素
            // 因此处理方式:
            // 或 1. 倒序遍历
            // 或 2. 复制一份 List / 或者复制数组
            List<PlaneEntity> planes = ctx.planeRepository.GetAll();

            // 倒序遍历
            for (int i = planes.Count - 1; i >= 0; i -= 1) {
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