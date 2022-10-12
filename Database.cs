using System;
using MySqlConnector;

namespace university
{
    public class Database : IDisposable
    {
        public MySqlConnection Connection { get; }


        public Database(string connectionString)
        {
            string myConnectionString;
            //myConnectionString = "server=192.168.1.112;uid=amakkonen;pwd=Eirene1234!;database=university";
            Connection = new MySqlConnection(System.Environment.GetEnvironmentVariable("DATABASE_URL"));
            //Connection = new MySqlConnection(myConnectionString);
        }

        public void Dispose() => Connection.Dispose();
    }
}