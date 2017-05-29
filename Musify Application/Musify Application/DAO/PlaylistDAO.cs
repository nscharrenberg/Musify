using Musify_Application.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Application.DAO
{
    public class PlaylistDAO : IPlaylistContext
    {
        static SqlDataAccessObject sqlDAO = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDAO.Connectionstring);
        public DataTable GetAllUsers()
        {
            string query = "SELECT * FROM [User]";
            DataTable dt = sqlDAO.Execute(query);

            return dt;
        }

        public DataTable GetMyNotifications(int userId)
        {
            string query = "SELECT item FROM notification WHERE receiver_id = @userId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@userId", SqlDbType.Int);
            command.Parameters["@userId"].Value = userId;

            DataTable dt = sqlDAO.Execute(command);

            return dt;
        }

        public void DeleteReadNotifications(int userId)
        {
            string query = "DELETE FROM notification WHERE receiver_id = @userId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@userId", SqlDbType.Int);
            command.Parameters["@userId"].Value = userId;

            sqlDAO.ExecuteNonQuery(command);
        }

        public void MakePlaylist(string playlist, string description, string imageUrl, DateTime createdAt, bool isPublic, int userId, bool isOwner)
        {
            SqlCommand command = sqlDAO.GetSqlCommand("spCreatePlaylist");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = playlist;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@ImageUrl", SqlDbType.VarChar).Value = imageUrl;
            command.Parameters.Add("@Public", SqlDbType.Bit).Value = isPublic;
            command.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = createdAt;
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
            command.Parameters.Add("@Owner", SqlDbType.Bit).Value = isOwner;

            sqlDAO.ExecuteNonQuery(command);
        }

        public void GetNotificationCount(int userId)
        {
            
        }
    }
}
