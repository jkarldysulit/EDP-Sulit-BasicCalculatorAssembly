namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblBasicCalculator = new Label();
            cmbOperator = new ComboBox();
            pnlTotal = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            btnCompute = new Button();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.BackColor = Color.FromArgb(207, 207, 207);
            txtNum1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtNum1.ForeColor = Color.Black;
            txtNum1.Location = new Point(76, 316);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(300, 43);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = Color.FromArgb(207, 207, 207);
            txtNum2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtNum2.ForeColor = Color.Black;
            txtNum2.Location = new Point(76, 475);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(300, 43);
            txtNum2.TabIndex = 1;
            // 
            // lblBasicCalculator
            // 
            lblBasicCalculator.AutoSize = true;
            lblBasicCalculator.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasicCalculator.ForeColor = Color.White;
            lblBasicCalculator.Location = new Point(12, 28);
            lblBasicCalculator.Name = "lblBasicCalculator";
            lblBasicCalculator.Size = new Size(220, 37);
            lblBasicCalculator.TabIndex = 2;
            lblBasicCalculator.Text = "Basic Calculator";
            // 
            // cmbOperator
            // 
            cmbOperator.BackColor = Color.FromArgb(207, 207, 207);
            cmbOperator.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(151, 388);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(121, 45);
            cmbOperator.TabIndex = 3;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(207, 207, 207);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(label1);
            pnlTotal.Location = new Point(15, 73);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(449, 196);
            pnlTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 26F);
            lblTotal.Location = new Point(136, 83);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(170, 47);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "__________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 36);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(207, 207, 207);
            btnCompute.Location = new Point(78, 544);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(300, 47);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 21, 28);
            ClientSize = new Size(480, 630);
            Controls.Add(btnCompute);
            Controls.Add(pnlTotal);
            Controls.Add(cmbOperator);
            Controls.Add(lblBasicCalculator);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmBasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblBasicCalculator;
        private ComboBox cmbOperator;
        private Panel pnlTotal;
        private Label lblTotal;
        private Label label1;
        private Button btnCompute;
    }
}
