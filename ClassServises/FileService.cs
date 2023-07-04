using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassServises
{
    public static class FileService
    {
        static private string usersdb = "user.txt";
        static private string path = Directory.GetCurrentDirectory();
        static private string userpath = "";
        public static bool Checkuser(string username, string password, out string userid)
        {
            userid = "";
            userpath = "";
            userpath = Path.Combine(path, usersdb);
            try
            {
                using (FileStream fs = new FileStream(userpath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] user = line.Split(',').ToArray();
                        
                            if (user.Length>1 && user[4] == username)
                            {
                                if (user[5] == password)
                                {
                                    userid = user[0];
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool Checkuser(string username)
        {
            userpath = "";
            userpath = Path.Combine(path, usersdb);
            using (FileStream fs = new FileStream(userpath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    string[] data = File.ReadAllLines(usersdb);
                    foreach (var line in data)
                    {
                        string[] user = line.Split(',').ToArray();
                        if (user[0].Length!=0 && user[4] == username)
                        {
                            return false;
                        }
                    }
                    
                }
            return true;
            }
        }
        public static void CreateUser<T>(T user) where T : User
        {
            if (!File.Exists(usersdb))
                File.Create(usersdb);
            userpath = Path.Combine(path, usersdb);
            using (StreamWriter writer = new StreamWriter(userpath, true))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(user.Id + ",");
                sb.Append(user.FirstName+",");
                sb.Append(user.LastName + ',');
                sb.Append(user.BirthDate.ToString() + ',');
                sb.Append(user.Username + ',');
                sb.Append(user.Password+'\n');
                writer.WriteLine(sb);
                //writer.WriteLine($"{user.Id},{user.FirstName},{user.LastName},{user.BirthDate},{user.Username},{user.Password}");
            }
        }
    }  
}
