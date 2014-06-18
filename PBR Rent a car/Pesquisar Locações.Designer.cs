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
            this.buttonAlterarDados = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Quilometragem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Veículos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_Cor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veículos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlterarDados
            // 
            this.buttonAlterarDados.Location = new System.Drawing.Point(15, 416);
            this.buttonAlterarDados.Name = "buttonAlterarDados";
            this.buttonAlterarDados.Size = new System.Drawing.Size(114, 23);
            this.buttonAlterarDados.TabIndex = 61;
            this.buttonAlterarDados.Text = "Devolver Veículo";
            this.buttonAlterarDados.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(532, 417);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 60;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
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
            // textBox_Quilometragem
            // 
            this.textBox_Quilometragem.Location = new System.Drawing.Point(12, 368);
            this.textBox_Quilometragem.Name = "textBox_Quilometragem";
            this.textBox_Quilometragem.Size = new System.Drawing.Size(144, 20);
            this.textBox_Quilometragem.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nome";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 318);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(201, 20);
            this.textBox_Nome.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Veículos
            // 
            this.dataGridView_Veículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Veículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF_CNPJ,
            this.Modelo,
            this.Cor,
            this.Data});
            this.dataGridView_Veículos.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Veículos.Name = "dataGridView_Veículos";
            this.dataGridView_Veículos.Size = new System.Drawing.Size(595, 241);
            this.dataGridView_Veículos.TabIndex = 54;
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
            this.textBox_Categoria.TabIndex = 65;
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.Location = new System.Drawing.Point(300, 369);
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(183, 20);
            this.textBox_Cor.TabIndex = 64;
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
            this.textBox_Fornecedor.TabIndex = 62;
            // 
            // Pesquisar_Locações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 452);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Cor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.buttonAlterarDados);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Quilometragem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Veículos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisar_Locações";
            this.ShowIcon = false;
            this.Text = "Pesquisar Locações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veículos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlterarDados;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Quilometragem;
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

    }
}