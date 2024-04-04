namespace Tutorial2D {

    // 上下文(语境)
    public class GameContext {

        // 存储
        public InputEntity input;
        public PlaneRepository planeRepository;
        public BulletRepository bulletRepository;

        // Service
        public IDService idService;

        public GameContext() {
            input = new InputEntity();
            planeRepository = new PlaneRepository();
            bulletRepository = new BulletRepository();
            idService = new IDService();
        }

    }

}