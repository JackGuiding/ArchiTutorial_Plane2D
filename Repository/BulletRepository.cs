using System.Collections.Generic;

namespace Tutorial2D {

    public class BulletRepository {

        List<BulletEntity> all;

        public BulletRepository() {
            all = new List<BulletEntity>();
        }

        public void Add(BulletEntity bullet) {
            all.Add(bullet);
        }

        public BulletEntity Get(int id) {
            foreach (BulletEntity bullet in all) {
                if (bullet.id == id) {
                    return bullet;
                }
            }
            return null;
        }

        public List<BulletEntity> GetAll() {
            return all;
        }

        public void Remove(BulletEntity bullet) {
            all.Remove(bullet);
        }

    }

}