
namespace Calculatorbaru
{
    partial class FormHitung
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
            this.gbox = new System.Windows.Forms.GroupBox();
            this.boxHasil = new System.Windows.Forms.ListBox();
            this.Hitung = new System.Windows.Forms.Button();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.boxHasil);
            this.gbox.Location = new System.Drawing.Point(17, 16);
            this.gbox.Margin = new System.Windows.Forms.Padding(4);
            this.gbox.Name = "gbox";
            this.gbox.Padding = new System.Windows.Forms.Padding(4);
            this.gbox.Size = new System.Drawing.Size(476, 459);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "Hasilnya";
            // 
            // boxHasil
            // 
            this.boxHasil.FormattingEnabled = true;
            this.boxHasil.ItemHeight = 16;
            this.boxHasil.Location = new System.Drawing.Point(8, 23);
            this.boxHasil.Margin = new System.Windows.Forms.Padding(4);
            this.boxHasil.Name = "boxHasil";
            this.boxHasil.Size = new System.Drawing.Size(459, 420);
            this.boxHasil.TabIndex = 0;
            this.boxHasil.SelectedIndexChanged += new System.EventHandler(this.lstboxHasil_SelectedIndexChanged);
            // 
            // Hitung
            // 
            this.Hitung.Location = new System.Drawing.Point(17, 482);
            this.Hitung.Margin = new System.Windows.Forms.Padding(4);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(476, 57);
            this.Hitung.TabIndex = 1;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // FormHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 554);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.gbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHitung";
            this.Text = "Fom Hitung";
            this.gbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.ListBox boxHasil;
        private System.Windows.Forms.Button Hitung;
    }
}

