using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Insane
{
    public partial class Loans : Form
    {
        string client_Name;
        string[] disp_Sex = {"Male", "Female", "Non-Binary"};
        int[] disp_Fees = {12, 24, 36, 60, 120, 180, 240};
        string[] countries_Disp;
        Dictionary<int, double> base_Interests;

        public Loans(string name)
        {
            InitializeComponent();
            client_Name = name;

            string countries_List = Properties.Resources.countriesList.ToString();
            countries_Disp = countries_List.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            base_Interests = new Dictionary<int, double>();
            int i;
            double interest;
            for(i = 0, interest = 3; i < disp_Fees.Length; i++, interest+= 0.5){
                base_Interests[disp_Fees[i]] = interest;
            }
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            popular_Fees();
            popular_sex();
            popular_Countries();
            welcome.Text += client_Name;
        }

        void popular_Fees(){
            for(int i = 0; i < disp_Fees.Length; i++){
                feesCB.Items.Add(disp_Fees[i]);
            }
        }

        void popular_sex(){
            for(int i = 0; i < disp_Sex.Length; i++){
                sexCB.Items.Add(disp_Sex[i]);
            }
        }

        void popular_Countries(){
            for(int i = 0; i < countries_Disp.Length; i++){
                countriesCB.Items.Add(countries_Disp[i]);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calculateInterest(){
            int orders_fees = (int)feesCB.SelectedItem;
            string select_country = countriesCB.SelectedItem.ToString().ToLower();
            double interest = base_Interests[orders_fees];

            if (new[] {"United States", "United Kingdom", "Australia", "Saudi Arabia"}.Contains(select_country))
            {
                interest += 0.3;
            }
            if (new[] {"Mexico", "Japan", "South Africa", "El Salvador", "Guatemala", "Argentina", "Chile" }.Contains(select_country)){
                interest -= 0.3;
            }

            return interest;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (validations())
            {
                case 0:
                    {
                        errorProvider1.SetError(perInfo, "");
                        errorProvider1.SetError(loansDet, "");
                        double monthly_interest = calculateInterest();
                        double amount_ordered = double.Parse(amountBox.Text);
                        int fees_ordered = (int)feesCB.SelectedItem;
                        double total_interest = amount_ordered * (monthly_interest / 100) * fees_ordered;
                        double amount_to_pay = amount_ordered + total_interest;
                        string message = "Your loan for " + amount_ordered + " in " + fees_ordered + " installments it will be granted with an interest of the " 
                            + monthly_interest + "% monthly\nThe final amount amounts to " + amount_to_pay;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, "Calculation of interest", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(perInfo, "You must complete all personal data");
                        errorProvider1.SetError(loansDet, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(loansDet, "You must enter a numerical amount and a number of installments");
                        errorProvider1.SetError(perInfo, "");
                        break;
                    }
            }
        }

        int validations()
        {
            if((sexCB.SelectedIndex <= -1) || (countriesCB.SelectedIndex <= -1)){
                return 1;
            }
            else
            {
                if(!(amountBox.Text.All(char.IsDigit)) || (amountBox.Text == "") || (feesCB.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
