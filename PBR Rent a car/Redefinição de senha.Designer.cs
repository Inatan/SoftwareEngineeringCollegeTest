namespace PBR_Rent_a_car
{
    partial class Redefinição_de_senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redefinição_de_senha));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SenhaVelha = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSenhaNova = new System.Windows.Forms.TextBox();
            this.textBoxSenhaNovaConvirmação = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRedefinir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Senha Velha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Login";
            // 
            // textBox_SenhaVelha
            // 
            this.textBox_SenhaVelha.Location = new System.Drawing.Point(9, 74);
            this.textBox_SenhaVelha.MaxLength = 10;
            this.textBox_SenhaVelha.Name = "textBox_SenhaVelha";
            this.textBox_SenhaVelha.PasswordChar = '*';
            this.textBox_SenhaVelha.Size = new System.Drawing.Size(208, 20);
            this.textBox_SenhaVelha.TabIndex = 1;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(8, 28);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(208, 20);
            this.textBox_Nome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Senha Nova (Confirmação)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Senha Nova";
            // 
            // textBoxSenhaNova
            // 
            this.textBoxSenhaNova.Location = new System.Drawing.Point(8, 120);
            this.textBoxSenhaNova.MaxLength = 10;
            this.textBoxSenhaNova.Name = "textBoxSenhaNova";
            this.textBoxSenhaNova.PasswordChar = '*';
            this.textBoxSenhaNova.Size = new System.Drawing.Size(208, 20);
            this.textBoxSenhaNova.TabIndex = 2;
            // 
            // textBoxSenhaNovaConvirmação
            // 
            this.textBoxSenhaNovaConvirmação.Location = new System.Drawing.Point(8, 166);
            this.textBoxSenhaNovaConvirmação.MaxLength = 10;
            this.textBoxSenhaNovaConvirmação.Name = "textBoxSenhaNovaConvirmação";
            this.textBoxSenhaNovaConvirmação.PasswordChar = '*';
            this.textBoxSenhaNovaConvirmação.Size = new System.Drawing.Size(208, 20);
            this.textBoxSenhaNovaConvirmação.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(156, 218);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(61, 32);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRedefinir
            // 
            this.buttonRedefinir.Location = new System.Drawing.Point(8, 218);
            this.buttonRedefinir.Name = "buttonRedefinir";
            this.buttonRedefinir.Size = new System.Drawing.Size(61, 32);
            this.buttonRedefinir.TabIndex = 4;
            this.buttonRedefinir.Text = "Redefinir";
            this.buttonRedefinir.UseVisualStyleBackColor = true;
            this.buttonRedefinir.Click += new System.EventHandler(this.buttonRedefinir_Click);
            // 
            // Redefinição_de_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 262);
            this.Controls.Add(this.buttonRedefinir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSenhaNova);
            this.Controls.Add(this.textBoxSenhaNovaConvirmação);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SenhaVelha);
            this.Controls.Add(this.textBox_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Redefinição_de_senha";
            this.Text = "Redefinição de senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SenhaVelha;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSenhaNova;
        private System.Windows.Forms.TextBox textBoxSenhaNovaConvirmação;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRedefinir;
    }
}