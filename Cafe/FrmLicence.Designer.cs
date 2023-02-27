using System.ComponentModel;

namespace Cafe
{
    partial class FrmLicence
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
            this.button1 = new System.Windows.Forms.Button();
            this._lbCpuId = new System.Windows.Forms.Label();
            this._txtLicence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lbCpuId
            // 
            this._lbCpuId.Location = new System.Drawing.Point(93, 74);
            this._lbCpuId.Name = "_lbCpuId";
            this._lbCpuId.Size = new System.Drawing.Size(100, 23);
            this._lbCpuId.TabIndex = 1;
            this._lbCpuId.Text = "label1";
            // 
            // _txtLicence
            // 
            this._txtLicence.Location = new System.Drawing.Point(93, 100);
            this._txtLicence.Name = "_txtLicence";
            this._txtLicence.Size = new System.Drawing.Size(279, 22);
            this._txtLicence.TabIndex = 2;
            // 
            // FrmLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtLicence);
            this.Controls.Add(this._lbCpuId);
            this.Controls.Add(this.button1);
            this.Name = "FrmLicence";
            this.Text = "FrmLicence";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox _txtLicence;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _lbCpuId;

        #endregion
    }
}