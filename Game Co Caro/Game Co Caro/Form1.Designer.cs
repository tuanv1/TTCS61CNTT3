namespace Game_Co_Caro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnShow = new System.Windows.Forms.Panel();
            this.lbRule = new System.Windows.Forms.Label();
            this.ptbPayer = new System.Windows.Forms.PictureBox();
            this.psbCooldownTime = new System.Windows.Forms.ProgressBar();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.Avata = new System.Windows.Forms.PictureBox();
            this.pnTableChess = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.player1VsPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCooldown = new System.Windows.Forms.Timer(this.components);
            this.pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).BeginInit();
            this.pnTableChess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.White;
            this.pnShow.Controls.Add(this.lbRule);
            this.pnShow.Controls.Add(this.ptbPayer);
            this.pnShow.Controls.Add(this.psbCooldownTime);
            this.pnShow.Controls.Add(this.txtNamePlayer);
            this.pnShow.Controls.Add(this.Avata);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnShow.Location = new System.Drawing.Point(616, 0);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(234, 558);
            this.pnShow.TabIndex = 2;
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRule.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(0, 465);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(230, 27);
            this.lbRule.TabIndex = 4;
            this.lbRule.Text = " 5 in a line to win";
            // 
            // ptbPayer
            // 
            this.ptbPayer.BackColor = System.Drawing.Color.Gray;
            this.ptbPayer.Location = new System.Drawing.Point(132, 286);
            this.ptbPayer.Name = "ptbPayer";
            this.ptbPayer.Size = new System.Drawing.Size(99, 86);
            this.ptbPayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPayer.TabIndex = 3;
            this.ptbPayer.TabStop = false;
            // 
            // psbCooldownTime
            // 
            this.psbCooldownTime.Location = new System.Drawing.Point(6, 335);
            this.psbCooldownTime.Maximum = 20000;
            this.psbCooldownTime.Name = "psbCooldownTime";
            this.psbCooldownTime.Size = new System.Drawing.Size(120, 37);
            this.psbCooldownTime.Step = 100;
            this.psbCooldownTime.TabIndex = 1;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer.Location = new System.Drawing.Point(6, 286);
            this.txtNamePlayer.Multiline = true;
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.ReadOnly = true;
            this.txtNamePlayer.Size = new System.Drawing.Size(120, 37);
            this.txtNamePlayer.TabIndex = 10;
            // 
            // Avata
            // 
            this.Avata.Image = ((System.Drawing.Image)(resources.GetObject("Avata.Image")));
            this.Avata.Location = new System.Drawing.Point(3, 26);
            this.Avata.Name = "Avata";
            this.Avata.Size = new System.Drawing.Size(229, 221);
            this.Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avata.TabIndex = 0;
            this.Avata.TabStop = false;
            // 
            // pnTableChess
            // 
            this.pnTableChess.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnTableChess.Controls.Add(this.menuStrip1);
            this.pnTableChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableChess.Location = new System.Drawing.Point(0, 0);
            this.pnTableChess.Name = "pnTableChess";
            this.pnTableChess.Size = new System.Drawing.Size(616, 558);
            this.pnTableChess.TabIndex = 3;
            this.pnTableChess.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTableChess_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuQuit});
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(50, 20);
            this.menuGame.Text = "Menu";
            // 
            // menuNewGame
            // 
            this.menuNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1VsPlayer2ToolStripMenuItem});
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(180, 22);
            this.menuNewGame.Text = "New game";
            this.menuNewGame.Click += new System.EventHandler(this.menuNewGame_Click);
            // 
            // player1VsPlayer2ToolStripMenuItem
            // 
            this.player1VsPlayer2ToolStripMenuItem.Name = "player1VsPlayer2ToolStripMenuItem";
            this.player1VsPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.player1VsPlayer2ToolStripMenuItem.Text = "Player1 vs Player2";
            this.player1VsPlayer2ToolStripMenuItem.Click += new System.EventHandler(this.player1VsPlayer2);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuQuit.Size = new System.Drawing.Size(180, 22);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click_1);
            // 
            // tmCooldown
            // 
            this.tmCooldown.Tick += new System.EventHandler(this.tmCooldown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 558);
            this.Controls.Add(this.pnTableChess);
            this.Controls.Add(this.pnShow);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnShow.ResumeLayout(false);
            this.pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).EndInit();
            this.pnTableChess.ResumeLayout(false);
            this.pnTableChess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.PictureBox ptbPayer;
        private System.Windows.Forms.ProgressBar psbCooldownTime;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.PictureBox Avata;
        private System.Windows.Forms.Panel pnTableChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem player1VsPlayer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.Timer tmCooldown;
    }
}

