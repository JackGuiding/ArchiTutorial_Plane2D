using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class BulletController {

        public static void DrawAll(GameContext ctx) {
            List<BulletEntity> all = ctx.bulletRepository.GetAll();
            for (int i = 0; i < all.Count; i += 1) {
                BulletEntity bullet = all[i];
                Raylib.DrawRectangleV(bullet.pos, bullet.size, bullet.color);
            }
        }
    }
}