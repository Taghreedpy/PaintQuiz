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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(497, 73);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(180, 37);
            txtWidth.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(497, 130);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(180, 37);
            txtHeight.TabIndex = 1;
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(497, 185);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(180, 37);
            txtArea.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(93, 342);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(135, 41);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnTotalTax
            // 
            btnTotalTax.Location = new Point(93, 405);
            btnTotalTax.Name = "btnTotalTax";
            btnTotalTax.Size = new Size(206, 41);
            btnTotalTax.TabIndex = 4;
            btnTotalTax.Text = "Total With Tax";
            btnTotalTax.UseVisualStyleBackColor = true;
            btnTotalTax.Click += btnTotalTax_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(467, 342);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(105, 31);
            lblSubtotal.TabIndex = 5;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(467, 392);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(51, 31);
            lblTax.TabIndex = 6;
            lblTax.Text = "Tax:";
            // 
            // lblTotalWithTax
            // 
            lblTotalWithTax.AutoSize = true;
            lblTotalWithTax.Location = new Point(467, 448);
            lblTotalWithTax.Name = "lblTotalWithTax";
            lblTotalWithTax.Size = new Size(148, 31);
            lblTotalWithTax.TabIndex = 7;
            lblTotalWithTax.Text = "TotalWithTax:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(467, 505);
            lblError.Name = "lblError";
            lblError.Size = new Size(76, 31);
            lblError.TabIndex = 8;
            lblError.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 73);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 9;
            label1.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 130);
            label2.Name = "label2";
            label2.Size = new Size(88, 31);
            label2.TabIndex = 10;
            label2.Text = "Height:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 189);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 11;
            label3.Text = "Area:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 728);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
