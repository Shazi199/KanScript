using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanScript.forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formHandlerTextBox.Text = this.Handle.ToString();
        }

        private void kcvHandlerFindButton_Click(object sender, EventArgs e)
        {
            int handler = 0;
            int.TryParse(kcvHandlerTextBox.Text, out handler);
            IntPtr gameHandler = new IntPtr(handler);
            IntPtr foundHandler = util.SystemAPI.FindKCVWindow(gameHandler);

            while (IntPtr.Zero.Equals(foundHandler))
            {
                if (!searchHandlerConfirm())
                {
                    break;
                }
                foundHandler = util.SystemAPI.FindKCVWindow(IntPtr.Zero);
            }

            if (!IntPtr.Zero.Equals(foundHandler))
            {
                kcvHandlerTextBox.Text = foundHandler.ToString();
            }
        }

        private bool searchHandlerConfirm()
        {
            DialogResult result = MessageBox.Show("没有找到新的KCV窗口，是否重新查找？", "KCV窗口未找到", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return DialogResult.Yes == result;
        }
    }
}
