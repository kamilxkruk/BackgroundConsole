using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLib
{
    public class WindowsFunctions
    {
        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam, string pvParam, uint fWinIni);

        public void SetWallpaper(string fileName)
        {
            var wallpaperName = fileName;
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var wallpaperFullPath = Path.Combine(desktopPath, wallpaperName);

            SystemParametersInfo(0x0014, 0, wallpaperFullPath, 0x0001);
        }

    }
}
