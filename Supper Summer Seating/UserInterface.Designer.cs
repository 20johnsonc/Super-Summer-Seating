﻿namespace Supper_Summer_Seating
{
    partial class UserInterface
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxLeftBox = new System.Windows.Forms.TextBox();
            this.uxMiddleBox = new System.Windows.Forms.TextBox();
            this.uxRightBox = new System.Windows.Forms.TextBox();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(1487, 40);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(97, 36);
            this.uxFile.Text = "Menu";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(359, 44);
            this.uxOpen.Text = "Open";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            // 
            // uxLeftBox
            // 
            this.uxLeftBox.Location = new System.Drawing.Point(28, 64);
            this.uxLeftBox.Multiline = true;
            this.uxLeftBox.Name = "uxLeftBox";
            this.uxLeftBox.Size = new System.Drawing.Size(252, 736);
            this.uxLeftBox.TabIndex = 1;
            // 
            // uxMiddleBox
            // 
            this.uxMiddleBox.Location = new System.Drawing.Point(315, 64);
            this.uxMiddleBox.Multiline = true;
            this.uxMiddleBox.Name = "uxMiddleBox";
            this.uxMiddleBox.Size = new System.Drawing.Size(246, 736);
            this.uxMiddleBox.TabIndex = 2;
            // 
            // uxRightBox
            // 
            this.uxRightBox.Location = new System.Drawing.Point(604, 64);
            this.uxRightBox.Multiline = true;
            this.uxRightBox.Name = "uxRightBox";
            this.uxRightBox.Size = new System.Drawing.Size(251, 736);
            this.uxRightBox.TabIndex = 3;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 889);
            this.Controls.Add(this.uxRightBox);
            this.Controls.Add(this.uxMiddleBox);
            this.Controls.Add(this.uxLeftBox);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.TextBox uxLeftBox;
        private System.Windows.Forms.TextBox uxMiddleBox;
        private System.Windows.Forms.TextBox uxRightBox;
    }
}

