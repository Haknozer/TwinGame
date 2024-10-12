using System;
using Timer = System.Windows.Forms.Timer;

namespace TwinGame
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        Timer timer;
        Timer matchTime;
        Timer chooseTime;
        Button choiceOne = null;
        Button choiceTwo = null;
        int playerOne = 0;
        int playerTwo = 0;
        Boolean turn = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameCreate();
            pOnePoint.Text = playerOne.ToString();
            pTwoPoint.Text = playerTwo.ToString();

        }

        void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {

                int r = i + (int)(random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        private void GameCreate()
        {
            panel1.Controls.Clear();
            int row = 8;
            int column = 5;

            int left = 0;
            int top = 50;

            int counter = 0;

            String[] fruits = ["ananas", "avakado", "ayva", "balkabagi", "cilek", "domates", "ejder", "elma", "erik", "incir", "karpuz", "kivi", "limon", "muz", "papaya", "seftali", "skivi", "tutku", "uzum", "yerik"];
            Shuffle(fruits);
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {

                    Button button = new Button();
                    button.Name = "buton" + i.ToString() + j.ToString();      // Button Name 
                    button.Text = fruits[counter];    // Button Text
                    button.Font = new Font("Fransýzca Yazýsý MT", 1); // Button Font Design
                    button.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(button.Text);
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.BackColor = Color.Red;
                    button.ForeColor = Color.Red;
                    button.Width = 100;
                    button.Height = 100;
                    button.Left = left;                 // Button Yeri
                    button.Top = top;                   // Button Yeri
                    panel1.Controls.Add((Button)button);          // Buttonu Forma Ekleme
                    button.Click += buttonClick;       // Game Control


                    left += 100;
                    counter += 1;


                    if (counter == 20)
                    {
                        counter = 0;
                        Shuffle(fruits);
                    }
                }
                top += 100;
                left = 0;
            }
            timer = new Timer();
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void buttonClick(object? sender, EventArgs e)
        {
            if (choiceOne == null)
            {
                choiceOne = (Button)sender;
                choiceOne.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(choiceOne.Text);
                
                
                chooseTime = new Timer();

                chooseTime.Interval = 5000;
                chooseTime.Enabled = true;
                chooseTime.Tick += timer2_Tick;
                chooseTime.Start();
            }
            else
            {
                choiceTwo = (Button)sender;
                choiceTwo.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(choiceTwo.Text);
               
                
                chooseTime.Stop();
                chooseTime.Enabled = false;
                chooseTime.Tick -= matchTimer_Tick;
            }



            if (choiceOne != null && choiceTwo != null)
            {
                if (choiceOne.Name == choiceTwo.Name)
                {
                    choiceTwo = null;
                }
                else
                {
                    this.Enabled = false;
                    matchTime = new Timer();
                    matchTime.Interval = 1000;
                    matchTime.Enabled = true;
                    matchTime.Tick += matchTimer_Tick;
                    matchTime.Start();
                }


            }
        }

        private void pointControll()
        {
            if (choiceOne.Text == choiceTwo.Text)
            {
                if (turn == false)
                {
                    playerOne += 1;
                    pOnePoint.Text = playerOne.ToString();
                }
                else
                {
                    playerTwo += 1;
                    pTwoPoint.Text = playerTwo.ToString();
                }

                choiceOne.Visible = false;
                choiceTwo.Visible = false;

                if (playerOne == 11)
                {
                    choiceOne = null;
                    choiceTwo = null;

                    EndGame();

                } else if (playerTwo == 11)
                {
                    choiceOne = null;
                    choiceTwo = null;

                    EndGame();

                } else if (playerOne + playerTwo == 20)
                {
                    choiceOne = null;
                    choiceTwo = null;

                    EndGame();
                }

            }
            else
            {

                choiceOne.BackgroundImage = null;
                choiceTwo.BackgroundImage = null;
                turn = !turn;
                label1.Text = "Turn Player ";
                label1.Text += turn == false ? "One" : "Two";
            }

            choiceOne = null;
            choiceTwo = null;
            this.Enabled = true;
        }

        private void EndGame()
        {
            matchTime.Stop();
            matchTime.Enabled = false;
            matchTime.Tick -= matchTimer_Tick;
            if (playerOne > playerTwo)
            {
                MessageBox.Show("Player One Won");
            }
            else if (playerTwo > playerOne)
            {
                MessageBox.Show("Player Two Won");
            }
            else
            {
                MessageBox.Show("Draw");
            }

            DialogResult dialogResult = MessageBox.Show("Try Again", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                restartGame();
            }
            else
            {
                Application.Exit();
            }
        }

        private void restartGame()
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.BackgroundImage = null;
                    control.ForeColor = Color.Red;
                }
            }
            timer.Stop();
            timer.Enabled = false;
            timer.Tick -= timer1_Tick;
        }

        private void matchTimer_Tick(object sender, EventArgs e)
        {
            pointControll();

            matchTime.Stop();
            matchTime.Enabled = false;
            matchTime.Tick -= matchTimer_Tick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (choiceTwo == null)
            {
                turn = !turn;
                choiceOne.BackColor = Color.Black;
                label1.Text = "Turn Player ";
                label1.Text += turn == false ? "One" : "Two";
                choiceOne = null;
            }

            chooseTime.Stop();
            chooseTime.Enabled = false;
            chooseTime.Tick -= matchTimer_Tick;
        }

        private void playerTwoLabel_Click(object sender, EventArgs e)
        {

        }

        private void playerOneLabel_Click(object sender, EventArgs e)
        {

        }
        private void pOnePoint_Click(object sender, EventArgs e)
        {

        }
        private void pTwoPoint_Click(object sender, EventArgs e)
        {

        }
    }
}
