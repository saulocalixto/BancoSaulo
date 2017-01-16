namespace BancoSaulo
{
    partial class Banco
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.titular = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.depositar = new System.Windows.Forms.Button();
            this.sacar = new System.Windows.Forms.Button();
            this.contaCliente = new System.Windows.Forms.GroupBox();
            this.transferir = new System.Windows.Forms.Button();
            this.transferenciabox = new System.Windows.Forms.ComboBox();
            this.labeltransferencia = new System.Windows.Forms.Label();
            this.groupBuscarConta = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.LabelEscolha = new System.Windows.Forms.Label();
            this.novaContaBotao = new System.Windows.Forms.Button();
            this.contaCliente.SuspendLayout();
            this.groupBuscarConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(97, 33);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(97, 59);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(97, 85);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // titular
            // 
            this.titular.AutoSize = true;
            this.titular.Location = new System.Drawing.Point(6, 40);
            this.titular.Name = "titular";
            this.titular.Size = new System.Drawing.Size(36, 13);
            this.titular.TabIndex = 3;
            this.titular.Text = "Titular";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(6, 66);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(44, 13);
            this.numero.TabIndex = 4;
            this.numero.Text = "Numero";
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(6, 92);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(34, 13);
            this.saldo.TabIndex = 5;
            this.saldo.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(97, 139);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 7;
            // 
            // depositar
            // 
            this.depositar.Location = new System.Drawing.Point(6, 198);
            this.depositar.Name = "depositar";
            this.depositar.Size = new System.Drawing.Size(75, 23);
            this.depositar.TabIndex = 8;
            this.depositar.Text = "Depositar";
            this.depositar.UseVisualStyleBackColor = true;
            this.depositar.Click += new System.EventHandler(this.depositar_Click);
            // 
            // sacar
            // 
            this.sacar.Location = new System.Drawing.Point(210, 198);
            this.sacar.Name = "sacar";
            this.sacar.Size = new System.Drawing.Size(75, 23);
            this.sacar.TabIndex = 9;
            this.sacar.Text = "Sacar";
            this.sacar.UseVisualStyleBackColor = true;
            this.sacar.Click += new System.EventHandler(this.sacar_Click);
            // 
            // contaCliente
            // 
            this.contaCliente.Controls.Add(this.transferir);
            this.contaCliente.Controls.Add(this.transferenciabox);
            this.contaCliente.Controls.Add(this.labeltransferencia);
            this.contaCliente.Controls.Add(this.sacar);
            this.contaCliente.Controls.Add(this.titular);
            this.contaCliente.Controls.Add(this.depositar);
            this.contaCliente.Controls.Add(this.textoTitular);
            this.contaCliente.Controls.Add(this.label1);
            this.contaCliente.Controls.Add(this.textoValor);
            this.contaCliente.Controls.Add(this.saldo);
            this.contaCliente.Controls.Add(this.numero);
            this.contaCliente.Controls.Add(this.textoNumero);
            this.contaCliente.Controls.Add(this.textoSaldo);
            this.contaCliente.Location = new System.Drawing.Point(12, 109);
            this.contaCliente.Name = "contaCliente";
            this.contaCliente.Size = new System.Drawing.Size(291, 243);
            this.contaCliente.TabIndex = 10;
            this.contaCliente.TabStop = false;
            this.contaCliente.Text = "Conta";
            // 
            // transferir
            // 
            this.transferir.Location = new System.Drawing.Point(97, 198);
            this.transferir.Name = "transferir";
            this.transferir.Size = new System.Drawing.Size(100, 23);
            this.transferir.TabIndex = 12;
            this.transferir.Text = "Transferência";
            this.transferir.UseVisualStyleBackColor = true;
            this.transferir.Click += new System.EventHandler(this.transferir_Click);
            // 
            // transferenciabox
            // 
            this.transferenciabox.FormattingEnabled = true;
            this.transferenciabox.Location = new System.Drawing.Point(97, 112);
            this.transferenciabox.Name = "transferenciabox";
            this.transferenciabox.Size = new System.Drawing.Size(100, 21);
            this.transferenciabox.TabIndex = 11;
            this.transferenciabox.SelectedIndexChanged += new System.EventHandler(this.transferenciabox_SelectedIndexChanged);
            // 
            // labeltransferencia
            // 
            this.labeltransferencia.AutoSize = true;
            this.labeltransferencia.Location = new System.Drawing.Point(6, 120);
            this.labeltransferencia.Name = "labeltransferencia";
            this.labeltransferencia.Size = new System.Drawing.Size(72, 13);
            this.labeltransferencia.TabIndex = 10;
            this.labeltransferencia.Text = "Transferência";
            // 
            // groupBuscarConta
            // 
            this.groupBuscarConta.Controls.Add(this.novaContaBotao);
            this.groupBuscarConta.Controls.Add(this.comboContas);
            this.groupBuscarConta.Controls.Add(this.LabelEscolha);
            this.groupBuscarConta.Location = new System.Drawing.Point(12, 13);
            this.groupBuscarConta.Name = "groupBuscarConta";
            this.groupBuscarConta.Size = new System.Drawing.Size(291, 87);
            this.groupBuscarConta.TabIndex = 11;
            this.groupBuscarConta.TabStop = false;
            this.groupBuscarConta.Text = "Buscar Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(97, 27);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(170, 21);
            this.comboContas.TabIndex = 3;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // LabelEscolha
            // 
            this.LabelEscolha.AutoSize = true;
            this.LabelEscolha.Location = new System.Drawing.Point(6, 30);
            this.LabelEscolha.Name = "LabelEscolha";
            this.LabelEscolha.Size = new System.Drawing.Size(85, 13);
            this.LabelEscolha.TabIndex = 0;
            this.LabelEscolha.Text = "Escolha a Conta";
            // 
            // novaContaBotao
            // 
            this.novaContaBotao.Location = new System.Drawing.Point(9, 54);
            this.novaContaBotao.Name = "novaContaBotao";
            this.novaContaBotao.Size = new System.Drawing.Size(75, 23);
            this.novaContaBotao.TabIndex = 13;
            this.novaContaBotao.Text = "Nova Conta";
            this.novaContaBotao.UseVisualStyleBackColor = true;
            this.novaContaBotao.Click += new System.EventHandler(this.novaContaBotao_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 362);
            this.Controls.Add(this.groupBuscarConta);
            this.Controls.Add(this.contaCliente);
            this.Name = "Banco";
            this.Text = "Banco do Saulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contaCliente.ResumeLayout(false);
            this.contaCliente.PerformLayout();
            this.groupBuscarConta.ResumeLayout(false);
            this.groupBuscarConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label titular;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button depositar;
        private System.Windows.Forms.Button sacar;
        private System.Windows.Forms.GroupBox contaCliente;
        private System.Windows.Forms.GroupBox groupBuscarConta;
        private System.Windows.Forms.Label LabelEscolha;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button transferir;
        private System.Windows.Forms.ComboBox transferenciabox;
        private System.Windows.Forms.Label labeltransferencia;
        private System.Windows.Forms.Button novaContaBotao;
    }
}

