using System;

static class Ohjelma
{
#if WINDOWS || XBOX
    static void Main(string[] args)
    {
        using (SpaceShooter game = new SpaceShooter())
        {
#if !DEBUG
            game.IsFullScreen = true;
#endif
            game.Run();
        }
    }
#endif
}
