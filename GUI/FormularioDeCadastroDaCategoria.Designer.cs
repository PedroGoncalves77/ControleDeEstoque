namespace GUI
{
    partial class FormularioDeCadastroDaCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnBotoes = new Panel();
            btLocalizar = new Button();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btInserir = new Button();
            pnDados = new Panel();
            textoNome = new TextBox();
            textoCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnBotoes.SuspendLayout();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btLocalizar);
            pnBotoes.Controls.Add(btCancelar);
            pnBotoes.Controls.Add(btSalvar);
            pnBotoes.Controls.Add(btExcluir);
            pnBotoes.Controls.Add(btAlterar);
            pnBotoes.Controls.Add(btInserir);
            pnBotoes.Location = new Point(12, 416);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(751, 133);
            pnBotoes.TabIndex = 1;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLocalizar.Image = Properties.Resources.icons8_lupa_48;
            btLocalizar.Location = new Point(179, 48);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(75, 75);
            btLocalizar.TabIndex = 6;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelar.Image = Properties.Resources.icons8_cancelar_48;
            btCancelar.Location = new Point(632, 44);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 75);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSalvar.Image = Properties.Resources.icons8_salvar_48;
            btSalvar.Location = new Point(518, 44);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 75);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btExcluir.Image = Properties.Resources.icons8_lixeira_48;
            btExcluir.Location = new Point(404, 44);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 75);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAlterar.Image = Properties.Resources.icons8_alterar_48;
            btAlterar.Location = new Point(290, 44);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 75);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btInserir.Image = Properties.Resources.icons8_insert_key_48;
            btInserir.Location = new Point(62, 44);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(75, 75);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // pnDados
            // 
            pnDados.Controls.Add(textoNome);
            pnDados.Controls.Add(textoCodigo);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(label1);
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(751, 398);
            pnDados.TabIndex = 2;
            // 
            // textoNome
            // 
            textoNome.Location = new Point(23, 112);
            textoNome.Name = "textoNome";
            textoNome.Size = new Size(700, 23);
            textoNome.TabIndex = 3;
            // 
            // textoCodigo
            // 
            textoCodigo.Enabled = false;
            textoCodigo.Location = new Point(23, 40);
            textoCodigo.Name = "textoCodigo";
            textoCodigo.Size = new Size(100, 23);
            textoCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // FormularioDeCadastroDaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnDados);
            Controls.Add(pnBotoes);
            Name = "FormularioDeCadastroDaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Cadastro da Categoria";
            Load += FormularioDeCadastroDaCategoria_Load;
            pnBotoes.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private Button button5;
        protected Button btInserir;
        protected Button btSalvar;
        protected Button btExcluir;
        protected Button btAlterar;
        protected Button btCancelar;
        protected Panel pnBotoes;
        protected Button btLocalizar;
        protected Panel pnDados;
        private TextBox textoNome;
        private TextBox textoCodigo;
        private Label label2;
        private Label label1;
    }
}