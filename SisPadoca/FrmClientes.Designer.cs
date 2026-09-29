namespace SisPadoca
{
    partial class FrmClientes
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
            LblCPF = new Label();
            MtbCPF = new MaskedTextBox();
            LblNome = new Label();
            LblSexo = new Label();
            LblData = new Label();
            LblEndereço = new Label();
            LblBairro = new Label();
            LblCidade = new Label();
            LblEstado = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            LblObservações = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Location = new Point(12, 38);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(42, 25);
            LblCPF.TabIndex = 0;
            LblCPF.Text = "CPF";
            // 
            // MtbCPF
            // 
            MtbCPF.Location = new Point(75, 35);
            MtbCPF.Mask = "###,###,###-##";
            MtbCPF.Name = "MtbCPF";
            MtbCPF.Size = new Size(111, 31);
            MtbCPF.TabIndex = 1;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(10, 101);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(61, 25);
            LblNome.TabIndex = 3;
            LblNome.Text = "Nome";
            // 
            // LblSexo
            // 
            LblSexo.AutoSize = true;
            LblSexo.Location = new Point(12, 167);
            LblSexo.Name = "LblSexo";
            LblSexo.Size = new Size(50, 25);
            LblSexo.TabIndex = 4;
            LblSexo.Text = "Sexo";
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Location = new Point(218, 41);
            LblData.Name = "LblData";
            LblData.Size = new Size(106, 25);
            LblData.TabIndex = 5;
            LblData.Text = "Nascimento";
            // 
            // LblEndereço
            // 
            LblEndereço.AutoSize = true;
            LblEndereço.Location = new Point(239, 104);
            LblEndereço.Name = "LblEndereço";
            LblEndereço.Size = new Size(85, 25);
            LblEndereço.TabIndex = 6;
            LblEndereço.Text = "Endereço";
            // 
            // LblBairro
            // 
            LblBairro.AutoSize = true;
            LblBairro.Location = new Point(266, 170);
            LblBairro.Name = "LblBairro";
            LblBairro.Size = new Size(58, 25);
            LblBairro.TabIndex = 7;
            LblBairro.Text = "Bairro";
            // 
            // LblCidade
            // 
            LblCidade.AutoSize = true;
            LblCidade.Location = new Point(554, 41);
            LblCidade.Name = "LblCidade";
            LblCidade.Size = new Size(67, 25);
            LblCidade.TabIndex = 8;
            LblCidade.Text = "Cidade";
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Location = new Point(554, 101);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(66, 25);
            LblEstado.TabIndex = 9;
            LblEstado.Text = "Estado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 31);
            textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 33);
            comboBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(330, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(330, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(665, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(654, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 16;
            // 
            // LblObservações
            // 
            LblObservações.AutoSize = true;
            LblObservações.Location = new Point(21, 303);
            LblObservações.Name = "LblObservações";
            LblObservações.Size = new Size(106, 25);
            LblObservações.TabIndex = 17;
            LblObservações.Text = "Obervações";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(142, 303);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 18;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(comboBox3);
            Controls.Add(LblObservações);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(LblEstado);
            Controls.Add(LblCidade);
            Controls.Add(LblBairro);
            Controls.Add(LblEndereço);
            Controls.Add(LblData);
            Controls.Add(LblSexo);
            Controls.Add(LblNome);
            Controls.Add(MtbCPF);
            Controls.Add(LblCPF);
            Name = "FrmClientes";
            Text = "Cadastro de Clientes";
            Load += FrmClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCPF;
        private MaskedTextBox MtbCPF;
        private Label LblNome;
        private Label LblSexo;
        private Label LblData;
        private Label LblEndereço;
        private Label LblBairro;
        private Label LblCidade;
        private Label LblEstado;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private Label LblObservações;
        private ComboBox comboBox3;
    }
}