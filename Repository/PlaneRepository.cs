using System;
using System.Collections.Generic;

namespace Tutorial2D {

    public class PlaneRepository {

        List<PlaneEntity> all;

        public PlaneRepository() {
            all = new List<PlaneEntity>();
        }

        // 新增
        public void Add(PlaneEntity plane) {
            all.Add(plane);
        }

        // 移除
        public void Remove(PlaneEntity plane) {
            all.Remove(plane);
        }

        // 查询单个
        public PlaneEntity Get(int id) {
            foreach (PlaneEntity plane in all) {
                if (plane.id == id) {
                    return plane;
                }
            }
            return null;
        }

        // 遍历(委托)
        public void ForEach(Action<PlaneEntity> action) {
            foreach (PlaneEntity plane in all) {
                action(plane);
            }
        }

        // 查所有
        public List<PlaneEntity> GetAll() {
            return all;
        }

    }

}