using Npgsql;
using System.Data;

namespace RoyalLibraryAPI.Repository
{
    public class DataContext : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DataContext()
        {
            Connection = new NpgsqlConnection("Host=royallibrary.database;Username=postgres;Password=admin;Database=royallibrary");
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
