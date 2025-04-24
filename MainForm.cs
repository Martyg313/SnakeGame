namespace SnakeGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;     // Assures modifying timer does not ruin key inputs
        }

        public static Panel thePanel = null!;                                       // Statically defined panel object for the game panel
        private List<Apple> appleList = new List<Apple>();                          // List for referencing all apple objects

        private Snake snake = null!;                                                // The <Snake> object of this game
        private bool pause = true;                                                  // Controls game pause
        private int score = 0;                                                      // Score
        private int highScore = 0;                                                  // Highscore

        private bool left = false, right = false, top = true, bottom = false;       // Default direction of snake
        private const int speed = 20;                                               // Speed of Snake
        private const int leftBound = 0;                                            // left border of map/panel
        private const int rightBound = 440;                                         // right border of map/panel
        private const int topBound = 0;                                             // top border of map/panel
        private const int bottomBound = 440;                                        // bottom border of map/panel
        private readonly Point scoreLabelPosistion = new Point(469, 101);           // score label position
        private readonly Point highScoreLabelPosistion = new Point(452, 124);       // high score label position

        private void Form1_Load(object sender, EventArgs e)
        {
            thePanel = gamePanel;       // Statically defines this panel object for other class refrences
        }

        /**
         *  Timer for snake movement game logic
        */
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Snake movment
            snake.MoveSnake(left, right, top, bottom, speed);

            // Wall detection
            CheckWallAndSegment();

            // Apple detection
            CheckApple();
        }

        /**
         * Start Button logic
         */
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Enables other controls
            startButton.Enabled = false;
            startButton.Visible = false;

            pauseButton.Enabled = true;
            pauseButton.Visible = true;

            resetButton.Enabled = true;
            resetButton.Visible = true;

            scoreLabel.Enabled = true;
            scoreLabel.Visible = true;
            scoreLabel.Location = scoreLabelPosistion;

            highScoreLabel.Enabled = true;
            highScoreLabel.Visible = true;
            highScoreLabel.Location = highScoreLabelPosistion;

            appleDisplayAmt.Enabled = false;
            appleDisplayAmt.Visible = false;

            appleBar.Enabled = false;
            appleBar.Visible = false;

            multiplierDisplayAmt.Enabled = false;
            multiplierDisplayAmt.Visible = false;

            multiplierBar.Enabled = false;
            multiplierBar.Visible = false;

            snakeDisplayAmount.Enabled = false;
            snakeDisplayAmount.Visible = false;

            snakeBar.Enabled = false;
            snakeBar.Visible = false;

            timer.Enabled = true;

            // Creates Snake
            snake = new Snake(snakeBar.Value);

            // Creates oat least one Apple
            SpawnApples();
        }

        /**
         * Pause button logic
         */
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (pause)
                pauseButton.Text = "Paused";
            else
                pauseButton.Text = "Pause";
            pause = !pause;
            timer.Enabled = !timer.Enabled;
        }

        /**
         * Reset Button logic
         */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /**
         * Keydown Inputs for determining the direction of <snake>
         */
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            SetDirection(e);
        }

        /**
         * Sets direction from <MainForm_KeyDown>
         */
        private void SetDirection(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (top)
                {
                    top = false;
                    left = true;
                }
                else if (left)
                {
                    left = false;
                    bottom = true;
                }
                else if (bottom)
                {
                    bottom = false;
                    right = true;
                }
                else if (right)
                {
                    right = false;
                    top = true;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (top)
                {
                    top = false;
                    right = true;
                }
                else if (right)
                {
                    right = false;
                    bottom = true;
                }
                else if (bottom)
                {
                    bottom = false;
                    left = true;
                }
                else if (left)
                {
                    left = false;
                    top = true;
                }
            }

            e.Handled = true;               // Ignores Windows "ding" exception
            e.SuppressKeyPress = true;
        }


        /**
         * Spawns the set number of apples given by the apple slidebar
         */
        private void SpawnApples()
        {
            for (int i = 0; i < appleBar.Value; i++)
                appleList.Add(new Apple());
        }

        /**
        * Disposes of <apple> and adds a point to the player's score
        * A new apple is created and the snake gains a new segment
        */
        private void CheckApple()
        {   
            // Cycle through each apple to check if is found
            for (int i = 0; i < appleList.Count; i++)
            {
                if (appleList[i].GetAppleBounds().IntersectsWith(snake.GetHeadBounds()))
                {
                    // Adds the appropiate amount of segments based on the multipler values
                    for (int j = 0; j < multiplierBar.Value; j++)
                        snake.AddSegment();

                    // Remove/delete the apple, and update scores
                    appleList[i].DeleteApple();
                    appleList.RemoveAt(i);
                    appleList.Add(new Apple());
                    score++;
                    scoreLabel.Text = $"Score: {score}";
                    if (score > highScore)
                    {
                        highScore = score;
                        highScoreLabel.Text = $"HighScore: {highScore}";
                    }
                }
            }
        }

        /**
         * Disposes of <snake> and stops the game if the snake meets a wall or itself
         */
        private void CheckWallAndSegment()
        {
            // Getting the <snake> head, and getting the <snake> segment boundries
            Rectangle sB = snake.GetHeadBounds();
            List<Rectangle> boundries = snake.GetBoundries();

            // Checks if if any of the <snake> segments colide with its head
            if (boundries.Any(x => x.IntersectsWith(sB)))
            {
                Reset();
            }

            // Checks if the <snake> head collides with the wall
            if (sB.Left < leftBound || sB.Right > rightBound || sB.Top < topBound || sB.Bottom > bottomBound)
            {
                Reset();
            }
        }

        /**
         * Resets the game to start again
         */
        private void Reset()
        {
            startButton.Enabled = true;
            startButton.Visible = true;

            pauseButton.Enabled = false;
            pauseButton.Visible = false;

            resetButton.Enabled = false;
            resetButton.Visible = false;

            appleDisplayAmt.Enabled = true;
            appleDisplayAmt.Visible = true;

            appleBar.Enabled = true;
            appleBar.Visible = true;

            multiplierDisplayAmt.Enabled = true;
            multiplierDisplayAmt.Visible = true;

            multiplierBar.Enabled = true;
            multiplierBar.Visible = true;

            snakeDisplayAmount.Enabled = true;
            snakeDisplayAmount.Visible = true;

            snakeBar.Enabled = true;
            snakeBar.Visible = true;

            timer.Enabled = !timer.Enabled;

            score = 0;
            scoreLabel.Text = $"Score: {score}";
            scoreLabel.Location = resetButton.Location;
            highScoreLabel.Location = new Point(452, scoreLabel.Location.Y + 20);

            snake.DeleteSnake();
            for (int i = 0; i < appleList.Count; i++)
                appleList[i].DeleteApple();
            appleList.Clear();

            left = false;
            right = false;
            top = true;
            bottom = false;
        }

        /**
         * Updates apple amount label if slider is moved
         */
        private void AppleBar_Scroll(object sender, EventArgs e)
        {
            appleDisplayAmt.Text = $"Apples: {appleBar.Value}";
        }

        /**
         * Updates mutliplier amount label if slider is moved
         */
        private void MultiplierBar_Scroll(object sender, EventArgs e)
        {
            multiplierDisplayAmt.Text = $"Multiplier: {multiplierBar.Value}";
        }

        /**
         * Updates snake length label if slider is moved
         */
        private void snakeBar_Scroll(object sender, EventArgs e)
        {
            snakeDisplayAmount.Text = $"Snake Length: {snakeBar.Value}";
        }
    }
}
