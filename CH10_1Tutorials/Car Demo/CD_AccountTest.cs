using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Demo
{
    public partial class CD_AccountTest : Form
    {
        public CD_AccountTest()
        {
            InitializeComponent();
        }

        private void GetCDData(SavingsAccount savings)
        {
            decimal interestRate;
            decimal balance;

            // Get the account number
            savings.AccountNumber = tbAccountNumber.Text;

            // Get the maturity date
            savings.MaturityDate = tbMatunityDate.Text;

            //Get the interest Rate
            if (decimal.TryParse(tbInterestRate.Text, out interestRate))
            {
                savings.InterestRate = interestRate;

                //Get the balance
                if (decimal.TryParse(tbBalance.Text, out balance))
                {
                    savings.Balance = balance;
                }
                else
                {
                    // Display error message
                    MessageBox.Show("Invalid Balance");
                }
            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid Interest Rate");
            }
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            // Create the savings account object
            SavingsAccount savings = new SavingsAccount();

            // Get the CD Account Data
            GetCDData(savings);

            // Display the CD Account Data
            lblAccountNumber.Text = savings.AccountNumber;
            lblInterestRate.Text = savings.InterestRate.ToString();
            lblBalance.Text = savings.Balance.ToString();
            lblMaturityDate.Text = savings.MaturityDate;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
