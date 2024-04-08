namespace carRentsApps
{
    partial class newUser
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.cbAdm = new System.Windows.Forms.CheckBox();
            this.cbKyw = new System.Windows.Forms.CheckBox();
            this.btnCncl = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(384, 119);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(181, 22);
            this.tbNama.TabIndex = 0;
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(384, 180);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(181, 22);
            this.tbUsn.TabIndex = 1;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(384, 241);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(181, 22);
            this.tbPwd.TabIndex = 2;
            // 
            // cbAdm
            // 
            this.cbAdm.AutoSize = true;
            this.cbAdm.Location = new System.Drawing.Point(385, 310);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Size = new System.Drawing.Size(107, 20);
            this.cbAdm.TabIndex = 3;
            this.cbAdm.Text = "Administrator";
            this.cbAdm.UseVisualStyleBackColor = true;
            // 
            // cbKyw
            // 
            this.cbKyw.AutoSize = true;
            this.cbKyw.Location = new System.Drawing.Point(503, 310);
            this.cbKyw.Name = "cbKyw";
            this.cbKyw.Size = new System.Drawing.Size(88, 20);
            this.cbKyw.TabIndex = 4;
            this.cbKyw.Text = "Karyawan";
            this.cbKyw.UseVisualStyleBackColor = true;
            // 
            // btnCncl
            // 
            this.btnCncl.Location = new System.Drawing.Point(384, 366);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(82, 59);
            this.btnCncl.TabIndex = 5;
            this.btnCncl.Text = "cncel";
            this.btnCncl.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(503, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 59);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(647, 32);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(82, 59);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Level";
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.cbKyw);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsn);
            this.Controls.Add(this.tbNama);
            this.Name = "newUser";
            this.Text = "newUser";
            this.Load += new System.EventHandler(this.newUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.CheckBox cbAdm;
        private System.Windows.Forms.CheckBox cbKyw;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}