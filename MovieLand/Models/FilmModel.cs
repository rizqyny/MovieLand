using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand.Models
{
    public class FilmModel
    {
        public int id_produk { get; set; }
        public string judul { get; set; }
        public int durasi { get; set; }
        public string deskripsi { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public int id_kategori { get; set; }
    }

    public class KategoriModel
    {
        public int id_kategori { get; set; }
        public string nama_kategori { get; set; }
    }
}

