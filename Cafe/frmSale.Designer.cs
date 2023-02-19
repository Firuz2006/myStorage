namespace Cafe
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tCTable = new System.Windows.Forms.TabControl();
            this.pCategoryStat = new System.Windows.Forms.Panel();
            this.pCategory = new System.Windows.Forms.Panel();
            this.pStat = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProductTotalPrice = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pSale = new System.Windows.Forms.Panel();
            this.dgProductList = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumpad = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.bn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.pProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pCategoryStat.SuspendLayout();
            this.pStat.SuspendLayout();
            this.pSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).BeginInit();
            this.pNumpad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCTable
            // 
            this.tCTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tCTable.Location = new System.Drawing.Point(0, 401);
            this.tCTable.Name = "tCTable";
            this.tCTable.SelectedIndex = 0;
            this.tCTable.Size = new System.Drawing.Size(828, 100);
            this.tCTable.TabIndex = 0;
            // 
            // pCategoryStat
            // 
            this.pCategoryStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCategoryStat.Controls.Add(this.pCategory);
            this.pCategoryStat.Controls.Add(this.pStat);
            this.pCategoryStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCategoryStat.Location = new System.Drawing.Point(0, 0);
            this.pCategoryStat.Name = "pCategoryStat";
            this.pCategoryStat.Size = new System.Drawing.Size(828, 88);
            this.pCategoryStat.TabIndex = 1;
            // 
            // pCategory
            // 
            this.pCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCategory.Location = new System.Drawing.Point(273, 0);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(553, 86);
            this.pCategory.TabIndex = 1;
            // 
            // pStat
            // 
            this.pStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStat.Controls.Add(this.btnRefresh);
            this.pStat.Controls.Add(this.btnDelete);
            this.pStat.Controls.Add(this.lblProductTotalPrice);
            this.pStat.Controls.Add(this.lblTable);
            this.pStat.Controls.Add(this.label1);
            this.pStat.Controls.Add(this.lbl);
            this.pStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pStat.Location = new System.Drawing.Point(0, 0);
            this.pStat.Name = "pStat";
            this.pStat.Size = new System.Drawing.Size(273, 86);
            this.pStat.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblProductTotalPrice
            // 
            this.lblProductTotalPrice.AutoSize = true;
            this.lblProductTotalPrice.Location = new System.Drawing.Point(53, 33);
            this.lblProductTotalPrice.Name = "lblProductTotalPrice";
            this.lblProductTotalPrice.Size = new System.Drawing.Size(28, 13);
            this.lblProductTotalPrice.TabIndex = 3;
            this.lblProductTotalPrice.Text = "0.00";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(43, 7);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 13);
            this.lblTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(3, 7);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(34, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Стол:";
            // 
            // pSale
            // 
            this.pSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSale.Controls.Add(this.dgProductList);
            this.pSale.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSale.Location = new System.Drawing.Point(0, 88);
            this.pSale.Name = "pSale";
            this.pSale.Size = new System.Drawing.Size(452, 313);
            this.pSale.TabIndex = 2;
            // 
            // dgProductList
            // 
            this.dgProductList.AllowUserToAddRows = false;
            this.dgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productCount,
            this.productUnit,
            this.productPrice,
            this.productAmount,
            this.productCheck,
            this.id,
            this.idSale,
            this.idUnit});
            this.dgProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductList.Location = new System.Drawing.Point(0, 0);
            this.dgProductList.Name = "dgProductList";
            this.dgProductList.Size = new System.Drawing.Size(450, 311);
            this.dgProductList.TabIndex = 0;
            this.dgProductList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgProductList_CellBeginEdit);
            this.dgProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductList_CellClick);
            this.dgProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductList_CellContentClick);
            this.dgProductList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductList_CellEndEdit);
            // 
            // productName
            // 
            this.productName.HeaderText = "Название";
            this.productName.Name = "productName";
            this.productName.Width = 130;
            // 
            // productCount
            // 
            this.productCount.HeaderText = "Колво";
            this.productCount.MaxInputLength = 5;
            this.productCount.Name = "productCount";
            this.productCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productCount.Width = 40;
            // 
            // productUnit
            // 
            this.productUnit.HeaderText = "ед.из";
            this.productUnit.Name = "productUnit";
            this.productUnit.ReadOnly = true;
            this.productUnit.Width = 30;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Цена";
            this.productPrice.MaxInputLength = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 50;
            // 
            // productAmount
            // 
            this.productAmount.HeaderText = "Сумма";
            this.productAmount.MaxInputLength = 10;
            this.productAmount.Name = "productAmount";
            this.productAmount.Width = 50;
            // 
            // productCheck
            // 
            this.productCheck.HeaderText = "Х";
            this.productCheck.Name = "productCheck";
            this.productCheck.Width = 30;
            // 
            // id
            // 
            this.id.HeaderText = "productId";
            this.id.MaxInputLength = 11;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 20;
            // 
            // idSale
            // 
            this.idSale.HeaderText = "idSale";
            this.idSale.MaxInputLength = 11;
            this.idSale.Name = "idSale";
            this.idSale.ReadOnly = true;
            this.idSale.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idSale.Visible = false;
            // 
            // idUnit
            // 
            this.idUnit.HeaderText = "idUnit";
            this.idUnit.MaxInputLength = 5;
            this.idUnit.Name = "idUnit";
            this.idUnit.ReadOnly = true;
            this.idUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idUnit.Visible = false;
            // 
            // pNumpad
            // 
            this.pNumpad.AutoScroll = true;
            this.pNumpad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNumpad.Controls.Add(this.panel1);
            this.pNumpad.Controls.Add(this.btnPay);
            this.pNumpad.Dock = System.Windows.Forms.DockStyle.Right;
            this.pNumpad.Location = new System.Drawing.Point(648, 88);
            this.pNumpad.Name = "pNumpad";
            this.pNumpad.Size = new System.Drawing.Size(180, 313);
            this.pNumpad.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.bn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 266);
            this.panel1.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(119, 190);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(48, 39);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(11, 10);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(102, 39);
            this.txtValue.TabIndex = 12;
            this.txtValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNumkey_MouseClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "<--";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(65, 190);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(48, 39);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(11, 190);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 39);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // bn9
            // 
            this.bn9.Location = new System.Drawing.Point(119, 55);
            this.bn9.Name = "bn9";
            this.bn9.Size = new System.Drawing.Size(48, 39);
            this.bn9.TabIndex = 8;
            this.bn9.Text = "9";
            this.bn9.UseVisualStyleBackColor = true;
            this.bn9.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(65, 55);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 39);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(11, 55);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 39);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(119, 100);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 39);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(65, 100);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 39);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(11, 100);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 39);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(119, 145);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 39);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(65, 145);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 39);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(11, 145);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 39);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numpudButton_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(11, 272);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(156, 34);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Оплатить";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pProduct
            // 
            this.pProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProduct.Location = new System.Drawing.Point(452, 88);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(196, 313);
            this.pProduct.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(110, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 501);
            this.Controls.Add(this.pProduct);
            this.Controls.Add(this.pNumpad);
            this.Controls.Add(this.pSale);
            this.Controls.Add(this.pCategoryStat);
            this.Controls.Add(this.tCTable);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSale_FormClosed);
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.pCategoryStat.ResumeLayout(false);
            this.pStat.ResumeLayout(false);
            this.pStat.PerformLayout();
            this.pSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).EndInit();
            this.pNumpad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCTable;
        private System.Windows.Forms.Panel pCategoryStat;
        private System.Windows.Forms.Panel pSale;
        private System.Windows.Forms.Panel pNumpad;
        private System.Windows.Forms.Panel pStat;
        private System.Windows.Forms.Panel pCategory;
        private System.Windows.Forms.FlowLayoutPanel pProduct;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgProductList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProductTotalPrice;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn productCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button bn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnRefresh;
    }
}