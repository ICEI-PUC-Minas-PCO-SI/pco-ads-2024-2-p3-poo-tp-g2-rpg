using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Jogo
{
    public Jogador Player1 { get; set; }
    public Jogador Player2 { get; set; }
    public string EnderecoImagens { get; set; }

    public Jogo()
    {
        this.Player1 = new Jogador();
        this.Player2 = new Jogador();
        EnderecoImagens = "C:\\Users\\Pedro Henrique\\Source\\Repos\\pco-ads-2024-2-p3-poo-tp-g2-rpg\\Src\\RPG\\Imagens\\";
    }
}

