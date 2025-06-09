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
        public CardFilm()
        {
            InitializeComponent();
            lblJudul.Parent = panelFilm; // atau parent lainnya
            lblJudul.BackColor = Color.Transparent;
        }

        private void panelFilm_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetData(string judul, string pathGambar)
        {
            lblJudul.Text = judul;
            if (File.Exists(pathGambar))
            {
                pbGambarFilm.Image = Image.FromFile(pathGambar);
            }
            else
            {
                pbGambarFilm.Image = null; // atau placeholder
            }


        }

        private void pbGambarFilm_Click(object sender, EventArgs e)
        {
            AddFilmForm addFilmForm = new AddFilmForm();
            addFilmForm.Show();
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {
            AddFilmForm addFilmForm = new AddFilmForm();
            addFilmForm.Show();
        }
    }
}