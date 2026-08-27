namespace CallTargetCalculatorGUI
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
            lblTitle = new Label();
            lblLoginHours = new Label();
            lblBreakMinutes = new Label();
            lblCallsTaken = new Label();
            txtOutput = new TextBox();
            btnCalculate = new Button();
            txtLoginHours = new TextBox();
            txtBreakMinutes = new TextBox();
            txtCallsTaken = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(271, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 39);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Call Target Calculator";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLoginHours
            // 
            lblLoginHours.AutoSize = true;
            lblLoginHours.Location = new Point(43, 81);
            lblLoginHours.Name = "lblLoginHours";
            lblLoginHours.Size = new Size(409, 25);
            lblLoginHours.TabIndex = 1;
            lblLoginHours.Text = "How many hours have you been logged in today?";
            // 
            // lblBreakMinutes
            // 
            lblBreakMinutes.AutoSize = true;
            lblBreakMinutes.Location = new Point(43, 118);
            lblBreakMinutes.Name = "lblBreakMinutes";
            lblBreakMinutes.Size = new Size(174, 25);
            lblBreakMinutes.TabIndex = 2;
            lblBreakMinutes.Text = "Total break minutes?";
            // 
            // lblCallsTaken
            // 
            lblCallsTaken.AutoSize = true;
            lblCallsTaken.Location = new Point(43, 163);
            lblCallsTaken.Name = "lblCallsTaken";
            lblCallsTaken.Size = new Size(154, 25);
            lblCallsTaken.TabIndex = 3;
            lblCallsTaken.Text = "Calls taken so far?";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(510, 224);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(278, 210);
            txtOutput.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(236, 222);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtLoginHours
            // 
            txtLoginHours.Location = new Point(458, 81);
            txtLoginHours.Name = "txtLoginHours";
            txtLoginHours.Size = new Size(150, 31);
            txtLoginHours.TabIndex = 6;
            // 
            // txtBreakMinutes
            // 
            txtBreakMinutes.Location = new Point(223, 118);
            txtBreakMinutes.Name = "txtBreakMinutes";
            txtBreakMinutes.Size = new Size(150, 31);
            txtBreakMinutes.TabIndex = 7;
            // 
            // txtCallsTaken
            // 
            txtCallsTaken.Location = new Point(222, 157);
            txtCallsTaken.Name = "txtCallsTaken";
            txtCallsTaken.Size = new Size(150, 31);
            txtCallsTaken.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCallsTaken);
            Controls.Add(txtBreakMinutes);
            Controls.Add(txtLoginHours);
            Controls.Add(btnCalculate);
            Controls.Add(txtOutput);
            Controls.Add(lblCallsTaken);
            Controls.Add(lblBreakMinutes);
            Controls.Add(lblLoginHours);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLoginHours;
        private Label lblBreakMinutes;
        private Label lblCallsTaken;
        private TextBox txtOutput;
        private Button btnCalculate;
        private TextBox txtLoginHours;
        private TextBox txtBreakMinutes;
        private TextBox txtCallsTaken;
    }
}
