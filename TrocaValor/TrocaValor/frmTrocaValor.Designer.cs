
namespace TrocaValor
{
    partial class frmTrocaValor
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
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btn_Trocar = new System.Windows.Forms.Button();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_valor1
            // 
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor1.Location = new System.Drawing.Point(13, 21);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(55, 19);
            this.lbl_valor1.TabIndex = 0;
            this.lbl_valor1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(74, 17);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(244, 23);
            this.txtValor1.TabIndex = 1;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.Location = new System.Drawing.Point(13, 76);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(55, 19);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Valor 2:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(75, 76);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(243, 23);
            this.txtValor2.TabIndex = 2;
            // 
            // btn_Trocar
            // 
            this.btn_Trocar.Location = new System.Drawing.Point(218, 191);
            this.btn_Trocar.Name = "btn_Trocar";
            this.btn_Trocar.Size = new System.Drawing.Size(100, 23);
            this.btn_Trocar.TabIndex = 4;
            this.btn_Trocar.Text = "Trocar Valor";
            this.btn_Trocar.UseVisualStyleBackColor = true;
            this.btn_Trocar.Click += new System.EventHandler(this.btn_Trocar_Click);
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor3.Location = new System.Drawing.Point(13, 142);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(55, 19);
            this.lblValor3.TabIndex = 5;
            this.lblValor3.Text = "Valor 3:";
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(74, 137);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(244, 23);
            this.txtValor3.TabIndex = 3;
            // 
            // frmTrocaValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 226);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.btn_Trocar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lbl_valor1);
            this.Name = "frmTrocaValor";
            this.Text = "Troca de valor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btn_Trocar;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.TextBox txtValor3;
    }
}

