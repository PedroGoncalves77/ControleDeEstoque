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
    public partial class FormularioPrincipal : Form
    {

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void subcategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioDeCadastroDaCategoria formulario = new FormularioDeCadastroDaCategoria();
            formulario.ShowDialog();
            //formulario.AlteraBotoes(1);
            formulario.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCategoria consultaCategoria = new ConsultaCategoria();
            consultaCategoria.ShowDialog();
            consultaCategoria.Dispose();
        }
    }
}
