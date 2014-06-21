namespace PBR_Rent_a_car
{
    partial class Cadastro_Cliente
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
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_CPF_CNPJ = new System.Windows.Forms.TextBox();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonCNPJ = new System.Windows.Forms.RadioButton();
            this.textBox_TelefoneMóvel = new System.Windows.Forms.TextBox();
            this.textBox_TelefoneFixo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Cidade = new System.Windows.Forms.TextBox();
            this.textBox_Número = new System.Windows.Forms.TextBox();
            this.textBox_Rua = new System.Windows.Forms.TextBox();
            this.textBox_CEP = new System.Windows.Forms.TextBox();
            this.textBox_Bairro = new System.Windows.Forms.TextBox();
            this.textBox_UF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Cadastrar = new System.Windows.Forms.Button();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(13, 42);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(238, 20);
            this.textBox_Nome.TabIndex = 0;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // textBox_CPF_CNPJ
            // 
            this.textBox_CPF_CNPJ.Location = new System.Drawing.Point(12, 98);
            this.textBox_CPF_CNPJ.MaxLength = 11;
            this.textBox_CPF_CNPJ.Name = "textBox_CPF_CNPJ";
            this.textBox_CPF_CNPJ.Size = new System.Drawing.Size(160, 20);
            this.textBox_CPF_CNPJ.TabIndex = 1;
            this.textBox_CPF_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CPF_CNPJ_KeyPress);
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Checked = true;
            this.radioButtonCPF.Location = new System.Drawing.Point(12, 124);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(45, 17);
            this.radioButtonCPF.TabIndex = 2;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonCNPJ
            // 
            this.radioButtonCNPJ.AutoSize = true;
            this.radioButtonCNPJ.Location = new System.Drawing.Point(63, 124);
            this.radioButtonCNPJ.Name = "radioButtonCNPJ";
            this.radioButtonCNPJ.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCNPJ.TabIndex = 3;
            this.radioButtonCNPJ.Text = "CNPJ";
            this.radioButtonCNPJ.UseVisualStyleBackColor = true;
            // 
            // textBox_TelefoneMóvel
            // 
            this.textBox_TelefoneMóvel.Location = new System.Drawing.Point(143, 182);
            this.textBox_TelefoneMóvel.MaxLength = 10;
            this.textBox_TelefoneMóvel.Name = "textBox_TelefoneMóvel";
            this.textBox_TelefoneMóvel.Size = new System.Drawing.Size(112, 20);
            this.textBox_TelefoneMóvel.TabIndex = 4;
            this.textBox_TelefoneMóvel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TelefoneMóvel_KeyPress);
            // 
            // textBox_TelefoneFixo
            // 
            this.textBox_TelefoneFixo.Location = new System.Drawing.Point(12, 182);
            this.textBox_TelefoneFixo.MaxLength = 10;
            this.textBox_TelefoneFixo.Name = "textBox_TelefoneFixo";
            this.textBox_TelefoneFixo.Size = new System.Drawing.Size(113, 20);
            this.textBox_TelefoneFixo.TabIndex = 5;
            this.textBox_TelefoneFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TelefoneFixo_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_Cidade);
            this.panel1.Controls.Add(this.textBox_Número);
            this.panel1.Controls.Add(this.textBox_Rua);
            this.panel1.Controls.Add(this.textBox_CEP);
            this.panel1.Controls.Add(this.textBox_Bairro);
            this.panel1.Controls.Add(this.textBox_UF);
            this.panel1.Location = new System.Drawing.Point(295, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 256);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(16, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Número";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(16, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(13, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(72, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cidade";
            // 
            // textBox_Cidade
            // 
            this.textBox_Cidade.Location = new System.Drawing.Point(70, 21);
            this.textBox_Cidade.Name = "textBox_Cidade";
            this.textBox_Cidade.Size = new System.Drawing.Size(146, 20);
            this.textBox_Cidade.TabIndex = 5;
            this.textBox_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cidade_KeyPress);
            // 
            // textBox_Número
            // 
            this.textBox_Número.Location = new System.Drawing.Point(16, 218);
            this.textBox_Número.MaxLength = 5;
            this.textBox_Número.Name = "textBox_Número";
            this.textBox_Número.Size = new System.Drawing.Size(55, 20);
            this.textBox_Número.TabIndex = 4;
            this.textBox_Número.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Número_KeyPress);
            // 
            // textBox_Rua
            // 
            this.textBox_Rua.Location = new System.Drawing.Point(16, 170);
            this.textBox_Rua.Name = "textBox_Rua";
            this.textBox_Rua.Size = new System.Drawing.Size(288, 20);
            this.textBox_Rua.TabIndex = 3;
            this.textBox_Rua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Rua_KeyPress);
            // 
            // textBox_CEP
            // 
            this.textBox_CEP.Location = new System.Drawing.Point(16, 64);
            this.textBox_CEP.MaxLength = 8;
            this.textBox_CEP.Name = "textBox_CEP";
            this.textBox_CEP.Size = new System.Drawing.Size(140, 20);
            this.textBox_CEP.TabIndex = 2;
            this.textBox_CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CEP_KeyPress);
            // 
            // textBox_Bairro
            // 
            this.textBox_Bairro.Location = new System.Drawing.Point(16, 115);
            this.textBox_Bairro.Name = "textBox_Bairro";
            this.textBox_Bairro.Size = new System.Drawing.Size(133, 20);
            this.textBox_Bairro.TabIndex = 1;
            this.textBox_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Bairro_KeyPress);
            // 
            // textBox_UF
            // 
            this.textBox_UF.Location = new System.Drawing.Point(16, 21);
            this.textBox_UF.MaxLength = 2;
            this.textBox_UF.Name = "textBox_UF";
            this.textBox_UF.Size = new System.Drawing.Size(27, 20);
            this.textBox_UF.TabIndex = 0;
            this.textBox_UF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UF_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF / CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefone Móvel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefone Fixo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(292, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Endereço";
            // 
            // Button_Cadastrar
            // 
            this.Button_Cadastrar.Location = new System.Drawing.Point(13, 258);
            this.Button_Cadastrar.Name = "Button_Cadastrar";
            this.Button_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cadastrar.TabIndex = 12;
            this.Button_Cadastrar.Text = "Cadastrar";
            this.Button_Cadastrar.UseVisualStyleBackColor = true;
            this.Button_Cadastrar.Click += new System.EventHandler(this.Button_Cadastrar_Click);
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.Location = new System.Drawing.Point(202, 258);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancelar.TabIndex = 13;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = true;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(12, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Usuário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(140, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Senha";
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(12, 221);
            this.textBox_Usuario.MaxLength = 10;
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(112, 20);
            this.textBox_Usuario.TabIndex = 16;
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(143, 221);
            this.textBox_Senha.MaxLength = 10;
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PasswordChar = '*';
            this.textBox_Senha.Size = new System.Drawing.Size(112, 20);
            this.textBox_Senha.TabIndex = 17;
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 288);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_TelefoneFixo);
            this.Controls.Add(this.textBox_TelefoneMóvel);
            this.Controls.Add(this.radioButtonCNPJ);
            this.Controls.Add(this.radioButtonCPF);
            this.Controls.Add(this.textBox_CPF_CNPJ);
            this.Controls.Add(this.textBox_Nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Cliente";
            this.ShowIcon = false;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.Cadastro_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_CPF_CNPJ;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.RadioButton radioButtonCNPJ;
        private System.Windows.Forms.TextBox textBox_TelefoneMóvel;
        private System.Windows.Forms.TextBox textBox_TelefoneFixo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_UF;
        private System.Windows.Forms.TextBox textBox_Bairro;
        private System.Windows.Forms.TextBox textBox_Cidade;
        private System.Windows.Forms.TextBox textBox_Número;
        private System.Windows.Forms.TextBox textBox_Rua;
        private System.Windows.Forms.TextBox textBox_CEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Cadastrar;
        private System.Windows.Forms.Button Button_Cancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Senha;
    }
}