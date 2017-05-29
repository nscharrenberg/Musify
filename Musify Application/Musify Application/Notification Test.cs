using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Musify_Application.DAO;
using Musify_Application.Repository;

namespace Musify_Application
{
    public partial class Notification_Test : Form
    {
        ErrorHandling eh = new ErrorHandling();
        static PlaylistDAO playlistDAO = new PlaylistDAO();
        PlaylistRepository pr = new PlaylistRepository(playlistDAO);
        private int selectedUser;
        public Notification_Test()
        {
            InitializeComponent();
        }

        private void Notification_Test_Load(object sender, EventArgs e)
        {
            notifyCountBtn.Visible = false;
            notificationList.Visible = false;
            try
            {
                DataTable dt = pr.GetAllUsers();
                userCombo.DisplayMember = "username";
                userCombo.ValueMember = "id";
                userCombo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                eh.WriteToFile(ex.ToString());
            }
        }

        private void notifyCountBtn_Click(object sender, EventArgs e)
        {
            notificationList.Visible = true;
            

            try
            {
                DataTable dt = pr.GetMyNotifications(selectedUser);
                notificationList.DisplayMember = "item";
                notificationList.ValueMember = "receiver_id";
                notificationList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                eh.WriteToFile(ex.ToString());
            }

            try
            {
                pr.DeleteReadNotifications(selectedUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                eh.WriteToFile(ex.ToString());
            }
        }

        private void chooseUserBtn_Click(object sender, EventArgs e)
        {
            selectedUser = (int)userCombo.SelectedValue;

            if (notificationList.Visible == true)
            {
                notificationList.Visible = false;
            }

            try
            {
                SqlDataAccessObject sqlDAO = new SqlDataAccessObject();
                SqlConnection conn = new SqlConnection(sqlDAO.Connectionstring);
                string query = "SELECT COUNT(*) FROM notification WHERE receiver_id = @userId";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@userId", SqlDbType.Int);
                command.Parameters["@userId"].Value = selectedUser;

                command.Connection.Open();
                notifyCountBtn.Visible = true;
                notifyCountBtn.Text = "You have " + command.ExecuteScalar() + " unread notifications!";
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                eh.WriteToFile(ex.ToString());
            }

        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PlaylistFrm pf = new PlaylistFrm();
                pf.ShowDialog();
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }
    }
}
