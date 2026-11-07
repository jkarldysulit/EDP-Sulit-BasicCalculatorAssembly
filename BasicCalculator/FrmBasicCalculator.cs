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
                if (!float.TryParse(txtNum1.Text, out float a))
                {
                    MessageBox.Show("Please enter a valid first number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNum1.Focus();
                    return;
                }

                if (!float.TryParse(txtNum2.Text, out float b))
                {
                    MessageBox.Show("Please enter a valid second number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNum2.Focus();
                    return;
                }

                if (cmbOperator.SelectedItem is not string operatorText)
                {
                    MessageBox.Show("Please select an operator.", "Missing operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbOperator.Focus();
                    return;
                }

                if (operatorText == "/" && b == 0)
                {
                    MessageBox.Show("Cannot divide by 0.", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNum2.Focus();
                    return;
                }

                float result;

                switch (operatorText)
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
                    default:
                        MessageBox.Show("Please select a valid operator.", "Invalid operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbOperator.Focus();
                        return;
                }

                lblTotal.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
