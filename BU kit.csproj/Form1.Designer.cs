namespace BU_Kit
{
    partial class menu
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
            this.BUKit_lbl = new System.Windows.Forms.Label();
            this.studentBtn = new System.Windows.Forms.Button();
            this.teacherBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.enrollmentTxt = new System.Windows.Forms.TextBox();
            this.enrollmentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUKit_lbl
            // 
            this.BUKit_lbl.AutoSize = true;
            this.BUKit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUKit_lbl.Location = new System.Drawing.Point(325, 55);
            this.BUKit_lbl.Name = "BUKit_lbl";
            this.BUKit_lbl.Size = new System.Drawing.Size(113, 37);
            this.BUKit_lbl.TabIndex = 0;
            this.BUKit_lbl.Text = "BU Kit";
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(270, 191);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(221, 23);
            this.studentBtn.TabIndex = 1;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // teacherBtn
            // 
            this.teacherBtn.Location = new System.Drawing.Point(270, 220);
            this.teacherBtn.Name = "teacherBtn";
            this.teacherBtn.Size = new System.Drawing.Size(221, 23);
            this.teacherBtn.TabIndex = 2;
            this.teacherBtn.Text = "Teacher";
            this.teacherBtn.UseVisualStyleBackColor = true;
            this.teacherBtn.Click += new System.EventHandler(this.teacherBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(270, 249);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(221, 23);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // enrollmentTxt
            // 
            this.enrollmentTxt.Location = new System.Drawing.Point(270, 153);
            this.enrollmentTxt.Name = "enrollmentTxt";
            this.enrollmentTxt.Size = new System.Drawing.Size(221, 20);
            this.enrollmentTxt.TabIndex = 4;
            // 
            // enrollmentLbl
            // 
            this.enrollmentLbl.AutoSize = true;
            this.enrollmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentLbl.Location = new System.Drawing.Point(267, 134);
            this.enrollmentLbl.Name = "enrollmentLbl";
            this.enrollmentLbl.Size = new System.Drawing.Size(73, 16);
            this.enrollmentLbl.TabIndex = 5;
            this.enrollmentLbl.Text = "Enrollment:";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enrollmentLbl);
            this.Controls.Add(this.enrollmentTxt);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.teacherBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.BUKit_lbl);
            this.Name = "menu";
            this.Text = "BU Kit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BUKit_lbl;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button teacherBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.TextBox enrollmentTxt;
        private System.Windows.Forms.Label enrollmentLbl;
    }
}

