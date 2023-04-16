using System.Data.SqlClient;

namespace TaxiMaxim.BL.Model
{
    public class DataBase
    {

        //private string SERVER_NAME = "DESKTOP-VPOMAI1\\SQL44";
        //private string DATABASE_NAME = "TaxiMaximalnaya";
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }

        /// <summary>
        /// Подключение к базе данных
        /// </summary>

        SqlConnection sqlConnection;
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        public DataBase(string serverName, string databaseName)
        {
            ServerName = serverName;
            DatabaseName = databaseName;
            sqlConnection = new SqlConnection($"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True");
        }
    }
}
