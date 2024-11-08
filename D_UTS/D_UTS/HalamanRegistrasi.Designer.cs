namespace D_UTS
{
    partial class HalamanRegistrasi
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
            this.tbUsernameRegistrasi = new System.Windows.Forms.TextBox();
            this.labelUsernamerRegistrasi = new System.Windows.Forms.Label();
            this.tbPasswordRegistrasi = new System.Windows.Forms.TextBox();
            this.labelPasswordRegistrasi = new System.Windows.Forms.Label();
            this.labelRegistrasi = new System.Windows.Forms.Label();
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsernameRegistrasi
            // 
            this.tbUsernameRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameRegistrasi.Location = new System.Drawing.Point(218, 187);
            this.tbUsernameRegistrasi.Name = "tbUsernameRegistrasi";
            this.tbUsernameRegistrasi.Size = new System.Drawing.Size(411, 29);
            this.tbUsernameRegistrasi.TabIndex = 11;
            this.tbUsernameRegistrasi.TextChanged += new System.EventHandler(this.tbUsernameRegistrasi_TextChanged);
            // 
            // labelUsernamerRegistrasi
            // 
            this.labelUsernamerRegistrasi.AutoSize = true;
            this.labelUsernamerRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernamerRegistrasi.Location = new System.Drawing.Point(109, 192);
            this.labelUsernamerRegistrasi.Name = "labelUsernamerRegistrasi";
            this.labelUsernamerRegistrasi.Size = new System.Drawing.Size(97, 24);
            this.labelUsernamerRegistrasi.TabIndex = 10;
            this.labelUsernamerRegistrasi.Text = "Username";
            // 
            // tbPasswordRegistrasi
            // 
            this.tbPasswordRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordRegistrasi.Location = new System.Drawing.Point(218, 245);
            this.tbPasswordRegistrasi.Name = "tbPasswordRegistrasi";
            this.tbPasswordRegistrasi.Size = new System.Drawing.Size(411, 29);
            this.tbPasswordRegistrasi.TabIndex = 9;
            // 
            // labelPasswordRegistrasi
            // 
            this.labelPasswordRegistrasi.AutoSize = true;
            this.labelPasswordRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordRegistrasi.Location = new System.Drawing.Point(109, 250);
            this.labelPasswordRegistrasi.Name = "labelPasswordRegistrasi";
            this.labelPasswordRegistrasi.Size = new System.Drawing.Size(92, 24);
            this.labelPasswordRegistrasi.TabIndex = 8;
            this.labelPasswordRegistrasi.Text = "Password";
            // 
            // labelRegistrasi
            // 
            this.labelRegistrasi.AutoSize = true;
            this.labelRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrasi.Location = new System.Drawing.Point(261, 84);
            this.labelRegistrasi.Name = "labelRegistrasi";
            this.labelRegistrasi.Size = new System.Drawing.Size(235, 39);
            this.labelRegistrasi.TabIndex = 7;
            this.labelRegistrasi.Text = "REGISTRASI";
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Location = new System.Drawing.Point(604, 364);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(90, 38);
            this.btnRegistrasi.TabIndex = 12;
            this.btnRegistrasi.Text = "Registrasi";
            this.btnRegistrasi.UseVisualStyleBackColor = true;
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
            // 
            // HalamanRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.tbUsernameRegistrasi);
            this.Controls.Add(this.labelUsernamerRegistrasi);
            this.Controls.Add(this.tbPasswordRegistrasi);
            this.Controls.Add(this.labelPasswordRegistrasi);
            this.Controls.Add(this.labelRegistrasi);
            this.Name = "HalamanRegistrasi";
            this.Text = "HalamanRegistrasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsernameRegistrasi;
        private System.Windows.Forms.Label labelUsernamerRegistrasi;
        private System.Windows.Forms.TextBox tbPasswordRegistrasi;
        private System.Windows.Forms.Label labelPasswordRegistrasi;
        private System.Windows.Forms.Label labelRegistrasi;
        private System.Windows.Forms.Button btnRegistrasi;
    }
}