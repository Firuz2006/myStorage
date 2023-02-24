using System.ComponentModel;

namespace Cafe
{
    public partial class Rate
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
            this._btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtUSD = new System.Windows.Forms.TextBox();
            this._txtTJS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(11, 346);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(269, 52);
            this._btnAdd.TabIndex = 1;
            this._btnAdd.Text = "Сохранить/Добавить";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Курс доллара";
            // 
            // _txtUSD
            // 
            this._txtUSD.Location = new System.Drawing.Point(11, 71);
            this._txtUSD.Name = "_txtUSD";
            this._txtUSD.Size = new System.Drawing.Size(268, 22);
            this._txtUSD.TabIndex = 3;
            // 
            // _txtTJS
            // 
            this._txtTJS.Location = new System.Drawing.Point(12, 147);
            this._txtTJS.Name = "_txtTJS";
            this._txtTJS.Size = new System.Drawing.Size(268, 22);
            this._txtTJS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Курс сомони";
            // 
            // Rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 506);
            this.Controls.Add(this._txtTJS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtUSD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rate";
            this.Text = "Rate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtUSD;
        private System.Windows.Forms.TextBox _txtTJS;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}