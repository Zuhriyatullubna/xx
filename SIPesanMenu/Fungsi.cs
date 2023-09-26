using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//import namespace

using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIPesanMenu
{
    class Fungsi : Koneksi
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DataSet ds;
        static SqlDataReader sdr;

        public static int EQuery(string query)
        {
            con = Koneksi.Conn;
            cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = query;

                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
             }
            finally {
                con.Close();
            }

        }
        //method untuk mengatur select atau menampilkan data ke datagridview
        public static DataSet DataGrid(string query, string tabel)
        {
            con = Koneksi.Conn;
            sda = new SqlDataAdapter(query, con);
            ds = new DataSet();

            try
            {
                con.Open();
                sda.Fill(ds, tabel);
                return ds;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        // method untuk menampilkan data kedalam combobox
        public static void Set_ComboBox(string query, string row, ComboBox box)
        {
            con = Koneksi.Conn;
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                sdr = cmd.ExecuteReader();
                box.Items.Clear();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        box.Items.Add(sdr[row]);
                    }
                }


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sdr != null)
                    sdr.Close();
                    con.Close();
            }
        }


        // method untuk menampilkan data kedalam textbox
        public static void Set_TextBox(string query, string row, TextBox box)
        {
            con = Koneksi.Conn;
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                sdr = cmd.ExecuteReader();
                box.Clear();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        box.Text=(sdr[row].ToString());
                    }
                }


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sdr != null)
                    sdr.Close();
                    con.Close();
            }
        }

        //method utk mencari data di datagridview
        public static void Cari(string query, string tabel, DataGridView dg)
        {
            con = Koneksi.Conn;

            try
            {
                con.Open();
                sda = new SqlDataAdapter(query, con);
                ds = new DataSet();
                sda.Fill(ds, tabel);
                dg.DataSource = ds;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                con.Close();
            }
        }




    }
}
