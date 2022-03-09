using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SeunWinBankAppCore
{
    public static class DbConnect
    {
        public static string path = Path.Combine(Environment.CurrentDirectory,"Store.json");
        public static bool WriteToDb(User user)
        {
            try
            {
                string json = JsonConvert.SerializeObject(user) + Environment.NewLine;
                File.AppendAllTextAsync(path, json).Wait();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            

            
        }

        public static List<object> ReadDb()
        {
            List<object> list = new List<object>(); 
            return list;
        }
    }
}
