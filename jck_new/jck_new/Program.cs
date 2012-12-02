using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SplashScreenControl;
using System.Drawing;

namespace jck_new
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
            ///////////////// // the following demonstrates how to use the instance object and change control properties
            // 
            SplashScreen.Instance.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // begin displaying the splash screen before running the application form
            SplashScreen.SetBackgroundImage(jck_new.Properties.Resources.splashbg2);
            SplashScreen.SetTitleString("默默KING的店铺销售系统");
            SplashScreen.SetCommentaryString("..数据装载中.");
            SplashScreen.BeginDisplay();
            ////////////////
            Application.Run(new MainForm());
        }
    }
}
