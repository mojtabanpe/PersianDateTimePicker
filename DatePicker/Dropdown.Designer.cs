namespace DatePicker
{
    partial class Dropdown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDropdown = new System.Windows.Forms.Button();
            this.txtInputDropdown = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnDropdown
            // 
            this.btnDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDropdown.Location = new System.Drawing.Point(3, 3);
            this.btnDropdown.Name = "btnDropdown";
            this.btnDropdown.Size = new System.Drawing.Size(70, 23);
            this.btnDropdown.TabIndex = 0;
            this.btnDropdown.Text = "▼";
            this.btnDropdown.UseVisualStyleBackColor = true;
            this.btnDropdown.Click += new System.EventHandler(this.btnDropdown_Click);
            // 
            // txtInputDropdown
            // 
            this.txtInputDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputDropdown.Location = new System.Drawing.Point(78, 4);
            this.txtInputDropdown.Name = "txtInputDropdown";
            this.txtInputDropdown.Size = new System.Drawing.Size(317, 20);
            this.txtInputDropdown.TabIndex = 1;
            // 
            // Dropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtInputDropdown);
            this.Controls.Add(this.btnDropdown);
            this.Name = "Dropdown";
            this.Size = new System.Drawing.Size(400, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDropdown;
        private System.Windows.Forms.MaskedTextBox txtInputDropdown;
    }
}
