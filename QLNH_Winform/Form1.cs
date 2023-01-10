using FontAwesome.Sharp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Media.Animation;
using QLNH_Winform.DAO;

namespace QLNH_Winform
{
    public partial class FormMainMenu : Form
    {
        private Account loginAccount;
        private Timer t;

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
            //btnOrder_Click(btnOrder, EventArgs.Empty);
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

        private FormDatHang currentFormDonHang;
        event EventHandler btnNewOrderClicked
        {
            add { this.currentFormDonHang.btnNewOrder.Click += value; }
            remove { this.currentFormDonHang.btnNewOrder.Click -= value; }
        }

        event EventHandler btnEditOrderClicked
        {
            add { this.currentFormDonHang.btnEditOrder.Click += value; }
            remove { this.currentFormDonHang.btnEditOrder.Click -= value; }
        }
        void reloadAccount()
        {
            LoginAccount = AccountDAO.Instance.GetAccountByUserName(LoginAccount.UserName);
        }
        void ChangeAccount(int type)
        {
            btnOrder.Visible = (type & 1 | (type >> 1) & 1 | (type >> 2) & 1) != 0;
            type >>= 3;
            btnMonAn.Visible = (type & 1 | (type >> 1) & 1 | (type >> 2) & 1) != 0;
            type >>= 3;
            btnBanAn.Visible = (type & 1 | (type >> 1) & 1 | (type >> 2) & 1) != 0;
            type >>= 3;
            btnTaiKhoan.Visible = (type & 1 | (type >> 1) & 1 | (type >> 2) & 1) != 0;
            type >>= 3;
            btnNhanVien.Visible = (type & 1 | (type >> 1) & 1 | (type >> 2) & 1) != 0;
            type >>= 3;
            btnThongKe.Visible = (type & 1 | (type >> 1) & 1 | (type >> 2) & 1) != 0;
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
                    currentButton.BackColor = Color.FromArgb(241, 243, 245);
                    currentButton.ForeColor = Color.FromArgb(57, 213, 213);
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = Color.FromArgb(57, 213, 213);
                    currentButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    pnTitleBar.BackColor = Color.White;
                    //pnTitleBar.ForeColor = Color.White;
                    //pnLogo.BackColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(128, 128, 255), 0.3);
                    leftBorderBtn.Size = new Size(9, currentButton.Size.Height);

                    //Left Border Button
                    leftBorderBtn.FillColor = Color.FromArgb(98, 182, 183);
                    leftBorderBtn.FillColor2 = Color.FromArgb(28, 49, 94);
                    leftBorderBtn.BackColor = Color.FromArgb(57, 213, 213);
                    leftBorderBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                    //Button Current Child Form
                    btnCurrentChildForm.IconChar = currentButton.IconChar;
                    btnCurrentChildForm.IconColor = Color.FromArgb(0, 23, 55);

                }
            }
        }

        private void DeactivateButton()
        {
            if (currentButton != null)
            {

                currentButton.BackColor = Color.White;
                currentButton.ForeColor = Color.FromArgb(0, 23, 55);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(101, 114, 133);
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
                if (currentChildForm.IsHandleCreated)
                {
                    return;
                }
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

            lblCurentChildForm.Text = childForm.Text.ToUpper();

        }

        internal void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            currentFormDonHang = new FormDatHang(((loginAccount.Type >> 1) & 1) == 0);
            btnNewOrderClicked += btnNewOrder_Click;
            btnEditOrderClicked += btnEditOrder_Click;
            OpenChildForm(currentFormDonHang);
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTaoDon());
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (currentFormDonHang.dtgvPrcsBill.SelectedRows.Count < 1) return;
            DataGridViewRow tmp = currentFormDonHang.dtgvPrcsBill.SelectedRows[0];
            int idTable = (int)tmp.Cells["idTable"].Value;
            int idBill = (int)tmp.Cells["id"].Value;
            OpenChildForm(new Forms.FormTaoDon(idTable, idBill));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(new Forms.FormThongKe());
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(new Forms.FormBanAn(((loginAccount.Type >> 8) & 1) == 0));
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            cuurrentFormMonAn = new Forms.FormMonAn(((loginAccount.Type >> 5) & 1) == 0);
            btnEditCategoryClicked += btnDanhMuc_Click;
            OpenChildForm(cuurrentFormMonAn);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDanhMuc());
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien(((loginAccount.Type >> 14) & 1) == 0);
            form.loginAcc = loginAccount;
            form.UpdateAccount += Form_UpdateAccount;
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            OpenChildForm(form);
        }

        private void Form_UpdateAccount(object sender, AccountEvent e)
        {
            loginAccount = e.Acc;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 8, 55));
            FormTaiKhoan f = new FormTaiKhoan(LoginAccount, ((loginAccount.Type >> 11) & 1) == 0);
            f.UpdateAccount += F_UpdateAccount;
            OpenChildForm(f);
        }

        private void F_UpdateAccount(object sender, AccountEvent e)
        {
            loginAccount = e.Acc;
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

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentChildForm.Close();
            if (currentChildForm.IsHandleCreated)
            {
                e.Cancel = true;
                return;
            }
        }
        private void ReloadPerm(object sender, EventArgs e)
        {
            reloadAccount();
        }
    }
}
