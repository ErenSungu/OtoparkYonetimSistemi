using System.Configuration;
using System.Data.SqlClient;

namespace OtoparkYonetimSistemi
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["OtoparkDb"].ConnectionString
            );
        }
    }
}
