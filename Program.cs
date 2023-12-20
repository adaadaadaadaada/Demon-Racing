using System;
using System.Numerics;
using System.Security.Cryptography;
using Raylib_CsLo;
using static System.Formats.Asn1.AsnWriter;

namespace DemonRacing
{
    /// <summary>
    /// Game
    /// </summary>
    internal class Program
    {
        Player player;
        Demon demon;
        MainMenu mainMenu;
        Options options;
        PauseMenu pauseMenu;
        Level level;
        int score;
        //Stack<GameState> statestack;

        public static void Main()
        {
            Program DemonRacing = new Program();
            DemonRacing.GameLoop();
        }

        void GameLoop() // peli
        {
            Raylib.InitWindow(1040, 700, "game");

            player = new Player(new Vector2(50, 50), 20, 50, Raylib.RED);

            while (Raylib.WindowShouldClose() == false)
            {
                player.Update(); 
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.BLACK);
                Draw();
                Raylib.EndDrawing();
            }
        }

        void Draw()
        {
            player.Draw();
        }

        Rectangle getRectangle(TransformComponent t, CollisionComponent c)
        {
            Rectangle r = new Rectangle(t.position.X, t.position.Y, c.size.X, c.size.Y);
            return r;
        }
    }
}