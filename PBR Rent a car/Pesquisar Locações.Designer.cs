namespace PBR_Rent_a_car
{
    partial class Pesquisar_Locações
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
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CPF_CNPJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Veículos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_Cor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veículos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Location = new System.Drawing.Point(15, 416);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(114, 23);
            this.buttonDevolver.TabIndex = 6;
            this.buttonDevolver.Text = "Devolver Veículo";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonAlterarDados_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(532, 417);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 7;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "CPF/CNPJ";
            // 
            // textBox_CPF_CNPJ
            // 
            this.textBox_CPF_CNPJ.Location = new System.Drawing.Point(12, 368);
            this.textBox_CPF_CNPJ.MaxLength = 14;
            this.textBox_CPF_CNPJ.Name = "textBox_CPF_CNPJ";
            this.textBox_CPF_CNPJ.Size = new System.Drawing.Size(144, 20);
            this.textBox_CPF_CNPJ.TabIndex = 2;
            this.textBox_CPF_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CPF_CNPJ_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Modelo";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 318);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(201, 20);
            this.textBox_Nome.TabIndex = 1;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Veículos
            // 
            this.dataGridView_Veículos.AllowUserToAddRows = false;
            this.dataGridView_Veículos.AllowUserToDeleteRows = false;
            this.dataGridView_Veículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Veículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF_CNPJ,
            this.Modelo,
            this.Cor,
            this.Data,
            this.Id});
            this.dataGridView_Veículos.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Veículos.Name = "dataGridView_Veículos";
            this.dataGridView_Veículos.Size = new System.Drawing.Size(695, 241);
            this.dataGridView_Veículos.TabIndex = 8;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Cliente";
            this.Nome.Name = "Nome";
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.HeaderText = "CPF/CNPJ Cliente";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data de Locação";
            this.Data.Name = "Data";
            this.Data.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Cor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Categoria";
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.Location = new System.Drawing.Point(300, 329);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(203, 20);
            this.textBox_Categoria.TabIndex = 4;
            this.textBox_Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Categoria_KeyPress);
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.Location = new System.Drawing.Point(300, 369);
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(183, 20);
            this.textBox_Cor.TabIndex = 5;
            this.textBox_Cor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fornecedor";
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.Location = new System.Drawing.Point(297, 280);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.Size = new System.Drawing.Size(228, 20);
            this.textBox_Fornecedor.TabIndex = 3;
            this.textBox_Fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Fornecedor_KeyPress);
            // 
            // Pesquisar_Locações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Cor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.buttonDevolver);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CPF_CNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Veículos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisar_Locações";
            this.ShowIcon = false;
            this.Text = "Pesquisar Locações";
            this.Load += new System.EventHandler(this.Pesquisar_Locações_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veículos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDevolver;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CPF_CNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Veículos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.TextBox textBox_Cor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;

    }
}