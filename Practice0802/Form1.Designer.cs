namespace Practice0802
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonRegister = new Button();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRepeatPassword = new TextBox();
            textBoxPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 81);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 132);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 184);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.Location = new Point(179, 240);
            label4.Name = "label4";
            label4.Size = new Size(101, 53);
            label4.TabIndex = 3;
            label4.Text = "Электронная почта*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 302);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Пароль*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 357);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 5;
            label6.Text = "Повторение пароля*";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(290, 412);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(176, 29);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(362, 78);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(215, 27);
            textBoxSurname.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(362, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 27);
            textBoxName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(362, 250);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(215, 27);
            textBoxEmail.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(362, 302);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(215, 27);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(362, 350);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.PasswordChar = '*';
            textBoxRepeatPassword.Size = new Size(215, 27);
            textBoxRepeatPassword.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(362, 184);
            textBoxPhone.Mask = "8-###-###-##-##";
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(215, 27);
            textBoxPhone.TabIndex = 13;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 508);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(buttonRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonRegister;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxRepeatPassword;
        private MaskedTextBox textBoxPhone;
    }
}