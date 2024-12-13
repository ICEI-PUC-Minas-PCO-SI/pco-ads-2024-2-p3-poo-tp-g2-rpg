using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace RPG.Class.Service  
{
    public class HeroiService
    {
        static string _urlBase = "https://superheroapi.com/api/";
        static string _TokenApi = "e46552f383b1f3aaf64f41147f20b97e/";

        public async Task<JObject> GetHeroById(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{_urlBase}{_TokenApi}{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonToString = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonConvert.DeserializeObject<JObject>(jsonToString);
                    return jsonObject;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
