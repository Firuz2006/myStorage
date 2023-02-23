namespace Cafe
{
    partial class frmCompany
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgCompany = new System.Windows.Forms.DataGridView();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(381, 622);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // dgCompany
            // 
            this.dgCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCompany.Location = new System.Drawing.Point(381, 0);
            this.dgCompany.Margin = new System.Windows.Forms.Padding(4);
            this.dgCompany.Name = "dgCompany";
            this.dgCompany.Size = new System.Drawing.Size(1002, 622);
            this.dgCompany.TabIndex = 13;
            this.dgCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompany_CellClick);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(58, 222);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(244, 22);
            this.txtCompany.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Компания:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(57, 462);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(245, 38);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(57, 507);
            this.bntSave.Margin = new System.Windows.Forms.Padding(4);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(245, 38);
            this.bntSave.TabIndex = 17;
            this.bntSave.Text = "Сохранить";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(57, 553);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Телефон";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(58, 282);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(244, 22);
            this.phone.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(56, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Адрес";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(57, 344);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(245, 22);
            this.address.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Информация";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(56, 408);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(246, 22);
            this.info.TabIndex = 25;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 622);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.dgCompany);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCompany";
            this.Text = "company";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox info;

        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;

        private System.Windows.Forms.Label label2;

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button btnDelete;
    }
}