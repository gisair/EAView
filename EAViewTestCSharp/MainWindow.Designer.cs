﻿namespace EAViewTestCSharp
{
    partial class MainWindow
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
            this.EAViewGlobeControl1 = new EAViewEngine.EAViewGlobeControl();
            this.SuspendLayout();
            // 
            // EAViewGlobeControl1
            // 
            this.EAViewGlobeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EAViewGlobeControl1.Location = new System.Drawing.Point(13, 13);
            this.EAViewGlobeControl1.Name = "EAViewGlobeControl1";
            this.EAViewGlobeControl1.Size = new System.Drawing.Size(420, 294);
            this.EAViewGlobeControl1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 319);
            this.Controls.Add(this.EAViewGlobeControl1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private EAViewEngine.EAViewGlobeControl EAViewGlobeControl1;
    }
}

