using Musify_Application.DAO;
using Musify_Application.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musify_Application
{
    public partial class PlaylistFrm : Form
    {
        ErrorHandling eh = new ErrorHandling();
        static PlaylistDAO playlistDAO = new PlaylistDAO();
        PlaylistRepository pr = new PlaylistRepository(playlistDAO);

        public PlaylistFrm()
        {
            InitializeComponent();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void genreToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void PlaylistFrm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = pr.GetAllUsers();
                userCombo.DisplayMember = "username";
                userCombo.ValueMember = "id";
                userCombo.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                eh.WriteToFile(ex.ToString());
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool checkstate = publicCheck.CheckState == CheckState.Checked ? true : false;

            try
            {
                pr.MakePlaylist(nameTxt.Text, descriptionTxt.Text, imageTxt.Text, DateTime.Now, checkstate, (int)userCombo.SelectedValue, true);
                MessageBox.Show("Playlist" + nameTxt.Text + "has been added successfully!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                eh.WriteToFile(ex.ToString());
            }
        }
    }
}
