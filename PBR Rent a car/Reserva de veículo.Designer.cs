namespace PBR_Rent_a_car
{
    partial class Reserva_de_veículo
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Mês = new System.Windows.Forms.TextBox();
            this.textBox_Minuto = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.textBox_Hora = new System.Windows.Forms.TextBox();
            this.textBox_Dia = new System.Windows.Forms.TextBox();
            this.ListBoxVeículo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.Button_Reservar = new System.Windows.Forms.Button();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Minuto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mês";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dia";
            // 
            // textBox_Mês
            // 
            this.textBox_Mês.Location = new System.Drawing.Point(46, 131);
            this.textBox_Mês.Name = "textBox_Mês";
            this.textBox_Mês.Size = new System.Drawing.Size(24, 20);
            this.textBox_Mês.TabIndex = 21;
            // 
            // textBox_Minuto
            // 
            this.textBox_Minuto.Location = new System.Drawing.Point(167, 131);
            this.textBox_Minuto.Name = "textBox_Minuto";
            this.textBox_Minuto.Size = new System.Drawing.Size(33, 20);
            this.textBox_Minuto.TabIndex = 20;
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Location = new System.Drawing.Point(76, 131);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(41, 20);
            this.textBox_Ano.TabIndex = 19;
            // 
            // textBox_Hora
            // 
            this.textBox_Hora.Location = new System.Drawing.Point(134, 131);
            this.textBox_Hora.Name = "textBox_Hora";
            this.textBox_Hora.Size = new System.Drawing.Size(27, 20);
            this.textBox_Hora.TabIndex = 18;
            // 
            // textBox_Dia
            // 
            this.textBox_Dia.Location = new System.Drawing.Point(12, 131);
            this.textBox_Dia.Name = "textBox_Dia";
            this.textBox_Dia.Size = new System.Drawing.Size(27, 20);
            this.textBox_Dia.TabIndex = 17;
            // 
            // ListBoxVeículo
            // 
            this.ListBoxVeículo.FormattingEnabled = true;
            this.ListBoxVeículo.Items.AddRange(new object[] {
            "Clique aqui para pesquisar o veículo"});
            this.ListBoxVeículo.Location = new System.Drawing.Point(12, 84);
            this.ListBoxVeículo.Name = "ListBoxVeículo";
            this.ListBoxVeículo.Size = new System.Drawing.Size(411, 17);
            this.ListBoxVeículo.TabIndex = 27;
            this.ListBoxVeículo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxVeículo_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome completo do Cliente";
            // 
            // textBox_Nome_Cliente
            // 
            this.textBox_Nome_Cliente.Location = new System.Drawing.Point(12, 32);
            this.textBox_Nome_Cliente.Name = "textBox_Nome_Cliente";
            this.textBox_Nome_Cliente.Size = new System.Drawing.Size(411, 20);
            this.textBox_Nome_Cliente.TabIndex = 29;
            // 
            // Button_Reservar
            // 
            this.Button_Reservar.Location = new System.Drawing.Point(16, 171);
            this.Button_Reservar.Name = "Button_Reservar";
            this.Button_Reservar.Size = new System.Drawing.Size(68, 23);
            this.Button_Reservar.TabIndex = 31;
            this.Button_Reservar.Text = "Reservar";
            this.Button_Reservar.UseVisualStyleBackColor = true;
            this.Button_Reservar.Click += new System.EventHandler(this.Button_Reservar_Click);
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.Location = new System.Drawing.Point(348, 171);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancelar.TabIndex = 32;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = true;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // Reserva_de_veículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 206);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Reservar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nome_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxVeículo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Mês);
            this.Controls.Add(this.textBox_Minuto);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.textBox_Hora);
            this.Controls.Add(this.textBox_Dia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reserva_de_veículo";
            this.ShowIcon = false;
            this.Text = "Reserva de veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Mês;
        private System.Windows.Forms.TextBox textBox_Minuto;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.TextBox textBox_Hora;
        private System.Windows.Forms.TextBox textBox_Dia;
        private System.Windows.Forms.ListBox ListBoxVeículo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nome_Cliente;
        private System.Windows.Forms.Button Button_Reservar;
        private System.Windows.Forms.Button Button_Cancelar;
    }
}