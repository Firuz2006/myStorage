using System.ComponentModel;

namespace Cafe
{
    partial class FrmCategory
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
            this.categoryDataGrid = new System.Windows.Forms.DataGridView();
            this.@new = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDataGrid
            // 
            this.categoryDataGrid.AllowUserToAddRows = false;
            this.categoryDataGrid.AllowUserToDeleteRows = false;
            this.categoryDataGrid.AllowUserToResizeColumns = false;
            this.categoryDataGrid.AllowUserToResizeRows = false;
            this.categoryDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.categoryDataGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.categoryDataGrid.Location = new System.Drawing.Point(438, 12);
            this.categoryDataGrid.Name = "categoryDataGrid";
            this.categoryDataGrid.Size = new System.Drawing.Size(335, 432);
            this.categoryDataGrid.TabIndex = 0;
            this.categoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGrid_CellClick);
            // 
            // new
            // 
            this.@new.Location = new System.Drawing.Point(27, 257);
            this.@new.Name = "new";
            this.@new.Size = new System.Drawing.Size(340, 55);
            this.@new.TabIndex = 1;
            this.@new.Text = "Новый";
            this.@new.UseVisualStyleBackColor = true;
            this.@new.Click += new System.EventHandler(this.new_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(27, 318);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(340, 51);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(27, 375);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(340, 49);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(27, 216);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(339, 22);
            this.name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.@new);
            this.Controls.Add(this.categoryDataGrid);
            this.Name = "FrmCategory";
            this.Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView categoryDataGrid;
        private System.Windows.Forms.Button @new;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox name;

        #endregion
    }
}