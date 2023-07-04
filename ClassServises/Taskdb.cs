using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ClassServises
{
    public static class Taskdb
    {
        static private string path = Directory.GetCurrentDirectory();
        static private string taskpath = "";
        static private string loadJson = "";
        static private string dirpath = "Usertasks";
        public static void Loaddata<T>(this List<T> ls, string address) where T : Taskdoing 
        {
            taskpath = "";
            path = Directory.GetCurrentDirectory();
            path =Path.Combine(path, dirpath);
            if (!Directory.Exists(dirpath)) 
            {
                Directory.CreateDirectory(dirpath);             
            }
            taskpath = Path.Combine(path, $"{address}.json");
            try
            {
                using (FileStream fs = new FileStream(taskpath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        loadJson = sr.ReadToEnd();
                    }
                    if (loadJson != "")
                    {
                        List<T> list = new List<T>();

                        list = JsonSerializer.Deserialize<List<T>>(loadJson);
                        ls.AddRange(list);
                    }
                    loadJson = "";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        public static void Savedata<T>(this List<T> list) where T: ITask
        {
            try
            {
                using (FileStream fs = new FileStream(taskpath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        loadJson = JsonSerializer.Serialize(list);
                        sw.Write(loadJson);
                    }
                    loadJson = "";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

