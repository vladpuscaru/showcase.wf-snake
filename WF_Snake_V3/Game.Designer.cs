namespace WF_Snake_V3
{
	partial class Game
	{
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.SpeedPanel = new System.Windows.Forms.Panel();
			this.SpeedLabel = new System.Windows.Forms.Label();
			this.SpeedPlus = new System.Windows.Forms.Label();
			this.SpeedMinus = new System.Windows.Forms.Label();
			this.SpeedText = new System.Windows.Forms.Label();
			this.scoreValue = new System.Windows.Forms.Label();
			this.score = new System.Windows.Forms.Label();
			this.gameOverLabel = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.gameCanvas = new System.Windows.Forms.PictureBox();
			this.settingsPanel.SuspendLayout();
			this.SpeedPanel.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// settingsPanel
			// 
			this.settingsPanel.BackColor = System.Drawing.Color.Snow;
			this.settingsPanel.Controls.Add(this.SpeedPanel);
			this.settingsPanel.Controls.Add(this.scoreValue);
			this.settingsPanel.Controls.Add(this.score);
			this.settingsPanel.Location = new System.Drawing.Point(13, 12);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(800, 57);
			this.settingsPanel.TabIndex = 1;
			// 
			// SpeedPanel
			// 
			this.SpeedPanel.BackColor = System.Drawing.Color.Black;
			this.SpeedPanel.Controls.Add(this.SpeedLabel);
			this.SpeedPanel.Controls.Add(this.SpeedPlus);
			this.SpeedPanel.Controls.Add(this.SpeedMinus);
			this.SpeedPanel.Controls.Add(this.SpeedText);
			this.SpeedPanel.Location = new System.Drawing.Point(651, 5);
			this.SpeedPanel.Name = "SpeedPanel";
			this.SpeedPanel.Size = new System.Drawing.Size(136, 48);
			this.SpeedPanel.TabIndex = 2;
			// 
			// SpeedLabel
			// 
			this.SpeedLabel.BackColor = System.Drawing.Color.Snow;
			this.SpeedLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.SpeedLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeedLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SpeedLabel.Location = new System.Drawing.Point(27, 0);
			this.SpeedLabel.Name = "SpeedLabel";
			this.SpeedLabel.Size = new System.Drawing.Size(82, 31);
			this.SpeedLabel.TabIndex = 2;
			this.SpeedLabel.Text = "label1";
			this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SpeedPlus
			// 
			this.SpeedPlus.CausesValidation = false;
			this.SpeedPlus.Dock = System.Windows.Forms.DockStyle.Right;
			this.SpeedPlus.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeedPlus.ForeColor = System.Drawing.Color.White;
			this.SpeedPlus.Location = new System.Drawing.Point(109, 0);
			this.SpeedPlus.Name = "SpeedPlus";
			this.SpeedPlus.Size = new System.Drawing.Size(27, 31);
			this.SpeedPlus.TabIndex = 9;
			this.SpeedPlus.Text = "+";
			this.SpeedPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SpeedPlus.Click += new System.EventHandler(this.SpeedPlus_Click);
			this.SpeedPlus.MouseEnter += new System.EventHandler(this.SpeedPlus_MouseEnter);
			this.SpeedPlus.MouseLeave += new System.EventHandler(this.SpeedPlus_MouseLeave);
			// 
			// SpeedMinus
			// 
			this.SpeedMinus.CausesValidation = false;
			this.SpeedMinus.Dock = System.Windows.Forms.DockStyle.Left;
			this.SpeedMinus.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeedMinus.ForeColor = System.Drawing.Color.White;
			this.SpeedMinus.Location = new System.Drawing.Point(0, 0);
			this.SpeedMinus.Name = "SpeedMinus";
			this.SpeedMinus.Size = new System.Drawing.Size(27, 31);
			this.SpeedMinus.TabIndex = 8;
			this.SpeedMinus.Text = "-";
			this.SpeedMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SpeedMinus.Click += new System.EventHandler(this.SpeedMinus_Click);
			this.SpeedMinus.MouseEnter += new System.EventHandler(this.SpeedMinus_MouseEnter);
			this.SpeedMinus.MouseLeave += new System.EventHandler(this.SpeedMinus_MouseLeave);
			// 
			// SpeedText
			// 
			this.SpeedText.BackColor = System.Drawing.Color.Snow;
			this.SpeedText.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SpeedText.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeedText.ForeColor = System.Drawing.Color.Maroon;
			this.SpeedText.Location = new System.Drawing.Point(0, 31);
			this.SpeedText.Name = "SpeedText";
			this.SpeedText.Size = new System.Drawing.Size(136, 17);
			this.SpeedText.TabIndex = 7;
			this.SpeedText.Text = "SPEED";
			this.SpeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scoreValue
			// 
			this.scoreValue.AutoSize = true;
			this.scoreValue.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.scoreValue.Location = new System.Drawing.Point(98, 9);
			this.scoreValue.Name = "scoreValue";
			this.scoreValue.Size = new System.Drawing.Size(65, 38);
			this.scoreValue.TabIndex = 1;
			this.scoreValue.Text = "0.0";
			// 
			// score
			// 
			this.score.AutoSize = true;
			this.score.BackColor = System.Drawing.Color.Transparent;
			this.score.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.score.ForeColor = System.Drawing.Color.Black;
			this.score.Location = new System.Drawing.Point(5, 5);
			this.score.Name = "score";
			this.score.Size = new System.Drawing.Size(104, 42);
			this.score.TabIndex = 0;
			this.score.Text = "Score:";
			// 
			// gameOverLabel
			// 
			this.gameOverLabel.BackColor = System.Drawing.Color.White;
			this.gameOverLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameOverLabel.Location = new System.Drawing.Point(132, 247);
			this.gameOverLabel.Name = "gameOverLabel";
			this.gameOverLabel.Size = new System.Drawing.Size(545, 293);
			this.gameOverLabel.TabIndex = 2;
			this.gameOverLabel.Text = "label1";
			this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusStrip1
			// 
			this.statusStrip1.AllowMerge = false;
			this.statusStrip1.BackColor = System.Drawing.Color.White;
			this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 683);
			this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(824, 36);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.StatusLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(809, 31);
			this.StatusLabel.Spring = true;
			this.StatusLabel.Text = "toolStripStatusLabel1";
			// 
			// gameCanvas
			// 
			this.gameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gameCanvas.Location = new System.Drawing.Point(13, 77);
			this.gameCanvas.Name = "gameCanvas";
			this.gameCanvas.Size = new System.Drawing.Size(800, 600);
			this.gameCanvas.TabIndex = 4;
			this.gameCanvas.TabStop = false;
			this.gameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.gameCanvas_Paint);
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(824, 719);
			this.Controls.Add(this.gameCanvas);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gameOverLabel);
			this.Controls.Add(this.settingsPanel);
			this.MaximumSize = new System.Drawing.Size(840, 758);
			this.MinimumSize = new System.Drawing.Size(840, 758);
			this.Name = "Game";
			this.Text = "Snake";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.settingsPanel.ResumeLayout(false);
			this.settingsPanel.PerformLayout();
			this.SpeedPanel.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		#endregion
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Label scoreValue;
		private System.Windows.Forms.Label score;
		private System.Windows.Forms.Label gameOverLabel;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.Panel SpeedPanel;
		private System.Windows.Forms.Label SpeedLabel;
		private System.Windows.Forms.Label SpeedText;
		private System.Windows.Forms.PictureBox gameCanvas;
		private System.Windows.Forms.Label SpeedMinus;
		private System.Windows.Forms.Label SpeedPlus;
	}
}

