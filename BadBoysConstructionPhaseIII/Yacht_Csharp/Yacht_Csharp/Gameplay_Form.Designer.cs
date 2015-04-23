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
            System.Windows.Forms.ColumnHeader Player;
            System.Windows.Forms.ColumnHeader Score;
            this.playerList = new System.Windows.Forms.ListView();
            this.rollDice_button = new System.Windows.Forms.Button();
            this.rolldiceList = new System.Windows.Forms.ListView();
            this.Dice_Rolled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoresList = new System.Windows.Forms.ListView();
            this.ScoringOption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseScore_button = new System.Windows.Forms.Button();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.playerList.Location = new System.Drawing.Point(12, 40);
            this.playerList.MultiSelect = false;
            this.playerList.Name = "playerList";
            this.playerList.Scrollable = false;
            this.playerList.Size = new System.Drawing.Size(182, 350);
            this.playerList.TabIndex = 0;
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.View = System.Windows.Forms.View.Details;
            // 
            // rollDice_button
            // 
            this.rollDice_button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDice_button.Location = new System.Drawing.Point(125, 407);
            this.rollDice_button.Name = "rollDice_button";
            this.rollDice_button.Size = new System.Drawing.Size(69, 178);
            this.rollDice_button.TabIndex = 2;
            this.rollDice_button.Text = "Roll the dice";
            this.rollDice_button.UseVisualStyleBackColor = true;
            this.rollDice_button.Click += new System.EventHandler(this.rollDice_button_Click);
            // 
            // rolldiceList
            // 
            this.rolldiceList.CheckBoxes = true;
            this.rolldiceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dice_Rolled});
            this.rolldiceList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolldiceList.Location = new System.Drawing.Point(12, 407);
            this.rolldiceList.Name = "rolldiceList";
            this.rolldiceList.Scrollable = false;
            this.rolldiceList.Size = new System.Drawing.Size(107, 178);
            this.rolldiceList.TabIndex = 3;
            this.rolldiceList.UseCompatibleStateImageBehavior = false;
            this.rolldiceList.View = System.Windows.Forms.View.Details;
            // 
            // Dice_Rolled
            // 
            this.Dice_Rolled.Text = "Dice Rolled";
            this.Dice_Rolled.Width = 103;
            // 
            // scoresList
            // 
            this.scoresList.BackColor = System.Drawing.Color.Yellow;
            this.scoresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScoringOption,
            this.Points});
            this.scoresList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresList.Location = new System.Drawing.Point(757, 158);
            this.scoresList.MultiSelect = false;
            this.scoresList.Name = "scoresList";
            this.scoresList.Size = new System.Drawing.Size(215, 350);
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
            this.chooseScore_button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseScore_button.Location = new System.Drawing.Point(757, 533);
            this.chooseScore_button.Name = "chooseScore_button";
            this.chooseScore_button.Size = new System.Drawing.Size(215, 52);
            this.chooseScore_button.TabIndex = 9;
            this.chooseScore_button.Text = "Choose Score";
            this.chooseScore_button.UseVisualStyleBackColor = true;
            this.chooseScore_button.Click += new System.EventHandler(this.chooseScore_button_Click);
            // 
            // AvatarBox
            // 
            this.AvatarBox.InitialImage = global::Yacht_Csharp.Properties.Resources.badass;
            this.AvatarBox.Location = new System.Drawing.Point(872, 40);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(100, 100);
            this.AvatarBox.TabIndex = 10;
            this.AvatarBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(735, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "here";
            this.label1.Click += new System.EventHandler(this.EasterEgg2_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(724, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player Turn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
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
            // Gameplay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvatarBox);
            this.Controls.Add(this.chooseScore_button);
            this.Controls.Add(this.scoresList);
            this.Controls.Add(this.rolldiceList);
            this.Controls.Add(this.rollDice_button);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gameplay_Form";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gameplay_FormClosed);
            this.Load += new System.EventHandler(this.Gamesetup_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.Button rollDice_button;
        private System.Windows.Forms.ListView rolldiceList;
        private System.Windows.Forms.ColumnHeader Dice_Rolled;
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
    }
}