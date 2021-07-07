
namespace ForEachArray
{
    partial class frmTurismo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisitar = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblLocais = new System.Windows.Forms.Label();
            this.lbLocais = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "5 lugares que gostaria de visitar";
            // 
            // txtVisitar
            // 
            this.txtVisitar.Location = new System.Drawing.Point(13, 54);
            this.txtVisitar.Name = "txtVisitar";
            this.txtVisitar.Size = new System.Drawing.Size(245, 23);
            this.txtVisitar.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(13, 113);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(245, 43);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar a lista";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 181);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(245, 43);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar a lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblLocais
            // 
            this.lblLocais.AutoSize = true;
            this.lblLocais.Location = new System.Drawing.Point(340, 13);
            this.lblLocais.Name = "lblLocais";
            this.lblLocais.Size = new System.Drawing.Size(142, 15);
            this.lblLocais.TabIndex = 4;
            this.lblLocais.Text = "Lista dos locais preferidos";
            // 
            // lbLocais
            // 
            this.lbLocais.FormattingEnabled = true;
            this.lbLocais.ItemHeight = 15;
            this.lbLocais.Location = new System.Drawing.Point(340, 54);
            this.lbLocais.Name = "lbLocais";
            this.lbLocais.Size = new System.Drawing.Size(448, 274);
            this.lbLocais.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(340, 358);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(448, 40);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar a lista";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(13, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(245, 40);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTurismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lbLocais);
            this.Controls.Add(this.lblLocais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtVisitar);
            this.Controls.Add(this.label1);
            this.Name = "frmTurismo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisitar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLocais;
        private System.Windows.Forms.ListBox lbLocais;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
    }
}

