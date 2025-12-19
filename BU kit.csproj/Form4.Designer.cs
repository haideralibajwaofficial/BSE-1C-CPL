namespace BU_Kit
{
    partial class teacherDashboard
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
            this.inventoryMngBtn = new System.Windows.Forms.Button();
            this.findFileBtn = new System.Windows.Forms.Button();
            this.newEntryBtn = new System.Windows.Forms.Button();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.shelfComboBox = new System.Windows.Forms.ComboBox();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.campusSelect = new System.Windows.Forms.ComboBox();
            this.campusLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.shelfLbl = new System.Windows.Forms.Label();
            this.columnLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.enrollmentTxt = new System.Windows.Forms.TextBox();
            this.enrollmentLbl = new System.Windows.Forms.Label();
            this.enrollmentTxt2 = new System.Windows.Forms.TextBox();
            this.enrollmentFindTxt = new System.Windows.Forms.TextBox();
            this.enrollmentFindLbl = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(456, 133);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // signedInTxt
            // 
            this.signedInTxt.Location = new System.Drawing.Point(299, 135);
            this.signedInTxt.Name = "signedInTxt";
            this.signedInTxt.ReadOnly = true;
            this.signedInTxt.Size = new System.Drawing.Size(151, 20);
            this.signedInTxt.TabIndex = 6;
            // 
            // BUKitLbl
            // 
            this.BUKitLbl.AutoSize = true;
            this.BUKitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUKitLbl.Location = new System.Drawing.Point(273, 44);
            this.BUKitLbl.Name = "BUKitLbl";
            this.BUKitLbl.Size = new System.Drawing.Size(219, 73);
            this.BUKitLbl.TabIndex = 5;
            this.BUKitLbl.Text = "BU Kit";
            // 
            // signedInAsLbl
            // 
            this.signedInAsLbl.AutoSize = true;
            this.signedInAsLbl.Location = new System.Drawing.Point(225, 138);
            this.signedInAsLbl.Name = "signedInAsLbl";
            this.signedInAsLbl.Size = new System.Drawing.Size(68, 13);
            this.signedInAsLbl.TabIndex = 4;
            this.signedInAsLbl.Text = "Signed in as:";
            // 
            // inventoryMngBtn
            // 
            this.inventoryMngBtn.Location = new System.Drawing.Point(299, 187);
            this.inventoryMngBtn.Name = "inventoryMngBtn";
            this.inventoryMngBtn.Size = new System.Drawing.Size(151, 23);
            this.inventoryMngBtn.TabIndex = 8;
            this.inventoryMngBtn.Text = "Manage Lab Files";
            this.inventoryMngBtn.UseVisualStyleBackColor = true;
            this.inventoryMngBtn.Click += new System.EventHandler(this.inventoryMngBtn_Click);
            // 
            // findFileBtn
            // 
            this.findFileBtn.Location = new System.Drawing.Point(456, 187);
            this.findFileBtn.Name = "findFileBtn";
            this.findFileBtn.Size = new System.Drawing.Size(104, 23);
            this.findFileBtn.TabIndex = 10;
            this.findFileBtn.Text = "Find a file";
            this.findFileBtn.UseVisualStyleBackColor = true;
            this.findFileBtn.Click += new System.EventHandler(this.findFileBtn_Click);
            // 
            // newEntryBtn
            // 
            this.newEntryBtn.Location = new System.Drawing.Point(457, 214);
            this.newEntryBtn.Name = "newEntryBtn";
            this.newEntryBtn.Size = new System.Drawing.Size(104, 23);
            this.newEntryBtn.TabIndex = 11;
            this.newEntryBtn.Text = "Make a new Entry";
            this.newEntryBtn.UseVisualStyleBackColor = true;
            this.newEntryBtn.Click += new System.EventHandler(this.newEntryBtn_Click);
            // 
            // roomComboBox
            // 
            this.roomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(575, 267);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(58, 21);
            this.roomComboBox.TabIndex = 12;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // shelfComboBox
            // 
            this.shelfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shelfComboBox.FormattingEnabled = true;
            this.shelfComboBox.Location = new System.Drawing.Point(638, 267);
            this.shelfComboBox.Name = "shelfComboBox";
            this.shelfComboBox.Size = new System.Drawing.Size(47, 21);
            this.shelfComboBox.TabIndex = 13;
            this.shelfComboBox.SelectedIndexChanged += new System.EventHandler(this.shelfComboBox_SelectedIndexChanged);
            // 
            // columnComboBox
            // 
            this.columnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(694, 267);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(46, 21);
            this.columnComboBox.TabIndex = 14;
            this.columnComboBox.SelectedIndexChanged += new System.EventHandler(this.columnComboBox_SelectedIndexChanged);
            // 
            // campusSelect
            // 
            this.campusSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campusSelect.FormattingEnabled = true;
            this.campusSelect.Location = new System.Drawing.Point(457, 266);
            this.campusSelect.Name = "campusSelect";
            this.campusSelect.Size = new System.Drawing.Size(112, 21);
            this.campusSelect.TabIndex = 15;
            this.campusSelect.SelectedIndexChanged += new System.EventHandler(this.campusSelect_SelectedIndexChanged);
            // 
            // campusLbl
            // 
            this.campusLbl.AutoSize = true;
            this.campusLbl.Location = new System.Drawing.Point(454, 250);
            this.campusLbl.Name = "campusLbl";
            this.campusLbl.Size = new System.Drawing.Size(48, 13);
            this.campusLbl.TabIndex = 16;
            this.campusLbl.Text = "Campus:";
            this.campusLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Location = new System.Drawing.Point(572, 251);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(38, 13);
            this.roomLbl.TabIndex = 17;
            this.roomLbl.Text = "Room:";
            this.roomLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // shelfLbl
            // 
            this.shelfLbl.AutoSize = true;
            this.shelfLbl.Location = new System.Drawing.Point(635, 251);
            this.shelfLbl.Name = "shelfLbl";
            this.shelfLbl.Size = new System.Drawing.Size(34, 13);
            this.shelfLbl.TabIndex = 18;
            this.shelfLbl.Text = "Shelf:";
            // 
            // columnLbl
            // 
            this.columnLbl.AutoSize = true;
            this.columnLbl.Location = new System.Drawing.Point(691, 251);
            this.columnLbl.Name = "columnLbl";
            this.columnLbl.Size = new System.Drawing.Size(45, 13);
            this.columnLbl.TabIndex = 19;
            this.columnLbl.Text = "Column:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(457, 419);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(296, 23);
            this.submitBtn.TabIndex = 20;
            this.submitBtn.Text = "Submit Entry";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // enrollmentTxt
            // 
            this.enrollmentTxt.Location = new System.Drawing.Point(518, 393);
            this.enrollmentTxt.Name = "enrollmentTxt";
            this.enrollmentTxt.Size = new System.Drawing.Size(115, 20);
            this.enrollmentTxt.TabIndex = 22;
            this.enrollmentTxt.TextChanged += new System.EventHandler(this.enrollmentTxt_TextChanged);
            // 
            // enrollmentLbl
            // 
            this.enrollmentLbl.AutoSize = true;
            this.enrollmentLbl.Location = new System.Drawing.Point(460, 396);
            this.enrollmentLbl.Name = "enrollmentLbl";
            this.enrollmentLbl.Size = new System.Drawing.Size(59, 13);
            this.enrollmentLbl.TabIndex = 21;
            this.enrollmentLbl.Text = "Enrollment:";
            // 
            // enrollmentTxt2
            // 
            this.enrollmentTxt2.Location = new System.Drawing.Point(638, 393);
            this.enrollmentTxt2.Name = "enrollmentTxt2";
            this.enrollmentTxt2.Size = new System.Drawing.Size(115, 20);
            this.enrollmentTxt2.TabIndex = 23;
            // 
            // enrollmentFindTxt
            // 
            this.enrollmentFindTxt.Location = new System.Drawing.Point(638, 187);
            this.enrollmentFindTxt.Name = "enrollmentFindTxt";
            this.enrollmentFindTxt.Size = new System.Drawing.Size(115, 20);
            this.enrollmentFindTxt.TabIndex = 25;
            // 
            // enrollmentFindLbl
            // 
            this.enrollmentFindLbl.AutoSize = true;
            this.enrollmentFindLbl.Location = new System.Drawing.Point(580, 190);
            this.enrollmentFindLbl.Name = "enrollmentFindLbl";
            this.enrollmentFindLbl.Size = new System.Drawing.Size(59, 13);
            this.enrollmentFindLbl.TabIndex = 24;
            this.enrollmentFindLbl.Text = "Enrollment:";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(712, 213);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(41, 23);
            this.findBtn.TabIndex = 26;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // teacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 481);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.enrollmentFindTxt);
            this.Controls.Add(this.enrollmentFindLbl);
            this.Controls.Add(this.enrollmentTxt2);
            this.Controls.Add(this.enrollmentTxt);
            this.Controls.Add(this.enrollmentLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.columnLbl);
            this.Controls.Add(this.shelfLbl);
            this.Controls.Add(this.roomLbl);
            this.Controls.Add(this.campusLbl);
            this.Controls.Add(this.campusSelect);
            this.Controls.Add(this.columnComboBox);
            this.Controls.Add(this.shelfComboBox);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.newEntryBtn);
            this.Controls.Add(this.findFileBtn);
            this.Controls.Add(this.inventoryMngBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.signedInTxt);
            this.Controls.Add(this.BUKitLbl);
            this.Controls.Add(this.signedInAsLbl);
            this.Name = "teacherDashboard";
            this.Text = "Teacher - BU Kit";
            this.Load += new System.EventHandler(this.teacherDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.TextBox signedInTxt;
        private System.Windows.Forms.Label BUKitLbl;
        private System.Windows.Forms.Label signedInAsLbl;
        private System.Windows.Forms.Button inventoryMngBtn;
        private System.Windows.Forms.Button findFileBtn;
        private System.Windows.Forms.Button newEntryBtn;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.ComboBox shelfComboBox;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.ComboBox campusSelect;
        private System.Windows.Forms.Label campusLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Label shelfLbl;
        private System.Windows.Forms.Label columnLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox enrollmentTxt;
        private System.Windows.Forms.Label enrollmentLbl;
        private System.Windows.Forms.TextBox enrollmentTxt2;
        private System.Windows.Forms.TextBox enrollmentFindTxt;
        private System.Windows.Forms.Label enrollmentFindLbl;
        private System.Windows.Forms.Button findBtn;
    }
}