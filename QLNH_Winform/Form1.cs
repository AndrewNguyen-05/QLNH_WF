﻿using FontAwesome.Sharp;
using QLNH_Winform.DTO;
using QLNH_Winform.Forms;
using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNH_Winform
{
    public partial class FormMainMenu : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        //Fields
        private IconButton currentButton;
        private Form currentChildForm;
        private Guna2GradientPanel leftBorderBtn;

        //Constructor
        public FormMainMenu(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc; 
            
            

            this.ClientSize = new System.Drawing.Size(1440, 800);

            leftBorderBtn = new Guna2GradientPanel();
            pnMenu.Controls.Add(leftBorderBtn);
            btnOrder_Click(btnOrder, EventArgs.Empty);
            //OpenChildForm(new Forms.FormThongKe());

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Event bubble
        private FormMonAn cuurrentFormMonAn;
        event EventHandler btnEditCategoryClicked
        {
            add { this.cuurrentFormMonAn.btnEditCategory.Click += value; }
            remove { this.cuurrentFormMonAn.btnEditCategory.Click -= value; }
        }

        void ChangeAccount(int type)
        {
            btnNhanVien.Visible = (type == 1);
            btnThongKe.Visible = (type == 1);
        }

        private void ActivateButton(object btnSender, Color color)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    //Button
                    DeactivateButton();
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = Color.FromArgb(41, 39, 40);
                    currentButton.ForeColor = Color.FromArgb(244, 237, 146);
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = Color.FromArgb(244, 237, 146);
                    currentButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    //pnTitleBar.BackColor = Color.FromArgb(128, 128, 255);
                    //pnTitleBar.ForeColor = Color.White;
                    //pnLogo.BackColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(128, 128, 255), 0.3);
                    leftBorderBtn.Size = new Size(9, currentButton.Size.Height);

                    //Left Border Button
                    leftBorderBtn.FillColor = Color.FromArgb(244, 237, 146);
                    leftBorderBtn.FillColor2 = Color.FromArgb(25, 104, 143);
                    leftBorderBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                    //Button Current Child Form
                    btnCurrentChildForm.IconChar = currentButton.IconChar;
                    btnCurrentChildForm.IconColor = Color.Tomato;

                }
            }
        }

        private void DeactivateButton()
        {
            if (currentButton != null)
            {

                currentButton.BackColor = Color.FromArgb(41, 39, 40);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        //Structs
        //private struct RGBColors
        //{
        //    public static Color color1 = Color.FromArgb(178, 8, 55);
        //    public static Color color2 = Color.FromArgb(178, 8, 55);
        //    public static Color color3 = Color.FromArgb(178, 8, 55);
        //    public static Color color4 = Color.FromArgb(178, 8, 55);
        //    public static Color color5 = Color.FromArgb(178, 8, 55);
        //    public static Color color6 = Color.FromArgb(178, 8, 55);
        //}
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
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
            pnTitleBar.FillColor = Color.FromArgb(255, 224, 192);
            pnTitleBar.FillColor2 = Color.FromArgb(192, 192, 255);
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(new Forms.FormGoiMon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnTitleBar.FillColor = Color.White;
            pnTitleBar.FillColor2 = Color.White;
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(new Forms.FormThongKe());
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            pnTitleBar.FillColor = Color.FromArgb(236, 233, 146);
            pnTitleBar.FillColor2 = Color.FromArgb(31, 108, 143);
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(new Forms.FormBanAn());
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            pnTitleBar.FillColor = Color.FromArgb(255, 255, 192);
            pnTitleBar.FillColor2 = Color.FromArgb(192, 255, 255);
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            cuurrentFormMonAn = new Forms.FormMonAn();
            btnEditCategoryClicked += btnDanhMuc_Click;
            OpenChildForm(cuurrentFormMonAn);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDanhMuc());
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnTitleBar.FillColor = Color.White;
            pnTitleBar.FillColor2 = Color.White;
            FormNhanVien form = new FormNhanVien();
            form.loginAcc = loginAccount;
            form.UpdateAccount += Form_UpdateAccount;
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(form);
        }

        private void Form_UpdateAccount(object sender, AccountEvent e)
        {
            loginAccount = e.Acc;
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(new Forms.FormKhoHang());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            pnTitleBar.FillColor = Color.FromArgb(255, 251, 233);
            pnTitleBar.FillColor2 = Color.FromArgb(255, 251, 233);
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            FormTaiKhoan f = new FormTaiKhoan(LoginAccount);
            f.UpdateAccount += F_UpdateAccount;
            OpenChildForm(f);
        }

        private void F_UpdateAccount(object sender, EventArgs e)
        {
            // Update DisplayName at FormMain
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
