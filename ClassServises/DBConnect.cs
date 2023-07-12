using Npgsql;
using System;
namespace ClassServises
{
    public class DBConnect
    {
        static string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root";
        static string databaseName = "todoappproject";
        static string connectionStringDatabase = $"Server=localhost;Port=5432;User Id =postgres;Password = root; Database={databaseName};";
        static string usertable = "usertable";
        static string tasktable = "tasksofusers";
        public DBConnect()
        {
            //Database borligini tekshirish
            using (var con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT 'CREATE DATABASE {databaseName}' WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = '{databaseName}')";
                    cmd.ExecuteScalar();
                }
            }

            //creating tables
            using (var conn = new NpgsqlConnection(connectionStringDatabase))
            {
                conn.Open();

                //create usertable
                using (var createUserTableCmd = new NpgsqlCommand())
                {
                    createUserTableCmd.Connection = conn;
                    string userCommand =
                       $"CREATE TABLE IF NOT EXISTS \"{usertable}\"(" +
                       "Id varchar(36) primary key," +
                       "FirstName varchar(30)," +
                       "LastName varchar(40)," +
                       "BirthDate DATE," +
                       "Username varchar(30)," +
                       "Password varchar(8)" +
                       ");";
                    createUserTableCmd.CommandText = userCommand;
                    createUserTableCmd.ExecuteNonQuery();

                    Console.WriteLine($"The table '{usertable}' created or already exists.");
                }
                //create usertasks table
                using (var createTaskTableCmd = new NpgsqlCommand())
                {
                    createTaskTableCmd.Connection = conn;


                    string task = $"CREATE TABLE IF NOT EXISTS {tasktable}(Id varchar(36), Title varchar(200),Description varchar(3000),DueDate DATE,Priority int,Status int,UserId varchar(36) not null,Primary key (Id),CONSTRAINT fk_userid FOREIGN KEY(UserId) REFERENCES \"{usertable}\"(Id) ON DELETE CASCADE);";
                    createTaskTableCmd.CommandText = task;
                    createTaskTableCmd.ExecuteNonQuery();

                    Console.WriteLine($"The table '{tasktable}' created or already exists.");
                }

            }

        }
        
        public static bool CheckUser(string username)
        {
            try { }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            string command = $"""Select Username From "{usertable}" """;
            using (var con = new NpgsqlConnection(connectionStringDatabase))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = con;
                    var result = GetBySubject();
                    IEnumerable<string> GetBySubject()
                    {
                        cmd.CommandText = command;
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        var result = new List<string>();
                        while (reader.Read())
                        {
                            result.Add(reader[0] as string);
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
        //creating new user
        public static bool CreateUser<T>(T user) where T : User
        {
            string command = $@"INSERT INTO ""{usertable}"" (Id, FirstName, LastName, BirthDate, Username, Password) 
                        VALUES (@Id, @FirstName, @LastName, @BirthDate, @Username, @Password)";

            using (var con = new NpgsqlConnection(connectionStringDatabase))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = command;

                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error creating user: {ex.Message}");
                        return true;
                    }
                }
            }
        }

    }
}