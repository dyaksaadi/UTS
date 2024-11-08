namespace D_UTS
{
    partial class HalamanDashboard
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
            this.dataGridViewDashboard = new System.Windows.Forms.DataGridView();
            this.labelHalamanDashboard = new System.Windows.Forms.Label();
            this.btnTambahDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDashboard
            // 
            this.dataGridViewDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDashboard.Location = new System.Drawing.Point(49, 105);
            this.dataGridViewDashboard.Name = "dataGridViewDashboard";
            this.dataGridViewDashboard.Size = new System.Drawing.Size(703, 277);
            this.dataGridViewDashboard.TabIndex = 3;
            // 
            // labelHalamanDashboard
            // 
            this.labelHalamanDashboard.AutoSize = true;
            this.labelHalamanDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalamanDashboard.Location = new System.Drawing.Point(202, 43);
            this.labelHalamanDashboard.Name = "labelHalamanDashboard";
            this.labelHalamanDashboard.Size = new System.Drawing.Size(402, 37);
            this.labelHalamanDashboard.TabIndex = 2;
            this.labelHalamanDashboard.Text = "HALAMAN DASHBOARD";
            // 
            // btnTambahDashboard
            // 
            this.btnTambahDashboard.Location = new System.Drawing.Point(651, 403);
            this.btnTambahDashboard.Name = "btnTambahDashboard";
            this.btnTambahDashboard.Size = new System.Drawing.Size(100, 33);
            this.btnTambahDashboard.TabIndex = 4;
            this.btnTambahDashboard.Text = "Tambah Buku";
            this.btnTambahDashboard.UseVisualStyleBackColor = true;
            // 
            // HalamanDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTambahDashboard);
            this.Controls.Add(this.dataGridViewDashboard);
            this.Controls.Add(this.labelHalamanDashboard);
            this.Name = "HalamanDashboard";
            this.Text = "HalamanDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDashboard;
        private System.Windows.Forms.Label labelHalamanDashboard;
        private System.Windows.Forms.Button btnTambahDashboard;
    }
}