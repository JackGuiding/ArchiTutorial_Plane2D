namespace Tutorial2D {

    public class GameContext {

        // 存储
        public PlaneRepository planeRepository;

        // Service
        public IDService idService;

        public GameContext() {
            planeRepository = new PlaneRepository();
            idService = new IDService();
        }

    }

}