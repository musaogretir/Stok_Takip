using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Stok_Takip
{
    public class JSON
    {
        public List<category> JSONread(string dosya, List<category> liste)
        {
            if (File.Exists(dosya))
            {
                string JSONdata = File.ReadAllText(dosya);
                liste = JsonConvert.DeserializeObject<List<category>> (JSONdata);
            }
            return liste;
        }

        public void JSONsaveFile(string dosya, List<category> liste)
        {
            string JSONdata = JsonConvert.SerializeObject(liste);

            if (File.Exists(dosya))
            {
                File.Delete(dosya);
            }
            
            using (var sw = new StreamWriter(dosya, true))
            {
                sw.WriteLine(JSONdata);
                sw.Close();
            }            
        }
    }
}
