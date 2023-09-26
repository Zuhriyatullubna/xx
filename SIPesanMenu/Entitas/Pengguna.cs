using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPesanMenu.Entitas
{
    class Pengguna
    {
        private string id_pengguna, kata_sandi, id_karyawan;

        public string Id_karyawan
        {
            get { return id_karyawan; }
            set { id_karyawan = value; }
        }

        public string Kata_sandi
        {
            get { return kata_sandi; }
            set { kata_sandi = value; }
        }

        public string Id_pengguna
        {
            get { return id_pengguna; }
            set { id_pengguna = value; }
        }

        //membuat constructor
        public Pengguna(string id_pengguna, string kata_sandi, string id_karyawan)
        {
            this.Id_pengguna = id_pengguna;
            this.Kata_sandi = kata_sandi;
            this.Id_karyawan = id_karyawan;
        }

    }
}
