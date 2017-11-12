namespace Othello
{
    partial class Board
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
            this.pBoard = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.btnPlayerChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoard)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoard
            // 
            this.pBoard.BackColor = System.Drawing.Color.DarkGreen;
            this.pBoard.Location = new System.Drawing.Point(0, 0);
            this.pBoard.Name = "pBoard";
            this.pBoard.Size = new System.Drawing.Size(512, 512);
            this.pBoard.TabIndex = 0;
            this.pBoard.TabStop = false;
            this.pBoard.Click += new System.EventHandler(this.pBoard_Click);
            this.pBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoard_MouseMove);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(528, 444);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "New Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(524, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "White\'s turn";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(528, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Board";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.blackLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.whiteLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(528, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Black:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "White:";
            // 
            // blackLabel
            // 
            this.blackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.blackLabel.AutoSize = true;
            this.blackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.blackLabel.Location = new System.Drawing.Point(87, 15);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(18, 20);
            this.blackLabel.TabIndex = 5;
            this.blackLabel.Text = "0";
            // 
            // whiteLabel
            // 
            this.whiteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.whiteLabel.AutoSize = true;
            this.whiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.whiteLabel.Location = new System.Drawing.Point(87, 65);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(18, 20);
            this.whiteLabel.TabIndex = 5;
            this.whiteLabel.Text = "0";
            // 
            // delay
            // 
            this.delay.Enabled = true;
            this.delay.Interval = 3000;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(528, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playerLabel.Location = new System.Drawing.Point(524, 163);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(109, 15);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "You play as WHITE!";
            this.playerLabel.Visible = false;
            // 
            // btnPlayerChange
            // 
            this.btnPlayerChange.Location = new System.Drawing.Point(634, 159);
            this.btnPlayerChange.Name = "btnPlayerChange";
            this.btnPlayerChange.Size = new System.Drawing.Size(63, 23);
            this.btnPlayerChange.TabIndex = 6;
            this.btnPlayerChange.Text = "Change";
            this.btnPlayerChange.UseVisualStyleBackColor = true;
            this.btnPlayerChange.Visible = false;
            this.btnPlayerChange.Click += new System.EventHandler(this.btnPlayerChange_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlayerChange);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBoard);
            this.MinimumSize = new System.Drawing.Size(700, 512);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(700, 512);
            this.Load += new System.EventHandler(this.Board_Load);
            this.Enter += new System.EventHandler(this.Board_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pBoard)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label whiteLabel;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button btnPlayerChange;
    }
}
