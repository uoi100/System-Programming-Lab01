namespace RegWMI
{
    partial class Dlg_Register
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
            this.lbl_AppName = new System.Windows.Forms.Label();
            this.txt_AppName = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.num_Year = new System.Windows.Forms.NumericUpDown();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_DialogTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AppName
            // 
            this.lbl_AppName.AutoSize = true;
            this.lbl_AppName.Location = new System.Drawing.Point(6, 16);
            this.lbl_AppName.Name = "lbl_AppName";
            this.lbl_AppName.Size = new System.Drawing.Size(93, 13);
            this.lbl_AppName.TabIndex = 0;
            this.lbl_AppName.Text = "Application Name:";
            // 
            // txt_AppName
            // 
            this.txt_AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AppName.Location = new System.Drawing.Point(179, 13);
            this.txt_AppName.Name = "txt_AppName";
            this.txt_AppName.Size = new System.Drawing.Size(164, 20);
            this.txt_AppName.TabIndex = 1;
            // 
            // btn_confirm
            // 
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirm.Location = new System.Drawing.Point(3, 0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_confirm.Size = new System.Drawing.Size(167, 23);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(6, 42);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(63, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Your Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Location = new System.Drawing.Point(179, 39);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(164, 20);
            this.txt_Name.TabIndex = 4;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(6, 67);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(32, 13);
            this.lbl_Year.TabIndex = 5;
            this.lbl_Year.Text = "Year:";
            // 
            // num_Year
            // 
            this.num_Year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Year.Location = new System.Drawing.Point(179, 65);
            this.num_Year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_Year.Name = "num_Year";
            this.num_Year.Size = new System.Drawing.Size(164, 20);
            this.num_Year.TabIndex = 6;
            this.num_Year.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(170, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(167, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_CancelClick);
            // 
            // lbl_DialogTxt
            // 
            this.lbl_DialogTxt.AutoSize = true;
            this.lbl_DialogTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_DialogTxt.Location = new System.Drawing.Point(0, 0);
            this.lbl_DialogTxt.Name = "lbl_DialogTxt";
            this.lbl_DialogTxt.Padding = new System.Windows.Forms.Padding(6, 3, 0, 0);
            this.lbl_DialogTxt.Size = new System.Drawing.Size(113, 16);
            this.lbl_DialogTxt.TabIndex = 8;
            this.lbl_DialogTxt.Text = "Please fill in the fields";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_AppName);
            this.groupBox1.Controls.Add(this.txt_AppName);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.lbl_Year);
            this.groupBox1.Controls.Add(this.num_Year);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 136);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 26);
            this.panel1.TabIndex = 8;
            // 
            // Dlg_Register
            // 
            this.AcceptButton = this.btn_confirm;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(346, 152);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_DialogTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 191);
            this.Name = "Dlg_Register";
            this.ShowIcon = false;
            this.Text = "Register Application";
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AppName;
        private System.Windows.Forms.TextBox txt_AppName;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.NumericUpDown num_Year;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_DialogTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}