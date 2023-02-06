using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SFCSADONET24
{
    public class MainConnector
    {
        SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);

        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }

        public SqlConnection GetConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто");
            }
        }

        public class DbExecutor
        {
            private MainConnector connector;

            public DbExecutor(MainConnector connector)
            {
                this.connector = connector;
            }

            public DataTable SelectAll(string table)
            {
                var selectcommandtext = $"select * from {table}";
                var adapter = new SqlDataAdapter(
                  selectcommandtext,
                  connector.GetConnection()
                );

                var ds = new DataSet();
                adapter.Fill(ds);

                return ds.Tables[0];
            }
        }


    }
}
