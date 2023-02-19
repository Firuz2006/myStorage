using System.ComponentModel;

namespace Cafe
{
    partial class frmStorage
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
            this.storageDataGridView = new System.Windows.Forms.DataGridView();
            this.@new = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storageDataGridView
            // 
            this.storageDataGridView.AllowUserToAddRows = false;
            this.storageDataGridView.AllowUserToDeleteRows = false;
            this.storageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDataGridView.Location = new System.Drawing.Point(323, 5);
            this.storageDataGridView.Name = "storageDataGridView";
            this.storageDataGridView.ReadOnly = true;
            this.storageDataGridView.RowTemplate.Height = 24;
            this.storageDataGridView.Size = new System.Drawing.Size(485, 497);
            this.storageDataGridView.TabIndex = 0;
            this.storageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storageDataGridView_CellClick);
            // 
            // new
            // 
            this.@new.Location = new System.Drawing.Point(44, 353);
            this.@new.Name = "new";
            this.@new.Size = new System.Drawing.Size(260, 36);
            this.@new.TabIndex = 1;
            this.@new.Text = "Новый";
            this.@new.UseVisualStyleBackColor = true;
            this.@new.Click += new System.EventHandler(this.new_Click_1);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(44, 395);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(260, 33);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(44, 434);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(260, 35);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(44, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 22);
            this.name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(44, 242);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(258, 22);
            this.address.TabIndex = 7;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(202, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 8;
            // 
            // frmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 514);
            this.Controls.Add(this.id);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.@new);
            this.Controls.Add(this.storageDataGridView);
            this.Name = "frmStorage";
            this.Text = "frmStorage";
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox id;

        private System.Windows.Forms.Button @new;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;

        private System.Windows.Forms.DataGridView storageDataGridView;

        #endregion
    }
}