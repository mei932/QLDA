using System;
using System.Windows.Forms;

namespace QLDA
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chính cho ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login is successful, open the TrangChu form
                Application.Run(new TrangChu(loginForm.LoggedInUserId, loginForm.LoggedInUserRole));
            }
        }
    }
}
