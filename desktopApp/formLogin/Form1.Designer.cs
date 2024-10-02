namespace formLogin
{
    partial class Form1
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
            login_button = new Button();
            userInput_label = new Label();
            userInput_textBox = new TextBox();
            passwordInput_textBox = new TextBox();
            passwordInput_label = new Label();
            status_label = new Label();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(585, 354);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 0;
            login_button.Text = "Logar";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // userInput_label
            // 
            userInput_label.AutoSize = true;
            userInput_label.Location = new Point(83, 119);
            userInput_label.Name = "userInput_label";
            userInput_label.Size = new Size(59, 20);
            userInput_label.TabIndex = 1;
            userInput_label.Text = "Usuário";
            // 
            // userInput_textBox
            // 
            userInput_textBox.Location = new Point(148, 116);
            userInput_textBox.Name = "userInput_textBox";
            userInput_textBox.Size = new Size(125, 27);
            userInput_textBox.TabIndex = 2;
            // 
            // passwordInput_textBox
            // 
            passwordInput_textBox.Location = new Point(148, 154);
            passwordInput_textBox.Name = "passwordInput_textBox";
            passwordInput_textBox.Size = new Size(125, 27);
            passwordInput_textBox.TabIndex = 4;
            // 
            // passwordInput_label
            // 
            passwordInput_label.AutoSize = true;
            passwordInput_label.Location = new Point(83, 157);
            passwordInput_label.Name = "passwordInput_label";
            passwordInput_label.Size = new Size(49, 20);
            passwordInput_label.TabIndex = 3;
            passwordInput_label.Text = "Senha";
            // 
            // status_label
            // 
            status_label.AutoSize = true;
            status_label.Location = new Point(348, 358);
            status_label.Name = "status_label";
            status_label.Size = new Size(0, 20);
            status_label.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(status_label);
            Controls.Add(passwordInput_textBox);
            Controls.Add(passwordInput_label);
            Controls.Add(userInput_textBox);
            Controls.Add(userInput_label);
            Controls.Add(login_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Label userInput_label;
        private TextBox userInput_textBox;
        private TextBox passwordInput_textBox;
        private Label passwordInput_label;
        private Label status_label;
    }
}
