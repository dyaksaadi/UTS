namespace D_UTS
{
    partial class FormTambahkanBukuBaru
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
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.tbUsernameRegistrasi = new System.Windows.Forms.TextBox();
            this.labelUsernamerRegistrasi = new System.Windows.Forms.Label();
            this.tbPasswordRegistrasi = new System.Windows.Forms.TextBox();
            this.labelPasswordRegistrasi = new System.Windows.Forms.Label();
            this.labelRegistrasi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Location = new System.Drawing.Point(603, 346);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(101, 38);
            this.btnRegistrasi.TabIndex = 18;
            this.btnRegistrasi.Text = "Tambahkan Buku";
            this.btnRegistrasi.UseVisualStyleBackColor = true;
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
            // 
            // tbUsernameRegistrasi
            // 
            this.tbUsernameRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameRegistrasi.Location = new System.Drawing.Point(248, 169);
            this.tbUsernameRegistrasi.Name = "tbUsernameRegistrasi";
            this.tbUsernameRegistrasi.Size = new System.Drawing.Size(411, 29);
            this.tbUsernameRegistrasi.TabIndex = 17;
            // 
            // labelUsernamerRegistrasi
            // 
            this.labelUsernamerRegistrasi.AutoSize = true;
            this.labelUsernamerRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernamerRegistrasi.Location = new System.Drawing.Point(108, 174);
            this.labelUsernamerRegistrasi.Name = "labelUsernamerRegistrasi";
            this.labelUsernamerRegistrasi.Size = new System.Drawing.Size(104, 24);
            this.labelUsernamerRegistrasi.TabIndex = 16;
            this.labelUsernamerRegistrasi.Text = "Judul Buku";
            // 
            // tbPasswordRegistrasi
            // 
            this.tbPasswordRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordRegistrasi.Location = new System.Drawing.Point(248, 227);
            this.tbPasswordRegistrasi.Name = "tbPasswordRegistrasi";
            this.tbPasswordRegistrasi.Size = new System.Drawing.Size(411, 29);
            this.tbPasswordRegistrasi.TabIndex = 15;
            this.tbPasswordRegistrasi.TextChanged += new System.EventHandler(this.tbPasswordRegistrasi_TextChanged);
            // 
            // labelPasswordRegistrasi
            // 
            this.labelPasswordRegistrasi.AutoSize = true;
            this.labelPasswordRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordRegistrasi.Location = new System.Drawing.Point(108, 232);
            this.labelPasswordRegistrasi.Name = "labelPasswordRegistrasi";
            this.labelPasswordRegistrasi.Size = new System.Drawing.Size(118, 24);
            this.labelPasswordRegistrasi.TabIndex = 14;
            this.labelPasswordRegistrasi.Text = "Tahun Terbit";
            // 
            // labelRegistrasi
            // 
            this.labelRegistrasi.AutoSize = true;
            this.labelRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrasi.Location = new System.Drawing.Point(167, 66);
            this.labelRegistrasi.Name = "labelRegistrasi";
            this.labelRegistrasi.Size = new System.Drawing.Size(461, 39);
            this.labelRegistrasi.TabIndex = 13;
            this.labelRegistrasi.Text = "TAMBAHKAN BUKU BARU";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(248, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 29);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kategori";
            // 
            // FormTambahkanBukuBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.tbUsernameRegistrasi);
            this.Controls.Add(this.labelUsernamerRegistrasi);
            this.Controls.Add(this.tbPasswordRegistrasi);
            this.Controls.Add(this.labelPasswordRegistrasi);
            this.Controls.Add(this.labelRegistrasi);
            this.Name = "FormTambahkanBukuBaru";
            this.Text = "FormTambahkanBukuBaru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.TextBox tbUsernameRegistrasi;
        private System.Windows.Forms.Label labelUsernamerRegistrasi;
        private System.Windows.Forms.TextBox tbPasswordRegistrasi;
        private System.Windows.Forms.Label labelPasswordRegistrasi;
        private System.Windows.Forms.Label labelRegistrasi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}