using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DemonRacing
{
    /// <summary>
    /// Player movement and mechanics
    /// </summary>
    internal class Player
    {
        public TransformComponent transform;
        public CollisionComponent collision;
        public Color playerColor;

        public Player(Vector2 startPos, float speed, int size, Color playerColor)
        {
            collision = new CollisionComponent(new Vector2(size, size));
            this.playerColor = playerColor;
            transform = new TransformComponent();
        }

        public void Update()
        {
            float deltaTime = Raylib.GetFrameTime();
            float acceleration = 200;
            float slowdown = 5;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                transform.rotation -= transform.turnspeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                transform.rotation += transform.turnspeed;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                transform.speed += acceleration * deltaTime;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                transform.speed += acceleration * deltaTime;
            }
            else
            {
                transform.speed -= slowdown * deltaTime;
            }

            if (transform.speed > transform.maxSpeed)
            {
                transform.speed = transform.maxSpeed;
            }
            if (transform.speed < 0)
            {
                transform.speed = 0;
            }

            Matrix4x4 rotationMatrix = Matrix4x4.CreateRotationZ(transform.rotation);
            // Always rotate the original direction
            transform.moveDirection = Vector2.Transform(transform.direction, rotationMatrix);

            transform.velocity = transform.moveDirection * transform.speed * deltaTime;
            transform.position += transform.velocity;

        }

        public void Draw()
        {
            Raylib.DrawRectangleV(transform.position, collision.size, playerColor);
            Vector2 target = transform.position + Vector2.Normalize(transform.moveDirection) * 40.0f;
            Raylib.DrawLine((int)transform.position.X, (int)transform.position.Y, (int)(target.X), (int)(target.Y), Raylib.GREEN);
        }
    }
}