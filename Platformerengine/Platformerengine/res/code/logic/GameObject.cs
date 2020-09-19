using Platformerengine.res.code.physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Platformerengine.res.code.logic {
    class GameObject {
        public GameObject() {
            Vector = new Vector2d(0, 0);
            Components = new LinkedList<Physic>();
        }
        private Point Coord { get; set; }
        private IVector2d Vector { get; }
        private LinkedList<Physic> Components;

        public void AddComponent(Physic ph) {
            Components.AddLast(ph);
        }

    }
}
