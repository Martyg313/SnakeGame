namespace SnakeGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timer = new System.Windows.Forms.Timer(components);
            gamePanel = new Panel();
            startButton = new Button();
            pauseButton = new Button();
            resetButton = new Button();
            scoreLabel = new Label();
            highScoreLabel = new Label();
            appleBar = new TrackBar();
            appleDisplayAmt = new Label();
            multiplierDisplayAmt = new Label();
            multiplierBar = new TrackBar();
            snakeDisplayAmount = new Label();
            snakeBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)appleBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)multiplierBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snakeBar).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 150;
            timer.Tick += Timer_Tick;
            // 
            // gamePanel
            // 
            gamePanel.BorderStyle = BorderStyle.FixedSingle;
            gamePanel.Location = new Point(12, 12);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(440, 440);
            gamePanel.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(192, 255, 192);
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.Font = new Font("Courier New", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            startButton.Location = new Point(469, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 40);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.White;
            pauseButton.Enabled = false;
            pauseButton.FlatStyle = FlatStyle.Popup;
            pauseButton.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pauseButton.Location = new Point(469, 12);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(100, 40);
            pauseButton.TabIndex = 2;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Visible = false;
            pauseButton.Click += PauseButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(255, 128, 128);
            resetButton.Enabled = false;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Courier New", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(469, 58);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(100, 40);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Visible = false;
            resetButton.Click += ResetButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(469, 58);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(100, 23);
            scoreLabel.TabIndex = 5;
            scoreLabel.Text = "Score: 0";
            scoreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // highScoreLabel
            // 
            highScoreLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            highScoreLabel.Location = new Point(452, 78);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(128, 39);
            highScoreLabel.TabIndex = 7;
            highScoreLabel.Text = "HighScore: 0";
            highScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appleBar
            // 
            appleBar.BackColor = SystemColors.AppWorkspace;
            appleBar.Location = new Point(452, 143);
            appleBar.Minimum = 1;
            appleBar.Name = "appleBar";
            appleBar.Size = new Size(128, 45);
            appleBar.TabIndex = 8;
            appleBar.Value = 1;
            appleBar.Scroll += AppleBar_Scroll;
            // 
            // appleDisplayAmt
            // 
            appleDisplayAmt.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            appleDisplayAmt.Location = new Point(452, 119);
            appleDisplayAmt.Name = "appleDisplayAmt";
            appleDisplayAmt.Size = new Size(128, 23);
            appleDisplayAmt.TabIndex = 9;
            appleDisplayAmt.Text = "Apples: 1";
            appleDisplayAmt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplierDisplayAmt
            // 
            multiplierDisplayAmt.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            multiplierDisplayAmt.Location = new Point(452, 186);
            multiplierDisplayAmt.Name = "multiplierDisplayAmt";
            multiplierDisplayAmt.Size = new Size(128, 23);
            multiplierDisplayAmt.TabIndex = 11;
            multiplierDisplayAmt.Text = "Multiplier: 1";
            multiplierDisplayAmt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplierBar
            // 
            multiplierBar.BackColor = SystemColors.AppWorkspace;
            multiplierBar.Location = new Point(452, 210);
            multiplierBar.Minimum = 1;
            multiplierBar.Name = "multiplierBar";
            multiplierBar.Size = new Size(128, 45);
            multiplierBar.TabIndex = 10;
            multiplierBar.Value = 1;
            multiplierBar.Scroll += MultiplierBar_Scroll;
            // 
            // snakeDisplayAmount
            // 
            snakeDisplayAmount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            snakeDisplayAmount.Location = new Point(452, 258);
            snakeDisplayAmount.Name = "snakeDisplayAmount";
            snakeDisplayAmount.Size = new Size(128, 23);
            snakeDisplayAmount.TabIndex = 13;
            snakeDisplayAmount.Text = "Snake Length: 3";
            snakeDisplayAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // snakeBar
            // 
            snakeBar.BackColor = SystemColors.AppWorkspace;
            snakeBar.Location = new Point(452, 282);
            snakeBar.Maximum = 50;
            snakeBar.Minimum = 3;
            snakeBar.Name = "snakeBar";
            snakeBar.Size = new Size(128, 45);
            snakeBar.TabIndex = 12;
            snakeBar.Value = 3;
            snakeBar.Scroll += snakeBar_Scroll;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(581, 464);
            Controls.Add(snakeDisplayAmount);
            Controls.Add(snakeBar);
            Controls.Add(multiplierDisplayAmt);
            Controls.Add(multiplierBar);
            Controls.Add(appleDisplayAmt);
            Controls.Add(appleBar);
            Controls.Add(highScoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(resetButton);
            Controls.Add(startButton);
            Controls.Add(gamePanel);
            Controls.Add(pauseButton);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "SnakeGame";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)appleBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)multiplierBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)snakeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Panel gamePanel;
        private Button startButton;
        private Button pauseButton;
        private Button resetButton;
        private Label scoreLabel;
        private Label highScoreLabel;
        private TrackBar appleBar;
        private Label appleDisplayAmt;
        private Label multiplierDisplayAmt;
        private TrackBar multiplierBar;
        private Label snakeDisplayAmount;
        private TrackBar snakeBar;
    }
}
