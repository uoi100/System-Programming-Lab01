﻿namespace RegWMI
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.clr_Dialog = new System.Windows.Forms.ColorDialog();
            this.btn_CtlPnlColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register / Edit Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_RegClick);
            // 
            // btn_CtlPnlColor
            // 
            this.btn_CtlPnlColor.Location = new System.Drawing.Point(13, 43);
            this.btn_CtlPnlColor.Name = "btn_CtlPnlColor";
            this.btn_CtlPnlColor.Size = new System.Drawing.Size(190, 23);
            this.btn_CtlPnlColor.TabIndex = 1;
            this.btn_CtlPnlColor.Text = "Modify Control Panel Title Color";
            this.btn_CtlPnlColor.UseVisualStyleBackColor = true;
            this.btn_CtlPnlColor.Click += new System.EventHandler(this.btn_CtlPnlClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_CtlPnlColor);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "RegWMI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog clr_Dialog;
        private System.Windows.Forms.Button btn_CtlPnlColor;
    }
}

