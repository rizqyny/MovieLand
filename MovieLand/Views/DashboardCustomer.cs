﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLand.Controllers;
using MovieLand.Models;

namespace MovieLand.Views
{
    public partial class DashboardCustomer : UserControl
    {
        public DashboardCustomer()
        {
            InitializeComponent();
        }

        private void DashboardCustomer_Load(object sender, EventArgs e)
        {
            LoadDataFilm();
        }

        private void LoadDataFilm()
        {
            List<FilmModel> filmList = FilmController.GetAllFilm();

            int x = 212, y = 220;
            int maxPerRow = 4;
            int counter = 0;

            foreach (var film in filmList)
            {
                string path = Path.Combine(Application.StartupPath, "Images", $"{film.gambar}");

                CardFilm card = new CardFilm();
                card.SetData(film.judul, path); // gambar = path

                card.FilmClicked += (s, judulFilm) =>
                {
                    FilmController controller = new FilmController();
                    var filmDetail = controller.GetFilmbyID(judulFilm);
                    if (filmDetail != null)
                    {
                        FilmClick filmClickForm = new FilmClick(filmDetail);
                        filmClickForm.Show();
                    }
                };

                card.Size = new Size(202, 307);
                card.Location = new Point(x, y);

                this.Controls.Add(card);

                x += card.Width + 76;
                counter++;

                if (counter % maxPerRow == 0)
                {
                    x = 212;
                    y += card.Height + 65;
                }
            }
        }
    }
}
