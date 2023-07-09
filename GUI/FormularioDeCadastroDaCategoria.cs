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

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            ConsultaCategoria consultaCat = new ConsultaCategoria();
            consultaCat.ShowDialog();
            if (consultaCat.codigo != 0) 
            {
                DALConexao conexao = new(DadosDaConexao.StringDaConexao);
                BLLCategoria bllCategoria = new(conexao);
                ModeloCategoria modelo = bllCategoria.CarregaModeloCategoria(consultaCat.codigo);
                textoCodigo.Text = modelo.CatCod.ToString();
                textoNome.Text = modelo.CatNome;
                AlteraBotoes(3);
            }
            else
            {
                LimpaTela();
                AlteraBotoes(1);
            }
            consultaCat.Dispose();
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
                    MessageBox.Show("Cadastro concluido. Código:" + modelo.CatCod.ToString());

                }
                else
                {
                    modelo.CatCod = Convert.ToInt32(textoCodigo.Text);
                    bllcat.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado!");

                }
                LimpaTela();
                AlteraBotoes(1);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            AlteraBotoes(2);            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult escolha = MessageBox.Show("Deseja excluir o registro?", "Aviso:", MessageBoxButtons.YesNo);
                if (escolha.ToString() == "Yes") 
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDaConexao);
                    BLLCategoria bllcat = new(conexao);
                    bllcat.Excluir(Convert.ToInt32(textoCodigo.Text));
                    LimpaTela();
                    AlteraBotoes(1);
                }
            }catch(Exception exception) 
            {
                MessageBox.Show("Impossivel excluir o regisro,existem dependências em outros locais.",exception.Message);
                AlteraBotoes(3);
            }
        }
    }
}
