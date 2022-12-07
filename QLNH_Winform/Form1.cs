using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;


namespace QLNH_Winform
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentButton;
        private Form activeForm;
        private Panel leftBorderBtn;


        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(9, 101);
            pnMenu.Controls.Add(leftBorderBtn); 
            OpenChildForm(new Forms.FormThongKe(), btnThongKe);
        }

        //private Color SelectThemeColor()
        //{

        //}
        private void ActivateButton(object btnSender, Color color)
        {
            if(btnSender != null)
            {
                if(currentButton != (IconButton)btnSender)
                {
                    //Button
                    DeactivateButton();
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = Color.FromArgb(95, 77, 221);
                    currentButton.ForeColor = color;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = color;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    //currentButton.ImageAlign = ContentAlignment.MiddleRight;

                    pnTitleBar.BackColor = Color.FromArgb(128, 128, 255);
                    pnTitleBar.ForeColor = Color.White;
                    pnLogo.BackColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(128, 128, 255), 0.3);
                    leftBorderBtn.Size = new Size(9, currentButton.Size.Height);
                    //Left Border Button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                }    
            }    
        }

        private void DeactivateButton()
        {
            //foreach(Control previousBtn in pnMenu.Controls)
            //{
            //    if(previousBtn.GetType() == typeof(Button))
            //    {
            //        previousBtn.BackColor = Color.Gainsboro;
            //        previousBtn.ForeColor = Color.FromArgb(31,30,68);
                    
            //        previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    }    
                
            //}    
            if(currentButton != null)
            {
                
                currentButton.BackColor = Color.FromArgb(31,30,68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro; 
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
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
            //OpenChildForm(new Forms.FormThongKe(), sender);
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormBanAn(), sender);
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormMonAn(), sender);
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormNhanVien(), sender);
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormKhoHang(), sender);
            ActivateButton(sender, RGBColors.color3);
        }
    }
}
