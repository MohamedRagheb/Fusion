﻿namespace FusionProject
{
    partial class AdminGrid
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
            components = new System.ComponentModel.Container();
            adminsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)adminsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // adminsBindingSource
            // 
            adminsBindingSource.DataSource = typeof(Admins);
            // 
            // AdminGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "AdminGrid";
            Text = "AdminGrid";
            ((System.ComponentModel.ISupportInitialize)adminsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource adminsBindingSource;
    }
}