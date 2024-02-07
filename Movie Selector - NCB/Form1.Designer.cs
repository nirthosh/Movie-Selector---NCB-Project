namespace Movie_Selector___NCB
{
    partial class Movie
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
            txtAge = new TextBox();
            btnCheck = new Button();
            btnClick = new Button();
            lblResult = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(82, 18);
            txtAge.Margin = new Padding(2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(102, 23);
            txtAge.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(193, 17);
            btnCheck.Margin = new Padding(2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(84, 20);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(281, 17);
            btnClick.Margin = new Padding(2);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(84, 20);
            btnClick.TabIndex = 3;
            btnClick.Text = "Clear";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ScrollBar;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(19, 45);
            lblResult.Margin = new Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(346, 59);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result Pending...";
            lblResult.Click += lblResult_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(281, 112);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 20);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Movie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(btnClick);
            Controls.Add(btnCheck);
            Controls.Add(txtAge);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Movie";
            Text = "Movie Selector - NCB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAge;
        private Button btnCheck;
        private Button btnClick;
        private Label lblResult;
        private Button btnExit;
    }
}