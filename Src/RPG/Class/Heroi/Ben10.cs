
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ben10 : Heroi
{
    public Ben10()
    {
        this.Nome = "Ben10";
        this.PontosdeVida = 4000;
        this.PontosdeMana = 30;
        this.ForcaFisica = 100;
        this.ForcaMagica = 20;
        this.PontoArmadura = 80;
        this.ResistenciaMagica = 20;
        this.Agilidade = 50;
        this.NomeImagem = "FtoGuerreiro.jpg";




        VetItem[0] = new Porrete();
        VetItem[1] = new EspadaBarroca();
        VetItem[2] = new Tempestade();//Olhar nas especificações
        this.MenorArma();
    }
}

