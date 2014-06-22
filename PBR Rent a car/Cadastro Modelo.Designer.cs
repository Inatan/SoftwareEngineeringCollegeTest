namespace PBR_Rent_a_car
{
    partial class Cadastro_Modelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.Button_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.Location = new System.Drawing.Point(11, 70);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.Size = new System.Drawing.Size(244, 20);
            this.textBox_Fornecedor.TabIndex = 10;
            this.textBox_Fornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Fornecedor_KeyPress);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(11, 24);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(244, 20);
            this.textBox_Nome.TabIndex = 9;
            this.textBox_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nome_KeyPress);
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.Location = new System.Drawing.Point(180, 110);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancelar.TabIndex = 15;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = true;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // Button_Cadastrar
            // 
            this.Button_Cadastrar.Location = new System.Drawing.Point(11, 110);
            this.Button_Cadastrar.Name = "Button_Cadastrar";
            this.Button_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Button_Cadastrar.TabIndex = 14;
            this.Button_Cadastrar.Text = "Cadastrar";
            this.Button_Cadastrar.UseVisualStyleBackColor = true;
            this.Button_Cadastrar.Click += new System.EventHandler(this.Button_Cadastrar_Click);
            // 
            // Cadastro_Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 141);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Cadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.textBox_Nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Modelo";
            this.ShowIcon = false;
            this.Text = "Cadastro de modelo de veiculo";
            this.Load += new System.EventHandler(this.Cadastro_Modelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Fornecedor;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button Button_Cancelar;
        private System.Windows.Forms.Button Button_Cadastrar;

        public System.EventHandler Button_Reservar_Click { get; set; }
    }
}