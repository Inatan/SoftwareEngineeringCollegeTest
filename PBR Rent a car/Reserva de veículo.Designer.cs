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
            this.ListBoxVeículo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Reservar = new System.Windows.Forms.Button();
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.comboBoxAno = new System.Windows.Forms.ComboBox();
            this.comboBoxMês = new System.Windows.Forms.ComboBox();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuto = new System.Windows.Forms.ComboBox();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Minuto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hora";
            // 
            // ListBoxVeículo
            // 
            this.ListBoxVeículo.FormattingEnabled = true;
            this.ListBoxVeículo.Items.AddRange(new object[] {
            "Clique aqui para pesquisar o veículo"});
            this.ListBoxVeículo.Location = new System.Drawing.Point(9, 84);
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
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cliente";
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
            // comboBoxAno
            // 
            this.comboBoxAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.comboBoxAno.Location = new System.Drawing.Point(87, 130);
            this.comboBoxAno.Name = "comboBoxAno";
            this.comboBoxAno.Size = new System.Drawing.Size(53, 21);
            this.comboBoxAno.TabIndex = 38;
            // 
            // comboBoxMês
            // 
            this.comboBoxMês.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMês.FormattingEnabled = true;
            this.comboBoxMês.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMês.Location = new System.Drawing.Point(48, 130);
            this.comboBoxMês.Name = "comboBoxMês";
            this.comboBoxMês.Size = new System.Drawing.Size(33, 21);
            this.comboBoxMês.TabIndex = 37;
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDia.Location = new System.Drawing.Point(9, 130);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(33, 21);
            this.comboBoxDia.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dia";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxHora.Location = new System.Drawing.Point(146, 130);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(33, 21);
            this.comboBoxHora.TabIndex = 39;
            // 
            // comboBoxMinuto
            // 
            this.comboBoxMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinuto.FormattingEnabled = true;
            this.comboBoxMinuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinuto.Location = new System.Drawing.Point(185, 130);
            this.comboBoxMinuto.Name = "comboBoxMinuto";
            this.comboBoxMinuto.Size = new System.Drawing.Size(33, 21);
            this.comboBoxMinuto.TabIndex = 40;
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.Items.AddRange(new object[] {
            "Clique aqui para pesquisar o Cliente"});
            this.listBoxCliente.Location = new System.Drawing.Point(9, 32);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(414, 17);
            this.listBoxCliente.TabIndex = 41;
            // 
            // Reserva_de_veículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 206);
            this.Controls.Add(this.listBoxCliente);
            this.Controls.Add(this.comboBoxMinuto);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.comboBoxAno);
            this.Controls.Add(this.comboBoxMês);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.Button_Reservar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxVeículo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
        private System.Windows.Forms.ListBox ListBoxVeículo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Reservar;
        private System.Windows.Forms.Button Button_Cancelar;
        private System.Windows.Forms.ComboBox comboBoxAno;
        private System.Windows.Forms.ComboBox comboBoxMês;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.ComboBox comboBoxMinuto;
        private System.Windows.Forms.ListBox listBoxCliente;
    }
}