using QLNH_Winform.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_Winform
{
    internal static class Program
    {
        class QLNHApplicationContext : ApplicationContext
        {
            private FormLogin formLogin;
            private FormMainMenu[] formMainMenu;
            private int formNumber;
            public QLNHApplicationContext()
            {
                formMainMenu = new FormMainMenu[2];
                formNumber = 0;
                formLogin = new FormLogin();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formMainMenu[formNumber] = new FormMainMenu(formLogin.loginAccount);
                    formMainMenu[formNumber].Show();
                    this.formMainMenuClosed += QLNHApplicationContext_formMainMenuClosed;
                }
                else
                {
                    throw new Exception("exit");
                }
            }
            private void QLNHApplicationContext_formMainMenuClosed(object sender, FormClosedEventArgs e)
            {
                this.formMainMenuClosed -= QLNHApplicationContext_formMainMenuClosed;
                formNumber = (formNumber + 1) % 2;
                formLogin = new FormLogin();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formMainMenu[formNumber] = new FormMainMenu(formLogin.loginAccount);
                    formMainMenu[formNumber].Show();
                    this.formMainMenuClosed += QLNHApplicationContext_formMainMenuClosed;
                }
                else
                {
                    Application.Exit();
                }
            }

            public event FormClosedEventHandler formMainMenuClosed
            {
                add { this.formMainMenu[formNumber].FormClosed += value; }
                remove { this.formMainMenu[formNumber].FormClosed -= value; }
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new QLNHApplicationContext());
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
