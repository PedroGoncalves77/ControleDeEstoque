using BBL;
using DAL;


namespace GUI
{

    public partial class ConsultaCategoria : Form
    {
        public int codigo = 0;
        public ConsultaCategoria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new(DadosDaConexao.StringDaConexao);
            BLLCategoria bllcat = new BLLCategoria(conexao);

            datagvDados.DataSource = bllcat.Localizar(texoValor.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaCategoria_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            datagvDados.Columns[0].HeaderText = "Código";
            datagvDados.Columns[0].Width = 50;
            datagvDados.Columns[1].HeaderText = "Nome";
            datagvDados.Columns[1].Width = 700;
        }

        private void datagvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                codigo = Convert.ToInt32(datagvDados.Rows[e.RowIndex].Cells[0].Value);
                Close();
            }
        }
    }
}
