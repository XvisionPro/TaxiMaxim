using System.Data.SqlClient;

namespace TaxiMaxim.BL.Model
{
    public class DataBase
    {

        private const string SERVER_NAME = "NOOTELLA\\SQLEXPRESS";
        private const string DATABASE_NAME = "TaxiMaxim";
        /// <summary>
        /// Подключение к базе данных
        /// </summary>
        SqlConnection sqlConnection = new SqlConnection($"Data Source={SERVER_NAME};Initial Catalog={DATABASE_NAME};Integrated Security=True");

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
    }
}
