using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoNetConnectedMode
{
    public class ConnectionHelper
    {
        public static DbConnection GetConnection()
        {
            DbProviderFactory providerFactory = DbProviderFactories.GetFactory(ConfigurationManager
                                                .ConnectionStrings["AspConnectedMode"].ProviderName);

            DbConnection connection = providerFactory.CreateConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["AspConnectedMode"].ConnectionString;
            connection.ConnectionString = connectionString;

            return connection;
        }
    }
}
