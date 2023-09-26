using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SIPesanMenu
{
    public partial class UC_Karyawan : UserControl
    {
        public UC_Karyawan()
        {
            InitializeComponent();
        }
        string jeniskelamin;

        private void TampilDataKaryawan()
        {
            string query = "select * from tbl_karyawan";
            Manager.ManagerKaryawan mm = new Manager.ManagerKaryawan();
            mm.TampilData(query, "tbl_karyawan", dgKaryawan);

        }

        private void UC_Karyawan_Load(object sender, EventArgs e)
        {
            TampilDataKaryawan();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Entitas.Karyawan mk = new Entitas.Karyawan(txtIDKaryawan.Text, txtNamaKaryawan.Text,
                txtTempatLahir.Text, dtTanggalLahir.Value, jeniskelamin, txtAlamat.Text, txtTelepon.Text);
            Manager.ManagerKaryawan mm = new Manager.ManagerKaryawan();
            int i = mm.Tambah(mk);
            if (i == 1)
            {
                MessageBox.Show("Simpan Data berhasil");
            }

        }

        private void rdLakilaki_CheckedChanged(object sender, EventArgs e)
        {
            jeniskelamin = "Laki-laki";
        }

        private void rdPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            jeniskelamin = "Perempuan";
        }

    }
}
