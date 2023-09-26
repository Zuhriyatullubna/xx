using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPesanMenu.Entitas
{
    class Pelanggan
    {
        //deklarasi variabel
        private string id_pelanggan, nama_pelanggan, alamat, telp;

        public string Telp
        {
            get { return telp; }
            set { telp = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }


        public string Nama_pelanggan
        {
            get { return nama_pelanggan; }
            set { nama_pelanggan = value; }
        }

        public string Id_pelanggan
        {
            get { return id_pelanggan; }
            set { id_pelanggan = value; }
        }

        //membuat constructor
        public Pelanggan (string id_pelanggan, string nama_pelanggan, string alamat, string telp)
        {
            this.Id_pelanggan = id_pelanggan;
            this.Nama_pelanggan = nama_pelanggan;
            this.Alamat = alamat;
            this.Telp = telp;

        }
    }
}
