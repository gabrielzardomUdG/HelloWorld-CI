namespace HolaMundo
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
            txt_password = new TextBox();
            txt_repeatPassword = new TextBox();
            btn_confirm = new Button();
            lbl_password = new Label();
            lbl_repeatPassword = new Label();
            lbl_title = new Label();
            lbl_instructions = new Label();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(225, 100);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(250, 31);
            txt_password.TabIndex = 0;
            // 
            // txt_repeatPassword
            // 
            txt_repeatPassword.Location = new Point(225, 175);
            txt_repeatPassword.Name = "txt_repeatPassword";
            txt_repeatPassword.Size = new Size(250, 31);
            txt_repeatPassword.TabIndex = 1;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(225, 250);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(250, 34);
            btn_confirm.TabIndex = 2;
            btn_confirm.Text = "confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(50, 100);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(87, 25);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // lbl_repeatPassword
            // 
            lbl_repeatPassword.AutoSize = true;
            lbl_repeatPassword.Location = new Point(50, 175);
            lbl_repeatPassword.Name = "lbl_repeatPassword";
            lbl_repeatPassword.Size = new Size(148, 25);
            lbl_repeatPassword.TabIndex = 4;
            lbl_repeatPassword.Text = "Repeat-Password";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(275, 50);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(162, 25);
            lbl_title.TabIndex = 5;
            lbl_title.Text = "Password Validator";
            // 
            // lbl_instructions
            // 
            lbl_instructions.AutoSize = true;
            lbl_instructions.Location = new Point(50, 309);
            lbl_instructions.Name = "lbl_instructions";
            lbl_instructions.Size = new Size(416, 150);
            lbl_instructions.TabIndex = 6;
            lbl_instructions.Text = "Instructions : Your password must include at least : \r\n\r\n-One upper case letter. \r\n-One lower case letter. \r\n-One special symbol, \r\n-One number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 544);
            Controls.Add(lbl_instructions);
            Controls.Add(lbl_title);
            Controls.Add(lbl_repeatPassword);
            Controls.Add(lbl_password);
            Controls.Add(btn_confirm);
            Controls.Add(txt_repeatPassword);
            Controls.Add(txt_password);
            Name = "Form1";
            Text = "HelloWorld";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_password;
        private TextBox txt_repeatPassword;
        private Button btn_confirm;
        private Label lbl_password;
        private Label lbl_repeatPassword;
        private Label lbl_title;
        private Label lbl_instructions;
    }
}
