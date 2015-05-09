namespace Yacht_Csharp
{
    partial class Gameplay_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader Player;
            System.Windows.Forms.ColumnHeader Score;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay_Form));
            this.playerList = new System.Windows.Forms.ListView();
            this.rollDice_button = new System.Windows.Forms.Button();
            this.scoresList = new System.Windows.Forms.ListView();
            this.ScoringOption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseScore_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RollDice5 = new System.Windows.Forms.PictureBox();
            this.RollDice4 = new System.Windows.Forms.PictureBox();
            this.RollDice3 = new System.Windows.Forms.PictureBox();
            this.RollDice2 = new System.Windows.Forms.PictureBox();
            this.RollDice1 = new System.Windows.Forms.PictureBox();
            this.HeldDiceBox5 = new System.Windows.Forms.PictureBox();
            this.HeldDiceBox4 = new System.Windows.Forms.PictureBox();
            this.HeldDiceBox3 = new System.Windows.Forms.PictureBox();
            this.HeldDiceBox2 = new System.Windows.Forms.PictureBox();
            this.HeldDiceBox1 = new System.Windows.Forms.PictureBox();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            Player.Text = "Player";
            Player.Width = 118;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.Width = 62;
            // 
            // playerList
            // 
            this.playerList.BackColor = System.Drawing.Color.Yellow;
            this.playerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Player,
            Score});
            this.playerList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playerList.HideSelection = false;
            this.playerList.Location = new System.Drawing.Point(14, 40);
            this.playerList.MultiSelect = false;
            this.playerList.Name = "playerList";
            this.playerList.Scrollable = false;
            this.playerList.Size = new System.Drawing.Size(212, 350);
            this.playerList.TabIndex = 0;
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.View = System.Windows.Forms.View.Details;
            // 
            // rollDice_button
            // 
            this.rollDice_button.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDice_button.ForeColor = System.Drawing.Color.Blue;
            this.rollDice_button.Location = new System.Drawing.Point(14, 396);
            this.rollDice_button.Name = "rollDice_button";
            this.rollDice_button.Size = new System.Drawing.Size(212, 189);
            this.rollDice_button.TabIndex = 2;
            this.rollDice_button.Text = "Roll the dice";
            this.rollDice_button.UseVisualStyleBackColor = true;
            this.rollDice_button.Click += new System.EventHandler(this.rollDice_button_Click);
            // 
            // scoresList
            // 
            this.scoresList.BackColor = System.Drawing.Color.Yellow;
            this.scoresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScoringOption,
            this.Points});
            this.scoresList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresList.Location = new System.Drawing.Point(946, 158);
            this.scoresList.MultiSelect = false;
            this.scoresList.Name = "scoresList";
            this.scoresList.Size = new System.Drawing.Size(250, 332);
            this.scoresList.TabIndex = 7;
            this.scoresList.UseCompatibleStateImageBehavior = false;
            this.scoresList.View = System.Windows.Forms.View.Details;
            // 
            // ScoringOption
            // 
            this.ScoringOption.Text = "Scoring Option";
            this.ScoringOption.Width = 140;
            // 
            // Points
            // 
            this.Points.Text = "Points";
            this.Points.Width = 70;
            // 
            // chooseScore_button
            // 
            this.chooseScore_button.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseScore_button.ForeColor = System.Drawing.Color.Blue;
            this.chooseScore_button.Location = new System.Drawing.Point(946, 496);
            this.chooseScore_button.Name = "chooseScore_button";
            this.chooseScore_button.Size = new System.Drawing.Size(251, 89);
            this.chooseScore_button.TabIndex = 9;
            this.chooseScore_button.Text = "Choose Score";
            this.chooseScore_button.UseVisualStyleBackColor = true;
            this.chooseScore_button.Click += new System.EventHandler(this.chooseScore_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(875, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "here";
            this.label1.Click += new System.EventHandler(this.EasterEgg2_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(862, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Turn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameStateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // saveGameStateToolStripMenuItem
            // 
            this.saveGameStateToolStripMenuItem.Name = "saveGameStateToolStripMenuItem";
            this.saveGameStateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveGameStateToolStripMenuItem.Text = "Save Game State";
            this.saveGameStateToolStripMenuItem.Click += new System.EventHandler(this.saveGameStateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Main Menu";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RollDice5
            // 
            this.RollDice5.Location = new System.Drawing.Point(588, 321);
            this.RollDice5.Name = "RollDice5";
            this.RollDice5.Size = new System.Drawing.Size(117, 100);
            this.RollDice5.TabIndex = 23;
            this.RollDice5.TabStop = false;
            this.RollDice5.Click += new System.EventHandler(this.RollDice5_Click);
            // 
            // RollDice4
            // 
            this.RollDice4.Location = new System.Drawing.Point(409, 321);
            this.RollDice4.Name = "RollDice4";
            this.RollDice4.Size = new System.Drawing.Size(117, 100);
            this.RollDice4.TabIndex = 22;
            this.RollDice4.TabStop = false;
            this.RollDice4.Click += new System.EventHandler(this.RollDice4_Click);
            // 
            // RollDice3
            // 
            this.RollDice3.Location = new System.Drawing.Point(659, 191);
            this.RollDice3.Name = "RollDice3";
            this.RollDice3.Size = new System.Drawing.Size(117, 100);
            this.RollDice3.TabIndex = 21;
            this.RollDice3.TabStop = false;
            this.RollDice3.Click += new System.EventHandler(this.RollDice3_Click);
            // 
            // RollDice2
            // 
            this.RollDice2.Location = new System.Drawing.Point(342, 191);
            this.RollDice2.Name = "RollDice2";
            this.RollDice2.Size = new System.Drawing.Size(117, 100);
            this.RollDice2.TabIndex = 20;
            this.RollDice2.TabStop = false;
            this.RollDice2.Click += new System.EventHandler(this.RollDice2_Click);
            // 
            // RollDice1
            // 
            this.RollDice1.InitialImage = ((System.Drawing.Image)(resources.GetObject("RollDice1.InitialImage")));
            this.RollDice1.Location = new System.Drawing.Point(498, 85);
            this.RollDice1.Name = "RollDice1";
            this.RollDice1.Size = new System.Drawing.Size(117, 100);
            this.RollDice1.TabIndex = 19;
            this.RollDice1.TabStop = false;
            this.RollDice1.Click += new System.EventHandler(this.RollDice1_Click);
            // 
            // HeldDiceBox5
            // 
            this.HeldDiceBox5.Location = new System.Drawing.Point(31, 259);
            this.HeldDiceBox5.Name = "HeldDiceBox5";
            this.HeldDiceBox5.Size = new System.Drawing.Size(58, 50);
            this.HeldDiceBox5.TabIndex = 18;
            this.HeldDiceBox5.TabStop = false;
            this.HeldDiceBox5.Click += new System.EventHandler(this.HeldDiceBox5_Click);
            // 
            // HeldDiceBox4
            // 
            this.HeldDiceBox4.Location = new System.Drawing.Point(31, 203);
            this.HeldDiceBox4.Name = "HeldDiceBox4";
            this.HeldDiceBox4.Size = new System.Drawing.Size(58, 50);
            this.HeldDiceBox4.TabIndex = 17;
            this.HeldDiceBox4.TabStop = false;
            this.HeldDiceBox4.Click += new System.EventHandler(this.HeldDiceBox4_Click);
            // 
            // HeldDiceBox3
            // 
            this.HeldDiceBox3.Location = new System.Drawing.Point(31, 147);
            this.HeldDiceBox3.Name = "HeldDiceBox3";
            this.HeldDiceBox3.Size = new System.Drawing.Size(58, 50);
            this.HeldDiceBox3.TabIndex = 16;
            this.HeldDiceBox3.TabStop = false;
            this.HeldDiceBox3.Click += new System.EventHandler(this.HeldDiceBox3_Click);
            // 
            // HeldDiceBox2
            // 
            this.HeldDiceBox2.Location = new System.Drawing.Point(31, 91);
            this.HeldDiceBox2.Name = "HeldDiceBox2";
            this.HeldDiceBox2.Size = new System.Drawing.Size(58, 50);
            this.HeldDiceBox2.TabIndex = 15;
            this.HeldDiceBox2.TabStop = false;
            this.HeldDiceBox2.Click += new System.EventHandler(this.HeldDiceBox2_Click);
            // 
            // HeldDiceBox1
            // 
            this.HeldDiceBox1.InitialImage = null;
            this.HeldDiceBox1.Location = new System.Drawing.Point(31, 35);
            this.HeldDiceBox1.Name = "HeldDiceBox1";
            this.HeldDiceBox1.Size = new System.Drawing.Size(58, 50);
            this.HeldDiceBox1.TabIndex = 14;
            this.HeldDiceBox1.TabStop = false;
            this.HeldDiceBox1.Click += new System.EventHandler(this.HeldDiceBox1_Click);
            // 
            // AvatarBox
            // 
            this.AvatarBox.InitialImage = global::Yacht_Csharp.Properties.Resources.badass;
            this.AvatarBox.Location = new System.Drawing.Point(1080, 40);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(117, 100);
            this.AvatarBox.TabIndex = 10;
            this.AvatarBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HeldDiceBox2);
            this.panel1.Controls.Add(this.HeldDiceBox1);
            this.panel1.Controls.Add(this.HeldDiceBox3);
            this.panel1.Controls.Add(this.HeldDiceBox4);
            this.panel1.Controls.Add(this.HeldDiceBox5);
            this.panel1.Location = new System.Drawing.Point(822, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 332);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(-6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Held Dice";
            // 
            // Gameplay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1211, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RollDice5);
            this.Controls.Add(this.RollDice4);
            this.Controls.Add(this.RollDice3);
            this.Controls.Add(this.RollDice2);
            this.Controls.Add(this.RollDice1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvatarBox);
            this.Controls.Add(this.chooseScore_button);
            this.Controls.Add(this.scoresList);
            this.Controls.Add(this.rollDice_button);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gameplay_Form";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gameplay_FormClosed);
            this.Load += new System.EventHandler(this.Gamesetup_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeldDiceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.Button rollDice_button;
        private System.Windows.Forms.ListView scoresList;
        private System.Windows.Forms.ColumnHeader ScoringOption;
        private System.Windows.Forms.ColumnHeader Points;
        private System.Windows.Forms.Button chooseScore_button;
        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox HeldDiceBox1;
        private System.Windows.Forms.PictureBox HeldDiceBox2;
        private System.Windows.Forms.PictureBox HeldDiceBox3;
        private System.Windows.Forms.PictureBox HeldDiceBox4;
        private System.Windows.Forms.PictureBox HeldDiceBox5;
        private System.Windows.Forms.PictureBox RollDice1;
        private System.Windows.Forms.PictureBox RollDice2;
        private System.Windows.Forms.PictureBox RollDice3;
        private System.Windows.Forms.PictureBox RollDice4;
        private System.Windows.Forms.PictureBox RollDice5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}