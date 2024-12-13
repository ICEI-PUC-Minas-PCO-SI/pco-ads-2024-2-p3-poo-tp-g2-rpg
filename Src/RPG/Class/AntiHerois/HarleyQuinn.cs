
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HarleyQuinn : AntiHeroi
{
    public HarleyQuinn()
    {
        this.Nome = "HarleyQuinn";
        this.PontosdeVida = 3000;
        this.PontosdeMana = 40;
        this.ForcaFisica = 100;
        this.ForcaMagica = 20;
        this.PontoArmadura = 100;
        this.ResistenciaMagica = 50;
        this.Agilidade = 80;
        this.NomeImagem = "FtoDragao.jpg";
        VetItem[0] = new HalitoDeFogo();
        VetItem[1] = new GarraLetal();

        this.MenorArma();
    }
}

