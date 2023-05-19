namespace Compund_Interest_Savings_Calculator
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
            title = new Label();
            Amount_Saved = new Label();
            Rate_Label = new Label();
            Years_Label = new Label();
            txtYears = new TextBox();
            txtInterestRate = new TextBox();
            txtAmountSaved = new TextBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnDecrease = new Button();
            btnIncrease = new Button();
            lblAnswer = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Tw Cen MT Condensed", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            title.Location = new Point(132, 9);
            title.Name = "title";
            title.Size = new Size(215, 44);
            title.TabIndex = 0;
            title.Text = "Savings Calulator";
            // 
            // Amount_Saved
            // 
            Amount_Saved.AutoSize = true;
            Amount_Saved.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Amount_Saved.Location = new Point(60, 72);
            Amount_Saved.Name = "Amount_Saved";
            Amount_Saved.Size = new Size(109, 20);
            Amount_Saved.TabIndex = 1;
            Amount_Saved.Text = "Amount Saved:";
            // 
            // Rate_Label
            // 
            Rate_Label.AutoSize = true;
            Rate_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rate_Label.Location = new Point(74, 110);
            Rate_Label.Name = "Rate_Label";
            Rate_Label.Size = new Size(95, 20);
            Rate_Label.TabIndex = 2;
            Rate_Label.Text = "Interest Rate:";
            // 
            // Years_Label
            // 
            Years_Label.AutoSize = true;
            Years_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Years_Label.Location = new Point(79, 148);
            Years_Label.Name = "Years_Label";
            Years_Label.Size = new Size(90, 20);
            Years_Label.TabIndex = 3;
            Years_Label.Text = "Years Saved:";
            // 
            // txtYears
            // 
            txtYears.Location = new Point(175, 149);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(100, 23);
            txtYears.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(175, 110);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(100, 23);
            txtInterestRate.TabIndex = 5;
            // 
            // txtAmountSaved
            // 
            txtAmountSaved.Location = new Point(175, 73);
            txtAmountSaved.Name = "txtAmountSaved";
            txtAmountSaved.Size = new Size(100, 23);
            txtAmountSaved.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(207, 208);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(96, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Caculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(362, 157);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Values";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(362, 110);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(94, 23);
            btnDecrease.TabIndex = 9;
            btnDecrease.Text = "Decrease Rate";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(362, 73);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(94, 23);
            btnIncrease.TabIndex = 10;
            btnIncrease.Text = "Increase Rate";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Cursor = Cursors.Cross;
            lblAnswer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.Location = new Point(207, 262);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 20);
            lblAnswer.TabIndex = 11;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(108, 258);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(93, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total Saved: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 317);
            Controls.Add(lblTotal);
            Controls.Add(lblAnswer);
            Controls.Add(btnIncrease);
            Controls.Add(btnDecrease);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(txtAmountSaved);
            Controls.Add(txtInterestRate);
            Controls.Add(txtYears);
            Controls.Add(Years_Label);
            Controls.Add(Rate_Label);
            Controls.Add(Amount_Saved);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label Amount_Saved;
        private Label Rate_Label;
        private Label Years_Label;
        private TextBox txtYears;
        private TextBox txtInterestRate;
        private TextBox txtAmountSaved;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnDecrease;
        private Button btnIncrease;
        private Label lblAnswer;
        private Label lblTotal;
    }
}