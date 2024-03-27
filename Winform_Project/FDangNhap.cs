﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Project.ClassDao;
using Winform_Project.ClassDoiTuong;

namespace Winform_Project
{
    public partial class FDangNhap : Form
    {
        public static SinhVien SinhVienAccount;
        public static GiangVien GiangVienAcount;
        SinhVienDao svDao = new SinhVienDao();
        GiangVienDao gvDao = new GiangVienDao();
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text == "1")
            {
                FGiangVien fGiangVien = new FGiangVien();
                this.Hide();
                fGiangVien.ShowDialog();

            }
            else if (txtTaiKhoan.Text !="" && svDao.LayThongTinSinhVien(txtTaiKhoan.Text) != null)
            {
                SinhVienAccount = svDao.LayThongTinSinhVien(txtTaiKhoan.Text);
                FSinhVien.FSinhVien fSinhVien = new FSinhVien.FSinhVien();
                this.Hide();
                fSinhVien.ShowDialog();
            }
            else MessageBox.Show("Sai tài khoản mật khẩu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
