using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Insane
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            requestBtn.Enabled = false;
        }

        private void controlButtons()
        {
            if(nameBox.Text.Trim() != string.Empty && nameBox.Text.All(char.IsLetter)){
                requestBtn.Enabled = true;
                errorProvider1.SetError(nameBox, "");
            }
            else{
                if (!(nameBox.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(nameBox, "Name should only contain letters");
                }
                else{
                    errorProvider1.SetError(nameBox, "You must introduce your name");
                }
                requestBtn.Enabled = false;
                nameBox.Focus();
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            controlButtons();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            using(Loans windowLoans = new Loans(nameBox.Text)){
                windowLoans.ShowDialog();
            }
        }
    }
}
