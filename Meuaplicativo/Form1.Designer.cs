namespace Meuaplicativo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lbCPF = new Label();
            txtcpf = new TextBox();
            txtendereco = new TextBox();
            lbEndereco = new Label();
            txtNome = new TextBox();
            lbNome = new Label();
            dgPessoa = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgPessoa);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbCPF);
            panel1.Controls.Add(txtcpf);
            panel1.Controls.Add(txtendereco);
            panel1.Controls.Add(lbEndereco);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lbNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 428);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(145, 389);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(266, 389);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(384, 389);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Location = new Point(29, 166);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(31, 15);
            lbCPF.TabIndex = 5;
            lbCPF.Text = "CPF:";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(73, 163);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(372, 23);
            txtcpf.TabIndex = 4;
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(73, 107);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(372, 23);
            txtendereco.TabIndex = 3;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Location = new Point(13, 115);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(59, 15);
            lbEndereco.TabIndex = 2;
            lbEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(372, 23);
            txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(29, 54);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(29, 208);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.Size = new Size(416, 144);
            dgPessoa.TabIndex = 9;
            dgPessoa.CellContentClick += dgPessoa_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 452);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtendereco;
        private Label lbEndereco;
        private TextBox txtNome;
        private Label lbNome;
        private Button button1;
        private Label lbCPF;
        private TextBox txtcpf;
        private Button button3;
        public Button button2;
        private DataGridView dgPessoa;
    }
}
