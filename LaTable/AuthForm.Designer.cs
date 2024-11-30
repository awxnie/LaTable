namespace LaTable
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(487, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(487, 262);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PlaceholderText = " Логин";
            this.loginTextBox.Size = new System.Drawing.Size(196, 27);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(487, 305);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = " Пароль";
            this.passwordTextBox.Size = new System.Drawing.Size(196, 27);
            this.passwordTextBox.TabIndex = 2;
            // 
            // authButton
            // 
            this.authButton.BackColor = System.Drawing.Color.AliceBlue;
            this.authButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.authButton.Location = new System.Drawing.Point(487, 350);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(196, 50);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // AuthForm
            // 
            this.AcceptButton = this.authButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button authButton;
    }
}