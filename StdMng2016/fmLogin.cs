using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using StdMng2016.Utility;
using System.Data.SqlClient;

namespace StdMng2016
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool IsValiadUses(String userName,String pwd)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(pwd));
            String pwdMd5 = Convert.ToBase64String(result);

            object userId = DbaseCS.ExecuteScalar("select UserID from t_User where UserID=@UserID and UserPwd=@UserPwd",
                                  new SqlParameter[]{new SqlParameter("@UserID",userName),
                                                    new SqlParameter("@UserPwd",pwdMd5)
                                                     } ,CmdType.CmdTxt);
            if (userId != null)
                return true;
            else
                return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (IsValiadUses(txtUserName.Text, txtPwd.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名密码错误！");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fmRegister fr = new fmRegister();
            fr.Show();
        }
    }
}
