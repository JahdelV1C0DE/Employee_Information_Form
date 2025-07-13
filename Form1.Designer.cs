namespace White_Ch11._1
{
    partial class EmployeeProductionWorker
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
            this.NewEmpBtn = new System.Windows.Forms.Button();
            this.EmpBox = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.ShiftBox = new System.Windows.Forms.TextBox();
            this.WageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentUserBox = new System.Windows.Forms.ListBox();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.WageLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShiftLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NewSuperVisorBtn = new System.Windows.Forms.Button();
            this.AnnualBox = new System.Windows.Forms.TextBox();
            this.BonusBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewEmpBtn
            // 
            this.NewEmpBtn.Location = new System.Drawing.Point(50, 463);
            this.NewEmpBtn.Name = "NewEmpBtn";
            this.NewEmpBtn.Size = new System.Drawing.Size(158, 60);
            this.NewEmpBtn.TabIndex = 0;
            this.NewEmpBtn.Text = "Create New Employee";
            this.NewEmpBtn.UseVisualStyleBackColor = true;
            this.NewEmpBtn.Click += new System.EventHandler(this.NewEmpBtn_Click);
            // 
            // EmpBox
            // 
            this.EmpBox.FormattingEnabled = true;
            this.EmpBox.ItemHeight = 20;
            this.EmpBox.Location = new System.Drawing.Point(784, 74);
            this.EmpBox.Name = "EmpBox";
            this.EmpBox.Size = new System.Drawing.Size(528, 564);
            this.EmpBox.TabIndex = 2;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(566, 672);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(158, 60);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(392, 129);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(236, 26);
            this.NameBox.TabIndex = 4;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(392, 205);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(236, 26);
            this.NumberBox.TabIndex = 5;
            // 
            // ShiftBox
            // 
            this.ShiftBox.Location = new System.Drawing.Point(392, 309);
            this.ShiftBox.Name = "ShiftBox";
            this.ShiftBox.Size = new System.Drawing.Size(236, 26);
            this.ShiftBox.TabIndex = 6;
            this.ShiftBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShiftBox_KeyPress);
            // 
            // WageBox
            // 
            this.WageBox.Location = new System.Drawing.Point(392, 385);
            this.WageBox.Name = "WageBox";
            this.WageBox.Size = new System.Drawing.Size(236, 26);
            this.WageBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a New Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Create a New Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wage Per Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "1st or 2nd Shift (Nums Only)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Number";
            // 
            // CurrentUserBox
            // 
            this.CurrentUserBox.FormattingEnabled = true;
            this.CurrentUserBox.ItemHeight = 20;
            this.CurrentUserBox.Location = new System.Drawing.Point(32, 74);
            this.CurrentUserBox.Name = "CurrentUserBox";
            this.CurrentUserBox.Size = new System.Drawing.Size(280, 364);
            this.CurrentUserBox.TabIndex = 12;
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Location = new System.Drawing.Point(566, 606);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(158, 60);
            this.ShowAllBtn.TabIndex = 13;
            this.ShowAllBtn.Text = "Show All Employees";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // WageLbl
            // 
            this.WageLbl.AutoSize = true;
            this.WageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WageLbl.Location = new System.Drawing.Point(920, 697);
            this.WageLbl.Name = "WageLbl";
            this.WageLbl.Size = new System.Drawing.Size(89, 25);
            this.WageLbl.TabIndex = 14;
            this.WageLbl.Text = "#######";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1051, 707);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "1st or 2nd Shift:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(975, 652);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name: ";
            // 
            // ShiftLbl
            // 
            this.ShiftLbl.AutoSize = true;
            this.ShiftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftLbl.Location = new System.Drawing.Point(1234, 707);
            this.ShiftLbl.Name = "ShiftLbl";
            this.ShiftLbl.Size = new System.Drawing.Size(78, 25);
            this.ShiftLbl.TabIndex = 17;
            this.ShiftLbl.Text = "######";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(1101, 652);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(78, 25);
            this.NameLbl.TabIndex = 18;
            this.NameLbl.Text = "######";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(808, 697);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Wage Hr/";
            // 
            // NewSuperVisorBtn
            // 
            this.NewSuperVisorBtn.Location = new System.Drawing.Point(50, 555);
            this.NewSuperVisorBtn.Name = "NewSuperVisorBtn";
            this.NewSuperVisorBtn.Size = new System.Drawing.Size(158, 60);
            this.NewSuperVisorBtn.TabIndex = 22;
            this.NewSuperVisorBtn.Text = "Create New Supervisor";
            this.NewSuperVisorBtn.UseVisualStyleBackColor = true;
            this.NewSuperVisorBtn.Click += new System.EventHandler(this.NewSuperVisorBtn_Click);
            // 
            // AnnualBox
            // 
            this.AnnualBox.Location = new System.Drawing.Point(392, 455);
            this.AnnualBox.Name = "AnnualBox";
            this.AnnualBox.Size = new System.Drawing.Size(236, 26);
            this.AnnualBox.TabIndex = 23;
            // 
            // BonusBox
            // 
            this.BonusBox.Location = new System.Drawing.Point(392, 540);
            this.BonusBox.Name = "BonusBox";
            this.BonusBox.Size = new System.Drawing.Size(236, 26);
            this.BonusBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Annual Wage (Supervisor Only)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(405, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Production Bonus (Supervisor Only)";
            // 
            // EmployeeProductionWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 899);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BonusBox);
            this.Controls.Add(this.AnnualBox);
            this.Controls.Add(this.NewSuperVisorBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ShiftLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WageLbl);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.CurrentUserBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WageBox);
            this.Controls.Add(this.ShiftBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EmpBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewEmpBtn);
            this.Name = "EmployeeProductionWorker";
            this.Text = "Production Worker Info";
            this.Load += new System.EventHandler(this.EmployeeProductionWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewEmpBtn;
        private System.Windows.Forms.ListBox EmpBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox ShiftBox;
        private System.Windows.Forms.TextBox WageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox CurrentUserBox;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.Label WageLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ShiftLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button NewSuperVisorBtn;
        private System.Windows.Forms.TextBox AnnualBox;
        private System.Windows.Forms.TextBox BonusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
    }
}

