namespace PBR_Rent_a_car
{
    partial class Cadastro_Veículo
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_Cor = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Modelo = new System.Windows.Forms.ComboBox();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.Button_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Categoria";
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.Location = new System.Drawing.Point(12, 112);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(183, 20);
            this.textBox_Categoria.TabIndex = 23;
            this.textBox_Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Categoria_KeyPress);
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.Location = new System.Drawing.Point(12, 64);
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(183, 20);
            this.textBox_Cor.TabIndex = 20;
            this.textBox_Cor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cor_KeyPress);
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Location = new System.Drawing.Point(12, 25);
            this.textBox_Ano.MaxLength = 4;
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(48, 20);
            this.textBox_Ano.TabIndex = 18;
            this.textBox_Ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ano_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modelo";
            // 
            // comboBox_Modelo
            // 
            this.comboBox_Modelo.FormattingEnabled = true;
            this.comboBox_Modelo.Location = new System.Drawing.Point(12, 151);
            this.comboBox_Modelo.Name = "comboBox_Modelo";
            this.comboBox_Modelo.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Modelo.TabIndex = 28;
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.Location = new System.Drawing.Point(126, 193);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancelar.TabIndex = 30;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = true;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // Button_Cadastrar
            // 
            this.Button_Cadastrar.Location = new System.Drawing.Point(12, 193);
            this.Button_Cadastrar.Name = "Button_Cadastrar";
            this.Button_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cadastrar.TabIndex = 29;
            this.Button_Cadastrar.Text = "Cadastrar";
            this.Button_Cadastrar.UseVisualStyleBackColor = true;
            this.Button_Cadastrar.Click += new System.EventHandler(this.Button_Cadastrar_Click);
            // 
            // Cadastro_Veículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 226);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Cadastrar);
            this.Controls.Add(this.comboBox_Modelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Cor);
            this.Controls.Add(this.textBox_Ano);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Veículo";
            this.ShowIcon = false;
            this.Text = "Cadastro de veículo";
            this.Load += new System.EventHandler(this.Cadastro_Veículo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.TextBox textBox_Cor;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Modelo;
        private System.Windows.Forms.Button Button_Cancelar;
        private System.Windows.Forms.Button Button_Cadastrar;
    }
}