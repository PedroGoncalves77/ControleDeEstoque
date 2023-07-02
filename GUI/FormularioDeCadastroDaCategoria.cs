using BBL;
using DAL;
using Modelo;
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
    public partial class FormularioDeCadastroDaCategoria : Form
    {
        public string operacao;
        public void AlteraBotoes(int op)
        {

            btAlterar.Enabled = false;
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {

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
        public FormularioDeCadastroDaCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioDeCadastroDaCategoria_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            AlteraBotoes(2);
        }
        public void LimpaTela()
        {
            textoCodigo.Clear();
            textoNome.Clear();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AlteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCategoria modelo = new();
                modelo.CatNome = textoNome.Text;

                DALConexao conexao = new(DadosDaConexao.StringDaConexao);
                BLLCategoria bllcat = new(conexao);


                if (operacao == "inserir")
                {
                    bllcat.Incluir(modelo);
                    MessageBox.Show("Cadastro concluido. Código: ");

                }
                else
                {
                    modelo.CatCod = Convert.ToInt32(textoCodigo.Text);
                    bllcat.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado!");

                }
                LimpaTela();
                AlteraBotoes(1);
            }catch(Exception exeption) 
            {
                MessageBox.Show(exeption.Message);
            }
        }
    }
}
