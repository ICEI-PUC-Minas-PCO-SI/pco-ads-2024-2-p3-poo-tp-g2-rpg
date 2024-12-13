using System;

namespace RPG.Class.Item
{
    public class Chute : Ataque
    {
        public override int Dano { get { return this.dano; } set { this.dano = value; } }
        private int dano;
        public override string Nome { get { return this.nome; } set { this.nome = value; } }
        private string nome;

        public override int Cura { get { return this.cura; } set { this.cura = value; } }
        private int cura;

        public override int GastoMana { get { return this.gastomana; } set { this.gastomana = value; } }
        private int gastomana;

        public Chute(int Forca)
        {
            this.Nome = "Chute";
            this.Cura = 0;
            this.Dano = 5 * Forca;
            this.GastoMana = 0;
        }


    }
}
