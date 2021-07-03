
namespace VetorUni
{
    partial class frmVetor
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
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pgbPreenche = new System.Windows.Forms.ProgressBar();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 15;
            this.lstLista.Location = new System.Drawing.Point(13, 13);
            this.lstLista.Name = "lstLista";
            this.lstLista.ScrollAlwaysVisible = true;
            this.lstLista.Size = new System.Drawing.Size(231, 379);
            this.lstLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o numero para somatorio";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(292, 98);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(292, 158);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(176, 37);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(292, 230);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(176, 37);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(292, 294);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 37);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pgbPreenche
            // 
            this.pgbPreenche.Location = new System.Drawing.Point(13, 415);
            this.pgbPreenche.Name = "pgbPreenche";
            this.pgbPreenche.Size = new System.Drawing.Size(455, 23);
            this.pgbPreenche.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(292, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 37);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pgbPreenche);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLista);
            this.Name = "frmVetor";
            this.Text = "Exemplo de Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ProgressBar pgbPreenche;
        private System.Windows.Forms.Button btnSair;
    }
}

