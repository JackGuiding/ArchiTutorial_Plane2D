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

    }
}