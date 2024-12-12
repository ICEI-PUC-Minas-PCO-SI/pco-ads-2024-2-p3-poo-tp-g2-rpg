using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        HeroiServices heroiServices = new HeroiServices();

        Console.WriteLine("Digite o ID do herói para buscar:");
        string id = Console.ReadLine();

        if (!string.IsNullOrEmpty(id))
        {
            Heroi heroi = await heroiServices.GetHeroById(id);

            if (heroi != null)
            {
                Console.WriteLine("\nDetalhes do Herói:");
                Console.WriteLine($"Nome: {heroi.Nome}");
                Console.WriteLine($"Inteligência: {heroi.Inteligencia}");
                Console.WriteLine($"Força: {heroi.Forca}");
                Console.WriteLine($"Velocidade: {heroi.Velocidade}");
                Console.WriteLine($"Durabilidade: {heroi.Durabilidade}");
                Console.WriteLine($"Poder: {heroi.Poder}");
                Console.WriteLine($"Combate: {heroi.Combate}");
            }
            else
            {
                Console.WriteLine("Herói não encontrado ou ocorreu um erro.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Por favor, insira um ID válido.");
        }
    }
}