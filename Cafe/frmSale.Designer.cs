using System.ComponentModel;

namespace Cafe
{
    sealed partial class FrmSale
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtUSD = new System.Windows.Forms.TextBox();
            this._txtTJS = new System.Windows.Forms.TextBox();
            this._txtSale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._lbIsPayed = new System.Windows.Forms.Label();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._txtQuantityHas = new System.Windows.Forms.NumericUpDown();
            this._txtQuantitySale = new System.Windows.Forms.NumericUpDown();
            this._cbClient = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtQuantityHas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtQuantitySale)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 244);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(418, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(375, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имеется";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(375, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Продать";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(648, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Финансы";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(592, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Валюта USD";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(592, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Валюта TJS";
            // 
            // _txtUSD
            // 
            this._txtUSD.Location = new System.Drawing.Point(721, 31);
            this._txtUSD.Name = "_txtUSD";
            this._txtUSD.Size = new System.Drawing.Size(100, 22);
            this._txtUSD.TabIndex = 10;
            // 
            // _txtTJS
            // 
            this._txtTJS.Location = new System.Drawing.Point(721, 60);
            this._txtTJS.Name = "_txtTJS";
            this._txtTJS.Size = new System.Drawing.Size(100, 22);
            this._txtTJS.TabIndex = 11;
            // 
            // _txtSale
            // 
            this._txtSale.Location = new System.Drawing.Point(721, 88);
            this._txtSale.Name = "_txtSale";
            this._txtSale.Size = new System.Drawing.Size(100, 22);
            this._txtSale.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(592, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Продажная цена";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(592, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Оплачено?";
            // 
            // _lbIsPayed
            // 
            this._lbIsPayed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._lbIsPayed.Location = new System.Drawing.Point(721, 115);
            this._lbIsPayed.Name = "_lbIsPayed";
            this._lbIsPayed.Size = new System.Drawing.Size(100, 23);
            this._lbIsPayed.TabIndex = 15;
            this._lbIsPayed.Text = "Нет";
            // 
            // _btnSubmit
            // 
            this._btnSubmit.Location = new System.Drawing.Point(382, 233);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(111, 23);
            this._btnSubmit.TabIndex = 16;
            this._btnSubmit.Text = "Продать";
            this._btnSubmit.UseVisualStyleBackColor = true;
            this._btnSubmit.Click += new System.EventHandler(this._btnSubmit_Click);
            // 
            // _txtQuantityHas
            // 
            this._txtQuantityHas.Location = new System.Drawing.Point(441, 32);
            this._txtQuantityHas.Name = "_txtQuantityHas";
            this._txtQuantityHas.Size = new System.Drawing.Size(120, 22);
            this._txtQuantityHas.TabIndex = 17;
            // 
            // _txtQuantitySale
            // 
            this._txtQuantitySale.Location = new System.Drawing.Point(441, 65);
            this._txtQuantitySale.Name = "_txtQuantitySale";
            this._txtQuantitySale.Size = new System.Drawing.Size(120, 22);
            this._txtQuantitySale.TabIndex = 18;
            // 
            // _cbClient
            // 
            this._cbClient.FormattingEnabled = true;
            this._cbClient.Location = new System.Drawing.Point(921, 28);
            this._cbClient.Name = "_cbClient";
            this._cbClient.Size = new System.Drawing.Size(121, 24);
            this._cbClient.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(882, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Клиенты";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(856, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Клиенты";
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 625);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._cbClient);
            this.Controls.Add(this._txtQuantitySale);
            this.Controls.Add(this._txtQuantityHas);
            this.Controls.Add(this._btnSubmit);
            this.Controls.Add(this._lbIsPayed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._txtSale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtTJS);
            this.Controls.Add(this._txtUSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FrmSale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtQuantityHas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtQuantitySale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox _cbClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.NumericUpDown _txtQuantityHas;
        private System.Windows.Forms.NumericUpDown _txtQuantitySale;

        private System.Windows.Forms.TextBox _txtSale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _lbIsPayed;
        private System.Windows.Forms.Button _btnSubmit;

        private System.Windows.Forms.TextBox _txtTJS;

        private System.Windows.Forms.TextBox _txtUSD;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}