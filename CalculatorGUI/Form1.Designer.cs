namespace CalculatorGUI
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
            label1 = new Label();
            btnAdd = new Button();
            btnSubstract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            txtResult = new TextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "WYNIK:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(58, 182);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 72);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(154, 182);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(90, 72);
            btnSubstract.TabIndex = 2;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(250, 182);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 72);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(346, 182);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 72);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(76, 30);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(660, 27);
            txtResult.TabIndex = 5;
            // 
            // txtA
            // 
            txtA.Location = new Point(250, 75);
            txtA.Name = "txtA";
            txtA.Size = new Size(201, 27);
            txtA.TabIndex = 6;
            // 
            // txtB
            // 
            txtB.Location = new Point(250, 124);
            txtB.Name = "txtB";
            txtB.Size = new Size(201, 27);
            txtB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 78);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 8;
            label2.Text = "LICZBA NR 1:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 127);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 9;
            label3.Text = "LICZBA NR 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtResult);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubstract);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnSubstract;
        private Button btnMultiply;
        private Button btnDivide;
        private TextBox txtResult;
        private TextBox txtA;
        private TextBox txtB;
        private Label label2;
        private Label label3;
    }
}
