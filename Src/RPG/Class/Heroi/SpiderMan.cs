using RPG.Class.Item;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using RPG.Class.Service;


public class SpiderMan : Heroi
{
    public SpiderMan()
    {
        this.NomeImagem = "SpiderMan.png";
        // Inicializa o herói chamando um método assíncrono
        InicializarHeroi("620");
        
        // Definição dos itens do herói
        VetItem[0] = new Porrete();
        VetItem[1] = new Intoxicacao();
        VetItem[2] = new Tempestade();
        VetItem[3] = new Cajado();
        VetItem[4] = new Besta();
        VetItem[5] = new EsferadeAtaque();
        this.MenorArma();
    }

    private async Task InicializarHeroi(string id)
    {
        HeroiService heroiService = new HeroiService();
        JObject HeroDados = await heroiService.GetHeroById(id);

        if (HeroDados != null)
        {
            // Atribuindo os valores do herói com dados da API
            this.Nome = HeroDados["name"].ToString();
            
            // Acessando os dados de powerstats
            JObject powerstats = HeroDados["powerstats"] as JObject;

            // Convertendo os dados para inteiros e calculando os atributos
            this.PontosdeVida = (int)(powerstats["intelligence"]?.ToObject<int>() +
                                      powerstats["strength"]?.ToObject<int>() +
                                      powerstats["speed"]?.ToObject<int>() +
                                      powerstats["durability"]?.ToObject<int>() +
                                      powerstats["power"]?.ToObject<int>() +
                                      powerstats["combat"]?.ToObject<int>()) * 6;

            this.PontosdeMana = powerstats["power"]?.ToObject<int>() ?? 0;
            this.ForcaFisica = powerstats["combat"]?.ToObject<int>() ?? 0;
            this.ForcaMagica = (powerstats["power"]?.ToObject<int>() + powerstats["combat"]?.ToObject<int>()) / 2 ?? 0;
            this.PontoArmadura  = powerstats["durability"]?.ToObject<int>() ?? 0;
            this.ResistenciaMagica = (powerstats["durability"]?.ToObject<int>() + powerstats["power"]?.ToObject<int>()) / 2 ?? 0;
            this.Agilidade = powerstats["speed"]?.ToObject<int>() ?? 0;

            // Acessando a URL da imagem
        }
    }
}
