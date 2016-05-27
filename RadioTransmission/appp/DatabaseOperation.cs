using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace appp
{
    class DatabaseOperation
    {
        static DatabaseOperation dbop = null;

        string mysqlConnectionString = null;
        MySqlConnection connection;
        MySqlCommand cmd;


        private DatabaseOperation()
        {
        }

        public static DatabaseOperation DB_OP
        {
            get
            {
                if (dbop == null)
                    dbop = new DatabaseOperation();
                return dbop;
            }
        }

        public bool InitializeConnection(string server, string database, string user, string password)
        {
            if (mysqlConnectionString == null)
            {
                mysqlConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, user, password);
                connection = new MySqlConnection(mysqlConnectionString);
                connection.Open();

            }
            return true;

        }
        public bool Insert()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Media(id,Name,Type,Length,Duration,TST) VALUES(@id, @Name, @Type, @Length, @Duration)";
            cmd.Parameters.AddWithValue("@id",123);
            cmd.Parameters.AddWithValue("@Name", "abc");
            cmd.Parameters.AddWithValue("@Type", "abcd");
            cmd.Parameters.AddWithValue("@Length", 3.1);
            cmd.Parameters.AddWithValue("@Duration", 10);
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}