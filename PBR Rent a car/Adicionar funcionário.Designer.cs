namespace PBR_Rent_a_car
{
    partial class Adicionar_funcionário
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CarteiraTrabalho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Salario = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Carteira de Trabalho";
            // 
            // textBox_CarteiraTrabalho
            // 
            this.textBox_CarteiraTrabalho.Location = new System.Drawing.Point(12, 65);
            this.textBox_CarteiraTrabalho.MaxLength = 5;
            this.textBox_CarteiraTrabalho.Name = "textBox_CarteiraTrabalho";
            this.textBox_CarteiraTrabalho.Size = new System.Drawing.Size(206, 20);
            this.textBox_CarteiraTrabalho.TabIndex = 64;
            this.textBox_CarteiraTrabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CarteiraTrabalho_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Função";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Salário (R$)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nome";
            // 
            // textBox_Salario
            // 
            this.textBox_Salario.Location = new System.Drawing.Point(12, 110);
            this.textBox_Salario.Name = "textBox_Salario";
            this.textBox_Salario.Size = new System.Drawing.Size(206, 20);
            this.textBox_Salario.TabIndex = 59;
            this.textBox_Salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Salario_KeyPress);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 25);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(207, 20);
            this.textBox_Nome.TabIndex = 58;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 259);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 66;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(143, 259);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 67;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Usuário";
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(12, 194);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(206, 20);
            this.textBox_Usuario.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Senha";
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(12, 233);
            this.textBox_Senha.MaxLength = 10;
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PasswordChar = '*';
            this.textBox_Senha.Size = new System.Drawing.Size(206, 20);
            this.textBox_Senha.TabIndex = 71;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 155);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 72;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Funcionário";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 73;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Gerente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Adicionar_funcionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 289);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CarteiraTrabalho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Salario);
            this.Controls.Add(this.textBox_Nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adicionar_funcionário";
            this.ShowIcon = false;
            this.Text = "Adicionar Funcionário";
            this.Load += new System.EventHandler(this.Adicionar_funcionário_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CarteiraTrabalho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Salario;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}