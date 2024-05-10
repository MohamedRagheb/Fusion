namespace FusionProject
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
            components = new System.ComponentModel.Container();
            Project_lable = new Label();
            helper_text = new Label();
            username_text = new TextBox();
            password_box = new TextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // Project_lable
            // 
            Project_lable.AutoSize = true;
            Project_lable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Project_lable.Location = new Point(298, 81);
            Project_lable.MinimumSize = new Size(60, 30);
            Project_lable.Name = "Project_lable";
            Project_lable.Size = new Size(105, 41);
            Project_lable.TabIndex = 0;
            Project_lable.Text = "Fusion";
            Project_lable.Click += label1_Click;
            // 
            // helper_text
            // 
            helper_text.AutoSize = true;
            helper_text.CausesValidation = false;
            helper_text.Location = new Point(240, 150);
            helper_text.Name = "helper_text";
            helper_text.Size = new Size(198, 20);
            helper_text.TabIndex = 2;
            helper_text.Text = "Enter Username Or Password";
            helper_text.Click += label2_Click;
            // 
            // username_text
            // 
            username_text.Location = new Point(227, 188);
            username_text.Name = "username_text";
            username_text.PlaceholderText = "Enter Username";
            username_text.Size = new Size(221, 27);
            username_text.TabIndex = 3;
            // 
            // password_box
            // 
            password_box.Location = new Point(226, 245);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.PlaceholderText = "Enter Password";
            password_box.Size = new Size(221, 27);
            password_box.TabIndex = 5;
            password_box.TextChanged += password_box_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(285, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(742, 475);
            Controls.Add(button1);
            Controls.Add(password_box);
            Controls.Add(username_text);
            Controls.Add(helper_text);
            Controls.Add(Project_lable);
            Name = "Form1";
            Text = "Fusion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Project_lable;
        private Label helper_text;
        private TextBox username_text;
        private TextBox password_box;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
    }
}