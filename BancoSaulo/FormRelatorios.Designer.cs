namespace BancoSaulo
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoCC = new System.Windows.Forms.Button();
            this.resumoBox = new System.Windows.Forms.GroupBox();
            this.labelsaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelMaior = new System.Windows.Forms.Label();
            this.resumoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 35);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(260, 121);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 234);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(120, 23);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo maior que 5000";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // botaoCC
            // 
            this.botaoCC.Location = new System.Drawing.Point(179, 234);
            this.botaoCC.Name = "botaoCC";
            this.botaoCC.Size = new System.Drawing.Size(93, 23);
            this.botaoCC.TabIndex = 2;
            this.botaoCC.Text = "Conta Corrente";
            this.botaoCC.UseVisualStyleBackColor = true;
            this.botaoCC.Click += new System.EventHandler(this.botaoCC_Click);
            // 
            // resumoBox
            // 
            this.resumoBox.Controls.Add(this.labelMaior);
            this.resumoBox.Controls.Add(this.labelSaldo);
            this.resumoBox.Controls.Add(this.labelMaiorSaldo);
            this.resumoBox.Controls.Add(this.labelsaldoTotal);
            this.resumoBox.Location = new System.Drawing.Point(13, 163);
            this.resumoBox.Name = "resumoBox";
            this.resumoBox.Size = new System.Drawing.Size(259, 67);
            this.resumoBox.TabIndex = 3;
            this.resumoBox.TabStop = false;
            this.resumoBox.Text = "Resumo";
            // 
            // labelsaldoTotal
            // 
            this.labelsaldoTotal.AutoSize = true;
            this.labelsaldoTotal.Location = new System.Drawing.Point(7, 20);
            this.labelsaldoTotal.Name = "labelsaldoTotal";
            this.labelsaldoTotal.Size = new System.Drawing.Size(61, 13);
            this.labelsaldoTotal.TabIndex = 0;
            this.labelsaldoTotal.Text = "Saldo Total";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(7, 41);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(63, 13);
            this.labelMaiorSaldo.TabIndex = 1;
            this.labelMaiorSaldo.Text = "Maior Saldo";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(180, 20);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(0, 13);
            this.labelSaldo.TabIndex = 2;
            // 
            // labelMaior
            // 
            this.labelMaior.AutoSize = true;
            this.labelMaior.Location = new System.Drawing.Point(180, 41);
            this.labelMaior.Name = "labelMaior";
            this.labelMaior.Size = new System.Drawing.Size(0, 13);
            this.labelMaior.TabIndex = 3;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 268);
            this.Controls.Add(this.resumoBox);
            this.Controls.Add(this.botaoCC);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.resumoBox.ResumeLayout(false);
            this.resumoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoCC;
        private System.Windows.Forms.GroupBox resumoBox;
        private System.Windows.Forms.Label labelMaior;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelsaldoTotal;
    }
}