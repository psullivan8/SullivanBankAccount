//Patrik Sullivan psullivan8@cnm.edu
//SullivanBankAccount
//6-25-20

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SullivanBankAccount
{
    public partial class Form1 : Form
    {
        BankAcct[] accounts = new BankAcct[3];
        private List<String> transactions = new List<String>();
        public Form1()
        {
            InitializeComponent();
            accounts[0] = new BankAcct("TBD", 1, 500M);
            accounts[1] = new SilverAcct("TBD", 2, 1500M, 1, 1234);
            accounts[2] = new GoldAcct("TBD", 3, 25000M, 2, 1234, 1.0);
            rbDeposit.Checked = true;
        }

        private void cmbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of the account type
            int acctType = cmbxType.SelectedIndex;
            //if index is 0, display default layout
            switch(acctType)
            {
                case 0:
                    //Display default layout
                    lblATMAcctNum.Visible = false;
                    txtATMAcctNum.Visible = false;
                    lblATMPIN.Visible = false;
                    txtATMPIN.Visible = false;
                    lblPercent.Visible = false;
                    txtPercent.Visible = false;
                    break;
                case 1:
                    //Display ATM box and PIN box
                    lblATMAcctNum.Visible = true;
                    txtATMAcctNum.Visible = true;
                    lblATMPIN.Visible = true;
                    txtATMPIN.Visible = true;
                    break;
                case 2:
                    //Display ATM box and PIN box
                    //Also display the interest
                    lblATMAcctNum.Visible = true;
                    txtATMAcctNum.Visible = true;
                    lblATMPIN.Visible = true;
                    txtATMPIN.Visible = true;
                    lblPercent.Visible = true;
                    txtPercent.Visible = true;
                    break;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Get the index of the account type
            int index = cmbxType.SelectedIndex;
            //Does not need downcasting because we will be doing deposits and
            //withdrawals and they are overridden. We can just use the array.
            try
            {
                if (rbDeposit.Checked == true)
                {
                    //Read in the amount
                    decimal amount = decimal.Parse(txtAmount.Text);
                    //Deposit the amount to the account balance
                    accounts[index].Deposit(amount);
                    //Add the transaction to the list of transactions
                    transactions.Add("Deposited " + amount.ToString("C") + " to Account " + accounts[index].AcctNum);
                    //Refresh the list box
                    lbTransactions.DataSource = null;
                    lbTransactions.DataSource = transactions;
                    //Print the updated account information to the Results box
                    txtResults.Text = accounts[index].ToString();
                }
                else
                {
                    //Read in the amount
                    decimal amount = decimal.Parse(txtAmount.Text);
                    //Withdraw the amount from the account balance
                    accounts[index].Withdraw(amount);
                    //Add the transaction to the list of transactions
                    transactions.Add("Withdrew " + amount.ToString("C") + " from Account " + accounts[index].AcctNum);
                    //Refresh the list box
                    lbTransactions.DataSource = null;
                    lbTransactions.DataSource = transactions;
                    //Print the updated account information to the Results box
                    txtResults.Text = accounts[index].ToString();
                }
            }
            catch(Exception exc)
            {
                //Print the error message to the Results box
                txtResults.Text = (exc.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            rbDeposit.Checked = true;
            txtResults.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the index of the account type
            int index = cmbxType.SelectedIndex;
            try
            {
                //Get the index of the account type
                accounts[index].Name = txtName.Text;
                //Updates the object of the appropriate class with the user info
                accounts[index].AcctNum = int.Parse(txtAcctNum.Text);
                switch (index)
                {
                    case 0:
                        break;
                    //For Silver and Gold:
                    case 1:
                        //using downcasting, set ATM Acct Num and PIN
                        SilverAcct newSilverAcct = (SilverAcct)accounts[1];
                        newSilverAcct.ATMAccount = int.Parse(txtATMAcctNum.Text);
                        newSilverAcct.PIN = int.Parse(txtATMPIN.Text);
                        break;
                    case 2:
                        //For Gold, set the interest rate
                        GoldAcct newGoldAcct = (GoldAcct)accounts[2];
                        newGoldAcct.ATMAccount = int.Parse(txtATMAcctNum.Text);
                        newGoldAcct.PIN = int.Parse(txtATMPIN.Text);
                        newGoldAcct.Interest = double.Parse(txtPercent.Text);
                        break;
                }
            }
            catch (Exception exc)
            {

            }
        }
    }
}
