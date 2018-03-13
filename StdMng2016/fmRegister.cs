using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StdMng2016.Utility;
using System.Security.Cryptography;

namespace StdMng2016
{
    public partial class fmRegister : Form
    {
        public fmRegister()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String userId = txtUserName.Text;
            String pwd = txtPwd.Text;
            String userDesc = txtUserDesc.Text;

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(pwd));
            String pwdMd5 = Convert.ToBase64String(result);
           
            try
            {

                DbaseCS.ExecuteNonQuery("insert t_User values(@UserID,@UserPwd,@UserDesc)", 
                                       new SqlParameter[]{
                                       new SqlParameter("@UserID",userId),
                                       new SqlParameter("@UserPwd",pwdMd5),
                                       new SqlParameter("@UserDesc",userDesc)}, 
                                       CmdType.CmdTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
