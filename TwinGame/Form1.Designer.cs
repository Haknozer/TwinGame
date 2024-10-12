namespace TwinGame
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            playerOneLabel = new Label();
            playerTwoLabel = new Label();
            pOnePoint = new Label();
            pTwoPoint = new Label();
            panel1 = new Panel();
            matchTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            RestartButton = new Button();
            ChooseTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // playerOneLabel
            // 
            playerOneLabel.AutoSize = true;
            playerOneLabel.BackColor = SystemColors.ActiveBorder;
            playerOneLabel.Font = new Font("Segoe UI", 22F);
            playerOneLabel.ForeColor = SystemColors.ActiveCaptionText;
            playerOneLabel.Location = new Point(867, 83);
            playerOneLabel.Name = "playerOneLabel";
            playerOneLabel.Size = new Size(207, 50);
            playerOneLabel.TabIndex = 0;
            playerOneLabel.Text = "Player One:";
            playerOneLabel.Click += playerOneLabel_Click;
            // 
            // playerTwoLabel
            // 
            playerTwoLabel.AutoSize = true;
            playerTwoLabel.Font = new Font("Segoe UI", 22F);
            playerTwoLabel.ForeColor = SystemColors.ActiveCaptionText;
            playerTwoLabel.Location = new Point(867, 245);
            playerTwoLabel.Name = "playerTwoLabel";
            playerTwoLabel.Size = new Size(205, 50);
            playerTwoLabel.TabIndex = 1;
            playerTwoLabel.Text = "Player Two:";
            playerTwoLabel.Click += playerTwoLabel_Click;
            // 
            // pOnePoint
            // 
            pOnePoint.AutoSize = true;
            pOnePoint.Font = new Font("Segoe UI", 25F);
            pOnePoint.ForeColor = SystemColors.ActiveCaptionText;
            pOnePoint.Location = new Point(1080, 77);
            pOnePoint.Name = "pOnePoint";
            pOnePoint.Size = new Size(48, 57);
            pOnePoint.TabIndex = 2;
            pOnePoint.Text = "0";
            pOnePoint.Click += pOnePoint_Click;
            // 
            // pTwoPoint
            // 
            pTwoPoint.AutoSize = true;
            pTwoPoint.Font = new Font("Segoe UI", 25F);
            pTwoPoint.ForeColor = SystemColors.ActiveCaptionText;
            pTwoPoint.Location = new Point(1080, 238);
            pTwoPoint.Name = "pTwoPoint";
            pTwoPoint.Size = new Size(48, 57);
            pTwoPoint.TabIndex = 3;
            pTwoPoint.Text = "0";
            pTwoPoint.Click += pTwoPoint_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(18, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 604);
            panel1.TabIndex = 4;
            // 
            // matchTimer
            // 
            matchTimer.Tick += matchTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(867, 402);
            label1.Name = "label1";
            label1.Size = new Size(259, 46);
            label1.TabIndex = 5;
            label1.Text = "Turn Player One";
            label1.Click += label1_Click;
            // 
            // RestartButton
            // 
            RestartButton.Location = new Point(881, 504);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(243, 74);
            RestartButton.TabIndex = 6;
            RestartButton.Text = "Reset";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += button1_Click;
            // 
            // ChooseTimer
            // 
            ChooseTimer.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1138, 667);
            Controls.Add(RestartButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pTwoPoint);
            Controls.Add(pOnePoint);
            Controls.Add(playerTwoLabel);
            Controls.Add(playerOneLabel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "TwinGame";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label playerOneLabel;
        private Label playerTwoLabel;
        private Label pOnePoint;
        private Label pTwoPoint;
        private Panel panel1;
        private System.Windows.Forms.Timer matchTimer;
        private Label label1;
        private Button RestartButton;
        private System.Windows.Forms.Timer ChooseTimer;
    }
}
