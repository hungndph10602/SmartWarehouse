using SmartWarehouse.Views;
using SmartWareHouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWarehouse.Utilities;
using System.Collections;

namespace SWarehouse.Views
{
    public partial class F02_Main : Form
    {
        //tạo biến tĩnh để truyền dữ liệu các Form
        public static F02_Main mdiobj;
        public F02_Main()
        {
            InitializeComponent();
            SortcutEnable();
            loadmain();
        }
        private void SortcutEnable()
        {
            if (!AppConstants.Islogin)
            {
                đăngNhậpToolStripMenuItem.ShortcutKeys = Keys.Control|Keys.L;
                thốngKêToolStripMenuItem.ShortcutKeys = Keys.None;
                quanrLíNhânViênToolStripMenuItem.ShortcutKeys = Keys.None;
                quảnLíkhachhangToolStripMenuItem.ShortcutKeys = Keys.None;
                quảnLíNhàCungCấpToolStripMenuItem.ShortcutKeys = Keys.None;
                quảnLíHóaĐơnToolStripMenuItem.ShortcutKeys = Keys.None;
                quảnLíNhậpKhoToolStripMenuItem.ShortcutKeys = Keys.None;
                quảnLíSảnPhẩmToolStripMenuItem.ShortcutKeys = Keys.None;
                quảnLíXuấtKhoToolStripMenuItem.ShortcutKeys = Keys.None;
                tạoPhiếuYêuCầuNhậpToolStripMenuItem.ShortcutKeys = Keys.None;
                hồSơNhânViênToolStripMenuItem.ShortcutKeys = Keys.None;
                đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = Keys.None;
            }
            else
            {
                đăngNhậpToolStripMenuItem.ShortcutKeys = Keys.None;
                thốngKêToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
                quanrLíNhânViênToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
                quảnLíkhachhangToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
                quảnLíNhàCungCấpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.K;
                quảnLíHóaĐơnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
                quảnLíNhậpKhoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
                quảnLíSảnPhẩmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
                quảnLíXuấtKhoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
                tạoPhiếuYêuCầuNhậpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
                hồSơNhânViênToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
                đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            }
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppConstants.Islogin)
            {
                MessageBox.Show("Vui lòng đăng xuất để sử dụng chức năng!");
                return;
            }
            F01_Login loginView = new F01_Login();
            loginView.ShowDialog();
            SortcutEnable();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F10_DoiMatKhau quenMatKhau = new F10_DoiMatKhau();
            quenMatKhau.ShowDialog();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (AppConstants.Islogin == false)
            {
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                hồSơNhânViênToolStripMenuItem.Visible = false;
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
            }
        }
        public void F02_Main_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void loadmain()
        {
            if (AppConstants.Islogin == false)
            {
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                hồSơNhânViênToolStripMenuItem.Visible = false;
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
            }
            F02_Main.mdiobj = this;
            F14_InsideMain i = new F14_InsideMain();
            i.WindowState = FormWindowState.Maximized;
            i.MdiParent = this;
            i.Show();
        }
        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F03_QLHoSoNhanVien qLHoSoNhanVien = new F03_QLHoSoNhanVien(AppConstants.StaffID);
            qLHoSoNhanVien.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, FormClosingEventArgs e)
        {
            var data = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo);
            if (data == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void quảnLíNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F05_QlNhapkho qlNhapkho = new F05_QlNhapkho();
            qlNhapkho.WindowState = FormWindowState.Maximized;
            qlNhapkho.MdiParent = this;
            qlNhapkho.Show();
        }

        private void quảnLíXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F06_QLXuatKho qLXuatKho = new F06_QLXuatKho();
            qLXuatKho.WindowState = FormWindowState.Maximized;
            qLXuatKho.MdiParent = this;
            qLXuatKho.Show();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F08_QLNhaCungCap qLNhaCungCap = new F08_QLNhaCungCap();
            qLNhaCungCap.WindowState = FormWindowState.Maximized;
            qLNhaCungCap.MdiParent = this;
            qLNhaCungCap.Show();
        }

        private void quanrLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F09_QLNhanVien qLNhanVien = new F09_QLNhanVien();
            qLNhanVien.WindowState = FormWindowState.Maximized;
            qLNhanVien.MdiParent = this;
            qLNhanVien.Show();
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F07_QLHoaDon qLHoaDon = new F07_QLHoaDon();
            qLHoaDon.WindowState = FormWindowState.Maximized;
            qLHoaDon.MdiParent = this;
            qLHoaDon.Show();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F04_QLKhachHang qLKhachHang = new F04_QLKhachHang();
            qLKhachHang.WindowState = FormWindowState.Maximized;
            qLKhachHang.MdiParent = this;
            qLKhachHang.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void F02_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void F02_Main_Leave(object sender, EventArgs e)
        {

        }

        private void tạoPhiếuYêuCầuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F12_NoteRequest ycNhap = new F12_NoteRequest();
            ycNhap.WindowState = FormWindowState.Maximized;
            ycNhap.MdiParent = this;
            ycNhap.Show();
        }

        private void F02_Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F13_Statistical f13_Statistical = new F13_Statistical();
            f13_Statistical.WindowState = FormWindowState.Maximized;
            f13_Statistical.MdiParent = this;
            f13_Statistical.Show();
        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F15_Product f15_Product = new F15_Product();
            f15_Product.WindowState = FormWindowState.Maximized;
            f15_Product.MdiParent = this;
            f15_Product.Show();
        }

        private void quênMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F11_FogotPassword f11_FogotPassword = new F11_FogotPassword();
            f11_FogotPassword.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn Đăng xuất không không?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Tài Khoản Đã Được Đăng Xuất !");
                AppConstants.Islogin = false;
                AppConstants.Role = 0;
                AppConstants.UserName = null;
                AppConstants.StaffID = 0;
                AppConstants.AccountID = 0;
                F14_InsideMain f14_InsideMain = new F14_InsideMain();
                f14_InsideMain.MdiParent = this;
                f14_InsideMain.Show();

            }
        }
    }
}
