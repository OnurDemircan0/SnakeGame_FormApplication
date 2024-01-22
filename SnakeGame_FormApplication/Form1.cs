using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace SnakeGame_FormApplication
{
    public partial class Form1 : Form
    {
        private int length = 10;
        private int width = 10;
        private int boxSize = 42;

        List<List<PictureBox>> pictureBoxes = new List<List<PictureBox>>();

        private int right = 1;
        private int up = 0;
        private bool canGoHorizontal = false;
        private bool canGoVertical = true;

        private int snakePositionX = 3; //This is position x in the gameScene array but position y in real cordinates.
        private int snakePositionY = 2; //This is position y in the gameScene array but position x in real cordinates.
        private List<int> snakePositionsX = new List<int>();
        private List<int> snakePositionsY = new List<int>();

        private bool gameIsActive = false;

        private int score = 0;
        private List<int> highScores = new List<int>();

        Color snakeColor = Color.ForestGreen;
        Color appleColor = Color.DarkRed;
        Color boardColor = Color.BurlyWood;
        Color wallColor = Color.DarkGray;

        public Form1()
        {
            InitializeComponent();

            difficultyComboBox.SelectedIndex = 0;

            ChangeTheBoard();
        }

        private void ChangeTheBoard()
        {
            int maximumEdge = Math.Max(width, length);
            boxSize = (int)(42 - ((maximumEdge - 10) * 3.14f));
            boxSize = Math.Max(boxSize, 15);

            tableLayoutPanel1.Controls.Clear();

            tableLayoutPanel1.RowCount = length;
            tableLayoutPanel1.ColumnCount = width;
            tableLayoutPanel1.AutoSize = true;

            for (int row = 0; row < length; row++)
            {
                if(row != 0 && row != length - 1)
                {
                    pictureBoxes.Add(new List<PictureBox>());
                }
                
                for (int col = 0; col < width; col++)
                {
                    if (row == 0 || row == length - 1 || col == 0 || col == width - 1)
                    {
                        PictureBox pictureBox = new PictureBox
                        {
                            Size = new Size(boxSize, boxSize), // Adjust the size of each PictureBox
                            BackColor = wallColor, // Set the background color
                        };
                        tableLayoutPanel1.Controls.Add(pictureBox, col, row);
                    }
                    else
                    {
                        PictureBox pictureBox = new PictureBox
                        {
                            Size = new Size(boxSize, boxSize), // Adjust the size of each PictureBox
                            BackColor = boardColor, // Set the background color
                        };
                        tableLayoutPanel1.Controls.Add(pictureBox, col, row);

                        
                        pictureBoxes[row - 1].Add(pictureBox);
                    }
                }
            }

            
        }

        private void InstantiateApple()
        {
            while (true)
            {
                Random rand = new Random();
                int randomPositionX = rand.Next(0, pictureBoxes.Count);
                int randomPositionY = rand.Next(0, pictureBoxes[0].Count);

                if (pictureBoxes[randomPositionX][randomPositionY].BackColor == boardColor)
                {
                    pictureBoxes[randomPositionX][randomPositionY].BackColor = appleColor;
                    return;
                }
            }
        }

        private void SnakeMovement()
        {
            snakePositionX = snakePositionX + up;
            snakePositionY = snakePositionY + right;

            if(snakePositionX < 0 || snakePositionX > pictureBoxes.Count - 1 || snakePositionY < 0 || snakePositionY > pictureBoxes[0].Count - 1)
            {
                GameOver();

                return;
            }

            snakePositionsX.Add(snakePositionX);
            snakePositionsY.Add(snakePositionY);

            PictureBox nextPictureBox = pictureBoxes[snakePositionX][snakePositionY];

            if(nextPictureBox.BackColor == boardColor)
            {
                nextPictureBox.BackColor = snakeColor;

                pictureBoxes[snakePositionsX[0]][snakePositionsY[0]].BackColor = boardColor;
                snakePositionsX.RemoveAt(0);
                snakePositionsY.RemoveAt(0);
            }
            else if(nextPictureBox.BackColor == appleColor)
            {
                nextPictureBox.BackColor = snakeColor;

                score++;
                scoreLabel.Text = "Score: " + score;

                InstantiateApple();
            }
            else if(nextPictureBox.BackColor == snakeColor)
            {
                GameOver();

                return;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            length = (int)numericUpDown1.Value;

            pictureBoxes.Clear();

            ChangeTheBoard();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            width = (int)numericUpDown2.Value;

            pictureBoxes.Clear();

            ChangeTheBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public async void GameOver()
        {
            GameOverScreen.Visible = true;
            gameIsActive = false;

            await Task.Delay(2000);

            GameOverScreen.Visible = false;
            ResetGame();
        }

        private void PlayButton(object sender, EventArgs e)
        {
            playButton.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            difficultyComboBox.Enabled = false;

            gameIsActive = true;

            snakePositionsX.Add(snakePositionX);
            snakePositionsY.Add(snakePositionY);
            pictureBoxes[snakePositionX][snakePositionY].BackColor = snakeColor;

            InstantiateApple();
        }

        private void ResetGame()
        {
            playButton.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            difficultyComboBox.Enabled = true;

            right = 1;
            up = 0;
            canGoHorizontal = false;
            canGoVertical = true;

            snakePositionX = 3;
            snakePositionY = 2;

            highScores.Add(score);
            highScores.Sort((a, b) => b.CompareTo(a));
            if (highScores.Count > 10) highScores.RemoveAt(highScores.Count - 1);
            string highScoresData = "";
            for(int i = 0; i < highScores.Count; i++)
            {
                highScoresData += (i + 1) + ". " + highScores[i] + "\n";
            }
            highScoresDataLabel.Text = highScoresData;

            score = 0;
            scoreLabel.Text = "Score: " + score;

            snakePositionsX.Clear();
            snakePositionsY.Clear();
            pictureBoxes.Clear();

            ChangeTheBoard();
        }

        private void DifficultySelection(object sender, EventArgs e)
        {
            switch (difficultyComboBox.SelectedIndex)
            {
                case 0:
                    timer1.Interval = 2000;
                    break;
                case 1:
                    timer1.Interval = 1000;
                    break;
                case 2:
                    timer1.Interval = 500;
                    break;
                case 3:
                    timer1.Interval = 250;
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(difficultyComboBox.Text);
            if (gameIsActive)
            {
                SnakeMovement();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (canGoVertical)
                    {
                        up = -1;
                        right = 0;

                        canGoVertical = false;
                        canGoHorizontal = true;
                    }
                    break;
                case Keys.Down:
                    if (canGoVertical)
                    {
                        up = 1;
                        right = 0;

                        canGoVertical = false;
                        canGoHorizontal = true;
                    }
                    break;
                case Keys.Right:
                    if (canGoHorizontal)
                    {
                        right = 1;
                        up = 0;

                        canGoHorizontal = false;
                        canGoVertical = true;
                    }
                    break;
                case Keys.Left:
                    if (canGoHorizontal)
                    {
                        right = -1;
                        up = 0;

                        canGoHorizontal = false;
                        canGoVertical = true;
                    }
                    break;
            }
        }

    }
}
