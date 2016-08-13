﻿using System;
using System.Diagnostics;

namespace DX12GameProgramming
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (D3DApp app = new InstancingAndCullingApp(Process.GetCurrentProcess().Handle))
            {
                app.Initialize();
                app.Run();
            }
        }
    }
}
