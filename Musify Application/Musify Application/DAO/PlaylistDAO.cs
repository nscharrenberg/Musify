﻿using Musify_Application.Interface;
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
        private SqlDataAccessObject sqlDAO = new SqlDataAccessObject();

        public DataTable GetAllUsers()
        {
            string query = "SELECT * FROM [User]";
            DataTable dt = sqlDAO.Execute(query);

            return dt;
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
    }
}
