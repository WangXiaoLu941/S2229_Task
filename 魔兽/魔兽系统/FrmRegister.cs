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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        public bool _null()
        {
            bool x = true;
            if (txtName.Text.Trim() == "" || txtNumber.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPassword.Text.Trim()=="" || txtPasswordAgain.Text.Trim()=="" || txtEmailAgain.Text.Trim()=="")
            {
                MessageBox.Show("请填写所有信息");
                x = false;
            }
            if (txtEmail.Text != txtEmailAgain.Text)
            {
                lbltishi1.Visible = true;
                x = false;
            }
            else
            {
                lbltishi1.Visible = false;
            }
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                lbltishi2.Visible = true;
                x = false;
            }
            else
            {
                lbltishi2.Visible = false;
            }
            return x;
        }

        public FrmLogin fl =new FrmLogin();

        private void btnzhuce_Click(object sender, EventArgs e)
        {
            
            if (_null())
            {
                LoginInfo info = new LoginInfo();
                for (int i = 1; i < 10; i++)
                {
                    if (fl.array[i] == null)
                    {
                        fl.array[i] = new LoginInfo();
                        info.Name = txtName.Text;
                        info.Id = txtNumber.Text;
                        info.Password = txtPassword.Text;
                        info.Email = txtName.Text;
                        fl.array[i] = info;
                        MessageBox.Show("注册成功");
                        break;
                    }
                }
                fl.Visible = true;
                this.Close();
            }
        }
    }
}
