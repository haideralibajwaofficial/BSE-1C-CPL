namespace BU_Kit
{
    partial class studentDashboard
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
            this.signedInAsLbl = new System.Windows.Forms.Label();
            this.BUKitLbl = new System.Windows.Forms.Label();
            this.signedInTxt = new System.Windows.Forms.TextBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.calculatorBtn = new System.Windows.Forms.Button();
            this.value1stTxt = new System.Windows.Forms.TextBox();
            this.value2ndTxt = new System.Windows.Forms.TextBox();
            this.valueResultTxt = new System.Windows.Forms.TextBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.rootBtn = new System.Windows.Forms.Button();
            this.sinBtn = new System.Windows.Forms.Button();
            this.cosBtn = new System.Windows.Forms.Button();
            this.tanBtn = new System.Windows.Forms.Button();
            this.factBtn = new System.Windows.Forms.Button();
            this.pBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signedInAsLbl
            // 
            this.signedInAsLbl.AutoSize = true;
            this.signedInAsLbl.Location = new System.Drawing.Point(231, 103);
            this.signedInAsLbl.Name = "signedInAsLbl";
            this.signedInAsLbl.Size = new System.Drawing.Size(68, 13);
            this.signedInAsLbl.TabIndex = 0;
            this.signedInAsLbl.Text = "Signed in as:";
            // 
            // BUKitLbl
            // 
            this.BUKitLbl.AutoSize = true;
            this.BUKitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUKitLbl.Location = new System.Drawing.Point(279, 9);
            this.BUKitLbl.Name = "BUKitLbl";
            this.BUKitLbl.Size = new System.Drawing.Size(219, 73);
            this.BUKitLbl.TabIndex = 1;
            this.BUKitLbl.Text = "BU Kit";
            // 
            // signedInTxt
            // 
            this.signedInTxt.Location = new System.Drawing.Point(305, 100);
            this.signedInTxt.Name = "signedInTxt";
            this.signedInTxt.ReadOnly = true;
            this.signedInTxt.Size = new System.Drawing.Size(151, 20);
            this.signedInTxt.TabIndex = 2;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(462, 97);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // calculatorBtn
            // 
            this.calculatorBtn.Location = new System.Drawing.Point(344, 152);
            this.calculatorBtn.Name = "calculatorBtn";
            this.calculatorBtn.Size = new System.Drawing.Size(75, 23);
            this.calculatorBtn.TabIndex = 4;
            this.calculatorBtn.Text = "Calculator";
            this.calculatorBtn.UseVisualStyleBackColor = true;
            this.calculatorBtn.Click += new System.EventHandler(this.calculatorBtn_Click);
            // 
            // value1stTxt
            // 
            this.value1stTxt.Location = new System.Drawing.Point(450, 157);
            this.value1stTxt.Name = "value1stTxt";
            this.value1stTxt.Size = new System.Drawing.Size(97, 20);
            this.value1stTxt.TabIndex = 5;
            // 
            // value2ndTxt
            // 
            this.value2ndTxt.Location = new System.Drawing.Point(645, 157);
            this.value2ndTxt.Name = "value2ndTxt";
            this.value2ndTxt.ReadOnly = true;
            this.value2ndTxt.Size = new System.Drawing.Size(97, 20);
            this.value2ndTxt.TabIndex = 6;
            // 
            // valueResultTxt
            // 
            this.valueResultTxt.Location = new System.Drawing.Point(450, 212);
            this.valueResultTxt.Name = "valueResultTxt";
            this.valueResultTxt.ReadOnly = true;
            this.valueResultTxt.Size = new System.Drawing.Size(292, 20);
            this.valueResultTxt.TabIndex = 7;
            this.valueResultTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(553, 155);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(17, 23);
            this.plusBtn.TabIndex = 8;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(622, 155);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(17, 23);
            this.divideBtn.TabIndex = 9;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(599, 155);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(17, 23);
            this.multiplyBtn.TabIndex = 10;
            this.multiplyBtn.Text = "x";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // rootBtn
            // 
            this.rootBtn.Location = new System.Drawing.Point(450, 183);
            this.rootBtn.Name = "rootBtn";
            this.rootBtn.Size = new System.Drawing.Size(17, 23);
            this.rootBtn.TabIndex = 12;
            this.rootBtn.Text = "√";
            this.rootBtn.UseVisualStyleBackColor = true;
            this.rootBtn.Click += new System.EventHandler(this.rootBtn_Click);
            // 
            // sinBtn
            // 
            this.sinBtn.Location = new System.Drawing.Point(473, 183);
            this.sinBtn.Name = "sinBtn";
            this.sinBtn.Size = new System.Drawing.Size(41, 23);
            this.sinBtn.TabIndex = 13;
            this.sinBtn.Text = "sin( )";
            this.sinBtn.UseVisualStyleBackColor = true;
            this.sinBtn.Click += new System.EventHandler(this.sinBtn_Click);
            // 
            // cosBtn
            // 
            this.cosBtn.Location = new System.Drawing.Point(520, 183);
            this.cosBtn.Name = "cosBtn";
            this.cosBtn.Size = new System.Drawing.Size(41, 23);
            this.cosBtn.TabIndex = 14;
            this.cosBtn.Text = "cos( )";
            this.cosBtn.UseVisualStyleBackColor = true;
            this.cosBtn.Click += new System.EventHandler(this.cosBtn_Click_1);
            // 
            // tanBtn
            // 
            this.tanBtn.Location = new System.Drawing.Point(567, 183);
            this.tanBtn.Name = "tanBtn";
            this.tanBtn.Size = new System.Drawing.Size(41, 23);
            this.tanBtn.TabIndex = 15;
            this.tanBtn.Text = "tan( )";
            this.tanBtn.UseVisualStyleBackColor = true;
            this.tanBtn.Click += new System.EventHandler(this.tanBtn_Click);
            // 
            // factBtn
            // 
            this.factBtn.Location = new System.Drawing.Point(614, 183);
            this.factBtn.Name = "factBtn";
            this.factBtn.Size = new System.Drawing.Size(25, 23);
            this.factBtn.TabIndex = 16;
            this.factBtn.Text = "x!";
            this.factBtn.UseVisualStyleBackColor = true;
            this.factBtn.Click += new System.EventHandler(this.factBtn_Click);
            // 
            // pBtn
            // 
            this.pBtn.Location = new System.Drawing.Point(645, 183);
            this.pBtn.Name = "pBtn";
            this.pBtn.Size = new System.Drawing.Size(45, 23);
            this.pBtn.TabIndex = 17;
            this.pBtn.Text = "Power";
            this.pBtn.UseVisualStyleBackColor = true;
            this.pBtn.Click += new System.EventHandler(this.pBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.Location = new System.Drawing.Point(696, 183);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(17, 23);
            this.cBtn.TabIndex = 18;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(719, 183);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(23, 23);
            this.equalBtn.TabIndex = 19;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(576, 155);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(17, 23);
            this.minusBtn.TabIndex = 20;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // studentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.pBtn);
            this.Controls.Add(this.factBtn);
            this.Controls.Add(this.tanBtn);
            this.Controls.Add(this.cosBtn);
            this.Controls.Add(this.sinBtn);
            this.Controls.Add(this.rootBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.valueResultTxt);
            this.Controls.Add(this.value2ndTxt);
            this.Controls.Add(this.value1stTxt);
            this.Controls.Add(this.calculatorBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.signedInTxt);
            this.Controls.Add(this.BUKitLbl);
            this.Controls.Add(this.signedInAsLbl);
            this.Name = "studentDashboard";
            this.Text = "BU Kit - Student Dashboard";
            this.Load += new System.EventHandler(this.studentDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signedInAsLbl;
        private System.Windows.Forms.Label BUKitLbl;
        private System.Windows.Forms.TextBox signedInTxt;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button calculatorBtn;
        private System.Windows.Forms.TextBox value1stTxt;
        private System.Windows.Forms.TextBox value2ndTxt;
        private System.Windows.Forms.TextBox valueResultTxt;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button rootBtn;
        private System.Windows.Forms.Button sinBtn;
        private System.Windows.Forms.Button cosBtn;
        private System.Windows.Forms.Button tanBtn;
        private System.Windows.Forms.Button factBtn;
        private System.Windows.Forms.Button pBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button minusBtn;
    }
}