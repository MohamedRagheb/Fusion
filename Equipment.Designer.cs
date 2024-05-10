namespace FusionProject
{
    partial class Equipment
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
            name_eq = new TextBox();
            label1 = new Label();
            descriptio = new Label();
            desc = new RichTextBox();
            active = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // name_eq
            // 
            name_eq.Location = new Point(63, 69);
            name_eq.Name = "name_eq";
            name_eq.Size = new Size(642, 23);
            name_eq.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // descriptio
            // 
            descriptio.AutoSize = true;
            descriptio.Location = new Point(10, 136);
            descriptio.Name = "descriptio";
            descriptio.Size = new Size(67, 15);
            descriptio.TabIndex = 3;
            descriptio.Text = "Description";
            descriptio.Click += label2_Click;
            // 
            // desc
            // 
            desc.Location = new Point(98, 136);
            desc.Name = "desc";
            desc.Size = new Size(607, 96);
            desc.TabIndex = 4;
            desc.Text = "";
            desc.TextChanged += desc_TextChanged;
            // 
            // active
            // 
            active.AutoSize = true;
            active.Location = new Point(39, 284);
            active.Name = "active";
            active.Size = new Size(59, 19);
            active.TabIndex = 5;
            active.Text = "Active";
            active.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(268, 349);
            button1.Name = "button1";
            button1.Size = new Size(245, 23);
            button1.TabIndex = 6;
            button1.Text = "Add Equipment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(active);
            Controls.Add(desc);
            Controls.Add(descriptio);
            Controls.Add(label1);
            Controls.Add(name_eq);
            Name = "Equipment";
            Text = "Equipment";
            Load += Equipment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_eq;
        private Label label1;
        private Label descriptio;
        private RichTextBox desc;
        private CheckBox active;
        private Button button1;
    }
}