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
            myConnectionString = "server=u-cdbr-west-03.cleardb.net;uid=7b33948994798;pwd=001c5211;database=heroku_666f9644cc1b28b?";
            //Connection = new MySqlConnection(System.Environment.GetEnvironmentVariable("DATABASE_URL"));
            Connection = new MySqlConnection(myConnectionString);
        }

        public void Dispose() => Connection.Dispose();
    }
}