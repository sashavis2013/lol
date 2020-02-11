using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace LolApp.API
{
    public class Api
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public Api(string region)
        {
            Region = region;
            Key = getKey("API/Key.txt"); 
            
        }

        protected HttpResponseMessage get (string URL)
        {
            using(HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                    return result.Result;
            }
        }

        protected string getURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        public string getKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }

    }
}
