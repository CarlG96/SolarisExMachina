using Raylib_cs;
using System.Security.Principal;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {
            Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "Solaris Ex Machina");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGREEN);

                Raylib.DrawText("Solaris Ex Machina", Raylib.GetScreenWidth() / 2 -100, 40, 20, Color.WHITE);
                Raylib.DrawText("Press Enter to Start", Raylib.GetScreenWidth() / 2 -100, (Raylib.GetScreenHeight() / 2) -10, 20, Color.WHITE);
                

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}