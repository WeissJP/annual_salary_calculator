using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace annual_salary_calculator
{
    public partial class annual_salary_calculator : Form
    {
        public annual_salary_calculator()
        {
            InitializeComponent();
        }

        private void annual_salary_calculator_Load(object sender, EventArgs e)
        {
            rdbFullTime.Checked = true;
            lblHoursPerWeek.Enabled = false;
            numUpDwnHours.Enabled = false;
            this.MinimumSize = new Size(400, 350);
            this.MaximumSize = new Size(400, 350);
        }

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {
            decimal hourlyRate;
            int workHours;
            const int WeeksPerYear = 52;

            //Start data validation
            if (txtEnterRate.Text.Length == 0)
            {
                MessageBox.Show("Please enter a pay rate.");
                return;
            }

            if (decimal.TryParse(txtEnterRate.Text, out hourlyRate) == false)
            {
                MessageBox.Show("Invalid hourly pay rate.");
                txtEnterRate.Focus();
                txtEnterRate.SelectAll();
                return;
            }
            //End data validation

            if (rdbFullTime.Checked)
            {
                workHours = 40;
            }
            else
            {
                workHours = (int)numUpDwnHours.Value;
            }

            decimal annualSalary = hourlyRate * workHours * WeeksPerYear;
            lblResult.Text = annualSalary.ToString("C2");
        }
        private void rdbPartTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartTime.Checked)
            {
                lblHoursPerWeek.Enabled = true;
                numUpDwnHours.Enabled = true;
            }
            else
            {
                lblHoursPerWeek.Enabled = false;
                numUpDwnHours.Enabled = false;
            }
        }

        private void numUpDwnHours_TextHighlight(object sender, EventArgs e)
        {
            numUpDwnHours.Select(0, 2);
        }

        private void txtEnterRate_TextHighlight(object sender, EventArgs e)
        {
            txtEnterRate.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterRate.Clear();
            numUpDwnHours.Value = 1;
            lblResult.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
