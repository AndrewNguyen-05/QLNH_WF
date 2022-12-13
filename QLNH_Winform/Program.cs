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
                formLogin = new FormLogin();
                formMainMenu[0] = new FormMainMenu();
                formNumber = 0;
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formMainMenu[formNumber].Show();
                    this.formMainMenuClosed += QLNHApplicationContext_formMainMenuClosed;
                }
            }
            private void QLNHApplicationContext_formMainMenuClosed(object sender, FormClosedEventArgs e)
            {
                this.formMainMenuClosed -= QLNHApplicationContext_formMainMenuClosed;
                formNumber = (formNumber + 1) % 2;
                formLogin = new FormLogin();
                formMainMenu[formNumber] = new FormMainMenu();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formMainMenu[formNumber].Show();
                    this.formMainMenuClosed += QLNHApplicationContext_formMainMenuClosed;
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
            //Application.Run(new FormGoiMon());
            Application.Run(new QLNHApplicationContext());
        }
    }
}
