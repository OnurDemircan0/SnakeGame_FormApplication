namespace SnakeGame_FormApplication
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
            tableLayoutPanel1 = new TableLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            playButton = new Button();
            scoreLabel = new Label();
            GameOverScreen = new Label();
            difficultyComboBox = new ComboBox();
            label3 = new Label();
            highScoresDataLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(500, 500);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(752, 236);
            numericUpDown1.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(752, 213);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(817, 213);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Width";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(817, 236);
            numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(59, 27);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += Timer_Tick;
            // 
            // playButton
            // 
            playButton.BackColor = SystemColors.MenuHighlight;
            playButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            playButton.Location = new Point(752, 60);
            playButton.Name = "playButton";
            playButton.Size = new Size(124, 50);
            playButton.TabIndex = 7;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += PlayButton;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreLabel.Location = new Point(752, 123);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(84, 28);
            scoreLabel.TabIndex = 8;
            scoreLabel.Text = "Score: 0";
            // 
            // GameOverScreen
            // 
            GameOverScreen.BackColor = Color.Gray;
            GameOverScreen.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            GameOverScreen.Location = new Point(296, 163);
            GameOverScreen.Name = "GameOverScreen";
            GameOverScreen.Size = new Size(355, 172);
            GameOverScreen.TabIndex = 9;
            GameOverScreen.Text = "Game Over";
            GameOverScreen.TextAlign = ContentAlignment.MiddleCenter;
            GameOverScreen.Visible = false;
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Expert" });
            difficultyComboBox.Location = new Point(754, 313);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(151, 28);
            difficultyComboBox.TabIndex = 10;
            difficultyComboBox.Tag = "";
            difficultyComboBox.SelectedIndexChanged += DifficultySelection;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(613, 35);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 11;
            label3.Text = "High Scores";
            // 
            // highScoresDataLabel
            // 
            highScoresDataLabel.AutoSize = true;
            highScoresDataLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            highScoresDataLabel.ForeColor = Color.SandyBrown;
            highScoresDataLabel.Location = new Point(613, 74);
            highScoresDataLabel.Name = "highScoresDataLabel";
            highScoresDataLabel.Size = new Size(89, 56);
            highScoresDataLabel.TabIndex = 12;
            highScoresDataLabel.Text = "No High\r\nScores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 547);
            Controls.Add(highScoresDataLabel);
            Controls.Add(label3);
            Controls.Add(difficultyComboBox);
            Controls.Add(GameOverScreen);
            Controls.Add(scoreLabel);
            Controls.Add(playButton);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private System.Windows.Forms.Timer timer1;
        private Button playButton;
        private Label scoreLabel;
        private Label GameOverScreen;
        private ComboBox difficultyComboBox;
        private Label label3;
        private Label highScoresDataLabel;
    }
}
