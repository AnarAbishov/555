using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_Full.Models;

namespace Cinema_Full
{
    public partial class Form1 : Form
    {
        private CinemaEntities db = new CinemaEntities();
        public Form1()
        {
            InitializeComponent();
            Display();
            fillFilms();
            fillHalls();
        }

        private void Display()
        {
            dgvFilms.DataSource = db.Films.Select(f => new {f.Name, f.MovieLength, f.ReleaseYear, f.Language, f.Rejissor,f.Janrs }).ToList();
        }

       
        private void fillFilms()
        {
            foreach (Film item in db.Films.ToList())
            {
                cmbxFilms.Items.Add(item.Name);
            }
        }

        private void fillHalls()
        {
            foreach (Hall item in db.Halls.ToList())
            {
                cmbxHalls.Items.Add(item.Name);
            }
        }

        private void cmbxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string films = cmbxFilms.Text;
            if (films == string.Empty)
            {
                MessageBox.Show("Filmi seçin");
                return;
            }

            cmbxHalls.Items.Clear();
            cmbxHalls.Text = "";
            

            int filmId = this.getCountryIdByName(country);

            List<Film> cities = db.Films.Where(c => c.CountryId == countryId).ToList();

            foreach (Film item in cities)
            {
                cmbxFilms.Items.Add(item.Name);
            }
        }
         private int getCountryIdByName(string filmsName)
        {
            return db.Films.FirstOrDefault(c => c.Name == filmsName).Id;
        }
    }
}
