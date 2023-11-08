namespace TaxiFareWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void predicateButton_Click(object sender, EventArgs e)
        {
            string vendor_id = comboBox1.Text;
            float rate_code=float.Parse(comboBox2.Text);
            float passenger_count=float.Parse(comboBox3.Text);
            float trip_distance=float.Parse(textBox1.Text);
            string payment_type=comboBox4.Text;

            TaxiFarePrediction.ModelInput Data = new TaxiFarePrediction.ModelInput()
            {
                Vendor_id = vendor_id,
                Rate_code = rate_code,
                Passenger_count = passenger_count,
                Trip_distance = trip_distance,
                Payment_type = payment_type,
            };

            var predicateResult=TaxiFarePrediction.Predict(Data);

            this.resultLabel.Text = predicateResult.Score.ToString();
        }
    }
}