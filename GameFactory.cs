using System.Numerics;
using Raylib_cs;

namespace Tutorial2D {

    public static class GameFactory {

        public static PlaneEntity Plane_Create(IDService idService, bool isPlayer, Vector2 pos, float moveSpeed, Vector2 size, Color color) {
            PlaneEntity plane = new PlaneEntity();
            plane.id = idService.planeIDRecord++; // 先赋值再自增 += ++x x+=
            plane.isPlayer = isPlayer;
            plane.pos = pos;
            plane.moveSpeed = moveSpeed;
            plane.size = size;
            plane.color = color;
            return plane;
        }

        public static BulletEntity Bullet_Create(IDService idService, bool isPlayer, Vector2 pos, Vector2 moveDir, float moveSpeed, Vector2 size, Color color) {
            BulletEntity bullet = new BulletEntity();
            bullet.id = idService.bulletIDRecord++;
            bullet.pos = pos;
            bullet.moveDir = moveDir;
            bullet.moveSpeed = moveSpeed;
            bullet.size = size;
            bullet.color = color;
            return bullet;
        }

    }

}