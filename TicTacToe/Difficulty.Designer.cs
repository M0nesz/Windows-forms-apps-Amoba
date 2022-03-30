namespace TicTacToe
{
    partial class Difficulty
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.difficulty_title = new System.Windows.Forms.Label();
            this.player1_o = new System.Windows.Forms.Label();
            this.player1_x = new System.Windows.Forms.Label();
            this.difficulty_easy = new System.Windows.Forms.Label();
            this.difficulty_normal = new System.Windows.Forms.Label();
            this.difficulty_hard = new System.Windows.Forms.Label();
            this.difficulty_arrow_right = new System.Windows.Forms.Button();
            this.player1name = new System.Windows.Forms.TextBox();
            this.player1_arrow_right = new System.Windows.Forms.Button();
            this.player2name = new System.Windows.Forms.TextBox();
            this.player2_x = new System.Windows.Forms.Label();
            this.player2_o = new System.Windows.Forms.Label();
            this.player2_arrow_right = new System.Windows.Forms.Button();
            this.player1_arrow_left = new System.Windows.Forms.Button();
            this.player2_arrow_left = new System.Windows.Forms.Button();
            this.difficulty_arrow_left = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficulty_title
            // 
            this.difficulty_title.AutoSize = true;
            this.difficulty_title.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_title.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficulty_title.Location = new System.Drawing.Point(137, 112);
            this.difficulty_title.Name = "difficulty_title";
            this.difficulty_title.Size = new System.Drawing.Size(168, 46);
            this.difficulty_title.TabIndex = 0;
            this.difficulty_title.Text = "Difficulty:";
            // 
            // player1_o
            // 
            this.player1_o.AutoSize = true;
            this.player1_o.BackColor = System.Drawing.Color.Transparent;
            this.player1_o.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1_o.Location = new System.Drawing.Point(500, 222);
            this.player1_o.Name = "player1_o";
            this.player1_o.Size = new System.Drawing.Size(51, 46);
            this.player1_o.TabIndex = 5;
            this.player1_o.Text = "O";
            // 
            // player1_x
            // 
            this.player1_x.AutoSize = true;
            this.player1_x.BackColor = System.Drawing.Color.Transparent;
            this.player1_x.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1_x.Location = new System.Drawing.Point(500, 222);
            this.player1_x.Name = "player1_x";
            this.player1_x.Size = new System.Drawing.Size(42, 46);
            this.player1_x.TabIndex = 6;
            this.player1_x.Text = "X";
            // 
            // difficulty_easy
            // 
            this.difficulty_easy.AutoSize = true;
            this.difficulty_easy.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_easy.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficulty_easy.Location = new System.Drawing.Point(488, 104);
            this.difficulty_easy.Name = "difficulty_easy";
            this.difficulty_easy.Size = new System.Drawing.Size(93, 46);
            this.difficulty_easy.TabIndex = 7;
            this.difficulty_easy.Text = "Easy";
            // 
            // difficulty_normal
            // 
            this.difficulty_normal.AutoSize = true;
            this.difficulty_normal.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_normal.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficulty_normal.Location = new System.Drawing.Point(457, 104);
            this.difficulty_normal.Name = "difficulty_normal";
            this.difficulty_normal.Size = new System.Drawing.Size(145, 46);
            this.difficulty_normal.TabIndex = 8;
            this.difficulty_normal.Text = "Normal";
            // 
            // difficulty_hard
            // 
            this.difficulty_hard.AutoSize = true;
            this.difficulty_hard.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_hard.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficulty_hard.Location = new System.Drawing.Point(477, 104);
            this.difficulty_hard.Name = "difficulty_hard";
            this.difficulty_hard.Size = new System.Drawing.Size(104, 46);
            this.difficulty_hard.TabIndex = 9;
            this.difficulty_hard.Text = "Hard";
            // 
            // difficulty_arrow_right
            // 
            this.difficulty_arrow_right.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_arrow_right.BackgroundImage = global::TicTacToe.Properties.Resources.arrow;
            this.difficulty_arrow_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.difficulty_arrow_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difficulty_arrow_right.Location = new System.Drawing.Point(608, 112);
            this.difficulty_arrow_right.Name = "difficulty_arrow_right";
            this.difficulty_arrow_right.Size = new System.Drawing.Size(33, 29);
            this.difficulty_arrow_right.TabIndex = 15;
            this.difficulty_arrow_right.UseVisualStyleBackColor = false;
            this.difficulty_arrow_right.Click += new System.EventHandler(this.difficulty_arrow_right_Click);
            // 
            // player1name
            // 
            this.player1name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.player1name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1name.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1name.Location = new System.Drawing.Point(137, 222);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(125, 53);
            this.player1name.TabIndex = 16;
            this.player1name.Text = "Player1";
            // 
            // player1_arrow_right
            // 
            this.player1_arrow_right.BackColor = System.Drawing.Color.Transparent;
            this.player1_arrow_right.BackgroundImage = global::TicTacToe.Properties.Resources.arrow;
            this.player1_arrow_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1_arrow_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player1_arrow_right.Location = new System.Drawing.Point(608, 230);
            this.player1_arrow_right.Name = "player1_arrow_right";
            this.player1_arrow_right.Size = new System.Drawing.Size(33, 29);
            this.player1_arrow_right.TabIndex = 17;
            this.player1_arrow_right.UseVisualStyleBackColor = false;
            this.player1_arrow_right.Click += new System.EventHandler(this.player1_arrow_right_Click);
            // 
            // player2name
            // 
            this.player2name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.player2name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2name.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2name.Location = new System.Drawing.Point(137, 348);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(125, 53);
            this.player2name.TabIndex = 18;
            this.player2name.Text = "Player2";
            // 
            // player2_x
            // 
            this.player2_x.AutoSize = true;
            this.player2_x.BackColor = System.Drawing.Color.Transparent;
            this.player2_x.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2_x.Location = new System.Drawing.Point(509, 348);
            this.player2_x.Name = "player2_x";
            this.player2_x.Size = new System.Drawing.Size(42, 46);
            this.player2_x.TabIndex = 19;
            this.player2_x.Text = "X";
            // 
            // player2_o
            // 
            this.player2_o.AutoSize = true;
            this.player2_o.BackColor = System.Drawing.Color.Transparent;
            this.player2_o.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2_o.Location = new System.Drawing.Point(500, 350);
            this.player2_o.Name = "player2_o";
            this.player2_o.Size = new System.Drawing.Size(51, 46);
            this.player2_o.TabIndex = 20;
            this.player2_o.Text = "O";
            // 
            // player2_arrow_right
            // 
            this.player2_arrow_right.BackColor = System.Drawing.Color.Transparent;
            this.player2_arrow_right.BackgroundImage = global::TicTacToe.Properties.Resources.arrow;
            this.player2_arrow_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2_arrow_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player2_arrow_right.Location = new System.Drawing.Point(608, 355);
            this.player2_arrow_right.Name = "player2_arrow_right";
            this.player2_arrow_right.Size = new System.Drawing.Size(33, 29);
            this.player2_arrow_right.TabIndex = 21;
            this.player2_arrow_right.UseVisualStyleBackColor = false;
            this.player2_arrow_right.Click += new System.EventHandler(this.player2_arrow_right_Click);
            // 
            // player1_arrow_left
            // 
            this.player1_arrow_left.BackColor = System.Drawing.Color.Transparent;
            this.player1_arrow_left.BackgroundImage = global::TicTacToe.Properties.Resources.arrow_left;
            this.player1_arrow_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1_arrow_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player1_arrow_left.Location = new System.Drawing.Point(407, 230);
            this.player1_arrow_left.Name = "player1_arrow_left";
            this.player1_arrow_left.Size = new System.Drawing.Size(33, 29);
            this.player1_arrow_left.TabIndex = 22;
            this.player1_arrow_left.UseVisualStyleBackColor = false;
            this.player1_arrow_left.Click += new System.EventHandler(this.player1_arrow_left_Click);
            // 
            // player2_arrow_left
            // 
            this.player2_arrow_left.BackColor = System.Drawing.Color.Transparent;
            this.player2_arrow_left.BackgroundImage = global::TicTacToe.Properties.Resources.arrow_left;
            this.player2_arrow_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2_arrow_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player2_arrow_left.Location = new System.Drawing.Point(407, 355);
            this.player2_arrow_left.Name = "player2_arrow_left";
            this.player2_arrow_left.Size = new System.Drawing.Size(33, 29);
            this.player2_arrow_left.TabIndex = 23;
            this.player2_arrow_left.UseVisualStyleBackColor = false;
            this.player2_arrow_left.Click += new System.EventHandler(this.player2_arrow_left_Click);
            // 
            // difficulty_arrow_left
            // 
            this.difficulty_arrow_left.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_arrow_left.BackgroundImage = global::TicTacToe.Properties.Resources.arrow_left;
            this.difficulty_arrow_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.difficulty_arrow_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difficulty_arrow_left.Location = new System.Drawing.Point(407, 112);
            this.difficulty_arrow_left.Name = "difficulty_arrow_left";
            this.difficulty_arrow_left.Size = new System.Drawing.Size(33, 29);
            this.difficulty_arrow_left.TabIndex = 24;
            this.difficulty_arrow_left.UseVisualStyleBackColor = false;
            this.difficulty_arrow_left.Click += new System.EventHandler(this.difficulty_arrow_left_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Eras Light ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start.Location = new System.Drawing.Point(326, 473);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(160, 65);
            this.start.TabIndex = 25;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.start);
            this.Controls.Add(this.difficulty_arrow_left);
            this.Controls.Add(this.player2_arrow_left);
            this.Controls.Add(this.player1_arrow_left);
            this.Controls.Add(this.player2_arrow_right);
            this.Controls.Add(this.player2_o);
            this.Controls.Add(this.player2_x);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1_arrow_right);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.difficulty_arrow_right);
            this.Controls.Add(this.difficulty_hard);
            this.Controls.Add(this.difficulty_normal);
            this.Controls.Add(this.difficulty_easy);
            this.Controls.Add(this.player1_x);
            this.Controls.Add(this.player1_o);
            this.Controls.Add(this.difficulty_title);
            this.Font = new System.Drawing.Font("Eras Light ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Difficulty";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label difficulty_title;
        private Label player1_o;
        private Label player1_x;
        private Label difficulty_easy;
        private Label difficulty_normal;
        private Label difficulty_hard;
        private Button difficulty_arrow_right;
        private TextBox player1name;
        private Button player1_arrow_right;
        private TextBox player2name;
        private Label player2_x;
        private Label player2_o;
        private Button player2_arrow_right;
        private Button player1_arrow_left;
        private Button player2_arrow_left;
        private Button difficulty_arrow_left;
        private Button start;
    }
}
