using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace DemonRacing
{
    /// <summary>
    /// Luo paikan, nopeuden, ja suunnan joita objektit voi käyttää
    /// </summary>
    internal class TransformComponent
    {
        public Vector2 moveDirection;
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 direction;
        public float rotation = 0.0f;
        public float turnspeed = 0.01f;
        public float speed = 0.0f;
        public float maxSpeed = 120.0f;
        public float acceleration = 3.0f;
        public TransformComponent()
        {
            position = new Vector2(100, 100);
            velocity = new Vector2(0, 0);
            direction = new Vector2(1, 0);
        }
    }
}
