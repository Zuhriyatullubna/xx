using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPesanMenu.Entitas
{
    class PesanMenu
    {
        private string id_transaksi, id_pelanggan, id_menu, id_karyawan;

        public string Id_karyawan
        {
            get { return id_karyawan; }
            set { id_karyawan = value; }
        }

        public string Id_menu
        {
            get { return id_menu; }
            set { id_menu = value; }
        }

        public string Id_pelanggan
        {
            get { return id_pelanggan; }
            set { id_pelanggan = value; }
        }

        public string Id_transaksi
        {
            get { return id_transaksi; }
            set { id_transaksi = value; }
        }
        private int tgl_pesan, jml_pesan, sub_total;

        public int Sub_total
        {
            get { return sub_total; }
            set { sub_total = value; }
        }

        public int Jml_pesan
        {
            get { return jml_pesan; }
            set { jml_pesan = value; }
        }

        public int Tgl_pesan
        {
            get { return tgl_pesan; }
            set { tgl_pesan = value; }
        }

        //membuat contructor
        public PesanMenu(string id_transaksi, int tgl_pesan, string id_pelanggan, string id_menu, int jml_pesan, int sub_total, string id_karyawan)
        {
            this.Id_transaksi = id_transaksi;
            this.Tgl_pesan = tgl_pesan;
            this.Id_pelanggan = id_pelanggan;
            this.Id_menu = id_menu;
            this.Jml_pesan = jml_pesan;
            this.Sub_total = sub_total;
            this.Id_karyawan = id_karyawan;
        }
    }
}
