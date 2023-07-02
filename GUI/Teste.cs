using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Teste : Form
    {
        public string operacao;
        public void AlteraBotoes(int op)
        {
            pnDados.Enabled = false;
            btAlterar.Enabled = false;
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {


            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }

        }

        public Teste() => InitializeComponent();

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
        }

        private void FormularioModeloDeCadastro_Load(object sender, EventArgs e)
        {


        }
    }
}
