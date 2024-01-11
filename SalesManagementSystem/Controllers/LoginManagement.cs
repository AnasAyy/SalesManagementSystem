using SalesManagementSystem.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class LoginManagement
    {

        public void Login(string userName, string password)
        {
            if (userName.Trim() == "" || password.Trim() == "")
            {
                LoginForm.GetloginForm.wrongLoginLable.Text = "الرجاء تعبئة جميع الحقول";
            }
            else if (userName.Trim() == "Ahmed" && password.Trim() == "123")
            {
                HomePage.GethomePage.تسجيلالدخولToolStripMenuItem1.Visible = false;
                HomePage.GethomePage.تسجيلالخروجToolStripMenuItem.Visible = true;
                HomePage.GethomePage.ادارةالمخازنToolStripMenuItem.Visible = true;
                HomePage.GethomePage.التقاريرToolStripMenuItem.Visible = true;
                HomePage.GethomePage.ادارةالمشترياتToolStripMenuItem.Visible = true;
                HomePage.GethomePage.ادارةالنظامToolStripMenuItem.Visible = true;
                HomePage.GethomePage.ادارةالمصروفاتToolStripMenuItem.Visible = true;
                HomePage.GethomePage.ادارةالمبيعاتToolStripMenuItem.Visible = true;
                HomePage.GethomePage.التقارييرToolStripMenuItem.Visible = true;
                LoginForm.GetloginForm.Close();
                Notification.GetDataForNotificationAsync();

            }
            else
            {
                LoginForm.GetloginForm.wrongLoginLable.Text = "الرجاءالتاكد من اسم المستخدم وكلمة المرور";
            }
        }

        public  void LogOut()
        {
            HomePage.GethomePage.تسجيلالدخولToolStripMenuItem1.Visible = true;
            HomePage.GethomePage.تسجيلالخروجToolStripMenuItem.Visible = false;
            HomePage.GethomePage.ادارةالمخازنToolStripMenuItem.Visible = false;
            HomePage.GethomePage.التقاريرToolStripMenuItem.Visible = false;
            HomePage.GethomePage.ادارةالمشترياتToolStripMenuItem.Visible = false;
            HomePage.GethomePage.ادارةالنظامToolStripMenuItem.Visible = false;
            HomePage.GethomePage.ادارةالمصروفاتToolStripMenuItem.Visible = false;
            HomePage.GethomePage.ادارةالمبيعاتToolStripMenuItem.Visible = false;
            HomePage.GethomePage.التقارييرToolStripMenuItem.Visible = false;

        }



    }
}
