namespace PaintQuiz
{
    partial class Form1
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
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            txtArea = new TextBox();
            btnCalculate = new Button();
            btnTotalTax = new Button();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotalWithTax = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(311, 416);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(180, 37);
            txtWidth.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(311, 473);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(180, 37);
            txtHeight.TabIndex = 1;
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(311, 528);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(180, 37);
            txtArea.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(152, 202);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(135, 41);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnTotalTax
            // 
            btnTotalTax.Location = new Point(152, 265);
            btnTotalTax.Name = "btnTotalTax";
            btnTotalTax.Size = new Size(135, 41);
            btnTotalTax.TabIndex = 4;
            btnTotalTax.Text = "Total With Tax";
            btnTotalTax.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(72, 372);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(76, 31);
            lblSubtotal.TabIndex = 5;
            lblSubtotal.Text = "label1";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(72, 422);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(76, 31);
            lblTax.TabIndex = 6;
            lblTax.Text = "label2";
            // 
            // lblTotalWithTax
            // 
            lblTotalWithTax.AutoSize = true;
            lblTotalWithTax.Location = new Point(72, 473);
            lblTotalWithTax.Name = "lblTotalWithTax";
            lblTotalWithTax.Size = new Size(76, 31);
            lblTotalWithTax.TabIndex = 7;
            lblTotalWithTax.Text = "label3";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(72, 531);
            lblError.Name = "lblError";
            lblError.Size = new Size(76, 31);
            lblError.TabIndex = 8;
            lblError.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 728);
            Controls.Add(lblError);
            Controls.Add(lblTotalWithTax);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(btnTotalTax);
            Controls.Add(btnCalculate);
            Controls.Add(txtArea);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Name = "Form1";
            Text = "PaintCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWidth;
        private TextBox txtHeight;
        private TextBox txtArea;
        private Button btnCalculate;
        private Button btnTotalTax;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotalWithTax;
        private Label lblError;
    }
}
