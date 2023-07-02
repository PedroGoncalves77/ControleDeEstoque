namespace GUI
{
    partial class ConsultaCategoria
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
            label1 = new Label();
            texoValor = new TextBox();
            btLocalizar = new Button();
            datagvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagvDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            label1.Click += label1_Click;
            // 
            // texoValor
            // 
            texoValor.Location = new Point(12, 60);
            texoValor.Name = "texoValor";
            texoValor.Size = new Size(669, 23);
            texoValor.TabIndex = 1;
            texoValor.TextChanged += textBox1_TextChanged;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLocalizar.Location = new Point(687, 60);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(75, 23);
            btLocalizar.TabIndex = 2;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // datagvDados
            // 
            datagvDados.AllowUserToAddRows = false;
            datagvDados.AllowUserToDeleteRows = false;
            datagvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvDados.Location = new Point(12, 108);
            datagvDados.Name = "datagvDados";
            datagvDados.ReadOnly = true;
            datagvDados.RowTemplate.Height = 25;
            datagvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagvDados.Size = new Size(750, 358);
            datagvDados.TabIndex = 3;
            datagvDados.CellDoubleClick += datagvDados_CellDoubleClick;
            // 
            // ConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(datagvDados);
            Controls.Add(btLocalizar);
            Controls.Add(texoValor);
            Controls.Add(label1);
            Name = "ConsultaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Categoria";
            Load += ConsultaCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)datagvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox texoValor;
        private Button btLocalizar;
        private DataGridView datagvDados;
    }
}