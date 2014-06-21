namespace PBR_Rent_a_car
{
    partial class Pesquisa_Veículos
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
            this.dataGridView_Veículos = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quilometragem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_Cor = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Quilometragem = new System.Windows.Forms.TextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.buttonMandarManutenção = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veículos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Veículos
            // 
            this.dataGridView_Veículos.AllowUserToAddRows = false;
            this.dataGridView_Veículos.AllowUserToDeleteRows = false;
            this.dataGridView_Veículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Veículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Cor,
            this.Ano,
            this.Quilometragem,
            this.Estado});
            this.dataGridView_Veículos.Location = new System.Drawing.Point(12, 13);
            this.dataGridView_Veículos.Name = "dataGridView_Veículos";
            this.dataGridView_Veículos.Size = new System.Drawing.Size(545, 241);
            this.dataGridView_Veículos.TabIndex = 0;
            this.dataGridView_Veículos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Veículos_RowHeaderMouseDoubleClick);
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
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // Quilometragem
            // 
            this.Quilometragem.HeaderText = "Quilometragem";
            this.Quilometragem.Name = "Quilometragem";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.Location = new System.Drawing.Point(288, 311);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.Size = new System.Drawing.Size(228, 20);
            this.textBox_Fornecedor.TabIndex = 14;
            this.textBox_Fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Fornecedor_KeyPress);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 311);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(201, 20);
            this.textBox_Nome.TabIndex = 13;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Categoria";
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.Location = new System.Drawing.Point(291, 360);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(203, 20);
            this.textBox_Categoria.TabIndex = 29;
            this.textBox_Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Categoria_KeyPress);
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.Location = new System.Drawing.Point(291, 400);
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(183, 20);
            this.textBox_Cor.TabIndex = 28;
            this.textBox_Cor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cor_KeyPress);
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Location = new System.Drawing.Point(15, 400);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(48, 20);
            this.textBox_Ano.TabIndex = 27;
            this.textBox_Ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ano_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Quilometragem menor que";
            // 
            // textBox_Quilometragem
            // 
            this.textBox_Quilometragem.Location = new System.Drawing.Point(12, 360);
            this.textBox_Quilometragem.Name = "textBox_Quilometragem";
            this.textBox_Quilometragem.Size = new System.Drawing.Size(144, 20);
            this.textBox_Quilometragem.TabIndex = 33;
            this.textBox_Quilometragem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Quilometragem_KeyPress);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(482, 428);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 35;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMandarManutenção
            // 
            this.buttonMandarManutenção.Location = new System.Drawing.Point(12, 428);
            this.buttonMandarManutenção.Name = "buttonMandarManutenção";
            this.buttonMandarManutenção.Size = new System.Drawing.Size(143, 23);
            this.buttonMandarManutenção.TabIndex = 36;
            this.buttonMandarManutenção.Text = "Mandar para Manutenção";
            this.buttonMandarManutenção.UseVisualStyleBackColor = true;
            this.buttonMandarManutenção.Click += new System.EventHandler(this.buttonMandarManutenção_Click);
            // 
            // Pesquisa_Veículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 463);
            this.Controls.Add(this.buttonMandarManutenção);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Quilometragem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Cor);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Veículos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisa_Veículos";
            this.ShowIcon = false;
            this.Text = "Pesquisa de Veículo";
            this.Load += new System.EventHandler(this.Pesquisa_Veículos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veículos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Veículos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quilometragem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Fornecedor;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.TextBox textBox_Cor;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Quilometragem;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button buttonMandarManutenção;

    }
}