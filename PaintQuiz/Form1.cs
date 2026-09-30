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
        const decimal decPricePersquareMater = 8.50m;
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


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
