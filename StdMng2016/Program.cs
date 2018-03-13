using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StdMng2016
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //fmLogin fmlogin = new fmLogin();

            //if (fmlogin.ShowDialog() == DialogResult.OK)
            //{
            //    fmlogin.Close();
            //    Application.Run(new fmMain());
            //}

            Application.Run(new fmMain());
        }
    }
}
