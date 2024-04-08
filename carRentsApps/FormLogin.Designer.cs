namespace carRentsApps
{
    partial class FormLogin
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
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.btnLgn = new System.Windows.Forms.Button();
            this.btnKtlg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(352, 150);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(100, 22);
            this.tbUsn.TabIndex = 0;
            this.tbUsn.TextChanged += new System.EventHandler(this.tbUsn_TextChanged);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(352, 204);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(100, 22);
            this.tbPwd.TabIndex = 1;
            // 
            // btnLgn
            // 
            this.btnLgn.Location = new System.Drawing.Point(348, 267);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.Size = new System.Drawing.Size(104, 48);
            this.btnLgn.TabIndex = 2;
            this.btnLgn.Text = "Login";
            this.btnLgn.UseVisualStyleBackColor = true;
            this.btnLgn.Click += new System.EventHandler(this.btnLgn_Click);
            // 
            // btnKtlg
            // 
            this.btnKtlg.Location = new System.Drawing.Point(348, 347);
            this.btnKtlg.Name = "btnKtlg";
            this.btnKtlg.Size = new System.Drawing.Size(104, 48);
            this.btnKtlg.TabIndex = 3;
            this.btnKtlg.Text = "Lihat Katalog";
            this.btnKtlg.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKtlg);
            this.Controls.Add(this.btnLgn);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsn);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Button btnLgn;
        private System.Windows.Forms.Button btnKtlg;
    }
}