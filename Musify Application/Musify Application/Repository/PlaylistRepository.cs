using Musify_Application.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Application.Repository
{
    public class PlaylistRepository
    {
        private IPlaylistContext context;

        public PlaylistRepository(IPlaylistContext context)
        {
            this.context = context;
        }

        public DataTable GetAllUsers()
        {
            return context.GetAllUsers();
        }

        public DataTable GetMyNotifications(int userId)
        {
            return context.GetMyNotifications(userId);
        }

        public void DeleteReadNotifications(int userId)
        {
            context.DeleteReadNotifications(userId);
        }
        public void MakePlaylist(string playlist, string description, string imageUrl, DateTime createdAt, bool isPublic, int userId, bool isOwner)
        {
            context.MakePlaylist(playlist, description, imageUrl, createdAt, isPublic, userId, isOwner);
        }

        public void GetNotificationCount(int userId)
        {
            context.GetNotificationCount(userId);
        }
    }
}
