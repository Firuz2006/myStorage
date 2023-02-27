using System.ComponentModel;

namespace Cafe
{
    partial class FrmReport
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
            this._dateFrom = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dateTo = new MetroFramework.Controls.MetroDateTime();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dateFrom
            // 
            this._dateFrom.Location = new System.Drawing.Point(12, 44);
            this._dateFrom.MinimumSize = new System.Drawing.Size(0, 30);
            this._dateFrom.Name = "_dateFrom";
            this._dateFrom.Size = new System.Drawing.Size(200, 30);
            this._dateFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Посмотреть отчёт от";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // _dateTo
            // 
            this._dateTo.Location = new System.Drawing.Point(12, 140);
            this._dateTo.MinimumSize = new System.Drawing.Size(0, 30);
            this._dateTo.Name = "_dateTo";
            this._dateTo.Size = new System.Drawing.Size(200, 30);
            this._dateTo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // _btnSubmit
            // 
            this._btnSubmit.Location = new System.Drawing.Point(12, 196);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(200, 41);
            this._btnSubmit.TabIndex = 5;
            this._btnSubmit.Text = "Посмотреть";
            this._btnSubmit.UseVisualStyleBackColor = true;
            this._btnSubmit.Click += new System.EventHandler(this._btnSubmit_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._dateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dateFrom);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _btnSubmit;

        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime _dateTo;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;

        private MetroFramework.Controls.MetroDateTime _dateFrom;

        #endregion
    }
}