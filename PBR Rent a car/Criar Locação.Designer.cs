namespace PBR_Rent_a_car
{
    partial class Criar_Locação
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxVeículo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.buttonLocar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // ListBoxVeículo
            // 
            this.ListBoxVeículo.FormattingEnabled = true;
            this.ListBoxVeículo.Items.AddRange(new object[] {
            "Clique aqui para pesquisar o veículo"});
            this.ListBoxVeículo.Location = new System.Drawing.Point(12, 77);
            this.ListBoxVeículo.Name = "ListBoxVeículo";
            this.ListBoxVeículo.Size = new System.Drawing.Size(286, 17);
            this.ListBoxVeículo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Veiculo";
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.Items.AddRange(new object[] {
            "Clique aqui para pesquisar o Cliente"});
            this.listBoxCliente.Location = new System.Drawing.Point(12, 25);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(286, 17);
            this.listBoxCliente.TabIndex = 30;
            // 
            // buttonLocar
            // 
            this.buttonLocar.Location = new System.Drawing.Point(13, 137);
            this.buttonLocar.Name = "buttonLocar";
            this.buttonLocar.Size = new System.Drawing.Size(75, 23);
            this.buttonLocar.TabIndex = 31;
            this.buttonLocar.Text = "Locar";
            this.buttonLocar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(223, 137);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 32;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Criar_Locação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 172);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLocar);
            this.Controls.Add(this.listBoxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxVeículo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Criar_Locação";
            this.ShowIcon = false;
            this.Text = "Criar Locação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxVeículo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.Button buttonLocar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}