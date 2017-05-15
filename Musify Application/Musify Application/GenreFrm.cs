using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Musify_Application.DAO;
using Musify_Application.Repository;

namespace Musify_Application
{
    public partial class GenreFrm : Form
    {
        static GenreDAO genreDao = new GenreDAO();
        GenreRepository gr = new GenreRepository(genreDao);
        ErrorHandling eh = new ErrorHandling();

        public GenreFrm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                nameTxt.Text = gr.SearchGenre(searchTxt.Text).Name;
                descriptionTxt.Text = gr.SearchGenre(searchTxt.Text).Description;
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
            
            try
            {
                genrePic.Load(gr.SearchGenre(searchTxt.Text).Image);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                genreList.ValueMember = "id";
                genreList.DisplayMember = "name";
                genreList.DataSource = gr.AllGenres();

            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
        }

        

        private void genreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedGenre = (int) genreList.SelectedValue;
                genreIDLbl.Text = gr.SearchGenreById(selectedGenre).Id.ToString();
                nameTxt.Text = gr.SearchGenreById(selectedGenre).Name;
                descriptionTxt.Text = gr.SearchGenreById(selectedGenre).Description;
                imageUrlTxt.Text = gr.SearchGenreById(selectedGenre).Image;
                genrePic.Load(gr.SearchGenreById(selectedGenre).Image);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            } 
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            string genreName = namTxt.Text;
            string genreDescription = descTxt.Text;
            string genreImage = imgTxt.Text;
            try
            {
                gr.AddGenre(genreName, genreDescription, genreImage);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }  
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gr.UpdateGenre(Convert.ToInt32(genreIDLbl.Text), nameTxt.Text, descriptionTxt.Text,
                    imageUrlTxt.Text);
                errorLbl.Text = "Updated!";
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gr.DeleteGenreById(Convert.ToInt16(genreIDLbl.Text));
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
                gr.RefreshList();
                genreList.ValueMember = "id";
                genreList.DisplayMember = "name";
                genreList.DataSource = gr.AllGenres();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ArtistFrm af = new ArtistFrm();
                af.ShowDialog();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
            }
            
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
