using System.Numerics;

namespace Tutorial2D {

    // 双人成行 / 茶杯头, 如果有多份输入(玩家一玩家二同屏), 就需要 Repository
    public class InputEntity {

        public Vector2 moveDir;
        // public float up; // 负代表上 正代表下
        // public float right; // 负代表左 正代表右

        public bool isFire;

    }

}