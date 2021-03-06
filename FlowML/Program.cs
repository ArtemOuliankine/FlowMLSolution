﻿using System;

namespace FlowML
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class. By Artem and Tomas
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
