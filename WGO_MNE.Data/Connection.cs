using MySql.Data.MySqlClient;

namespace WGO_MNE.Data
{
    public class Connection
    {
        public MySqlConnection sqlConn;
        public const string datasourceURL = "Server=IVANP\\SQLEXPRESS;Database=WGO_MNE;Integrated Security=True;TrustServerCertificate=True";

        public Connection()
        {
            sqlConn = new MySqlConnection(datasourceURL);
        }

        public void Open()
        {
            sqlConn.Open();
        }

        public void Close()
        {
            sqlConn.Close();
        }
    }
}
