using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIPesanMenu.Manager
{
    class ManagerKaryawan
    {
        static int temp;
        static string query;

        //membuat method tambah data
        public int Tambah(Entitas.Karyawan k)
        {
            temp = 0;
            query = "INSERT INTO tbl_karyawan VALUES( "+
                " '"+k.Id_karyawan+"',  "+
                " '"+k.Nama_karyawan+"',  "+
                " '"+k.Tempat_lahir+"',  "+
                " '"+k.Tgl_lahir.ToString("yyyy-MM-dd") + "',  "+
                " '"+k.Jenis_kelamin+"',  "+
                " '"+k.Alamat+"',  "+
                " '"+k.Telp+"'";

            try
            {
                temp = Fungsi.EQuery(query);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return temp;
        }

        //membuat method ubah data
        public int Edit(Entitas.Karyawan k)
        {
            temp = 0;
            query = "UPDATE tbl_karyawan SET " +
                "nama_karyawan= '" + k.Nama_karyawan + "',  " +
                "tempat_lahir= '" + k.Tempat_lahir + "',  " +
                "tgl_lahir= '" + k.Tgl_lahir.ToString("yyyy-MM-dd") + "',  " +
                "jenis_kelamin= '" + k.Jenis_kelamin + "',  " +
                "alamat= '" + k.Alamat + "',  " +
                "telp= '" + k.Telp + "',"+
                "WHERE id_karyawan= '"+k.Id_karyawan+"'";

            try
            {
                temp = Fungsi.EQuery(query);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return temp;
        }


        //membuat method hapus data
        public int Hapus(string ha)
        {
            temp = 0;
            query = "DELETE FROM tbl_karyawan WHERE id_karyawan = '" + ha + "'";

            try
            {
                temp = Fungsi.EQuery(query);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return temp;
        }


        //method untuk menampilkan data
        public void TampilData(string query, string tabel, DataGridView dg)
        {
            try
            {
                dg.DataSource = Fungsi.DataGrid(query, tabel);
                dg.DataMember = tabel;
                //memberikan nama tiap kolom 
                dg.Columns[0].HeaderText = " ID Karyawan";
                dg.Columns[1].HeaderText = " Nama Karyawan";
                dg.Columns[2].HeaderText = " Tempat Lahir";
                dg.Columns[3].HeaderText = " Tanggal Lahir";
                dg.Columns[4].HeaderText = " Jenis Kelamin";
                dg.Columns[5].HeaderText = " Alamat";
                dg.Columns[6].HeaderText = " Telepon";
                //agar kolom tidak bisa diperbesar secara manual (optional)
                dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            finally { }
        }
    }
}
