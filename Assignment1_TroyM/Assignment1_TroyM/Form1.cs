// Name: Troy Mouton.
// File: Assignment1_TroyM.
// Date: 2023-09-18.
// Description: Program that takes 7 inputs from the user, and finds the average of them.

namespace Assignment1_TroyM
{
    public partial class Form1 : Form
    {
        // Declares the total sales and day counter variables.
        decimal runningSalesTotal = 0;
        int day = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Method that closes the form.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxGameSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxEntries_TextChanged(object sender, EventArgs e)
        {

        }

        // Function that uses TryParse to check if input fields are numeric (borrowed from stack overflow).
        private bool IsNumeric(string s) => decimal.TryParse(s, out var value);

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Declaring sales variable to be sent to Entries box.
            // (Set dailySales to -1 and not 0 to ensure failed isNumeric checks also fail at second if statement).
            decimal dailySales = -1;

            // Creates a variable that stores the validated value from the text box if the value IsNumeric.
            if (IsNumeric(textBoxGameSale.Text))
            {
                dailySales = Convert.ToDecimal(textBoxGameSale.Text);
            }

            // Validates that daily sale input is a whole number.
            if (dailySales - (int)dailySales == 0 && dailySales >= 0)
            {
                // Increases day counter if validation is successful.
                day++;

                // Appends the Entries box once input has been validated.
                richTextBoxEntries.AppendText(dailySales.ToString() + "\r\n");
                runningSalesTotal += (int)dailySales;

                labelDayDisplay.Text = "Day " + day.ToString();
            }
            // If validation fails, this else statement displays an error message within a message box.
            else
            {
                MessageBox.Show("ERROR: \tInput must be a whole number \n\tgreater than 0!");
            }

            // Clear and refocus sales box after field is entered.
            textBoxGameSale.Clear();
            textBoxGameSale.Focus();

            if (day > 7)
            {
                /* Declares sales average by dividing the total sales by 7, then prints the output into the
                 output text box. */
                decimal averageWeeklySales = 0;
                averageWeeklySales = runningSalesTotal / 7;
                textBoxAverage.Text = "Average Video Game Sales: " + averageWeeklySales.ToString("c");

                // Hides day counter label and disables sales input box.
                labelDayDisplay.Visible = false;
                textBoxGameSale.Enabled = false;
            }
        }

        private void labelDayDisplay_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Resets global variables and labels.
            runningSalesTotal = 0;
            day = 1;
            labelDayDisplay.Text = "Day 1";

            // Enables input text box and day display.
            textBoxGameSale.Enabled = true;
            labelDayDisplay.Visible = true;
            labelDayDisplay.Text = "Day 1";

            // Clears all text boxes when reset button is clicked.
            textBoxGameSale.Clear();
            textBoxGameSale.Focus();
            textBoxAverage.Clear();
            richTextBoxEntries.Clear();
        }
    }
}