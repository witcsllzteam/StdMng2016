using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace StdMng2016.StdMng
{
    public partial class fmStdADO : Form
    {
        Byte[] imgBytes;
        String conStr = "server=.\\llzlt;database=StdMng2015N;Integrated Security=true;Connect Timeout=30;";
        string dropFileName;
        bool isDrop;

        public fmStdADO()
        {
            InitializeComponent();
        }
        void FillDept()
        {
           SqlConnection con = new SqlConnection(conStr);
           try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "select SdeptID,SdeptName from t_Sdept";

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "select Sno,Cno,Grade from t_sc";

                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                sda1.Fill(ds,"t_Sdept");
                sda2.Fill(ds, "t_SC");
                cbDept.DataSource = ds.Tables["t_Sdept"];
                cbDept.ValueMember = "SdeptID";
                cbDept.DisplayMember = "SdeptName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void fmStdADO_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            dpBirth.Value = new DateTime(1990, 1, 1);
            FillDept();
            pbImage.AllowDrop = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
              e.Handled = true;
        }

        private void txtIDCardNums_Leave(object sender, EventArgs e)
        {
            string idCardRegStr = @"^\d{17}[\d|X]$|^\d{15}$";

            Regex r = new Regex(idCardRegStr);

            if (!r.IsMatch(txtIDCardNums.Text))
            {
                epStd.SetError(txtIDCardNums, "身份证号错误!");
                txtIDCardNums.Focus();
                btnInsert.Enabled = false;
            }
            else
            {
                epStd.SetError(txtIDCardNums, "");
                btnInsert.Enabled = true;
            }         
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string emailRegStr = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex r = new Regex(emailRegStr);

            if (!r.IsMatch(txtEmail.Text))
            {
                epStd.SetError(txtEmail, "邮箱输入错误!");
                txtEmail.Focus();
            }
            else
            {
                epStd.SetError(txtEmail, "");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream;

            if (ofdStd.ShowDialog() == DialogResult.OK)
            {
                myStream = ofdStd.OpenFile();                              
                pbImage.Image = Bitmap.FromStream(myStream);

                imgBytes = new byte[myStream.Length]; 
                myStream.Seek(0, SeekOrigin.Begin);
                myStream.Read(imgBytes, 0, (int)myStream.Length);
                isDrop = false;
               
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert t_student(sno,sname,sgender,sbirth,sdept,simage,sIDNum,sEmail) values"
                                               + "(@sno,@sname,@sgender,@sbirth,@sdept,@simage,@sIDNum,@sEmail)";

                String sGender = cbGender.SelectedIndex == 0 ? "男":"女";

                if (isDrop)
                    imgBytes = File.ReadAllBytes(dropFileName);

                cmd.Parameters.AddRange(new SqlParameter[] { 
                                        new SqlParameter("@sno",txtID.Text),
                                        new SqlParameter("@sname",txtName.Text),
                                        new SqlParameter("@sgender",sGender),
                                        new SqlParameter("@sbirth",dpBirth.Value),
                                        new SqlParameter("@sdept",cbDept.SelectedValue),
                                        new SqlParameter("@simage",imgBytes),
                                        new SqlParameter("@sIDNum",txtIDCardNums.Text),
                                        new SqlParameter("@sEmail",txtEmail.Text)                                
                                   });                
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("插入学生信息成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void QueryStd(String sno)
        {
            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select sno,sname,sgender,sbirth,sdept,simage,sIDNum,sEmail from t_student where sno=@sno";
                cmd.Parameters.AddWithValue("@sno", sno);
                #region dataread

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            txtName.Text = rd["sname"].ToString();
                            cbGender.SelectedIndex = rd["sgender"].ToString() == "男" ? 0 : 1;
                            dpBirth.Value = Convert.ToDateTime(rd["sbirth"]);
                            cbDept.SelectedValue = rd["sdept"].ToString();

                            if (rd["SImage"] != DBNull.Value)
                                pbImage.Image = Bitmap.FromStream(new MemoryStream((Byte[])rd["SImage"]));

                            txtIDCardNums.Text = rd["sIDNum"].ToString();
                            txtEmail.Text = rd["sEmail"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("查无此人！");
                    }
                }
                #endregion

                #region dataSet方式
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    txtName.Text = ds.Tables[0].Rows[0]["SName"].ToString();
                //    txtIDCardNums.Text = ds.Tables[0].Rows[0]["sIDNum"].ToString();
                //    cbGender.SelectedItem = ds.Tables[0].Rows[0]["SGender"];
                //    dpBirth.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["SBirth"]);
                //    cbDept.SelectedValue = ds.Tables[0].Rows[0]["SDept"];
                //    txtEmail.Text = ds.Tables[0].Rows[0]["sEmail"].ToString();
                //    pbImage.Image = Bitmap.FromStream(new MemoryStream((byte[])ds.Tables[0].Rows[0]["SImage"]));
                //}
                //else
                //{
                //    MessageBox.Show("查无此人！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                #endregion 
              
               }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryStd(txtID.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update t_student set sname=@sname,sgender=@sgender,sbirth=@sbirth,sdept=@sdept,simage=@simage,sIDNum=@sIDNum,sEmail=@sEmail where sno=@sno";
                
                String sGender = cbGender.SelectedIndex == 0 ? "男" : "女";
                
                if (isDrop)
                    imgBytes = File.ReadAllBytes(dropFileName);

                cmd.Parameters.AddRange(new SqlParameter[] { 
                                        new SqlParameter("@sno",txtID.Text),
                                        new SqlParameter("@sname",txtName.Text),
                                        new SqlParameter("@sgender",sGender),
                                        new SqlParameter("@sbirth",dpBirth.Value),
                                        new SqlParameter("@sdept",cbDept.SelectedValue),
                                        new SqlParameter("@simage",imgBytes),
                                        new SqlParameter("@sIDNum",txtIDCardNums.Text),
                                        new SqlParameter("@sEmail",txtEmail.Text)                                
                                   });

                cmd.ExecuteNonQuery();
                MessageBox.Show("更新学生信息成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlTransaction trans = null;
            try
            {
                con.Open();
                trans = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = trans;
                cmd.CommandText = "delete t_sc where sno=@sno;delete t_student where sno=@sno";               
                cmd.Parameters.AddWithValue("@sno",txtID.Text);
                cmd.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("删除学生信息成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QueryStd("200215122");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if(trans != null)
                     trans.Rollback();

            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            QueryStd(txtID.Text);
        }

        private void pbImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbImage_DragDrop(object sender, DragEventArgs e)
        {
            dropFileName = ((string[])e.Data.GetData("FileDrop"))[0];
            pbImage.Image = Bitmap.FromFile(dropFileName);
            isDrop = true;
        }

       
    }
}
