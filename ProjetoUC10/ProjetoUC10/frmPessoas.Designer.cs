
namespace ProjetoUC10
{
    partial class frmPessoas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoas));
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.lblPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersons
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersons.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersons.EnableHeadersVisualStyles = false;
            this.dgvPersons.Location = new System.Drawing.Point(12, 98);
            this.dgvPersons.Name = "dgvPersons";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersons.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersons.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersons.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dgvPersons.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersons.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPersons.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersons.RowTemplate.Height = 25;
            this.dgvPersons.Size = new System.Drawing.Size(1298, 740);
            this.dgvPersons.TabIndex = 0;
            this.dgvPersons.TabStop = false;
            this.dgvPersons.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersons_RowHeaderMouseClick);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(1392, 150);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(17, 15);
            this.lblPersonId.TabIndex = 1;
            this.lblPersonId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1392, 209);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(1392, 268);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Endereço";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(1392, 327);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 15);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Número";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(1392, 386);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(51, 15);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Telefone";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(1392, 445);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 15);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Cidade";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(1392, 504);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 15);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "Estado";
            // 
            // txtPersonId
            // 
            this.txtPersonId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPersonId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPersonId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPersonId.Location = new System.Drawing.Point(1492, 147);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.ReadOnly = true;
            this.txtPersonId.Size = new System.Drawing.Size(379, 23);
            this.txtPersonId.TabIndex = 8;
            this.txtPersonId.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Location = new System.Drawing.Point(1492, 205);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAddress.Location = new System.Drawing.Point(1492, 263);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(379, 23);
            this.txtAddress.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumber.Location = new System.Drawing.Point(1492, 321);
            this.txtNumber.Mask = "000000";
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(379, 23);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.ValidatingType = typeof(int);
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelephone.Location = new System.Drawing.Point(1492, 379);
            this.txtTelephone.Mask = "(99) 00000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(379, 23);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCity.Location = new System.Drawing.Point(1492, 437);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(379, 23);
            this.txtCity.TabIndex = 6;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtState.Location = new System.Drawing.Point(1492, 495);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(379, 23);
            this.txtState.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1392, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(1521, 602);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 49);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "ATUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1650, 602);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 49);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "APAGAR";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(1779, 602);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 49);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "LIMPAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchName.Location = new System.Drawing.Point(12, 62);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(129, 15);
            this.lblSearchName.TabIndex = 19;
            this.lblSearchName.Text = "PROCURE POR NOME:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchName.HideSelection = false;
            this.txtSearchName.Location = new System.Drawing.Point(147, 59);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(507, 23);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchClear.Location = new System.Drawing.Point(660, 46);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(155, 46);
            this.btnSearchClear.TabIndex = 1;
            this.btnSearchClear.Text = "LIMPAR BUSCA";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPerson.Location = new System.Drawing.Point(1492, 98);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(157, 21);
            this.lblPerson.TabIndex = 23;
            this.lblPerson.Text = "DADOS DA PESSOA";
            // 
            // frmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.dgvPersons);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPessoas";
            this.Text = "CADASTRO DE PESSOAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox txtNumber;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Label lblPerson;
    }
}

