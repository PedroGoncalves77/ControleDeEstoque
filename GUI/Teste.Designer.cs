namespace GUI
{
    partial class Teste
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
        public void InitializeComponent()
        {
            pnDados = new Panel();
            pnBotoes = new Panel();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            pnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(760, 400);
            pnDados.TabIndex = 0;
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btCancelar);
            pnBotoes.Controls.Add(btSalvar);
            pnBotoes.Controls.Add(btExcluir);
            pnBotoes.Controls.Add(btAlterar);
            pnBotoes.Controls.Add(btLocalizar);
            pnBotoes.Controls.Add(btInserir);
            pnBotoes.Location = new Point(12, 427);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(760, 122);
            pnBotoes.TabIndex = 1;
            //pnBotoes.Paint += pnBotoes_Paint;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelar.Image = Properties.Resources.icons8_cancelar_48;
            btCancelar.Location = new Point(633, 28);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 75);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            //btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSalvar.Image = Properties.Resources.icons8_salvar_48;
            btSalvar.Location = new Point(509, 28);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 75);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            //btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btExcluir.Image = Properties.Resources.icons8_lixeira_48;
            btExcluir.Location = new Point(385, 28);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 75);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            //btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAlterar.Image = Properties.Resources.icons8_alterar_48;
            btAlterar.Location = new Point(261, 28);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 75);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            //btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLocalizar.Image = Properties.Resources.icons8_lupa_48;
            btLocalizar.Location = new Point(137, 28);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(75, 75);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            //btLocalizar.Click += btLocalizar_Click;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btInserir.Image = Properties.Resources.icons8_insert_key_481;
            btInserir.Location = new Point(13, 28);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(75, 75);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            //btInserir.Click += btInserir_Click;
            // 
            // FormularioModeloDeCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnBotoes);
            Controls.Add(pnDados);
            Name = "FormularioTeste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Tetse";
            //Load += FormularioTeste_Load;
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }
        protected Panel pnDados;
        protected Panel pnBotoes;
        protected Button btCancelar;
        protected Button btSalvar;
        protected Button btExcluir;
        protected Button btAlterar;
        protected Button btLocalizar;
        protected Button btInserir;
        #region Windows Form Designer generated code

       

        #endregion
    }
}