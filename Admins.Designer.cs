namespace FusionProject
{
    partial class Admins
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
            admin_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            admin_password = new TextBox();
            button1 = new Button();
            admin_male = new RadioButton();
            admin_female = new RadioButton();
            SuspendLayout();
            // 
            // admin_name
            // 
            admin_name.Location = new Point(111, 116);
            admin_name.Name = "admin_name";
            admin_name.Size = new Size(532, 27);
            admin_name.TabIndex = 0;
            admin_name.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 118);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 189);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // admin_password
            // 
            admin_password.Location = new Point(111, 186);
            admin_password.Name = "admin_password";
            admin_password.PasswordChar = '*';
            admin_password.Size = new Size(532, 27);
            admin_password.TabIndex = 2;
            admin_password.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(311, 301);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 4;
            button1.Text = "Add Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += handel_add_admin;
            // 
            // admin_male
            // 
            admin_male.AutoSize = true;
            admin_male.Location = new Point(207, 244);
            admin_male.Name = "admin_male";
            admin_male.Size = new Size(63, 24);
            admin_male.TabIndex = 5;
            admin_male.TabStop = true;
            admin_male.Text = "male";
            admin_male.UseVisualStyleBackColor = true;
            // 
            // admin_female
            // 
            admin_female.AutoSize = true;
            admin_female.Location = new Point(315, 246);
            admin_female.Name = "admin_female";
            admin_female.Size = new Size(78, 24);
            admin_female.TabIndex = 6;
            admin_female.TabStop = true;
            admin_female.Text = "Female";
            admin_female.UseVisualStyleBackColor = true;
            // 
            // Admins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(admin_female);
            Controls.Add(admin_male);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(admin_password);
            Controls.Add(label1);
            Controls.Add(admin_name);
            Name = "Admins";
            RightToLeft = RightToLeft.No;
            Text = "Add Admin";
            Load += Admins_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox admin_name;
        private Label label1;
        private Label label2;
        private TextBox admin_password;
        private Button button1;
        private RadioButton admin_male;
        private RadioButton admin_female;
    }
}