using System.ComponentModel;

namespace Cafe
{
    partial class FrmCashOutBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtUSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTJS = new System.Windows.Forms.TextBox();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnNew = new System.Windows.Forms.Button();
            this._cbStorage = new System.Windows.Forms.ComboBox();
            this._cbExpense = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Склад";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Валюта в долларах";
            // 
            // _txtUSD
            // 
            this._txtUSD.Location = new System.Drawing.Point(12, 118);
            this._txtUSD.Name = "_txtUSD";
            this._txtUSD.Size = new System.Drawing.Size(218, 22);
            this._txtUSD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Валюта в сомони";
            // 
            // _txtTJS
            // 
            this._txtTJS.Location = new System.Drawing.Point(12, 197);
            this._txtTJS.Name = "_txtTJS";
            this._txtTJS.Size = new System.Drawing.Size(218, 22);
            this._txtTJS.TabIndex = 6;
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(12, 465);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(218, 38);
            this._btnDelete.TabIndex = 9;
            this._btnDelete.Text = "Удалить";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click_1);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(12, 418);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(218, 41);
            this._btnSave.TabIndex = 8;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click_1);
            // 
            // _btnNew
            // 
            this._btnNew.Location = new System.Drawing.Point(12, 372);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(218, 40);
            this._btnNew.TabIndex = 7;
            this._btnNew.Text = "Новый";
            this._btnNew.UseVisualStyleBackColor = true;
            this._btnNew.Click += new System.EventHandler(this._btnNew_Click_1);
            // 
            // _cbStorage
            // 
            this._cbStorage.FormattingEnabled = true;
            this._cbStorage.Location = new System.Drawing.Point(12, 42);
            this._cbStorage.Name = "_cbStorage";
            this._cbStorage.Size = new System.Drawing.Size(218, 24);
            this._cbStorage.TabIndex = 10;
            // 
            // _cbExpense
            // 
            this._cbExpense.FormattingEnabled = true;
            this._cbExpense.Location = new System.Drawing.Point(12, 292);
            this._cbExpense.Name = "_cbExpense";
            this._cbExpense.Size = new System.Drawing.Size(218, 24);
            this._cbExpense.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Expense";
            // 
            // FrmCashOutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbExpense);
            this.Controls.Add(this._cbStorage);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnNew);
            this.Controls.Add(this._txtTJS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtUSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCashOutBox";
            this.Text = "frmCashInBox";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ComboBox _cbExpense;

        private System.Windows.Forms.ComboBox _cbStorage;

        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnNew;

        private System.Windows.Forms.TextBox _txtTJS;

        private System.Windows.Forms.TextBox _txtUSD;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}