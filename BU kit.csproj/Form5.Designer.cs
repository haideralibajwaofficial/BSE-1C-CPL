namespace BU_Kit
{
    partial class adminDashboard
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.signedInTxt = new System.Windows.Forms.TextBox();
            this.BUKitLbl = new System.Windows.Forms.Label();
            this.signedInAsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(459, 121);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 11;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // signedInTxt
            // 
            this.signedInTxt.Location = new System.Drawing.Point(302, 123);
            this.signedInTxt.Name = "signedInTxt";
            this.signedInTxt.ReadOnly = true;
            this.signedInTxt.Size = new System.Drawing.Size(151, 20);
            this.signedInTxt.TabIndex = 10;
            // 
            // BUKitLbl
            // 
            this.BUKitLbl.AutoSize = true;
            this.BUKitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUKitLbl.Location = new System.Drawing.Point(276, 32);
            this.BUKitLbl.Name = "BUKitLbl";
            this.BUKitLbl.Size = new System.Drawing.Size(219, 73);
            this.BUKitLbl.TabIndex = 9;
            this.BUKitLbl.Text = "BU Kit";
            // 
            // signedInAsLbl
            // 
            this.signedInAsLbl.AutoSize = true;
            this.signedInAsLbl.Location = new System.Drawing.Point(228, 126);
            this.signedInAsLbl.Name = "signedInAsLbl";
            this.signedInAsLbl.Size = new System.Drawing.Size(68, 13);
            this.signedInAsLbl.TabIndex = 8;
            this.signedInAsLbl.Text = "Signed in as:";
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.signedInTxt);
            this.Controls.Add(this.BUKitLbl);
            this.Controls.Add(this.signedInAsLbl);
            this.Name = "adminDashboard";
            this.Text = "admin - BU kit";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.TextBox signedInTxt;
        private System.Windows.Forms.Label BUKitLbl;
        private System.Windows.Forms.Label signedInAsLbl;
    }
}