using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class HeroiServices
{
    static string _urlBase = "https://superheroapi.com/api/e46552f383b1f3aaf64f41147f20b97e/";

    public async Task<Heroi> GetHeroById(string id)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{_urlBase}{id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonToString = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonConvert.DeserializeObject<JObject>(jsonToString);

                    Heroi heroi = new Heroi
                    {
                        Nome = jsonObject["name"]?.ToString(),
                        Inteligencia = jsonObject["powerstats"]?["intelligence"]?.ToString(),
                        Forca = jsonObject["powerstats"]?["strength"]?.ToString(),
                        Velocidade = jsonObject["powerstats"]?["speed"]?.ToString(),
                        Durabilidade = jsonObject["powerstats"]?["durability"]?.ToString(),
                        Poder = jsonObject["powerstats"]?["power"]?.ToString(),
                        Combate = jsonObject["powerstats"]?["combat"]?.ToString()
                    };

                    Console.WriteLine($"Sucesso! Herói encontrado: {heroi.Nome}");
                    return heroi;
                }
                else
                {
                    Console.WriteLine($"Erro: StatusCode {response.StatusCode}");
                    return null;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar a API: {ex.Message}");
            return null;
        }
    }
}
