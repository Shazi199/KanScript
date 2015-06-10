namespace KanScript.forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.formHandlerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kcvHandlerTextBox = new System.Windows.Forms.TextBox();
            this.kcvHandlerFindButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.scriptInitButton = new System.Windows.Forms.Button();
            this.luaScriptTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本窗口句柄：";
            // 
            // formHandlerTextBox
            // 
            this.formHandlerTextBox.Location = new System.Drawing.Point(412, 169);
            this.formHandlerTextBox.Name = "formHandlerTextBox";
            this.formHandlerTextBox.ReadOnly = true;
            this.formHandlerTextBox.Size = new System.Drawing.Size(100, 21);
            this.formHandlerTextBox.TabIndex = 1;
            this.formHandlerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "KCV窗口句柄：";
            // 
            // kcvHandlerTextBox
            // 
            this.kcvHandlerTextBox.Location = new System.Drawing.Point(412, 196);
            this.kcvHandlerTextBox.Name = "kcvHandlerTextBox";
            this.kcvHandlerTextBox.Size = new System.Drawing.Size(100, 21);
            this.kcvHandlerTextBox.TabIndex = 3;
            this.kcvHandlerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kcvHandlerFindButton
            // 
            this.kcvHandlerFindButton.Location = new System.Drawing.Point(412, 223);
            this.kcvHandlerFindButton.Name = "kcvHandlerFindButton";
            this.kcvHandlerFindButton.Size = new System.Drawing.Size(100, 23);
            this.kcvHandlerFindButton.TabIndex = 4;
            this.kcvHandlerFindButton.Text = "查找KCV窗口";
            this.kcvHandlerFindButton.UseVisualStyleBackColor = true;
            this.kcvHandlerFindButton.Click += new System.EventHandler(this.kcvHandlerFindButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "运行脚本（测试）";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scriptInitButton
            // 
            this.scriptInitButton.Location = new System.Drawing.Point(12, 223);
            this.scriptInitButton.Name = "scriptInitButton";
            this.scriptInitButton.Size = new System.Drawing.Size(141, 23);
            this.scriptInitButton.TabIndex = 6;
            this.scriptInitButton.Text = "初始化脚本";
            this.scriptInitButton.UseVisualStyleBackColor = true;
            this.scriptInitButton.Click += new System.EventHandler(this.scriptInitButton_Click);
            // 
            // luaScriptTextBox
            // 
            this.luaScriptTextBox.Location = new System.Drawing.Point(12, 12);
            this.luaScriptTextBox.Multiline = true;
            this.luaScriptTextBox.Name = "luaScriptTextBox";
            this.luaScriptTextBox.Size = new System.Drawing.Size(305, 205);
            this.luaScriptTextBox.TabIndex = 7;
            this.luaScriptTextBox.Text = "-- 点击主界面出击\r\nKSAPI:clickLeftMouseButton(220, 250);\r\n\r\n-- 等待2秒\r\nKSAPI:wait(2000);\r\n" +
    "\r\n-- 点击回港\r\nKSAPI:clickLeftMouseButton(70, 60);";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 258);
            this.Controls.Add(this.luaScriptTextBox);
            this.Controls.Add(this.scriptInitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kcvHandlerFindButton);
            this.Controls.Add(this.kcvHandlerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formHandlerTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanScript";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formHandlerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kcvHandlerTextBox;
        private System.Windows.Forms.Button kcvHandlerFindButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button scriptInitButton;
        private System.Windows.Forms.TextBox luaScriptTextBox;
    }
}

