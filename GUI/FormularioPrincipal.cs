
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
            FormularioDeCadastroSubCategoria f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioDeCadastroDaCategoria formulario = new FormularioDeCadastroDaCategoria();
            formulario.ShowDialog();
            formulario.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCategoria consultaCategoria = new ConsultaCategoria();
            consultaCategoria.ShowDialog();
            consultaCategoria.Dispose();
        }

        private void subcategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioConsultaSubCategoria consulta = new FormularioConsultaSubCategoria();
            consulta.ShowDialog();
            consulta.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCadastroUnidadeDeMedida formularioCadastro = new();
            formularioCadastro.ShowDialog();
            formularioCadastro.Dispose();
        }
    }
}
