using System;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtNum1.Text);
                float b = float.Parse(txtNum2.Text);

                float result = 0;

                switch (cmbOperator.SelectedItem.ToString())
                {
                    case "+":
                        result = BasicComputation.add(a, b);
                        break;
                    case "-":
                        result = BasicComputation.subtract(a, b);
                        break;
                    case "*":
                        result = BasicComputation.multiply(a, b);
                        break;
                    case "/":
                        result = BasicComputation.divide(a, b);
                        break;
                }
                if (b == 0)
                    MessageBox.Show("Cannot be divided by 0");
                else
                lblTotal.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }
    }
}
