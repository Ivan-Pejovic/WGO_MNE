using MySql.Data.MySqlClient;

namespace WGO_MNE.Data
{
    public class Connection
    {
        public MySqlConnection sqlConn;
        public const string datasourceURL = "Server=localhost;Database=wgo_mne;User Id=root;Password=admin;";

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
