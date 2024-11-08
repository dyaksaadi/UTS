namespace D_UTS
{
    partial class HalamanLogin
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
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelUsernameLogin = new System.Windows.Forms.Label();
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.btnMasukLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogin.Location = new System.Drawing.Point(83, 219);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(92, 24);
            this.labelPasswordLogin.TabIndex = 2;
            this.labelPasswordLogin.Text = "Password";
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLogin.Location = new System.Drawing.Point(192, 214);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(411, 29);
            this.tbPasswordLogin.TabIndex = 4;
            // 
            // labelUsernameLogin
            // 
            this.labelUsernameLogin.AutoSize = true;
            this.labelUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameLogin.Location = new System.Drawing.Point(83, 172);
            this.labelUsernameLogin.Name = "labelUsernameLogin";
            this.labelUsernameLogin.Size = new System.Drawing.Size(97, 24);
            this.labelUsernameLogin.TabIndex = 5;
            this.labelUsernameLogin.Text = "Username";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameLogin.Location = new System.Drawing.Point(192, 167);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(411, 29);
            this.tbUsernameLogin.TabIndex = 6;
            // 
            // btnMasukLogin
            // 
            this.btnMasukLogin.Location = new System.Drawing.Point(594, 324);
            this.btnMasukLogin.Name = "btnMasukLogin";
            this.btnMasukLogin.Size = new System.Drawing.Size(96, 36);
            this.btnMasukLogin.TabIndex = 7;
            this.btnMasukLogin.Text = "Masuk";
            this.btnMasukLogin.UseVisualStyleBackColor = true;
            // 
            // HalamanLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMasukLogin);
            this.Controls.Add(this.tbUsernameLogin);
            this.Controls.Add(this.labelUsernameLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.label1);
            this.Name = "HalamanLogin";
            this.Text = "HalamanLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Label labelUsernameLogin;
        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.Button btnMasukLogin;
    }
}