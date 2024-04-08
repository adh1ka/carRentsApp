namespace carRentsApps.Administrator.Car_Seat
{
    partial class mngCs
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
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(246, 392);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(112, 22);
            this.tbPwd.TabIndex = 20;
            this.tbPwd.Visible = false;
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(246, 330);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(112, 22);
            this.tbUsn.TabIndex = 19;
            this.tbUsn.Visible = false;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(246, 270);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(112, 22);
            this.tbNama.TabIndex = 18;
            this.tbNama.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1282, 552);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 72);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1282, 342);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 72);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1282, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 72);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 458);
            this.dataGridView1.TabIndex = 14;
            // 
            // mngCs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 791);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUsn);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mngCs";
            this.Text = "mngCs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}