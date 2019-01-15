namespace TGRS_ui
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(70, 255);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(250, 50);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(70, 195);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(250, 50);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTB.Location = new System.Drawing.Point(70, 70);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(250, 20);
            this.usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(70, 120);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(250, 20);
            this.passwordTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(384, 369);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
    }
}

