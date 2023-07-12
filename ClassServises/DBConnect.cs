using Npgsql;

namespace ClassServises
{
    public static class DBConnect
    {
        static string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root";
        static string databaseName = "ToDoAppProject";
        static string connectionStringDatabase = $"Server=localhost;Port=5432;User Id =postgres;Password = root; Database={databaseName};";
        static string tasktable = "tasksofusers";
        static string usertable = "usertable";
        static DBConnect()
        {
                string taskcommand = $"CREATE TABLE IF NOT EXISTS '{tasktable}'(" +
                    $"Id varchar(36)," +
                    $"Title varchar(200)," +
                    $"Description varchar(3000)," +
                    $"DueDate DATE NOT NULL," +
                    $"Priority int," +
                    $"Status int," +
                    $"UserId int not null," +
                    $"PRIMARY KEY(id)," +
                    $"Constraint(fk_userid) " +
                    $"FOREIGN KEY (UserId) " +
                    $"References {usertable}(Id) " +
                    $"on update cascade" +
                    $");";
                string usercommand = $"CREATE TABLE IF NOT EXISTS '{usertable}'(" +
                    $"Id varchar(36) primary key," +
                    $"FirstName varchar(30)," +
                    $"LastName varchar(40)," +
                    $"BirthDate DATE NOT NULL," +
                    $"Username varchar(30)," +
                    $"Password varchar(8)" +
                    $");";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                bool isDatabaseExists;
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT 1 FROM pg_catalog.pg_database WHERE datname='{databaseName}';";
                    isDatabaseExists = cmd.ExecuteScalar() != null;
                }

                if (!isDatabaseExists)
                {
                    // Create the database
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"CREATE DATABASE if not exists '{databaseName}';";
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Database created successfully!");
                    };
                }
                using(var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = usercommand;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = taskcommand;
                    cmd.ExecuteNonQuery();
                }    
                Console.WriteLine($"The table '{tasktable}' created to database");
                }

        }
        public static bool CheckUser(string username)
        {
            string command = $"Select Id, Username From {usertable}";
            using (var con = new NpgsqlConnection(connectionStringDatabase))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = con;
                    var result = GetBySubject();
                    IEnumerable<string> GetBySubject()
                    {
                        cmd.CommandText = $"SELECT * FROM person";
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        var result = new List<string>();
                        while (reader.Read())
                        {
                            result.Add(reader[1] as string);
                        }
                        return result;
                    }
                    if (result.Contains(username))
                    {
                        return false;
                    }
                }
            }
            return true;
            
            
            

        }
        public static bool CheckUser(string username, string password, out string userid)
        {
            userid = string.Empty;
            var resultlist = new List<object[]>();

            string command = $"Select Id, Username, Password From {usertable}";
            using (var con = new NpgsqlConnection(connectionStringDatabase))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand(command, con))
                {
                    using (var reader = cmd.ExecuteReader()) 
                    { 
                        var rowValues = new object[reader.FieldCount];
                        reader.GetValues(rowValues);
                        resultlist.Add(rowValues);
                    }
                }
            }
            foreach(var item in resultlist)
            {
                if (item[1].ToString()==username && item[2].ToString()==password) 
                {
                    userid = item[0].ToString();
                    return true;
                }
            }
            return false;
        }
        public static void CreateUser<T>(T user) where T : User
        {
            string command = $"""INSERT INTO {usertable} Values ({user.Id.ToString()}, {user.FirstName}, {user.LastName}, "{user.BirthDate.Year}-{user.BirthDate.Month}-{user.BirthDate.Day}", {user.Username}, {user.Password}""";
            using (var con = new NpgsqlConnection(connectionStringDatabase))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = command;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        
    }
}