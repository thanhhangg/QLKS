using System;
using System.Data;
using System.Data.SqlClient;

namespace QLKS
{
    public static class DataAccess
    {
        private static string connectionString = "Server=localhost;Database=QLKS;Trusted_Connection=True;";

        // use to execute select
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }

                connection.Close();
            }

            return dataTable;
        }

        internal static DataTable GetData(string v)
        {
            throw new NotImplementedException();
        }

        // use to execute insert, update, delete
        public static int ExecuteNonQuery(string query)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new(query, connection))
                {
                    result = command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return result;
        }

        public static int ExecuteScalar(string query)
        {
            int newID;

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    newID = (int)command.ExecuteScalar();
                }

                connection.Close();
            }

            return newID;
        }
    }
}