using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace MovieLand.Views
{
    public partial class CardFilm : UserControl
    {
        public string JudulFilm { get; private set; }

        public event EventHandler<string> FilmClicked;
        public CardFilm()
        {
            InitializeComponent();
            lblJudul.Parent = panelFilm;
            lblJudul.BackColor = Color.Transparent;

            pbGambarFilm.Click += OnFilmClicked;
            lblJudul.Click += OnFilmClicked;
        }


        private void panelFilm_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetData(string judul, string pathGambar)
        {
            JudulFilm = judul;
            lblJudul.Text = judul;

            if (File.Exists(pathGambar))
            {
                pbGambarFilm.Image = Image.FromFile(pathGambar);
            }
            else
            {
                pbGambarFilm.Image = null;
            }
        }

        private void OnFilmClicked(object sender, EventArgs e)
        {
            FilmClicked?.Invoke(this, JudulFilm);
        }

    }

}