using System;


namespace RPG.Class.Item
{
    class Soco : Ataque
    {
        public override int Dano { get { return this.dano; } set { this.dano = value; } }
        private int dano;
        public override string Nome { get { return this.nome; } set { this.nome = value; } }
        private string nome;

        public override int Cura { get { return this.cura; } set { this.cura = value; } }
        private int cura;

        public override int GastoMana { get { return this.gastomana; } set { this.gastomana = value; } }
        private int gastomana;
        public Soco(int Forca)
        {
            this.Nome = "Soco";
            this.Dano = 4 * Forca;
        }
    }
}
