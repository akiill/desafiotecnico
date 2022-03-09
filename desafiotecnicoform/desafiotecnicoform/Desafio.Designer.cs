
namespace desafiotecnicoform
{
    partial class Desafio
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDivisores = new System.Windows.Forms.TextBox();
            this.txtPrimos = new System.Windows.Forms.TextBox();
            this.lblPrimos = new System.Windows.Forms.Label();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAguarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(119, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite um número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(29, 47);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(200, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Números divisores";
            // 
            // txtDivisores
            // 
            this.txtDivisores.Enabled = false;
            this.txtDivisores.Location = new System.Drawing.Point(29, 105);
            this.txtDivisores.Multiline = true;
            this.txtDivisores.Name = "txtDivisores";
            this.txtDivisores.Size = new System.Drawing.Size(705, 120);
            this.txtDivisores.TabIndex = 3;
            // 
            // txtPrimos
            // 
            this.txtPrimos.Enabled = false;
            this.txtPrimos.Location = new System.Drawing.Point(29, 256);
            this.txtPrimos.Name = "txtPrimos";
            this.txtPrimos.Size = new System.Drawing.Size(705, 22);
            this.txtPrimos.TabIndex = 5;
            // 
            // lblPrimos
            // 
            this.lblPrimos.AutoSize = true;
            this.lblPrimos.Location = new System.Drawing.Point(26, 236);
            this.lblPrimos.Name = "lblPrimos";
            this.lblPrimos.Size = new System.Drawing.Size(111, 17);
            this.lblPrimos.TabIndex = 4;
            this.lblPrimos.Text = "Números primos";
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(26, 335);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(61, 17);
            this.lblMsgErro.TabIndex = 6;
            this.lblMsgErro.Text = "msgErro";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(497, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(578, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(659, 297);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAguarde
            // 
            this.lblAguarde.AutoSize = true;
            this.lblAguarde.Location = new System.Drawing.Point(274, 303);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(150, 17);
            this.lblAguarde.TabIndex = 10;
            this.lblAguarde.Text = "Aguarde, calculando...";
            // 
            // Desafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 371);
            this.Controls.Add(this.lblAguarde);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.txtPrimos);
            this.Controls.Add(this.lblPrimos);
            this.Controls.Add(this.txtDivisores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Desafio";
            this.Text = "Desafio .Net";
            this.Load += new System.EventHandler(this.Desafio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDivisores;
        private System.Windows.Forms.TextBox txtPrimos;
        private System.Windows.Forms.Label lblPrimos;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAguarde;
    }
}

