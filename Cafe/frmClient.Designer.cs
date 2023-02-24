using System.ComponentModel;

namespace Cafe
{
    partial class FrmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._btnNew = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtAddr = new System.Windows.Forms.TextBox();
            this._txtLName = new System.Windows.Forms.TextBox();
            this._txtPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 512);
            this.dataGridView1.TabIndex = 0;
            // 
            // _btnNew
            // 
            this._btnNew.Location = new System.Drawing.Point(12, 351);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(250, 40);
            this._btnNew.TabIndex = 1;
            this._btnNew.Text = "Новый";
            this._btnNew.UseVisualStyleBackColor = true;
            this._btnNew.Click += new System.EventHandler(this._btnNew_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(12, 397);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(250, 41);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(12, 444);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(250, 38);
            this._btnDelete.TabIndex = 3;
            this._btnDelete.Text = "Удалить";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(12, 52);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(250, 22);
            this._txtName.TabIndex = 9;
            // 
            // _txtAddr
            // 
            this._txtAddr.Location = new System.Drawing.Point(12, 242);
            this._txtAddr.Name = "_txtAddr";
            this._txtAddr.Size = new System.Drawing.Size(250, 22);
            this._txtAddr.TabIndex = 11;
            // 
            // _txtLName
            // 
            this._txtLName.Location = new System.Drawing.Point(12, 112);
            this._txtLName.Name = "_txtLName";
            this._txtLName.Size = new System.Drawing.Size(250, 22);
            this._txtLName.TabIndex = 13;
            // 
            // _txtPhone
            // 
            this._txtPhone.Location = new System.Drawing.Point(12, 176);
            this._txtPhone.Mask = "00-000-00-00";
            this._txtPhone.Name = "_txtPhone";
            this._txtPhone.Size = new System.Drawing.Size(250, 22);
            this._txtPhone.TabIndex = 14;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 536);
            this.Controls.Add(this._txtPhone);
            this.Controls.Add(this._txtLName);
            this.Controls.Add(this._txtAddr);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmClient";
            this.Text = "frmClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MaskedTextBox _txtPhone;

        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtAddr;
        private System.Windows.Forms.TextBox _txtLName;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button _btnNew;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnDelete;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}