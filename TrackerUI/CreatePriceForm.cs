using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePriceForm : Form
    {
        public CreatePriceForm()
        {
            InitializeComponent();
        }

        private void createPriceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameTextBox.Text, 
                    placeNameTextBox.Text, 
                    prizeAmountTextBox.Text, 
                    prizePercentTextBox.Text);
                
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out decimal prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentTextBox.Text, out double prizePercentage);
            bool placeNumberValid = int.TryParse(placeNumberTextBox.Text, out int placeNumber);

            if (!placeNumberValid || !prizePercentageValid || !prizeAmountValid) output = false;

            if (placeNumber < 1) output = false;

            if (placeNameTextBox.Text == null) output = false;

            if (prizeAmount <= 0 && prizePercentage <= 0) output = false;

            if (prizePercentage < 0 || prizePercentage > 100) output = false;

            return output;
        }
    }
}
