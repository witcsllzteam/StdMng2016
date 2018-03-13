using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StdMng2016.StdMng
{
    public partial class fmEDM : Form
    {
        Byte[] imgBytes;

        public fmEDM()
        {
            InitializeComponent();
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

            }
        }

        private void fmEDM_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;

            using (StdMng2015NEntities se = new StdMng2015NEntities())
            {
                cbDept.DataSource = se.t_Sdept;
                cbDept.DisplayMember = "SdeptName";
                cbDept.ValueMember = "SdeptID";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (StdMng2015NEntities se = new StdMng2015NEntities())
            {
                try
                {
                    t_Student std = new t_Student();
                    std.sno = txtID.Text;
                    std.sname = txtName.Text;
                    std.SGender = cbGender.SelectedItem.ToString();
                    std.Sdept = cbDept.SelectedValue.ToString();
                    std.sIDNum = txtIDCardNums.Text;
                    std.SBirth = dpBirth.Value;
                    std.sEmail = txtEmail.Text;
                    std.SImage = imgBytes;
                    //se.AddTot_Student(std);
                    se.t_Student.AddObject(std);
                    se.SaveChanges();
                    MessageBox.Show("保存学生信息成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (StdMng2015NEntities se = new StdMng2015NEntities())
            {
                t_Student std1 = 
                    (from st in se.t_Student
                           where st.sno == txtID.Text
                           select st).FirstOrDefault();

                t_Student std = se.t_Student.
                          Where(t => t.sno == txtID.Text)
                          .FirstOrDefault();

                if (std != null)
                {
                    txtName.Text = std.sname;
                    cbGender.SelectedItem = std.SGender;
                    cbDept.SelectedValue = std.Sdept;
                    txtIDCardNums.Text = std.sIDNum;
                    dpBirth.Value = std.SBirth;
                    txtEmail.Text = std.sEmail;

                    if (std.SImage != null)
                    {
                        pbImage.Image = Bitmap.FromStream(new MemoryStream(std.SImage));
                    }
                }
                else
                {
                    MessageBox.Show("查无此人！");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (StdMng2015NEntities se = new StdMng2015NEntities())
            {
                try
                {
                    t_Student std = se.t_Student.
                                    Where(s => s.sno == txtID.Text).FirstOrDefault();

                    if (std != null)
                    {
                        std.sname = txtName.Text;
                        std.SGender = cbGender.SelectedItem.ToString();
                        std.Sdept = cbDept.SelectedValue.ToString();
                        std.sIDNum = txtIDCardNums.Text;
                        std.SBirth = dpBirth.Value;
                        std.sEmail = txtEmail.Text;
                        std.SImage = imgBytes;
                        se.SaveChanges();
                        MessageBox.Show("修改学生信息成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("查无此人！");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (StdMng2015NEntities se = new StdMng2015NEntities())
            {
                t_Student std = (from s in se.t_Student
                                 where s.sno == txtID.Text
                                 select s).FirstOrDefault();

                if (std != null)
                {
                    try
                    {
                        IEnumerable<t_SC> stdSC
                        = from sc in se.t_SC where sc.Sno == std.sno 
                          select sc;
                        
                        foreach (t_SC tsc in stdSC)
                        {
                            se.DeleteObject(tsc);
                        }

                        se.DeleteObject(std);
                        se.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                     
            }
        }
    }
}
