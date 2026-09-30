namespace PaintQuiz
{
    public partial class Form1 : Form
    {
        double dblWidth;

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
