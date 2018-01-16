using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 魔兽系统
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public LoginInfo[] array = new LoginInfo[10];

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region 用户1
            LoginInfo info = new LoginInfo();
            info.Name = "王一";
            info.Id = "120";
            info.Email = "123@qq.com";
            info.Password = "123";
            array[0] = new LoginInfo();
            array[0] = info;
            
            #endregion

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndenglu_Click(object sender, EventArgs e)
        {
            string email = this.txtemail.Text;
            string pwd = this.txtpwd.Text;
            if ((this.txtemail.Text.Trim() == null || this.txtemail.Text.Trim() == "") || (this.txtpwd.Text.Trim() == null || this.txtpwd.Text.Trim() == ""))
            {
                MessageBox.Show("用户名或密码不能为空", "提示");
            }
            else
            {
                bool ok = false;
                foreach(LoginInfo item in array)
                {
                    if(item != null)
                    {
                        if (email == item.Email && pwd == item.Password)
                        {

                            ok = true;
                            FrmMain fm = new FrmMain();
                            fm.lblList.Text = "欢迎,"+item.Name;
                            fm.Show();
                            break;
                        }
                    }
                }
                if (ok == false)
                {
                    this.lbltishi.Visible = true;
                    this.txtemail.Clear();
                    this.txtpwd.Clear();
                }
            }
        }

        private void lklbltext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmre = new FrmRegister();
            frmre.fl = this;
            frmre.Show();
            this.Hide();
        }
    }
}
