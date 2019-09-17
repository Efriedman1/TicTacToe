namespace TicTacToe
{
    partial class frmTicTacToe
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.txtPlayerAName = new System.Windows.Forms.TextBox();
            this.txtPlayerBName = new System.Windows.Forms.TextBox();
            this.btnNameOneOK = new System.Windows.Forms.Button();
            this.btnNameTwoOK = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnBoard02 = new System.Windows.Forms.Button();
            this.btnBoard12 = new System.Windows.Forms.Button();
            this.btnBoard01 = new System.Windows.Forms.Button();
            this.btnBoard11 = new System.Windows.Forms.Button();
            this.btnBoard00 = new System.Windows.Forms.Button();
            this.btnBoard10 = new System.Windows.Forms.Button();
            this.btnBoard22 = new System.Windows.Forms.Button();
            this.btnBoard21 = new System.Windows.Forms.Button();
            this.btnBoard20 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnP1Edit = new System.Windows.Forms.Button();
            this.btnP2Edit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBoard.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(305, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic Tac Toe";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(66, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(664, 22);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Welcome to Tic Tac Toe! Please get started by entering the players names below!";
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneName.Location = new System.Drawing.Point(62, 157);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(177, 29);
            this.lblPlayerOneName.TabIndex = 2;
            this.lblPlayerOneName.Text = "Player 1 Name:";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoName.Location = new System.Drawing.Point(62, 221);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(177, 29);
            this.lblPlayerTwoName.TabIndex = 3;
            this.lblPlayerTwoName.Text = "Player 2 Name:";
            this.lblPlayerTwoName.Visible = false;
            // 
            // txtPlayerAName
            // 
            this.txtPlayerAName.Location = new System.Drawing.Point(255, 160);
            this.txtPlayerAName.Name = "txtPlayerAName";
            this.txtPlayerAName.Size = new System.Drawing.Size(286, 26);
            this.txtPlayerAName.TabIndex = 4;
            // 
            // txtPlayerBName
            // 
            this.txtPlayerBName.Location = new System.Drawing.Point(255, 224);
            this.txtPlayerBName.Name = "txtPlayerBName";
            this.txtPlayerBName.Size = new System.Drawing.Size(286, 26);
            this.txtPlayerBName.TabIndex = 5;
            this.txtPlayerBName.Visible = false;
            // 
            // btnNameOneOK
            // 
            this.btnNameOneOK.Location = new System.Drawing.Point(557, 161);
            this.btnNameOneOK.Name = "btnNameOneOK";
            this.btnNameOneOK.Size = new System.Drawing.Size(85, 29);
            this.btnNameOneOK.TabIndex = 6;
            this.btnNameOneOK.Text = "OK";
            this.btnNameOneOK.UseVisualStyleBackColor = true;
            this.btnNameOneOK.Click += new System.EventHandler(this.btnNameOneOK_Click);
            // 
            // btnNameTwoOK
            // 
            this.btnNameTwoOK.Location = new System.Drawing.Point(557, 225);
            this.btnNameTwoOK.Name = "btnNameTwoOK";
            this.btnNameTwoOK.Size = new System.Drawing.Size(85, 29);
            this.btnNameTwoOK.TabIndex = 7;
            this.btnNameTwoOK.Text = "OK";
            this.btnNameTwoOK.UseVisualStyleBackColor = true;
            this.btnNameTwoOK.Visible = false;
            this.btnNameTwoOK.Click += new System.EventHandler(this.btnNameTwoOK_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Controls.Add(this.btnBoard02);
            this.pnlBoard.Controls.Add(this.btnBoard12);
            this.pnlBoard.Controls.Add(this.btnBoard01);
            this.pnlBoard.Controls.Add(this.btnBoard11);
            this.pnlBoard.Controls.Add(this.btnBoard00);
            this.pnlBoard.Controls.Add(this.btnBoard10);
            this.pnlBoard.Controls.Add(this.btnBoard22);
            this.pnlBoard.Controls.Add(this.btnBoard21);
            this.pnlBoard.Controls.Add(this.btnBoard20);
            this.pnlBoard.Location = new System.Drawing.Point(155, 339);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(500, 500);
            this.pnlBoard.TabIndex = 8;
            this.pnlBoard.Visible = false;
            // 
            // btnBoard02
            // 
            this.btnBoard02.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard02.Location = new System.Drawing.Point(347, 3);
            this.btnBoard02.Name = "btnBoard02";
            this.btnBoard02.Size = new System.Drawing.Size(150, 150);
            this.btnBoard02.TabIndex = 8;
            this.btnBoard02.UseVisualStyleBackColor = true;
            this.btnBoard02.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard12
            // 
            this.btnBoard12.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard12.Location = new System.Drawing.Point(347, 175);
            this.btnBoard12.Name = "btnBoard12";
            this.btnBoard12.Size = new System.Drawing.Size(150, 150);
            this.btnBoard12.TabIndex = 7;
            this.btnBoard12.UseVisualStyleBackColor = true;
            this.btnBoard12.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard01
            // 
            this.btnBoard01.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard01.Location = new System.Drawing.Point(176, 3);
            this.btnBoard01.Name = "btnBoard01";
            this.btnBoard01.Size = new System.Drawing.Size(150, 150);
            this.btnBoard01.TabIndex = 6;
            this.btnBoard01.UseVisualStyleBackColor = true;
            this.btnBoard01.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard11
            // 
            this.btnBoard11.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard11.Location = new System.Drawing.Point(176, 175);
            this.btnBoard11.Name = "btnBoard11";
            this.btnBoard11.Size = new System.Drawing.Size(150, 150);
            this.btnBoard11.TabIndex = 5;
            this.btnBoard11.UseVisualStyleBackColor = true;
            this.btnBoard11.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard00
            // 
            this.btnBoard00.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard00.Location = new System.Drawing.Point(3, 3);
            this.btnBoard00.Name = "btnBoard00";
            this.btnBoard00.Size = new System.Drawing.Size(150, 150);
            this.btnBoard00.TabIndex = 4;
            this.btnBoard00.UseVisualStyleBackColor = true;
            this.btnBoard00.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard10
            // 
            this.btnBoard10.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard10.Location = new System.Drawing.Point(3, 175);
            this.btnBoard10.Name = "btnBoard10";
            this.btnBoard10.Size = new System.Drawing.Size(150, 150);
            this.btnBoard10.TabIndex = 3;
            this.btnBoard10.UseVisualStyleBackColor = true;
            this.btnBoard10.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard22
            // 
            this.btnBoard22.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard22.Location = new System.Drawing.Point(347, 347);
            this.btnBoard22.Name = "btnBoard22";
            this.btnBoard22.Size = new System.Drawing.Size(150, 150);
            this.btnBoard22.TabIndex = 2;
            this.btnBoard22.UseVisualStyleBackColor = true;
            this.btnBoard22.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard21
            // 
            this.btnBoard21.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard21.Location = new System.Drawing.Point(176, 347);
            this.btnBoard21.Name = "btnBoard21";
            this.btnBoard21.Size = new System.Drawing.Size(150, 150);
            this.btnBoard21.TabIndex = 1;
            this.btnBoard21.UseVisualStyleBackColor = true;
            this.btnBoard21.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoard20
            // 
            this.btnBoard20.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard20.Location = new System.Drawing.Point(3, 347);
            this.btnBoard20.Name = "btnBoard20";
            this.btnBoard20.Size = new System.Drawing.Size(150, 150);
            this.btnBoard20.TabIndex = 0;
            this.btnBoard20.UseVisualStyleBackColor = true;
            this.btnBoard20.Click += new System.EventHandler(this.Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(318, 277);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(172, 35);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnP1Edit
            // 
            this.btnP1Edit.Location = new System.Drawing.Point(651, 161);
            this.btnP1Edit.Name = "btnP1Edit";
            this.btnP1Edit.Size = new System.Drawing.Size(85, 29);
            this.btnP1Edit.TabIndex = 11;
            this.btnP1Edit.Text = "Edit";
            this.btnP1Edit.UseVisualStyleBackColor = true;
            this.btnP1Edit.Visible = false;
            this.btnP1Edit.Click += new System.EventHandler(this.btnP1Edit_Click);
            // 
            // btnP2Edit
            // 
            this.btnP2Edit.Location = new System.Drawing.Point(651, 225);
            this.btnP2Edit.Name = "btnP2Edit";
            this.btnP2Edit.Size = new System.Drawing.Size(85, 29);
            this.btnP2Edit.TabIndex = 12;
            this.btnP2Edit.Text = "Edit";
            this.btnP2Edit.UseVisualStyleBackColor = true;
            this.btnP2Edit.Visible = false;
            this.btnP2Edit.Click += new System.EventHandler(this.btnP2Edit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(215, 869);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(172, 35);
            this.btnNewGame.TabIndex = 13;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 869);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 950);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnP2Edit);
            this.Controls.Add(this.btnP1Edit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnNameTwoOK);
            this.Controls.Add(this.btnNameOneOK);
            this.Controls.Add(this.txtPlayerBName);
            this.Controls.Add(this.txtPlayerAName);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.pnlBoard.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.Label lblPlayerTwoName;
        private System.Windows.Forms.TextBox txtPlayerAName;
        private System.Windows.Forms.TextBox txtPlayerBName;
        private System.Windows.Forms.Button btnNameOneOK;
        private System.Windows.Forms.Button btnNameTwoOK;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnBoard02;
        private System.Windows.Forms.Button btnBoard12;
        private System.Windows.Forms.Button btnBoard01;
        private System.Windows.Forms.Button btnBoard11;
        private System.Windows.Forms.Button btnBoard00;
        private System.Windows.Forms.Button btnBoard10;
        private System.Windows.Forms.Button btnBoard22;
        private System.Windows.Forms.Button btnBoard21;
        private System.Windows.Forms.Button btnBoard20;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnP1Edit;
        private System.Windows.Forms.Button btnP2Edit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
    }
}

