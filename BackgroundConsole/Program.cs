using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExampleLib;

namespace BackgroundConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var funcs = new WindowsFunctions();
            funcs.SetWallpaper("cage.jpg");
        }
    }
}
