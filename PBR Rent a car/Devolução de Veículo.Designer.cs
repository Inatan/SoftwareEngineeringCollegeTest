namespace PBR_Rent_a_car
{
    partial class Devolução_de_Veículo
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
            this.labelData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPreço = new System.Windows.Forms.Label();
            this.buttonPago = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entregre em:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(85, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(31, 13);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço a ser pago:";
            // 
            // labelPreço
            // 
            this.labelPreço.AutoSize = true;
            this.labelPreço.Location = new System.Drawing.Point(109, 53);
            this.labelPreço.Name = "labelPreço";
            this.labelPreço.Size = new System.Drawing.Size(31, 13);
            this.labelPreço.TabIndex = 3;
            this.labelPreço.Text = "Valor";
            // 
            // buttonPago
            // 
            this.buttonPago.Location = new System.Drawing.Point(12, 94);
            this.buttonPago.Name = "buttonPago";
            this.buttonPago.Size = new System.Drawing.Size(75, 23);
            this.buttonPago.TabIndex = 4;
            this.buttonPago.Text = "Concluir";
            this.buttonPago.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Devolução_de_Veículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPago);
            this.Controls.Add(this.labelPreço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devolução_de_Veículo";
            this.ShowIcon = false;
            this.Text = "Devolução de Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPreço;
        private System.Windows.Forms.Button buttonPago;
        private System.Windows.Forms.Button button1;
    }
}