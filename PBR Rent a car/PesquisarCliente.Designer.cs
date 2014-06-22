namespace PBR_Rent_a_car
{
    partial class PesquisarCliente
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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CPF_CNPJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.buttonAlterarDados = new System.Windows.Forms.Button();
            this.textBox_Cidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UF = new System.Windows.Forms.TextBox();
            this.textBox_Rua = new System.Windows.Forms.TextBox();
            this.textBox_Bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Número = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CEP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(12, 259);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 0;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF_CNPJ,
            this.CEP,
            this.Endereço,
            this.Telefones,
            this.Id});
            this.dataGridView_Clientes.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.Size = new System.Drawing.Size(644, 241);
            this.dataGridView_Clientes.TabIndex = 12;
            this.dataGridView_Clientes.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Clientes_RowHeaderMouseDoubleClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.HeaderText = "CPF/CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            // 
            // Telefones
            // 
            this.Telefones.HeaderText = "Telefones";
            this.Telefones.Name = "Telefones";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(488, 481);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 10;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "CPF/CNPJ";
            // 
            // textBox_CPF_CNPJ
            // 
            this.textBox_CPF_CNPJ.Location = new System.Drawing.Point(10, 364);
            this.textBox_CPF_CNPJ.MaxLength = 14;
            this.textBox_CPF_CNPJ.Name = "textBox_CPF_CNPJ";
            this.textBox_CPF_CNPJ.Size = new System.Drawing.Size(144, 20);
            this.textBox_CPF_CNPJ.TabIndex = 2;
            this.textBox_CPF_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CPF_CNPJ_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(10, 315);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(201, 20);
            this.textBox_Nome.TabIndex = 1;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // buttonAlterarDados
            // 
            this.buttonAlterarDados.Location = new System.Drawing.Point(10, 481);
            this.buttonAlterarDados.Name = "buttonAlterarDados";
            this.buttonAlterarDados.Size = new System.Drawing.Size(94, 23);
            this.buttonAlterarDados.TabIndex = 9;
            this.buttonAlterarDados.Text = "Alterar Dados";
            this.buttonAlterarDados.UseVisualStyleBackColor = true;
            this.buttonAlterarDados.Click += new System.EventHandler(this.buttonAlterarDados_Click);
            // 
            // textBox_Cidade
            // 
            this.textBox_Cidade.Location = new System.Drawing.Point(324, 315);
            this.textBox_Cidade.Name = "textBox_Cidade";
            this.textBox_Cidade.Size = new System.Drawing.Size(239, 20);
            this.textBox_Cidade.TabIndex = 5;
            this.textBox_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cidade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cidade";
            // 
            // textBox_UF
            // 
            this.textBox_UF.Location = new System.Drawing.Point(282, 315);
            this.textBox_UF.MaxLength = 2;
            this.textBox_UF.Name = "textBox_UF";
            this.textBox_UF.Size = new System.Drawing.Size(29, 20);
            this.textBox_UF.TabIndex = 4;
            this.textBox_UF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UF_KeyPress);
            // 
            // textBox_Rua
            // 
            this.textBox_Rua.Location = new System.Drawing.Point(282, 404);
            this.textBox_Rua.Name = "textBox_Rua";
            this.textBox_Rua.Size = new System.Drawing.Size(270, 20);
            this.textBox_Rua.TabIndex = 7;
            this.textBox_Rua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Rua_KeyPress);
            // 
            // textBox_Bairro
            // 
            this.textBox_Bairro.Location = new System.Drawing.Point(282, 364);
            this.textBox_Bairro.Name = "textBox_Bairro";
            this.textBox_Bairro.Size = new System.Drawing.Size(270, 20);
            this.textBox_Bairro.TabIndex = 6;
            this.textBox_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Bairro_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Rua";
            // 
            // textBox_Número
            // 
            this.textBox_Número.Location = new System.Drawing.Point(284, 444);
            this.textBox_Número.MaxLength = 5;
            this.textBox_Número.Name = "textBox_Número";
            this.textBox_Número.Size = new System.Drawing.Size(32, 20);
            this.textBox_Número.TabIndex = 8;
            this.textBox_Número.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Número_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "CEP";
            // 
            // textBox_CEP
            // 
            this.textBox_CEP.Location = new System.Drawing.Point(10, 416);
            this.textBox_CEP.MaxLength = 8;
            this.textBox_CEP.Name = "textBox_CEP";
            this.textBox_CEP.Size = new System.Drawing.Size(144, 20);
            this.textBox_CEP.TabIndex = 3;
            this.textBox_CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CEP_KeyPress);
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 516);
            this.Controls.Add(this.buttonAlterarDados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_CEP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Número);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CPF_CNPJ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Bairro);
            this.Controls.Add(this.textBox_Rua);
            this.Controls.Add(this.textBox_UF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Cidade);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridView_Clientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisarCliente";
            this.ShowIcon = false;
            this.Text = "PesquisarCliente";
            this.Load += new System.EventHandler(this.PesquisarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CPF_CNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button buttonAlterarDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefones;
        private System.Windows.Forms.TextBox textBox_Cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UF;
        private System.Windows.Forms.TextBox textBox_Rua;
        private System.Windows.Forms.TextBox textBox_Bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Número;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}