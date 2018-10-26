using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            artistCombo.DataSource = DataService.GetAllArtists();
            artistCombo.DisplayMember = "name";
            artistCombo.ValueMember = "Id";
            Artist obj = artistCombo.SelectedItem as Artist;

            if (obj != null)
            {
                albumCombo.DataSource = DataService.GetAlbumsByArtist(obj.Name);
                albumCombo.DisplayMember = "name";
                albumCombo.ValueMember = "Id";
                Album alb = albumCombo.SelectedItem as Album;

                if (alb != null)
                    songsGridView.DataSource = DataService.GetSongsInAlbum(alb.Id);
            }

        }

        private void artistCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist obj = artistCombo.SelectedItem as Artist;

            if (obj != null)
            {
                albumCombo.DataSource = DataService.GetAlbumsByArtist(obj.Name);
                albumCombo.DisplayMember = "name";
                albumCombo.ValueMember = "Id";
                Album alb = albumCombo.SelectedItem as Album;
            }

        }

        private void albumCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album obj = albumCombo.SelectedItem as Album;

            if (obj != null)
                songsGridView.DataSource = DataService.GetSongsInAlbum(obj.Id);

        }
    }
}
