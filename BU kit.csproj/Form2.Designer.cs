namespace BU_Kit
{
    partial class adminVerification
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.specialKeyLbl = new System.Windows.Forms.Label();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(112, 90);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(234, 20);
            this.passwordTxt.TabIndex = 0;
            // 
            // specialKeyLbl
            // 
            this.specialKeyLbl.AutoSize = true;
            this.specialKeyLbl.Location = new System.Drawing.Point(109, 74);
            this.specialKeyLbl.Name = "specialKeyLbl";
            this.specialKeyLbl.Size = new System.Drawing.Size(171, 13);
            this.specialKeyLbl.TabIndex = 1;
            this.specialKeyLbl.Text = "Enter Special Key To Verify Admin:";
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(112, 116);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(234, 23);
            this.verifyBtn.TabIndex = 2;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 190);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.specialKeyLbl);
            this.Controls.Add(this.passwordTxt);
            this.Name = "adminVerification";
            this.Text = "Verify Admin";
            this.Load += new System.EventHandler(this.adminVerification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label specialKeyLbl;
        private System.Windows.Forms.Button verifyBtn;
    }
}