namespace yjl
{
    partial class FileAttribute
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.System = new System.Windows.Forms.CheckBox();
            this.ReadOnly = new System.Windows.Forms.CheckBox();
            this.Hidden = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "browser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.System);
            this.groupBox1.Controls.Add(this.ReadOnly);
            this.groupBox1.Controls.Add(this.Hidden);
            this.groupBox1.Location = new System.Drawing.Point(20, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "file attribute";
            // 
            // System
            // 
            this.System.AutoSize = true;
            this.System.Location = new System.Drawing.Point(393, 28);
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(77, 19);
            this.System.TabIndex = 4;
            this.System.Text = "System";
            this.System.UseVisualStyleBackColor = true;
            // 
            // ReadOnly
            // 
            this.ReadOnly.AutoSize = true;
            this.ReadOnly.Location = new System.Drawing.Point(203, 28);
            this.ReadOnly.Name = "ReadOnly";
            this.ReadOnly.Size = new System.Drawing.Size(93, 19);
            this.ReadOnly.TabIndex = 3;
            this.ReadOnly.Text = "ReadOnly";
            this.ReadOnly.UseVisualStyleBackColor = true;
            // 
            // Hidden
            // 
            this.Hidden.AutoSize = true;
            this.Hidden.Location = new System.Drawing.Point(25, 28);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(77, 19);
            this.Hidden.TabIndex = 0;
            this.Hidden.Text = "Hidden";
            this.Hidden.UseVisualStyleBackColor = true;
            // 
            // FileAttribute
            // 
            this.ClientSize = new System.Drawing.Size(520, 149);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FileAttribute";
            this.Text = "FileAttribute";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ReadOnly;
        private System.Windows.Forms.CheckBox Hidden;
        private System.Windows.Forms.CheckBox System;
    }
}

