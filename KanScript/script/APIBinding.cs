using KanScript.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KanScript.script
{
    class APIBinding
    {
        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParamm, int lParam);

        private const uint WM_LBUTTONDOWN = 0x0201;
        private const uint WM_LBUTTONUP = 0x0202;
        private const int MK_LBUTTON = 0x001;

        private MainForm form;

        public APIBinding(MainForm form)
        {
            this.form = form;
        }

        public void clickLeftMouseButton(int xPos,int yPos)
        {
            // 低位x坐标，高位y坐标
            int lParam = xPos + (yPos << 16);

            PostMessage(form.getKcvHandler(), WM_LBUTTONDOWN, MK_LBUTTON, lParam);
            PostMessage(form.getKcvHandler(), WM_LBUTTONUP, 0, lParam);
        }

        public void wait(int millisecond)
        {
            System.Threading.Thread.Sleep(millisecond);
        }
    }
}
