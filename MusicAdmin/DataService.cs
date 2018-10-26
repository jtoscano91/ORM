using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MusicAdmin
{
    public static class DataService
    {
        public static List<Artist> GetAllArtists()
        {
            using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                return conn.Query<Artist>("SELECT id, name FROM artists").ToList();
            }
        }

        public static List<Album> GetAlbumsByArtist(string artist)
        {
            using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                return conn.Query<Album>("getAlbumsByArtist", new { Artist = artist }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<Song> GetSongsInAlbum(long albumId)
        {
            using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                return conn.Query<Song>("getSongsByAlbum", new { Album = albumId }, commandType: CommandType.StoredProcedure).ToList();
            }

        }
    }
}
