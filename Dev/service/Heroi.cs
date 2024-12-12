//APAGAR DEPOIS 

public class Heroi 
{
   public string Nome { get; set; }
    public string Inteligencia { get; set; }
    public string Forca { get; set; }
    public string Velocidade { get; set; }
    public string Durabilidade { get; set; }
    public string Poder { get; set; }
    public string Combate { get; set; }

    public void ExibirAtributos()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Inteligência: {Inteligencia}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Velocidade: {Velocidade}");
        Console.WriteLine($"Durabilidade: {Durabilidade}");
        Console.WriteLine($"Poder: {Poder}");
        Console.WriteLine($"Combate: {Combate}");
    }
}