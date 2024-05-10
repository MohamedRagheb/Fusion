namespace FusionProject
{
    partial class Treniess
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
            treniee_name = new TextBox();
            label1 = new Label();
            Age = new Label();
            label2 = new Label();
            treniee_job = new TextBox();
            checkBox1 = new CheckBox();
            add_treniee = new Button();
            treniee_age = new TextBox();
            SuspendLayout();
            // 
            // treniee_name
            // 
            treniee_name.Location = new Point(83, 34);
            treniee_name.Name = "treniee_name";
            treniee_name.Size = new Size(529, 23);
            treniee_name.TabIndex = 0;
            treniee_name.TextChanged += treniee_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 42);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(25, 91);
            Age.Name = "Age";
            Age.Size = new Size(28, 15);
            Age.TabIndex = 3;
            Age.Text = "Age";
            Age.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 145);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "Job ";
            label2.Click += label2_Click_1;
            // 
            // treniee_job
            // 
            treniee_job.Location = new Point(86, 137);
            treniee_job.Name = "treniee_job";
            treniee_job.Size = new Size(529, 23);
            treniee_job.TabIndex = 5;
            treniee_job.TextChanged += textBox2_TextChanged_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(87, 181);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Auto renew";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // add_treniee
            // 
            add_treniee.Location = new Point(285, 241);
            add_treniee.Name = "add_treniee";
            add_treniee.Size = new Size(122, 23);
            add_treniee.TabIndex = 8;
            add_treniee.Text = "Add Treniee";
            add_treniee.UseVisualStyleBackColor = true;
            add_treniee.Click += add_treniee_Click;
            // 
            // treniee_age
            // 
            treniee_age.Location = new Point(86, 87);
            treniee_age.Name = "treniee_age";
            treniee_age.Size = new Size(529, 23);
            treniee_age.TabIndex = 9;
            // 
            // Treniess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(treniee_age);
            Controls.Add(add_treniee);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(treniee_job);
            Controls.Add(Age);
            Controls.Add(label1);
            Controls.Add(treniee_name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Treniess";
            Text = "Treniess";
            Load += Treniess_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox treniee_name;
        private Label label1;
        private Label Age;
        private Label label2;
        private TextBox treniee_job;
        private CheckBox checkBox1;
        private Button add_treniee;
        private TextBox treniee_age;
    }
}