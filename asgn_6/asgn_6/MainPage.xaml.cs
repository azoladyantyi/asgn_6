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
        Customer newCustomer;
        BankAccount account;
        public MainPage()
        {

            InitializeComponent();
            fnb = new Bank("First National Bank", 41515, "Kenilworth");
            newCustomer = new Customer("776645424", "10 me at Home", "Bob", "The builder");
            fnb.AddCustomer(newCustomer);
            account = newCustomer.ApplyForBankAccount();

        }
        private async void ButtonToDeposit_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(Deposit_Money.Text.ToString());
            string reason = Dep_reason.Text.ToString();
            account.DepositMoney(amount, DateTime.Now, reason);
            await DisplayAlert("Information!", $"You have deposted R{amount}", "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            input.Text = "Hey please choose the option provided!";
        }
    }
}
