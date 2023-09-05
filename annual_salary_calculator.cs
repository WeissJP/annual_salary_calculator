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
            txtEnterHours.Enabled = false;
        }

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {
            decimal hourlyRate;
            int workHours;
            const int WeeksPerYear = 52;

            if (txtEnterRate.Text.Length == 0)
            {
                MessageBox.Show("Please enter a pay rate.");
                return;
            }

            if ((rdbPartTime.Checked == true) && (int.TryParse(txtEnterHours.Text, out workHours) == false))
            {
                MessageBox.Show("Invalid weekly hours.");
                txtEnterHours.Focus();
                txtEnterHours.SelectAll();
                return;
            }

            if (decimal.TryParse(txtEnterRate.Text, out hourlyRate) == false)
            {
                MessageBox.Show("Invalid hourly pay rate.");
                txtEnterRate.Focus();
                txtEnterRate.SelectAll();
                return;
            }

            if (rdbFullTime.Checked)
            {
                workHours = 40;
            }
            else
            {
                workHours = int.Parse(txtEnterHours.Text);
            }

            decimal annualSalary;
            annualSalary = hourlyRate * workHours * WeeksPerYear;
                
            lblResult.Text = annualSalary.ToString("C2");
        }
        private void rdbPartTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartTime.Checked)
            {
                lblHoursPerWeek.Enabled = true;
                txtEnterHours.Enabled = true;
            }
            else
            {
                lblHoursPerWeek.Enabled = false;
                txtEnterHours.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterRate.Clear();
            txtEnterHours.Clear();
            lblResult.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
