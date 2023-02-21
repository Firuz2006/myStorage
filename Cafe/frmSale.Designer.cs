using System.ComponentModel;

namespace Cafe
{
    partial class frmSale
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
            this._cbStorage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this._cbFirm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtTJS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtUSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cbProduct = new System.Windows.Forms.ComboBox();
            this._isPayed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // _btnNew
            // 
            this._btnNew.Location = new System.Drawing.Point(12, 495);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(248, 35);
            this._btnNew.TabIndex = 1;
            this._btnNew.Text = "Новый";
            this._btnNew.UseVisualStyleBackColor = true;
            this._btnNew.Click += new System.EventHandler(this._btnNew_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(12, 536);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(248, 35);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(12, 577);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(248, 35);
            this._btnDelete.TabIndex = 3;
            this._btnDelete.Text = "Удалить";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _cbStorage
            // 
            this._cbStorage.FormattingEnabled = true;
            this._cbStorage.Location = new System.Drawing.Point(12, 424);
            this._cbStorage.Name = "_cbStorage";
            this._cbStorage.Size = new System.Drawing.Size(248, 24);
            this._cbStorage.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Склад";
            // 
            // _cbFirm
            // 
            this._cbFirm.FormattingEnabled = true;
            this._cbFirm.Location = new System.Drawing.Point(12, 359);
            this._cbFirm.Name = "_cbFirm";
            this._cbFirm.Size = new System.Drawing.Size(250, 24);
            this._cbFirm.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Фирма";
            // 
            // _txtTJS
            // 
            this._txtTJS.Location = new System.Drawing.Point(12, 219);
            this._txtTJS.Name = "_txtTJS";
            this._txtTJS.Size = new System.Drawing.Size(248, 22);
            this._txtTJS.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Цена в сомони(TJS)";
            // 
            // _txtUSD
            // 
            this._txtUSD.Location = new System.Drawing.Point(12, 160);
            this._txtUSD.Name = "_txtUSD";
            this._txtUSD.Size = new System.Drawing.Size(248, 22);
            this._txtUSD.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Цена в долларах(USD)";
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(12, 98);
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(248, 22);
            this._txtQuantity.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Продукт";
            // 
            // _cbProduct
            // 
            this._cbProduct.FormattingEnabled = true;
            this._cbProduct.Location = new System.Drawing.Point(12, 35);
            this._cbProduct.Name = "_cbProduct";
            this._cbProduct.Size = new System.Drawing.Size(248, 24);
            this._cbProduct.TabIndex = 20;
            // 
            // _isPayed
            // 
            this._isPayed.Location = new System.Drawing.Point(12, 454);
            this._isPayed.Name = "_isPayed";
            this._isPayed.Size = new System.Drawing.Size(104, 24);
            this._isPayed.TabIndex = 34;
            this._isPayed.Text = "Оплачено";
            this._isPayed.UseVisualStyleBackColor = true;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 625);
            this.Controls.Add(this._isPayed);
            this.Controls.Add(this._cbStorage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._cbFirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtTJS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtUSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbProduct);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSale";
            this.Text = "frmSale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox _isPayed;

        private System.Windows.Forms.ComboBox _cbStorage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cbFirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtTJS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtUSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbProduct;

        private System.Windows.Forms.Button _btnNew;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnDelete;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}