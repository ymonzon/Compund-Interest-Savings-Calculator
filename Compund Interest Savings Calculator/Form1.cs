namespace Compund_Interest_Savings_Calculator
{
    public partial class Form1 : Form
    {
        double initial = 1000;
        double years = 10;
        double interest = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAmountSaved.Text = Convert.ToString(initial);
            txtInterestRate.Text = Convert.ToString(interest);
            txtYears.Text = Convert.ToString(years);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            interest++;
            txtInterestRate.Text = Convert.ToString(interest);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            interest--;
            if (interest > 0)
            {
                txtInterestRate.Text = Convert.ToString(interest);
            }
            else
            {
                interest = 0;
                txtInterestRate.Text = Convert.ToString(interest);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initial = 1000;
            years = 10;
            interest = 5;

            txtAmountSaved.Text = Convert.ToString(initial);
            txtInterestRate.Text = Convert.ToString(interest);
            txtYears.Text = Convert.ToString(years);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            initial = Convert.ToDouble(txtAmountSaved.Text);
            years = Convert.ToDouble(txtYears.Text);
            interest = Convert.ToDouble(txtInterestRate.Text);

            double total_interest = initial * interest * years / 100;
            double total = initial + total_interest;
            lblAnswer.Text = String.Format("{0:0.00}", total);
        }
    }
}