using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StdMng2016.StdMng
{
    public partial class fmLINQ : Form
    {
        StdMng2015NEntities se = new StdMng2015NEntities();

        public fmLINQ()
        {
            InitializeComponent();
        }

        private void btnSPExm1_Click(object sender, EventArgs e)
        {
            //原始的查询，返回学生集合 类似题型 见数据库书
           IEnumerable<t_Student> result = se.t_Student.
                                  Where(s => s.sno == "20107777");

           IEnumerable<t_Student> result1 = from s in se.t_Student 
                                            where s.sno == "20107777" 
                                            select s;           
           gvStd.DataSource = result;         
        }

        private void btnSelExm2_Click(object sender, EventArgs e)
        {
            ////投影，自定义类型，返回学生集合 类似题型 见数据库书
            var result = se.t_Student.Where(s => s.sno == "20107777")
                         .Select(s => new { 学号 = s.sno, 姓名 = s.sname, 性别 = s.SGender, 出身日期 = s.SBirth });

            var result1 = from s in se.t_Student where s.sno == "20107777"
                          select 
                          new { 学号 = s.sno, 姓名 = s.sname, 性别 = s.SGender, 出身日期 = s.SBirth };

            gvStd.DataSource = result;
        }

        private void btnSelExm3_Click(object sender, EventArgs e)
        {
            //筛选条件的与&& 或|| 非! :类似题型 见数据库书
            //where 后的关系表达式 逻辑表达式
            //between 的表示   转化为 >=   &&  <=  
            //in 的 表示 只能用或关系枚举
            var result = se.t_Student.Where(s => s.Sdept == "IS" && s.SGender == "女").
                                      Select(s => new { 学号 = s.sno, 姓名 = s.sname, 性别 = s.SGender, 出身日期 = s.SBirth });

            var result1 = from s in se.t_Student
                          where s.Sdept == "IS" && s.SGender == "女"
                          select new 
                          { 学号 = s.sno, 姓名 = s.sname, 性别 = s.SGender, 出身日期 = s.SBirth };

            gvStd.DataSource = result1;
        }

        private void btnSelExm4_Click(object sender, EventArgs e)
        {
            //类似题型  最差的2个成绩  第2，3的最好成绩等等
            var result = (from t in se.t_SC
                          where t.Cno == "1"
                          orderby t.Grade descending
                          select new { 学号 = t.Sno, 课程号 = t.Cno, 成绩 = t.Grade })
                          .Take(2);

            var result1 = se.t_SC.Where(t => t.Cno == "1").
                           OrderByDescending(t => t.Grade).
                           Select(t => new { 学号 = t.Sno, 课程号 = t.Cno, 成绩 = t.Grade }).Skip(1).Take(2);

            gvStd.DataSource = result1;
        }



        private void fmLINQ_Load(object sender, EventArgs e)
        {

        }

        private void fmLINQ_FormClosed(object sender, FormClosedEventArgs e)
        {
            se.Dispose();
        }

        private void btnJoin1_Click(object sender, EventArgs e)
        {
            //简单联接
            var result = from std in se.t_Student
                    join ssc in se.t_SC
                    on std.sno equals ssc.Sno
                    join c in se.t_Course 
                    on ssc.Cno equals c.Cno
                    join dept in se.t_Sdept
                    on std.Sdept equals dept.SdeptID
                    orderby std.sno
                    select
                    new
                    {
                       所在系 = dept.SdeptName,
                       学号 = std.sno, 
                       学生姓名 = std.sname,
                       课程 = c.CName,
                       成绩 = ssc.Grade };

            //利用EDM的导航关系实现简单联接
            var result1 = 
                    from std in se.t_Student
                    from ssc in std.t_SC
                    orderby std.sno
                    select new
                    {
                        所在系=std.t_Sdept.SdeptName,
                        学号 = std.sno,
                        学生姓名 = std.sname,
                        课程 = ssc.t_Course.CName,
                        成绩 = ssc.Grade
                    };

            //方法语法
            var result2 = se.t_Student.
                           OrderBy(s=>s.sno).
                           Join(se.t_SC, s => s.sno, sc => sc.Sno,
                          (s, sc) => new { 所在系 = s.t_Sdept.SdeptName, 学号 = s.sno, 学生姓名 = s.sname, 课程 = sc.t_Course.CName, 成绩 = sc.Grade });

            gvStd.DataSource = result1;
        }

        private void btnGrp1_Click(object sender, EventArgs e)
        {
            //分组1
            var result = from sc in se.t_SC
                      group sc by sc.Sno 
                      into ssc
                      select new
                      {
                          学号 = ssc.Key,
                          学生姓名 = ssc.FirstOrDefault().t_Student.sname,
                          选课门数 = ssc.Count(),
                          平均成绩 = ssc.Average(s => s.Grade)
                      };

            //分组2 
            var result1 = se.t_SC.GroupBy(sc => sc.Sno)
                          .Select(ssc => new { 学号 = ssc.Key ,
                                               学生姓名 = ssc.FirstOrDefault().t_Student.sname,
                                               选课门数 = ssc.Count(),
                                               平均成绩 = ssc.Average(s => s.Grade) });

            
            //另一种方法，利用导航属性，不分组也可以,和上面两种方法的区别在哪里
            var result2 = from s in se.t_Student
                      select new
                      {
                          学号 = s.sno,
                          姓名 = s.sname,
                          选课门数 = s.t_SC.Count,
                          平均成绩 = s.t_SC.Average(s1 => s1.Grade) == null ? 0 : s.t_SC.Average(s1 => s1.Grade)
                      };

            gvStd.DataSource = result;
        }

        private void btnGrp2_Click(object sender, EventArgs e)
        {
            //方法语法
            var result = se.t_Student.GroupBy(s => s.SGender).Select(sg => new { 性别 = sg.Key, 人数 = sg.Count() });
            //查询表达式语法  into sg 表示对分组结果的引用
            var result1 =  from s 
                           in se.t_Student
                           group s by s.SGender 
                           into sg 
                           select new {性别 = sg.Key, 人数 = sg.Count()};

            gvStd.DataSource = result1;
        }

        private void btnGrp3_Click(object sender, EventArgs e)
        {
            //方法语法
            var result = se.t_Student.GroupBy(s => s.Sdept).Select(sg => new { 系别 = se.t_Sdept.Where(d=>d.SdeptID == sg.Key).FirstOrDefault().SdeptName, 人数 = sg.Count() });
     
            //查询表达式语法
            var result1 = from s in se.t_Student 
                          group s by s.Sdept
                          into sg
                          select new {系别 = 
                              //(from d in se.t_Sdept where d.SdeptID == sg.Key select d).FirstOrDefault().SdeptName,
                              sg.FirstOrDefault().t_Sdept.SdeptName,
                              人数=sg.Count()};

            //换一个角度，从利用导航属性系别表出发进行统计
            var result2 = se.t_Sdept.Select(d => new { 系别 = d.SdeptName, 人数 = d.t_Student.Count() });
            
            var result3 = from d in se.t_Sdept 
                          select new { 
                              系别 = d.SdeptName, 
                              人数 = d.t_Student.Count() 
                          };
            //....思考其它解放，如join 


            gvStd.DataSource = result3;
        }


             
    }
}
