using System.ComponentModel;

namespace Cafe
{
    partial class frmInvoice
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
            this.id = new System.Windows.Forms.TextBox();
            this._cbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtUSD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtTJS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtSale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._cbFirm = new System.Windows.Forms.ComboBox();
            this._isPayed = new System.Windows.Forms.CheckBox();
            this._btnNew = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._cbStorage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1644, 683);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(217, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(107, 22);
            this.id.TabIndex = 1;
            // 
            // _cbProduct
            // 
            this._cbProduct.FormattingEnabled = true;
            this._cbProduct.Location = new System.Drawing.Point(32, 42);
            this._cbProduct.Name = "_cbProduct";
            this._cbProduct.Size = new System.Drawing.Size(292, 24);
            this._cbProduct.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Продукт";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(32, 105);
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(292, 22);
            this._txtQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена в долларах(USD)";
            // 
            // _txtUSD
            // 
            this._txtUSD.Location = new System.Drawing.Point(32, 178);
            this._txtUSD.Name = "_txtUSD";
            this._txtUSD.Size = new System.Drawing.Size(292, 22);
            this._txtUSD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена в сомони(TJS)";
            // 
            // _txtTJS
            // 
            this._txtTJS.Location = new System.Drawing.Point(32, 253);
            this._txtTJS.Name = "_txtTJS";
            this._txtTJS.Size = new System.Drawing.Size(292, 22);
            this._txtTJS.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Продажная цена";
            // 
            // _txtSale
            // 
            this._txtSale.Location = new System.Drawing.Point(32, 331);
            this._txtSale.Name = "_txtSale";
            this._txtSale.Size = new System.Drawing.Size(292, 22);
            this._txtSale.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Фирма";
            // 
            // _cbFirm
            // 
            this._cbFirm.FormattingEnabled = true;
            this._cbFirm.Location = new System.Drawing.Point(32, 396);
            this._cbFirm.Name = "_cbFirm";
            this._cbFirm.Size = new System.Drawing.Size(294, 24);
            this._cbFirm.TabIndex = 13;
            // 
            // _isPayed
            // 
            this._isPayed.Location = new System.Drawing.Point(32, 509);
            this._isPayed.Name = "_isPayed";
            this._isPayed.Size = new System.Drawing.Size(292, 24);
            this._isPayed.TabIndex = 14;
            this._isPayed.Text = "Оплачено";
            this._isPayed.UseVisualStyleBackColor = true;
            // 
            // _btnNew
            // 
            this._btnNew.Location = new System.Drawing.Point(32, 539);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(292, 48);
            this._btnNew.TabIndex = 15;
            this._btnNew.Text = "Новый";
            this._btnNew.UseVisualStyleBackColor = true;
            this._btnNew.Click += new System.EventHandler(this._btnNew_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(32, 593);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(292, 48);
            this._btnSave.TabIndex = 16;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(32, 647);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(292, 48);
            this._btnDelete.TabIndex = 17;
            this._btnDelete.Text = "Удалить";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(32, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Склад";
            // 
            // _cbStorage
            // 
            this._cbStorage.FormattingEnabled = true;
            this._cbStorage.Location = new System.Drawing.Point(32, 472);
            this._cbStorage.Name = "_cbStorage";
            this._cbStorage.Size = new System.Drawing.Size(292, 24);
            this._cbStorage.TabIndex = 19;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 711);
            this.Controls.Add(this._cbStorage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnNew);
            this.Controls.Add(this._isPayed);
            this.Controls.Add(this._cbFirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtTJS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtUSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbProduct);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cbStorage;

        private System.Windows.Forms.CheckBox _isPayed;
        private System.Windows.Forms.Button _btnNew;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnDelete;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _cbFirm;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtSale;

        private System.Windows.Forms.TextBox _txtUSD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtTJS;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtQuantity;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox _cbProduct;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox id;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}