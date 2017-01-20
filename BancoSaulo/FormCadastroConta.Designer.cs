namespace BancoSaulo
{
    partial class FormCadastroConta
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
            this.numeroLabel = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.titularLabel = new System.Windows.Forms.Label();
            this.cadastrarBox = new System.Windows.Forms.GroupBox();
            this.boxTipoConta = new System.Windows.Forms.ComboBox();
            this.labelTipoConta = new System.Windows.Forms.Label();
            this.textoGanho = new System.Windows.Forms.TextBox();
            this.labelGanho = new System.Windows.Forms.Label();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.cadastrarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(61, 45);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(44, 13);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Numero";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(134, 45);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(118, 20);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.TabStop = false;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(134, 80);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(118, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // titularLabel
            // 
            this.titularLabel.AutoSize = true;
            this.titularLabel.Location = new System.Drawing.Point(61, 80);
            this.titularLabel.Name = "titularLabel";
            this.titularLabel.Size = new System.Drawing.Size(36, 13);
            this.titularLabel.TabIndex = 2;
            this.titularLabel.Text = "Titular";
            // 
            // cadastrarBox
            // 
            this.cadastrarBox.Controls.Add(this.boxTipoConta);
            this.cadastrarBox.Controls.Add(this.labelTipoConta);
            this.cadastrarBox.Controls.Add(this.textoGanho);
            this.cadastrarBox.Controls.Add(this.labelGanho);
            this.cadastrarBox.Controls.Add(this.cadastrarBotao);
            this.cadastrarBox.Location = new System.Drawing.Point(30, 13);
            this.cadastrarBox.Name = "cadastrarBox";
            this.cadastrarBox.Size = new System.Drawing.Size(258, 213);
            this.cadastrarBox.TabIndex = 4;
            this.cadastrarBox.TabStop = false;
            this.cadastrarBox.Text = "Cadastrar Cliente";
            // 
            // boxTipoConta
            // 
            this.boxTipoConta.FormattingEnabled = true;
            this.boxTipoConta.Location = new System.Drawing.Point(104, 137);
            this.boxTipoConta.Name = "boxTipoConta";
            this.boxTipoConta.Size = new System.Drawing.Size(118, 21);
            this.boxTipoConta.TabIndex = 2;
            this.boxTipoConta.SelectedIndexChanged += new System.EventHandler(this.boxTipoConta_SelectedIndexChanged);
            // 
            // labelTipoConta
            // 
            this.labelTipoConta.AutoSize = true;
            this.labelTipoConta.Location = new System.Drawing.Point(31, 145);
            this.labelTipoConta.Name = "labelTipoConta";
            this.labelTipoConta.Size = new System.Drawing.Size(59, 13);
            this.labelTipoConta.TabIndex = 3;
            this.labelTipoConta.Text = "Tipo Conta";
            // 
            // textoGanho
            // 
            this.textoGanho.Location = new System.Drawing.Point(104, 102);
            this.textoGanho.Name = "textoGanho";
            this.textoGanho.Size = new System.Drawing.Size(118, 20);
            this.textoGanho.TabIndex = 1;
            // 
            // labelGanho
            // 
            this.labelGanho.AutoSize = true;
            this.labelGanho.Location = new System.Drawing.Point(31, 105);
            this.labelGanho.Name = "labelGanho";
            this.labelGanho.Size = new System.Drawing.Size(39, 13);
            this.labelGanho.TabIndex = 1;
            this.labelGanho.Text = "Ganho";
            // 
            // cadastrarBotao
            // 
            this.cadastrarBotao.Location = new System.Drawing.Point(147, 184);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBotao.TabIndex = 3;
            this.cadastrarBotao.Text = "Cadastrar";
            this.cadastrarBotao.UseVisualStyleBackColor = true;
            this.cadastrarBotao.Click += new System.EventHandler(this.cadastrarBotao_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(335, 260);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.titularLabel);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.cadastrarBox);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.cadastrarBox.ResumeLayout(false);
            this.cadastrarBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label titularLabel;
        private System.Windows.Forms.GroupBox cadastrarBox;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.TextBox textoGanho;
        private System.Windows.Forms.Label labelGanho;
        private System.Windows.Forms.ComboBox boxTipoConta;
        private System.Windows.Forms.Label labelTipoConta;
    }
}