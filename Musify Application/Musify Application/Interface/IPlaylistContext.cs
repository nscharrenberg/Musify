﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Application.Interface
{
    public interface IPlaylistContext
    {
        DataTable GetAllUsers();
        void MakePlaylist(string playlist, string description, string imageUrl, DateTime createdAt, bool isPublic, int userId, bool isOwner);
    }

}
