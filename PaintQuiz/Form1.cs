namespace PaintQuiz
{
    public partial class Form1 : Form
    {
        double dblWidth = 0;
        double dblHeight = 0;
        double dblArea = 0;
        decimal decSubtotal;
        decimal decTax;
        decimal decTotalWithTax;
        const decimal decPricePerSquareMetre = 8.50m;
        const decimal decTaxRate = 0.05m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";

                dblWidth = double.Parse(txtWidth.Text);
                dblHeight = double.Parse(txtHeight.Text);

                dblArea = dblWidth * dblHeight;
                decSubtotal = (decimal)dblArea * decPricePerSquareMetre;

                txtArea.Text = dblArea.ToString("N2");
                lblSubtotal.Text = decSubtotal.ToString("C");

                


            }
            catch (FormatException)
            {
                lblError.Text = "Please enter a proper number";
            }
        }

        

        private void btnTotalTax_Click(object sender, EventArgs e)
        {
            
            decTax = decSubtotal * decTaxRate;
            decTotalWithTax = decSubtotal + decTax;

            lblTax.Text = decTax.ToString("C");
            lblTotalWithTax.Text = decTotalWithTax.ToString("C");

            
        }
    }
}
