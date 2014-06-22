namespace PBR_Rent_a_car
{
    partial class Pesquisar_Funcionário
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
            this.dataGridView_Funcionários = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarteriaTrabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Função = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CarteiraTrabalho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Salario = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.checkBoxGerente = new System.Windows.Forms.CheckBox();
            this.checkBoxFuncionário = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Funcionários)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(12, 263);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 39;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // dataGridView_Funcionários
            // 
            this.dataGridView_Funcionários.AllowUserToAddRows = false;
            this.dataGridView_Funcionários.AllowUserToDeleteRows = false;
            this.dataGridView_Funcionários.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Funcionários.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CarteriaTrabalho,
            this.Função,
            this.Salário});
            this.dataGridView_Funcionários.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Funcionários.Name = "dataGridView_Funcionários";
            this.dataGridView_Funcionários.Size = new System.Drawing.Size(445, 241);
            this.dataGridView_Funcionários.TabIndex = 38;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CarteriaTrabalho
            // 
            this.CarteriaTrabalho.HeaderText = "Carteira de Trabalho";
            this.CarteriaTrabalho.Name = "CarteriaTrabalho";
            // 
            // Função
            // 
            this.Função.HeaderText = "Função";
            this.Função.Name = "Função";
            // 
            // Salário
            // 
            this.Salário.HeaderText = "Salário";
            this.Salário.Name = "Salário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Carteira de Trabalho";
            // 
            // textBox_CarteiraTrabalho
            // 
            this.textBox_CarteiraTrabalho.Location = new System.Drawing.Point(12, 354);
            this.textBox_CarteiraTrabalho.MaxLength = 5;
            this.textBox_CarteiraTrabalho.Name = "textBox_CarteiraTrabalho";
            this.textBox_CarteiraTrabalho.Size = new System.Drawing.Size(144, 20);
            this.textBox_CarteiraTrabalho.TabIndex = 56;
            this.textBox_CarteiraTrabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CarteiraTrabalho_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Função";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Salário Maior que";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome";
            // 
            // textBox_Salario
            // 
            this.textBox_Salario.Location = new System.Drawing.Point(229, 305);
            this.textBox_Salario.Name = "textBox_Salario";
            this.textBox_Salario.Size = new System.Drawing.Size(228, 20);
            this.textBox_Salario.TabIndex = 51;
            this.textBox_Salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Salario_KeyPress);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 305);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(201, 20);
            this.textBox_Nome.TabIndex = 50;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(382, 391);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 58;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 391);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 59;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(105, 391);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 60;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(283, 391);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 61;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // checkBoxGerente
            // 
            this.checkBoxGerente.AutoSize = true;
            this.checkBoxGerente.Checked = true;
            this.checkBoxGerente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGerente.Location = new System.Drawing.Point(234, 357);
            this.checkBoxGerente.Name = "checkBoxGerente";
            this.checkBoxGerente.Size = new System.Drawing.Size(64, 17);
            this.checkBoxGerente.TabIndex = 62;
            this.checkBoxGerente.Text = "Gerente";
            this.checkBoxGerente.UseVisualStyleBackColor = true;
            // 
            // checkBoxFuncionário
            // 
            this.checkBoxFuncionário.AutoSize = true;
            this.checkBoxFuncionário.Checked = true;
            this.checkBoxFuncionário.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFuncionário.Location = new System.Drawing.Point(329, 357);
            this.checkBoxFuncionário.Name = "checkBoxFuncionário";
            this.checkBoxFuncionário.Size = new System.Drawing.Size(81, 17);
            this.checkBoxFuncionário.TabIndex = 63;
            this.checkBoxFuncionário.Text = "Funcionário";
            this.checkBoxFuncionário.UseVisualStyleBackColor = true;
            // 
            // Pesquisar_Funcionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 426);
            this.Controls.Add(this.checkBoxFuncionário);
            this.Controls.Add(this.checkBoxGerente);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CarteiraTrabalho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Salario);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridView_Funcionários);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisar_Funcionário";
            this.ShowIcon = false;
            this.Text = "Pesquisar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Funcionários)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridView_Funcionários;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarteriaTrabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Função;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salário;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CarteiraTrabalho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Salario;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.CheckBox checkBoxGerente;
        private System.Windows.Forms.CheckBox checkBoxFuncionário;
    }
}