namespace annual_salary_calculator
{
    partial class annual_salary_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.btnCalcSalary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpEmplyType = new System.Windows.Forms.GroupBox();
            this.rdbPartTime = new System.Windows.Forms.RadioButton();
            this.rdbFullTime = new System.Windows.Forms.RadioButton();
            this.txtEnterRate = new System.Windows.Forms.TextBox();
            this.numUpDwnHours = new System.Windows.Forms.NumericUpDown();
            this.grpEmplyType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your hourly pay rate:";
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPerWeek.Location = new System.Drawing.Point(29, 136);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(212, 16);
            this.lblHoursPerWeek.TabIndex = 2;
            this.lblHoursPerWeek.Text = "Enter the hours you work per week:";
            // 
            // btnCalcSalary
            // 
            this.btnCalcSalary.Location = new System.Drawing.Point(31, 174);
            this.btnCalcSalary.Name = "btnCalcSalary";
            this.btnCalcSalary.Size = new System.Drawing.Size(102, 32);
            this.btnCalcSalary.TabIndex = 4;
            this.btnCalcSalary.Text = "Calculate";
            this.btnCalcSalary.UseVisualStyleBackColor = true;
            this.btnCalcSalary.Click += new System.EventHandler(this.btnCalcSalary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(247, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your annual gross salary is:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(247, 255);
            this.lblResult.MinimumSize = new System.Drawing.Size(100, 2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 22);
            this.lblResult.TabIndex = 8;
            // 
            // grpEmplyType
            // 
            this.grpEmplyType.Controls.Add(this.rdbPartTime);
            this.grpEmplyType.Controls.Add(this.rdbFullTime);
            this.grpEmplyType.Location = new System.Drawing.Point(167, 30);
            this.grpEmplyType.Name = "grpEmplyType";
            this.grpEmplyType.Size = new System.Drawing.Size(157, 48);
            this.grpEmplyType.TabIndex = 9;
            this.grpEmplyType.TabStop = false;
            this.grpEmplyType.Text = "Employment Type";
            // 
            // rdbPartTime
            // 
            this.rdbPartTime.AutoSize = true;
            this.rdbPartTime.Location = new System.Drawing.Point(85, 19);
            this.rdbPartTime.Name = "rdbPartTime";
            this.rdbPartTime.Size = new System.Drawing.Size(66, 17);
            this.rdbPartTime.TabIndex = 1;
            this.rdbPartTime.TabStop = true;
            this.rdbPartTime.Text = "Part-time";
            this.rdbPartTime.UseVisualStyleBackColor = true;
            this.rdbPartTime.CheckedChanged += new System.EventHandler(this.rdbPartTime_CheckedChanged);
            // 
            // rdbFullTime
            // 
            this.rdbFullTime.AutoSize = true;
            this.rdbFullTime.Location = new System.Drawing.Point(6, 19);
            this.rdbFullTime.Name = "rdbFullTime";
            this.rdbFullTime.Size = new System.Drawing.Size(63, 17);
            this.rdbFullTime.TabIndex = 0;
            this.rdbFullTime.TabStop = true;
            this.rdbFullTime.Text = "Full-time";
            this.rdbFullTime.UseVisualStyleBackColor = true;
            // 
            // txtEnterRate
            // 
            this.txtEnterRate.Location = new System.Drawing.Point(247, 104);
            this.txtEnterRate.Name = "txtEnterRate";
            this.txtEnterRate.Size = new System.Drawing.Size(77, 20);
            this.txtEnterRate.TabIndex = 2;
            this.txtEnterRate.Enter += new System.EventHandler(this.txtEnterRate_TextHighlight);
            this.txtEnterRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEnterRate_TextHighlight);
            // 
            // numUpDwnHours
            // 
            this.numUpDwnHours.Location = new System.Drawing.Point(247, 136);
            this.numUpDwnHours.Maximum = new decimal(new int[] {
            39,
            0,
            0,
            0});
            this.numUpDwnHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwnHours.Name = "numUpDwnHours";
            this.numUpDwnHours.Size = new System.Drawing.Size(77, 20);
            this.numUpDwnHours.TabIndex = 3;
            this.numUpDwnHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwnHours.Enter += new System.EventHandler(this.numUpDwnHours_TextHighlight);
            this.numUpDwnHours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numUpDwnHours_TextHighlight);
            // 
            // annual_salary_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 335);
            this.Controls.Add(this.numUpDwnHours);
            this.Controls.Add(this.txtEnterRate);
            this.Controls.Add(this.grpEmplyType);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHoursPerWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcSalary);
            this.Name = "annual_salary_calculator";
            this.Text = "Annual Gross Salary Calculator";
            this.Load += new System.EventHandler(this.annual_salary_calculator_Load);
            this.grpEmplyType.ResumeLayout(false);
            this.grpEmplyType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.Button btnCalcSalary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpEmplyType;
        private System.Windows.Forms.RadioButton rdbFullTime;
        private System.Windows.Forms.RadioButton rdbPartTime;
        private System.Windows.Forms.TextBox txtEnterRate;
        private System.Windows.Forms.NumericUpDown numUpDwnHours;
    }
}

