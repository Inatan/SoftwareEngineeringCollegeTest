namespace PBR_Rent_a_car
{
    partial class CadastroLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLogin));
            this.labelPBR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRedefinirSenha = new System.Windows.Forms.Button();
            this.buttonNãoConsigoLogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPBR
            // 
            this.labelPBR.AutoSize = true;
            this.labelPBR.Font = new System.Drawing.Font("Haettenschweiler", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPBR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPBR.Location = new System.Drawing.Point(26, 9);
            this.labelPBR.Name = "labelPBR";
            this.labelPBR.Size = new System.Drawing.Size(170, 35);
            this.labelPBR.TabIndex = 1;
            this.labelPBR.Text = "PBR Rent a Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login";
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.Location = new System.Drawing.Point(12, 210);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.PasswordChar = '*';
            this.textBox_Fornecedor.Size = new System.Drawing.Size(208, 20);
            this.textBox_Fornecedor.TabIndex = 14;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 164);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(208, 20);
            this.textBox_Nome.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(164, 290);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(56, 32);
            this.buttonLogin.TabIndex = 18;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonRedefinirSenha
            // 
            this.buttonRedefinirSenha.Location = new System.Drawing.Point(12, 249);
            this.buttonRedefinirSenha.Name = "buttonRedefinirSenha";
            this.buttonRedefinirSenha.Size = new System.Drawing.Size(91, 35);
            this.buttonRedefinirSenha.TabIndex = 19;
            this.buttonRedefinirSenha.Text = "Redefinir Senha";
            this.buttonRedefinirSenha.UseVisualStyleBackColor = true;
            this.buttonRedefinirSenha.Click += new System.EventHandler(this.buttonRedefinirSenha_Click);
            // 
            // buttonNãoConsigoLogar
            // 
            this.buttonNãoConsigoLogar.Location = new System.Drawing.Point(109, 249);
            this.buttonNãoConsigoLogar.Name = "buttonNãoConsigoLogar";
            this.buttonNãoConsigoLogar.Size = new System.Drawing.Size(111, 35);
            this.buttonNãoConsigoLogar.TabIndex = 20;
            this.buttonNãoConsigoLogar.Text = "Não consigo logar";
            this.buttonNãoConsigoLogar.UseVisualStyleBackColor = true;
            // 
            // CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 334);
            this.Controls.Add(this.buttonNãoConsigoLogar);
            this.Controls.Add(this.buttonRedefinirSenha);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPBR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.CadastroLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPBR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Fornecedor;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRedefinirSenha;
        private System.Windows.Forms.Button buttonNãoConsigoLogar;
    }
}