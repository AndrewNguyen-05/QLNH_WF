using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_Winform
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
        }

        //private Color SelectThemeColor()
        //{

        //}
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DeactivateButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(96, 93, 236);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTitleBar.BackColor = Color.FromArgb(128, 128, 255);
                    pnTitleBar.ForeColor = Color.White;
                    pnLogo.BackColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(128, 128, 255), 0.7);

                }    
            }    
        }

        private void DeactivateButton()
        {
            foreach(Control previousBtn in pnMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.FromArgb(96, 93, 236);
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }    
                
            }    
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDesktop.Controls.Add(childForm);
            this.pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormThongKe(), sender);
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBanAn(), sender);
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMonAn(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNhanVien(), sender);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKhoHang(), sender);
        }
    }
}
