using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNH_Winform
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentButton;
        private Form currentChildForm;
        private Panel leftBorderBtn;


        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            pnMenu.Controls.Add(leftBorderBtn);
            btnOrder_Click(btnOrder, EventArgs.Empty);
            //OpenChildForm(new Forms.FormThongKe());

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object btnSender, Color color)
        {
            if(btnSender != null)
            {
                if(currentButton != (IconButton)btnSender)
                {
                    //Button
                    DeactivateButton();
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = Color.FromArgb(41, 39, 40);
                    currentButton.ForeColor = color;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = color;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    //pnTitleBar.BackColor = Color.FromArgb(128, 128, 255);
                    //pnTitleBar.ForeColor = Color.White;
                    //pnLogo.BackColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(128, 128, 255), 0.3);
                    leftBorderBtn.Size = new Size(9, currentButton.Size.Height);

                    //Left Border Button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                    //Button Current Child Form
                    btnCurrentChildForm.IconChar = currentButton.IconChar;
                    btnCurrentChildForm.IconColor = color;

                }    
            }    
        }

        private void DeactivateButton()
        {  
            if(currentButton != null)
            {
                
                currentButton.BackColor = Color.FromArgb(41, 39, 40);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro; 
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(178, 8, 55);
            public static Color color2 = Color.FromArgb(178, 8, 55);
            public static Color color3 = Color.FromArgb(178, 8, 55);
            public static Color color4 = Color.FromArgb(178, 8, 55);
            public static Color color5 = Color.FromArgb(178, 8, 55);
            public static Color color6 = Color.FromArgb(178, 8, 55);
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //Chi mo form
                currentChildForm.Close();
            }
            //ActivateButton(btnSender);
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDesktop.Controls.Add(childForm);
            this.pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurentChildForm.Text = childForm.Text;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Forms.FormGoiMon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormThongKe());
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormBanAn());
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormMonAn());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.FormNhanVien());
        }
        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.FormKhoHang());
        }

        private void Reset()
        {
            DeactivateButton();
            leftBorderBtn.Visible = false;
            btnCurrentChildForm.IconChar = IconChar.Home;
            btnCurrentChildForm.IconColor = Color.MediumPurple;
            lblCurentChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
