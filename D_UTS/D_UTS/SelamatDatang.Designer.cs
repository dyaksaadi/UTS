namespace D_UTS
{
    partial class SelamatDatang
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHalamanBuku = new System.Windows.Forms.Button();
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELAMAT DATANG";
            // 
            // btnHalamanBuku
            // 
            this.btnHalamanBuku.Location = new System.Drawing.Point(139, 142);
            this.btnHalamanBuku.Name = "btnHalamanBuku";
            this.btnHalamanBuku.Size = new System.Drawing.Size(121, 52);
            this.btnHalamanBuku.TabIndex = 1;
            this.btnHalamanBuku.Text = "Halaman Buku";
            this.btnHalamanBuku.UseVisualStyleBackColor = true;
            this.btnHalamanBuku.Click += new System.EventHandler(this.btnHalamanBuku_Click);
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Location = new System.Drawing.Point(325, 142);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(121, 52);
            this.btnRegistrasi.TabIndex = 2;
            this.btnRegistrasi.Text = "Registrasi";
            this.btnRegistrasi.UseVisualStyleBackColor = true;
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(502, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 52);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // SelamatDatang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.btnHalamanBuku);
            this.Controls.Add(this.label1);
            this.Name = "SelamatDatang";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHalamanBuku;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.Button btnLogin;
    }
}

