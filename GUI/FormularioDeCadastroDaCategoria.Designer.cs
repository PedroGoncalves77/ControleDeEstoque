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
            pnDados = new Panel();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            subCategoriaToolStripMenuItem = new ToolStripMenuItem();
            unidadeDeMedidaToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            movimentaçãoToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            btLocalizar = new Button();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btInserir = new Button();
            pnDados.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Controls.Add(menuStrip1);
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(751, 398);
            pnDados.TabIndex = 0;
            pnDados.Paint += pnDados_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, consultaToolStripMenuItem, movimentaçãoToolStripMenuItem, relatórioToolStripMenuItem, ferramentasToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(751, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, subCategoriaToolStripMenuItem, unidadeDeMedidaToolStripMenuItem, produtoToolStripMenuItem, toolStripSeparator1, clienteToolStripMenuItem, fornecedorToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(177, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // subCategoriaToolStripMenuItem
            // 
            subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            subCategoriaToolStripMenuItem.Size = new Size(177, 22);
            subCategoriaToolStripMenuItem.Text = "SubCategoria";
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            unidadeDeMedidaToolStripMenuItem.Size = new Size(177, 22);
            unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(177, 22);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(174, 6);
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(177, 22);
            clienteToolStripMenuItem.Text = "Cliente ";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(177, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(69, 20);
            consultaToolStripMenuItem.Text = "Consulta ";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            movimentaçãoToolStripMenuItem.Size = new Size(99, 20);
            movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // panel2
            // 
            panel2.Controls.Add(btLocalizar);
            panel2.Controls.Add(btCancelar);
            panel2.Controls.Add(btSalvar);
            panel2.Controls.Add(btExcluir);
            panel2.Controls.Add(btAlterar);
            panel2.Controls.Add(btInserir);
            panel2.Location = new Point(12, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 133);
            panel2.TabIndex = 1;
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
            btLocalizar.Click += button1_Click;
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
            // 
            // FormularioDeCadastroDaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(pnDados);
            MainMenuStrip = menuStrip1;
            Name = "FormularioDeCadastroDaCategoria";
            Text = "Formulario Cadastro da Categoria";
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
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
        protected Panel pnDados;
        protected Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem subCategoriaToolStripMenuItem;
        private ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        protected Button btLocalizar;
    }
}