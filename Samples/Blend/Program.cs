﻿using System.Diagnostics;

namespace DX12GameProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (D3DApp app = new BlendApp(Process.GetCurrentProcess().Handle))
            {
                app.Initialize();
                app.Run();
            }
        }
    }
}
