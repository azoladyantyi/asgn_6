using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;

namespace asgn_6
{
    public partial class MainPage : ContentPage
    {

        Bank fnb;
        Customer newCustomerInfo;
        BankAccount accountNum;
        public MainPage()
        {

            InitializeComponent();
            fnb = new Bank("First National Bank", 25123, "Cape Town");
            newCustomerInfo = new Customer("6574746878", "16581 Diya Street", "Philippi", "7750");
            fnb.AddCustomer(newCustomerInfo);
            accountNum = newCustomerInfo.ApplyForBankAccount();

        }
        private async void ButtonToDeposit_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(Deposit_Money.Text.ToString());
            string reason = Dep_reason.Text.ToString();
            accountNum.DepositMoney(amount, DateTime.Now, reason);
            await DisplayAlert("Information!", $"You have deposted R{amount}", "Ok");
        }

        private async void ButtonToWithdraw_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(Withdraw_Money.Text.ToString());
            string reason = reason_withdraw.Text.ToString();
            accountNum.WithdrawMoney(amount, DateTime.Now, reason);
            await DisplayAlert("Information!", $"You have widthdrawn R{amount}", "Ok");
        }
        private void ButtonToTransactions_Clicked(object sender, EventArgs e)
        {
            string history = accountNum.GetTransactionHistory();
            TransactionHistory.Text = history;
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            input.Text = "Hey please choose the option provided!";
        }
    }
}
