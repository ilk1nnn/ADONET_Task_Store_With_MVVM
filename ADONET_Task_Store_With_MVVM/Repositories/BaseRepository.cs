using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Task_Store_With_MVVM.Repositories
{
    public class BaseRepository
    {

        private static string _connectionString = App.SqlConnectionString;
        protected static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}
