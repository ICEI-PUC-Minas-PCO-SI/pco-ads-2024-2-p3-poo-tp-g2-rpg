using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class FrmSelPersonagem : Form
    {

        public Jogo NovoJogo { get; set; }
        public int CountPersonagem = 0;
        public FrmSelPersonagem()
        {
            InitializeComponent();
        }
        
        public FrmSelPersonagem(Jogo jogo)
        {
            NovoJogo = jogo;
            InitializeComponent();
        }

        public void NovoPersonagem(Personagem personagem)
        {
            if (CountPersonagem == 0)
                NovoJogo.Player1.Personagem = personagem;
            else
                NovoJogo.Player2.Personagem = personagem;
            CountPersonagem++;
        }
        public void MudarDeTela()
        {
            if (CountPersonagem <= 1)
                this.Show();
            else
            {
                FrmPrecombate combate = new FrmPrecombate(NovoJogo);
                combate.Show();
                this.Hide();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnben10_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Ben10());
            this.MudarDeTela();
        }

        private void btngodzilla_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Godzilla());
            this.MudarDeTela();
        }

        private void btngoku_Click(object sender, EventArgs e)
        {

            this.NovoPersonagem(new Goku());
            this.MudarDeTela();
        }

        private void btnspider_Click(object sender, EventArgs e)
        {

            this.NovoPersonagem(new SpiderMan());
            this.MudarDeTela();
        }

        private void btndeadpool_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Deadpool());
            this.MudarDeTela();
        }

        private void btnharley_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new HarleyQuinn());
            this.MudarDeTela();
        }

        private void btnhellboy_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Hellboy());
            this.MudarDeTela();
        }

        private void btnloki_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Loki());
            this.MudarDeTela();
        }
    }
}
