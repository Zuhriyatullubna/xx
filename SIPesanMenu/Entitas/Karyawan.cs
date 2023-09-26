using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPesanMenu.Entitas
{
    class Karyawan
    {
        //deklarasi variabel
        private string id_karyawan, nama_karyawan, tempat_lahir, jenis_kelamin, alamat, telp;

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

        public string Jenis_kelamin
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }

        public string Tempat_lahir
        {
            get { return tempat_lahir; }
            set { tempat_lahir = value; }
        }

        public string Nama_karyawan
        {
            get { return nama_karyawan; }
            set { nama_karyawan = value; }
        }

        public string Id_karyawan
        {
            get { return id_karyawan; }
            set { id_karyawan = value; }
        }
        private DateTime tgl_lahir;

        public DateTime Tgl_lahir
        {
            get { return tgl_lahir; }
            set { tgl_lahir = value; }
        }
        
        //membuat constructor
        public Karyawan (string id_karyawan, string nama_karyawan, string tempat_lahir, DateTime tgl_lahir, string jenis_kelamin, string alamat, string telp)
        {
            this.Id_karyawan = id_karyawan;
            this.Nama_karyawan = nama_karyawan;
            this.Tempat_lahir = tempat_lahir;
            this.Tgl_lahir = tgl_lahir;
            this.Jenis_kelamin = jenis_kelamin;
            this.Alamat = alamat;
            this.Telp = telp;
        }
    }
}
