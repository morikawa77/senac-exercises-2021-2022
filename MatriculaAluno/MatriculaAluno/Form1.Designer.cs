
namespace MatriculaAluno
{
    partial class frmMatricula
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblHoje = new System.Windows.Forms.Label();
            this.lblIdadeAtual = new System.Windows.Forms.Label();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMostraCategoria = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(480, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Location = new System.Drawing.Point(13, 53);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(117, 15);
            this.lblAnoNasc.TabIndex = 0;
            this.lblAnoNasc.Text = "Data de Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(131, 49);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(105, 23);
            this.dtpNascimento.TabIndex = 2;
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Location = new System.Drawing.Point(267, 53);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(0, 15);
            this.lblHoje.TabIndex = 0;
            // 
            // lblIdadeAtual
            // 
            this.lblIdadeAtual.AutoSize = true;
            this.lblIdadeAtual.Location = new System.Drawing.Point(136, 97);
            this.lblIdadeAtual.Name = "lblIdadeAtual";
            this.lblIdadeAtual.Size = new System.Drawing.Size(0, 15);
            this.lblIdadeAtual.TabIndex = 5;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(13, 155);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(168, 37);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.Text = "Identificar Categoria";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(204, 166);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMostraCategoria
            // 
            this.lblMostraCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblMostraCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraCategoria.Location = new System.Drawing.Point(275, 153);
            this.lblMostraCategoria.Name = "lblMostraCategoria";
            this.lblMostraCategoria.Size = new System.Drawing.Size(233, 43);
            this.lblMostraCategoria.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(193, 220);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(159, 39);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 271);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMostraCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.lblIdadeAtual);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblAnoNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMatricula";
            this.Text = "Matricula do Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblHoje;
        private System.Windows.Forms.Label lblIdadeAtual;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMostraCategoria;
        private System.Windows.Forms.Button btnSair;
    }
}

