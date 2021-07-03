
namespace IMC
{
    partial class CalculoPesoIdeal
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
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.gb_Sexo = new System.Windows.Forms.GroupBox();
            this.rbtn_Feminino = new System.Windows.Forms.RadioButton();
            this.rbtn_Masculino = new System.Windows.Forms.RadioButton();
            this.lbl_PesoIdeal = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.gb_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(23, 32);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(39, 15);
            this.lbl_Altura.TabIndex = 0;
            this.lbl_Altura.Text = "Altura";
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(23, 50);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(100, 23);
            this.txt_Altura.TabIndex = 1;
            // 
            // gb_Sexo
            // 
            this.gb_Sexo.Controls.Add(this.rbtn_Feminino);
            this.gb_Sexo.Controls.Add(this.rbtn_Masculino);
            this.gb_Sexo.Location = new System.Drawing.Point(211, 32);
            this.gb_Sexo.Name = "gb_Sexo";
            this.gb_Sexo.Size = new System.Drawing.Size(202, 57);
            this.gb_Sexo.TabIndex = 2;
            this.gb_Sexo.TabStop = false;
            this.gb_Sexo.Text = "Sexo";
            // 
            // rbtn_Feminino
            // 
            this.rbtn_Feminino.AutoSize = true;
            this.rbtn_Feminino.Location = new System.Drawing.Point(114, 21);
            this.rbtn_Feminino.Name = "rbtn_Feminino";
            this.rbtn_Feminino.Size = new System.Drawing.Size(75, 19);
            this.rbtn_Feminino.TabIndex = 1;
            this.rbtn_Feminino.TabStop = true;
            this.rbtn_Feminino.Text = "Feminino";
            this.rbtn_Feminino.UseVisualStyleBackColor = true;
            this.rbtn_Feminino.Click += new System.EventHandler(this.rbtn_Feminino_Click);
            // 
            // rbtn_Masculino
            // 
            this.rbtn_Masculino.AutoSize = true;
            this.rbtn_Masculino.Checked = true;
            this.rbtn_Masculino.Location = new System.Drawing.Point(7, 21);
            this.rbtn_Masculino.Name = "rbtn_Masculino";
            this.rbtn_Masculino.Size = new System.Drawing.Size(80, 19);
            this.rbtn_Masculino.TabIndex = 0;
            this.rbtn_Masculino.TabStop = true;
            this.rbtn_Masculino.Text = "Masculino";
            this.rbtn_Masculino.UseVisualStyleBackColor = true;
            this.rbtn_Masculino.Click += new System.EventHandler(this.rbtn_Masculino_Click);
            // 
            // lbl_PesoIdeal
            // 
            this.lbl_PesoIdeal.AutoSize = true;
            this.lbl_PesoIdeal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PesoIdeal.Location = new System.Drawing.Point(218, 162);
            this.lbl_PesoIdeal.Name = "lbl_PesoIdeal";
            this.lbl_PesoIdeal.Size = new System.Drawing.Size(70, 19);
            this.lbl_PesoIdeal.TabIndex = 3;
            this.lbl_PesoIdeal.Text = "Peso Ideal";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Peso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Peso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Peso.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Peso.Location = new System.Drawing.Point(218, 208);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(190, 40);
            this.lbl_Peso.TabIndex = 4;
            // 
            // CalculoPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.lbl_PesoIdeal);
            this.Controls.Add(this.gb_Sexo);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.lbl_Altura);
            this.Name = "CalculoPesoIdeal";
            this.Text = "Cálculo de Índice de Massa Corporea - IMC";
            this.gb_Sexo.ResumeLayout(false);
            this.gb_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.GroupBox gb_Sexo;
        private System.Windows.Forms.RadioButton rbtn_Feminino;
        private System.Windows.Forms.RadioButton rbtn_Masculino;
        private System.Windows.Forms.Label lbl_PesoIdeal;
        private System.Windows.Forms.Label lbl_Peso;
    }
}

