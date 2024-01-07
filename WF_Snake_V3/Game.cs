using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Snake_V3
{
	public partial class Game : Form
	{
		#region Game Attribues: snake, fruit

		private Snake snake;
		private Fruit fruit;

		#endregion

		public Game()
		{
			InitializeComponent();
			StartGame();
		}

		#region Game Methods

		private void StartGame()
		{

			// generare setari default
			new Settings();
			gameOverLabel.Visible = false;

			// bari UI
			StatusLabel.Text = "Game Running | Press 'P' to Pause";
			SpeedLabel.Text = Settings.Speed.ToString();

			// initializare date
			snake = new Snake(gameCanvas.Width / 2, gameCanvas.Height / 2, Settings.EntityWidth);
			GenerateFruit();

			// cu cat creste viteza, cu atat devine jocul mai rapid
			gameTimer = new Timer() { Interval = 2000 / Settings.Speed };
			gameTimer.Tick += UpdateScreen;
			gameTimer.Start();
		}

		private void GamePause()
		{
			gameTimer.Stop();
			StatusLabel.Text = "Game Paused | Press 'P' to Resume";
		}

		private void GameResume()
		{
			gameTimer.Start();
			StatusLabel.Text = "Game Running | Press 'P' to Pause";
		}

		private void GenerateFruit()
		{
			// TODO: Rethink algorithm.. ATM is not correct!!
			fruit = new Fruit((new Random()).Next(0, gameCanvas.Width), (new Random()).Next(0, gameCanvas.Height), Settings.EntityWidth);
		}

		private void UpdateScreen(Object sender, EventArgs args)
		{
			if (!Settings.GameOver)
			{
				snake.Move();
				Logics();
				gameCanvas.Invalidate();
			}
			else
			{
				gameTimer.Stop();
				gameOverLabel.Visible = true;
				gameOverLabel.BringToFront();
				gameCanvas.Invalidate();
			}
		}

		private void Logics()
		{
			// Border Collision
			if (snake.Head.X >= gameCanvas.Width || snake.Head.X < 0 || 
				snake.Head.Y >= gameCanvas.Height || snake.Head.Y < 0)
			{
				Settings.GameOver = true;
				snake.Head.Color = Brushes.Red;
				foreach (var t in snake.Tail)
				{
					t.Color = Brushes.Red;
				}

			}


			/// Entity Collision

			// Snake - Snake
			for (int i = 0; i < snake.Tail.Count; i++)
			{
				if (snake.Head.X == snake.Tail[i].X && snake.Head.Y == snake.Tail[i].Y)
				{
					Settings.Score -= snake.Shrink(i);
					scoreValue.Text = Settings.Score.ToString();

				}
			}

			// Snake - Fruit
			if (snake.Head.X == fruit.X && snake.Head.Y == fruit.Y)
			{
				Settings.Score += fruit.Value;
				scoreValue.Text = Settings.Score.ToString();

				snake.Grow(fruit);
				GenerateFruit();
			}

		}

		#endregion

		#region Paint Canvas
		private void gameCanvas_Paint(object sender, PaintEventArgs e)
		{
			Graphics canvas = e.Graphics;

			if (!Settings.GameOver)
			{
				// Draw the snake
				Brush snakeHeadColor = snake.Head.Color;
				Brush snakeTailColor;

				canvas.FillRectangle(snakeHeadColor, snake.Head.X, snake.Head.Y, snake.Head.Width, snake.Head.Height);

				for (int i = 0; i < snake.Tail.Count; i++)
				{
					snakeTailColor = snake.Tail[i].Color;
					canvas.FillRectangle(snakeTailColor, snake.Tail[i].X, snake.Tail[i].Y, snake.Tail[i].Width, snake.Tail[i].Height);
				}

				// Draw the fruit
				Brush fruitColor = fruit.Color;
				canvas.FillRectangle(fruitColor, fruit.X, fruit.Y, fruit.Width, fruit.Height);
			}
			else
			{
				gameOverLabel.Text = "Game over! \nYour final score was " + Settings.Score + "\nThank you for playing!\nPress ENTER to restart";
				Settings.GameOver = true;
			}
		}
		#endregion

		#region Key Event Handler

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up:
					if (snake.Direction != Direction.DOWN)
					{
						snake.Direction = Direction.UP;
					}
					break;
				case Keys.Down:
					if (snake.Direction != Direction.UP)
					{
						snake.Direction = Direction.DOWN;
					}
					break;
				case Keys.Left:
					if (snake.Direction != Direction.RIGHT)
					{
						snake.Direction = Direction.LEFT;
					}
					break;
				case Keys.Right:
					if (snake.Direction != Direction.LEFT)
					{
						snake.Direction = Direction.RIGHT;
					}
					break;
				case Keys.P:
					if (gameTimer.Enabled)
					{
						GamePause();
					} else
					{
						GameResume();
					}
					break;
				case Keys.Enter:
					if (Settings.GameOver)
					{
						StartGame();
					}
					break;
			}
		}

		#endregion

		private void SpeedMinus_Click(object sender, EventArgs e)
		{
			if (Settings.Speed > 0)
			{
				Settings.Speed--;
			}
			SpeedLabel.Text = Settings.Speed.ToString();
		}

		private void SpeedPlus_Click(object sender, EventArgs e)
		{
			if (Settings.Speed < 40)
			{
				Settings.Speed++;
			}
			SpeedLabel.Text = Settings.Speed.ToString();
		}

		private void SpeedMinus_MouseLeave(object sender, EventArgs e)
		{
			SpeedMinus.BackColor = Color.Black;
		}

		private void SpeedMinus_MouseEnter(object sender, EventArgs e)
		{
			SpeedMinus.BackColor = Color.Maroon;
		}

		private void SpeedPlus_MouseEnter(object sender, EventArgs e)
		{
			SpeedPlus.BackColor = Color.Maroon;
		}

		private void SpeedPlus_MouseLeave(object sender, EventArgs e)
		{
			SpeedPlus.BackColor = Color.Black;
		}
	}
}
