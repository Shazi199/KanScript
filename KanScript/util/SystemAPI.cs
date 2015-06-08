using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KanScript.util
{
    class SystemAPI
    {
        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

        [DllImport("User32.dll", EntryPoint = "GetTopWindow")]
        private static extern IntPtr GetTopWindow(IntPtr hwndParent);

        [DllImport("User32.dll", EntryPoint = "GetParent")]
        private static extern IntPtr GetParent(IntPtr hwndChild);

        private const string KCV_CLASS_NAME = "HwndWrapper[KanColleViewer.exe;;6da30081-a9e0-4b37-ac4e-e49cae117449]";
        private const string KCV_WINDOW_NAME = "提督業も忙しい！";

        private const string GAME_CLASS_NAME = "Internet Explorer_Server";
        private const string GAME_WINDOW_NAME = null;

        public static IntPtr FindKCVWindow(IntPtr gameHandler)
        {
            IntPtr lastKCVHandler = IntPtr.Zero;
            if (!IntPtr.Zero.Equals(gameHandler))
            {
                lastKCVHandler = GetParent(GetParent(GetParent(gameHandler)));
            }

            IntPtr KCVMainWindowHandler = FindWindowEx(IntPtr.Zero, lastKCVHandler, KCV_CLASS_NAME, KCV_WINDOW_NAME);
            if (IntPtr.Zero.Equals(KCVMainWindowHandler))
            {
                return IntPtr.Zero;
            }

            IntPtr KCVGameWindowHandler = GetTopWindow(GetTopWindow(GetTopWindow(KCVMainWindowHandler)));
            return KCVGameWindowHandler;
        }
    }
}
