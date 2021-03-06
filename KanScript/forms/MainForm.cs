﻿using KanScript.script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanScript.forms
{
    public partial class MainForm : Form
    {
        private ScriptRunner scriptRunner;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formHandlerTextBox.Text = Handle.ToString();
            scriptInitButton_Click(sender, e);
        }

        private void kcvHandlerFindButton_Click(object sender, EventArgs e)
        {
            IntPtr foundHandler = util.SystemAPI.FindKCVWindow(getKcvHandler());

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

        public IntPtr getKcvHandler()
        {
            int handler = 0;
            int.TryParse(kcvHandlerTextBox.Text, out handler);
            IntPtr gameHandler = new IntPtr(handler);

            return gameHandler;
        }

        private void scriptRunButton_Click(object sender, EventArgs e)
        {
            new Thread(runScript).Start();
        }

        private void scriptInitButton_Click(object sender, EventArgs e)
        {
            scriptRunner = new ScriptRunner(this);
        }

        private void runScript()
        {
            if (scriptRunner != null)
            {
                scriptRunner.runScript(luaScriptTextBox.Text);
            }
        }

        private void scriptOpenButtion_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "打开脚本文件";
            fd.Filter = "脚本文件(*.lua)|*.lua|所有文件(*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                FileInfo file = new FileInfo(fd.FileName);
                StreamReader sr = file.OpenText();
                while (sr.Peek() > 0)
                {
                    sb.AppendLine(sr.ReadLine());
                }
                luaScriptTextBox.Text = sb.ToString();
            }
        }
    }
}
