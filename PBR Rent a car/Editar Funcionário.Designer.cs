﻿namespace PBR_Rent_a_car
{
    partial class Editar_Funcionário
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CarteiraTrabalho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Salario = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.radioButtonGerente = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionário = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(144, 188);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 77;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(13, 188);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 76;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Carteira de Trabalho";
            // 
            // textBox_CarteiraTrabalho
            // 
            this.textBox_CarteiraTrabalho.Location = new System.Drawing.Point(12, 64);
            this.textBox_CarteiraTrabalho.MaxLength = 5;
            this.textBox_CarteiraTrabalho.Name = "textBox_CarteiraTrabalho";
            this.textBox_CarteiraTrabalho.Size = new System.Drawing.Size(206, 20);
            this.textBox_CarteiraTrabalho.TabIndex = 74;
            this.textBox_CarteiraTrabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CarteiraTrabalho_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(11, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Função";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Salário (R$)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nome";
            // 
            // textBox_Salario
            // 
            this.textBox_Salario.Location = new System.Drawing.Point(12, 109);
            this.textBox_Salario.Name = "textBox_Salario";
            this.textBox_Salario.Size = new System.Drawing.Size(206, 20);
            this.textBox_Salario.TabIndex = 69;
            this.textBox_Salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Salario_KeyPress);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 24);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(207, 20);
            this.textBox_Nome.TabIndex = 68;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // radioButtonGerente
            // 
            this.radioButtonGerente.AutoSize = true;
            this.radioButtonGerente.Location = new System.Drawing.Point(138, 154);
            this.radioButtonGerente.Name = "radioButtonGerente";
            this.radioButtonGerente.Size = new System.Drawing.Size(63, 17);
            this.radioButtonGerente.TabIndex = 79;
            this.radioButtonGerente.TabStop = true;
            this.radioButtonGerente.Text = "Gerente";
            this.radioButtonGerente.UseVisualStyleBackColor = true;
            // 
            // radioButtonFuncionário
            // 
            this.radioButtonFuncionário.AutoSize = true;
            this.radioButtonFuncionário.Location = new System.Drawing.Point(15, 154);
            this.radioButtonFuncionário.Name = "radioButtonFuncionário";
            this.radioButtonFuncionário.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFuncionário.TabIndex = 78;
            this.radioButtonFuncionário.TabStop = true;
            this.radioButtonFuncionário.Text = "Funcionário";
            this.radioButtonFuncionário.UseVisualStyleBackColor = true;
            // 
            // Editar_Funcionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 220);
            this.Controls.Add(this.radioButtonGerente);
            this.Controls.Add(this.radioButtonFuncionário);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CarteiraTrabalho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Salario);
            this.Controls.Add(this.textBox_Nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar_Funcionário";
            this.ShowIcon = false;
            this.Text = "Editar Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CarteiraTrabalho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Salario;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.RadioButton radioButtonGerente;
        private System.Windows.Forms.RadioButton radioButtonFuncionário;
    }
}