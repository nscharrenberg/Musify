using Musify_Application.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Musify_Application.Repository;

namespace Musify_Application
{
    public partial class ArtistFrm : Form
    {
        static ArtistDao artistDAO = new ArtistDao();
        ArtistRepository ar = new ArtistRepository(artistDAO);

        static GenreDAO genreDao = new GenreDAO();
        GenreRepository gr = new GenreRepository(genreDao);

        // Error Handling
        ErrorHandling eh = new ErrorHandling();
        public ArtistFrm()
        {
            InitializeComponent();
        }

        private void addArtistBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ar.AddArtist(addNameTxt.Text, addBigImageTxt.Text, addSmallImageTxt.Text, addBioTxt.Text);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                GenreFrm gf = new GenreFrm();
                gf.ShowDialog();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string search = searchTxt.Text;
                updateNameTxt.Text = ar.SearchArtistByName(search).Name;
                UpdateBiographyTxt.Text = ar.SearchArtistByName(search).Biography;
                UpdateBigImageTxt.Text = ar.SearchArtistByName(search).SmallImage;
                UpdateSmallImageTxt.Text = ar.SearchArtistByName(search).SmallImage;
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }

            try
            {
                artistPic.Load(ar.SearchArtistByName(searchTxt.Text).BigImage);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }

        private void ArtistFrm_Load(object sender, EventArgs e)
        {
            try
            {
                artistList.ValueMember = "id";
                artistList.DisplayMember = "name";
                artistList.DataSource = ar.AllArtists();

            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }

            try
            {
                genreList.DataSource = gr.AllGenres();
                genreList.ValueMember = "id";
                genreList.DisplayMember = "name";
                
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }

        private void artistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedArtist = (int)artistList.SelectedValue;
                artistIDLbl.Text = ar.SearchArtistById(selectedArtist).Id.ToString();
                updateNameTxt.Text = ar.SearchArtistById(selectedArtist).Name;
                UpdateBiographyTxt.Text = ar.SearchArtistById(selectedArtist).Biography;
                UpdateBigImageTxt.Text = ar.SearchArtistById(selectedArtist).SmallImage;
                UpdateSmallImageTxt.Text = ar.SearchArtistById(selectedArtist).SmallImage;
                artistPic.Load(ar.SearchArtistById(selectedArtist).BigImage);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }

        private void updateArtistBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ar.UpdateArtist(Convert.ToInt32(artistIDLbl.Text), updateNameTxt.Text, UpdateBiographyTxt.Text,
                    UpdateBigImageTxt.Text, UpdateSmallImageTxt.Text);
                
                errorLbl.Text = "Updated!";
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                errorLbl.Text = "Could not Update!";
            }

            try
            {
                foreach (var genre in genreList.CheckedItems)
                {
                    ar.AddGenreToArtist(Convert.ToInt32(artistIDLbl.Text), Convert.ToInt32(genreList.SelectedValue));
                    errorLbl.Text = "Updated! '" + genre +"'";
                };


            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                errorLbl.Text = "Could not Update!";
            }

            try
            {
                ar.RefreshList();
                artistList.ValueMember = "id";
                artistList.DisplayMember = "name";
                artistList.DataSource = ar.AllArtists();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                errorLbl.Text += " Couldn't Refresh List";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ar.DeleteArtistById(Convert.ToInt16(artistIDLbl.Text));
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ar.RefreshList();
                artistList.ValueMember = "id";
                artistList.DisplayMember = "name";
                artistList.DataSource = ar.AllArtists();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
        }

        private void genreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PlaylistFrm pf = new PlaylistFrm();
                pf.ShowDialog();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
        }
    }
}
