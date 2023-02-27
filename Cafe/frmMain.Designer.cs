using System.ComponentModel;

namespace Cafe
{
    partial class FrmMain
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
            this._btnClient = new System.Windows.Forms.Button();
            this._btnStorage = new System.Windows.Forms.Button();
            this._btnProduct = new System.Windows.Forms.Button();
            this._bntUnit = new System.Windows.Forms.Button();
            this._btnSale = new System.Windows.Forms.Button();
            this._btnFirm = new System.Windows.Forms.Button();
            this._btnRate = new System.Windows.Forms.Button();
            this._btnCashIn = new System.Windows.Forms.Button();
            this._btnCashOut = new System.Windows.Forms.Button();
            this._btnCategory = new System.Windows.Forms.Button();
            this._btnInvoice = new System.Windows.Forms.Button();
            this.Income = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnClient
            // 
            this._btnClient.Location = new System.Drawing.Point(12, 12);
            this._btnClient.Name = "_btnClient";
            this._btnClient.Size = new System.Drawing.Size(146, 43);
            this._btnClient.TabIndex = 0;
            this._btnClient.Text = "Клиенты";
            this._btnClient.UseVisualStyleBackColor = true;
            this._btnClient.Click += new System.EventHandler(this._btnClient_Click);
            // 
            // _btnStorage
            // 
            this._btnStorage.Location = new System.Drawing.Point(12, 61);
            this._btnStorage.Name = "_btnStorage";
            this._btnStorage.Size = new System.Drawing.Size(146, 43);
            this._btnStorage.TabIndex = 1;
            this._btnStorage.Text = "Склад";
            this._btnStorage.UseVisualStyleBackColor = true;
            this._btnStorage.Click += new System.EventHandler(this._btnStorage_Click);
            // 
            // _btnProduct
            // 
            this._btnProduct.Location = new System.Drawing.Point(12, 110);
            this._btnProduct.Name = "_btnProduct";
            this._btnProduct.Size = new System.Drawing.Size(146, 47);
            this._btnProduct.TabIndex = 3;
            this._btnProduct.Text = "Продукт";
            this._btnProduct.UseVisualStyleBackColor = true;
            this._btnProduct.Click += new System.EventHandler(this._btnProduct_Click);
            // 
            // _bntUnit
            // 
            this._bntUnit.Location = new System.Drawing.Point(12, 163);
            this._bntUnit.Name = "_bntUnit";
            this._bntUnit.Size = new System.Drawing.Size(146, 43);
            this._bntUnit.TabIndex = 2;
            this._bntUnit.Text = "Ед. Измерения";
            this._bntUnit.UseVisualStyleBackColor = true;
            this._bntUnit.Click += new System.EventHandler(this._bntUnit_Click);
            // 
            // _btnSale
            // 
            this._btnSale.Location = new System.Drawing.Point(12, 212);
            this._btnSale.Name = "_btnSale";
            this._btnSale.Size = new System.Drawing.Size(146, 43);
            this._btnSale.TabIndex = 5;
            this._btnSale.Text = "Продажа";
            this._btnSale.UseVisualStyleBackColor = true;
            this._btnSale.Click += new System.EventHandler(this._btnSale_Click);
            // 
            // _btnFirm
            // 
            this._btnFirm.Location = new System.Drawing.Point(12, 261);
            this._btnFirm.Name = "_btnFirm";
            this._btnFirm.Size = new System.Drawing.Size(146, 43);
            this._btnFirm.TabIndex = 4;
            this._btnFirm.Text = "Фирма";
            this._btnFirm.UseVisualStyleBackColor = true;
            this._btnFirm.Click += new System.EventHandler(this._btnFirm_Click);
            // 
            // _btnRate
            // 
            this._btnRate.Location = new System.Drawing.Point(316, 114);
            this._btnRate.Name = "_btnRate";
            this._btnRate.Size = new System.Drawing.Size(146, 43);
            this._btnRate.TabIndex = 11;
            this._btnRate.Text = "Валюта";
            this._btnRate.UseVisualStyleBackColor = true;
            this._btnRate.Click += new System.EventHandler(this._btnRate_Click);
            // 
            // _btnCashIn
            // 
            this._btnCashIn.Location = new System.Drawing.Point(164, 110);
            this._btnCashIn.Name = "_btnCashIn";
            this._btnCashIn.Size = new System.Drawing.Size(146, 47);
            this._btnCashIn.TabIndex = 9;
            this._btnCashIn.UseVisualStyleBackColor = true;
            this._btnCashIn.Click += new System.EventHandler(this._btnCashIn_Click);
            // 
            // _btnCashOut
            // 
            this._btnCashOut.Location = new System.Drawing.Point(164, 163);
            this._btnCashOut.Name = "_btnCashOut";
            this._btnCashOut.Size = new System.Drawing.Size(146, 43);
            this._btnCashOut.TabIndex = 8;
            this._btnCashOut.Text = "Расход";
            this._btnCashOut.UseVisualStyleBackColor = true;
            this._btnCashOut.Click += new System.EventHandler(this._btnCashOut_Click);
            // 
            // _btnCategory
            // 
            this._btnCategory.Location = new System.Drawing.Point(164, 61);
            this._btnCategory.Name = "_btnCategory";
            this._btnCategory.Size = new System.Drawing.Size(146, 43);
            this._btnCategory.TabIndex = 7;
            this._btnCategory.Text = "Категория";
            this._btnCategory.UseVisualStyleBackColor = true;
            this._btnCategory.Click += new System.EventHandler(this._btnCategory_Click);
            // 
            // _btnInvoice
            // 
            this._btnInvoice.Location = new System.Drawing.Point(164, 12);
            this._btnInvoice.Name = "_btnInvoice";
            this._btnInvoice.Size = new System.Drawing.Size(146, 43);
            this._btnInvoice.TabIndex = 6;
            this._btnInvoice.Text = "Накладные";
            this._btnInvoice.UseVisualStyleBackColor = true;
            this._btnInvoice.Click += new System.EventHandler(this._btnInvoice_Click);
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(316, 10);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(146, 47);
            this.Income.TabIndex = 12;
            this.Income.Text = "Доход";
            this.Income.UseVisualStyleBackColor = true;
            this.Income.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Расход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _btnReport
            // 
            this._btnReport.Location = new System.Drawing.Point(635, 10);
            this._btnReport.Name = "_btnReport";
            this._btnReport.Size = new System.Drawing.Size(153, 45);
            this._btnReport.TabIndex = 14;
            this._btnReport.Text = "Отчёт";
            this._btnReport.UseVisualStyleBackColor = true;
            this._btnReport.Click += new System.EventHandler(this._btnReport_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnReport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Income);
            this.Controls.Add(this._btnRate);
            this.Controls.Add(this._btnCashIn);
            this.Controls.Add(this._btnCashOut);
            this.Controls.Add(this._btnCategory);
            this.Controls.Add(this._btnInvoice);
            this.Controls.Add(this._btnSale);
            this.Controls.Add(this._btnFirm);
            this.Controls.Add(this._btnProduct);
            this.Controls.Add(this._bntUnit);
            this.Controls.Add(this._btnStorage);
            this.Controls.Add(this._btnClient);
            this.Name = "FrmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _btnReport;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button Income;

        private System.Windows.Forms.Button _btnClient;
        private System.Windows.Forms.Button _btnStorage;
        private System.Windows.Forms.Button _btnProduct;
        private System.Windows.Forms.Button _bntUnit;
        private System.Windows.Forms.Button _btnSale;
        private System.Windows.Forms.Button _btnFirm;
        private System.Windows.Forms.Button _btnRate;
        private System.Windows.Forms.Button _btnCashIn;
        private System.Windows.Forms.Button _btnCashOut;
        private System.Windows.Forms.Button _btnCategory;
        private System.Windows.Forms.Button _btnInvoice;

        #endregion
    }
}