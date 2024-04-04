using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class BulletDomain {

        public static BulletEntity Spawn(GameContext ctx, bool isPlayer, Vector2 pos, float moveSpeed, Vector2 size, Color color) {
            BulletEntity bullet = GameFactory.Bullet_Create(ctx.idService, isPlayer, pos, moveSpeed, size, color);
            ctx.bulletRepository.Add(bullet);
            return bullet;
        }

    }
}