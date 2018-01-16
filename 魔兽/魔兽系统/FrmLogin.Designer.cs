namespace 魔兽系统
{
    partial class FrmLogin
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btndenglu = new System.Windows.Forms.Button();
            this.lbltext1 = new System.Windows.Forms.Label();
            this.lklbltext = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltishi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblemail.Location = new System.Drawing.Point(44, 116);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(77, 12);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "电子邮箱地址";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpwd.Location = new System.Drawing.Point(44, 194);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(29, 12);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "密码";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(46, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(371, 21);
            this.txtemail.TabIndex = 2;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(46, 221);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(371, 21);
            this.txtpwd.TabIndex = 3;
            // 
            // btndenglu
            // 
            this.btndenglu.BackColor = System.Drawing.Color.Gray;
            this.btndenglu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btndenglu.FlatAppearance.BorderSize = 0;
            this.btndenglu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndenglu.ForeColor = System.Drawing.SystemColors.Control;
            this.btndenglu.Location = new System.Drawing.Point(46, 272);
            this.btndenglu.Name = "btndenglu";
            this.btndenglu.Size = new System.Drawing.Size(75, 38);
            this.btndenglu.TabIndex = 4;
            this.btndenglu.Text = "登录";
            this.btndenglu.UseVisualStyleBackColor = false;
            this.btndenglu.Click += new System.EventHandler(this.btndenglu_Click);
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.ForeColor = System.Drawing.Color.Silver;
            this.lbltext1.Location = new System.Drawing.Point(35, 361);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(125, 12);
            this.lbltext1.TabIndex = 5;
            this.lbltext1.Text = "还没有通行证？现在就";
            // 
            // lklbltext
            // 
            this.lklbltext.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.lklbltext.AutoSize = true;
            this.lklbltext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklbltext.LinkColor = System.Drawing.Color.DarkGray;
            this.lklbltext.Location = new System.Drawing.Point(166, 361);
            this.lklbltext.Name = "lklbltext";
            this.lklbltext.Size = new System.Drawing.Size(29, 12);
            this.lklbltext.TabIndex = 6;
            this.lklbltext.TabStop = true;
            this.lklbltext.Text = "注册";
            this.lklbltext.VisitedLinkColor = System.Drawing.Color.Purple;
            this.lklbltext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbltext_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::魔兽系统.Properties.Resources.关闭;
            this.pictureBox2.Location = new System.Drawing.Point(455, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::魔兽系统.Properties.Resources._1_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbltishi
            // 
            this.lbltishi.AutoSize = true;
            this.lbltishi.ForeColor = System.Drawing.Color.Red;
            this.lbltishi.Location = new System.Drawing.Point(154, 285);
            this.lbltishi.Name = "lbltishi";
            this.lbltishi.Size = new System.Drawing.Size(113, 12);
            this.lbltishi.TabIndex = 9;
            this.lbltishi.Text = "邮箱地址或密码有误";
            this.lbltishi.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(481, 430);
            this.Controls.Add(this.lbltishi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lklbltext);
            this.Controls.Add(this.lbltext1);
            this.Controls.Add(this.btndenglu);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btndenglu;
        private System.Windows.Forms.Label lbltext1;
        private System.Windows.Forms.LinkLabel lklbltext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltishi;
    }
}

