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

        public static void Fly(GameContext ctx, BulletEntity bullet, float dt) {
            bullet.pos += bullet.moveDir * bullet.moveSpeed * dt;
            // bullet.pos = bullet.pos + bullet.moveDir * bullet.moveSpeed * dt;
        }

    }
}