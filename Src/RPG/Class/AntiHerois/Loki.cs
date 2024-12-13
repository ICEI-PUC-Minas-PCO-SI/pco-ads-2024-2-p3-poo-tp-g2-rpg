
using RPG.Class.Item;

public class Loki : AntiHeroi
{
    public Loki()
    {
        this.Nome = "Loki";
        this.PontosdeVida = 2500;
        this.PontosdeMana = 20;
        this.ForcaFisica = 40;
        this.ForcaMagica = 20;
        this.PontoArmadura = 80;
        this.ResistenciaMagica = 90;
        this.Agilidade = 20;
        this.NomeImagem = "FtoZumbi.png";
        VetItem[0] = new Intoxicacao();
        VetItem[1] = new GarraLetal();
        VetItem[2] = new Porrete();
        VetItem[3] = new Cajado();

        this.MenorArma();
    }
}

