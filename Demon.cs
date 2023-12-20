using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonRacing
{
    /// <summary>
    /// This class is for the opponents/enemies that the player has to race against.
    /// It includes their moving, rotating, and pathfinding.
    /// </summary>
    internal class Demon
    {
        TransformComponent transform;
        CollisionComponent collision;
        // Color demonColor

        /// <summary>
        /// Gives the demon(s) a size, color, and speed
        /// </summary>
        public Demon() { }

        /// <summary>
        /// Updates the demon(s) acceleration, slowdown, as well as position, collision, rotation, speed, and direction.
        /// </summary>
        public void Update() { }

        /// <summary>
        /// Draws the demon(s)
        /// </summary>
        public void Draw() { }
    }
}
