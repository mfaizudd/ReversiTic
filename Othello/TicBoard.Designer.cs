namespace Othello
{
    partial class TicBoard
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
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pBoard = new System.Windows.Forms.PictureBox();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.btnPlayerChange = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(530, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh Board";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTurn.Location = new System.Drawing.Point(526, 12);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(64, 20);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Text = "O\'s turn";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(530, 444);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "New Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBoard
            // 
            this.pBoard.BackColor = System.Drawing.Color.White;
            this.pBoard.Location = new System.Drawing.Point(2, 0);
            this.pBoard.Name = "pBoard";
            this.pBoard.Size = new System.Drawing.Size(512, 512);
            this.pBoard.TabIndex = 7;
            this.pBoard.TabStop = false;
            this.pBoard.Click += new System.EventHandler(this.pBoard_Click);
            this.pBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoard_MouseMove);
            // 
            // delay
            // 
            this.delay.Interval = 1500;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // btnPlayerChange
            // 
            this.btnPlayerChange.Location = new System.Drawing.Point(636, 159);
            this.btnPlayerChange.Name = "btnPlayerChange";
            this.btnPlayerChange.Size = new System.Drawing.Size(63, 23);
            this.btnPlayerChange.TabIndex = 14;
            this.btnPlayerChange.Text = "Change";
            this.btnPlayerChange.UseVisualStyleBackColor = true;
            this.btnPlayerChange.Visible = false;
            this.btnPlayerChange.Click += new System.EventHandler(this.btnPlayerChange_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playerLabel.Location = new System.Drawing.Point(526, 163);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(82, 15);
            this.playerLabel.TabIndex = 13;
            this.playerLabel.Text = "You play as O!";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(530, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TicBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBoard);
            this.Controls.Add(this.btnPlayerChange);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.btnBack);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "TicBoard";
            this.Size = new System.Drawing.Size(700, 512);
            this.Load += new System.EventHandler(this.TicBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pBoard;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Button btnPlayerChange;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button btnBack;
    }
}
