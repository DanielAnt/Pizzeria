using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Markup;

namespace Pizzeria
{
    public static class Constants
    {
              
        public static Dictionary<string, string> LoadMenuJson()
        {
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            using (StreamReader r = new StreamReader("menu.json",enc))
            {
                string json = r.ReadToEnd();
                var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                return dictionary;
            }
            
        }

    }
}
