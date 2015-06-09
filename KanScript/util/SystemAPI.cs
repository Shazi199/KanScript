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

        private const string KCV_WINDOW_NAME = "提督業も忙しい！";

        public static IntPtr FindKCVWindow(IntPtr gameHandler)
        {
            IntPtr lastKCVHandler = IntPtr.Zero;
            if (!IntPtr.Zero.Equals(gameHandler))
            {
                lastKCVHandler = GetParent(GetParent(GetParent(gameHandler)));
            }

            IntPtr KCVMainWindowHandler = FindWindowEx(IntPtr.Zero, lastKCVHandler, null, KCV_WINDOW_NAME);
            if (IntPtr.Zero.Equals(KCVMainWindowHandler))
            {
                return IntPtr.Zero;
            }

            IntPtr KCVGameWindowHandler = GetTopWindow(GetTopWindow(GetTopWindow(KCVMainWindowHandler)));
            return KCVGameWindowHandler;
        }
    }
}
