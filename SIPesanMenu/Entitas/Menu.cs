using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPesanMenu.Entitas
{
    class Menu
    {
        //deklarasi variabel
        private string id_menu, nama_menu;

        public string Nama_menu
        {
            get { return nama_menu; }
            set { nama_menu = value; }
        }

        public string Id_menu
        {
            get { return id_menu; }
            set { id_menu = value; }
        }
        private int harga_menu;

        public int Harga_menu
        {
            get { return harga_menu; }
            set { harga_menu = value; }
        }
        
        //membuat constructor
        public Menu(string id_menu, string nama_menu, int harga_menu)
        {
            this.Id_menu = id_menu;
            this.Nama_menu = nama_menu;
            this.Harga_menu = harga_menu;                                                                                                                                                                                                                                                                                                                                                                                
        }
    }
}
