using System;

namespace RPG.Class.Item
{
    public class CaosExplosivo : Poder
    {

        public override int Dano { get { return this.dano; } set { this.dano = value; } }
        private int dano;
        public override string Nome { get { return this.nome; } set { this.nome = value; } }
        private string nome;
        public override int Cura { get { return this.cura; } set { this.cura = value; } }
        private int cura;
        public override int GastoMana { get { return this.gastomana; } set { this.gastomana = value; } }
        private int gastomana;
        public override string EfeitoItem { get { return RPG.Class.Enum.EnumEfeitoItem.Dano.ToString(); } set { } }

        public CaosExplosivo(int Poder)
        {
            this.Nome = "CaosExplosivo ";
            this.Cura =0;
            this.Dano = (int) Math.Floor(11 * Poder * 0.4);
            this.GastoMana=12; 
        }
    }
}
