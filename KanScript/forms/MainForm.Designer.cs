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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本窗口句柄：";
            // 
            // formHandlerTextBox
            // 
            this.formHandlerTextBox.Location = new System.Drawing.Point(412, 171);
            this.formHandlerTextBox.Name = "formHandlerTextBox";
            this.formHandlerTextBox.ReadOnly = true;
            this.formHandlerTextBox.Size = new System.Drawing.Size(100, 21);
            this.formHandlerTextBox.TabIndex = 1;
            this.formHandlerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "KCV窗口句柄：";
            // 
            // kcvHandlerTextBox
            // 
            this.kcvHandlerTextBox.Location = new System.Drawing.Point(412, 198);
            this.kcvHandlerTextBox.Name = "kcvHandlerTextBox";
            this.kcvHandlerTextBox.Size = new System.Drawing.Size(100, 21);
            this.kcvHandlerTextBox.TabIndex = 3;
            this.kcvHandlerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kcvHandlerFindButton
            // 
            this.kcvHandlerFindButton.Location = new System.Drawing.Point(412, 225);
            this.kcvHandlerFindButton.Name = "kcvHandlerFindButton";
            this.kcvHandlerFindButton.Size = new System.Drawing.Size(100, 23);
            this.kcvHandlerFindButton.TabIndex = 4;
            this.kcvHandlerFindButton.Text = "查找KCV窗口";
            this.kcvHandlerFindButton.UseVisualStyleBackColor = true;
            this.kcvHandlerFindButton.Click += new System.EventHandler(this.kcvHandlerFindButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 258);
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
    }
}

