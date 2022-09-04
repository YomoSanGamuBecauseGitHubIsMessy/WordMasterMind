namespace MasterMind
{
    partial class MasterMindForm
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
            this.DownPanel = new System.Windows.Forms.Panel();
            this.lettersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.enterBtn = new System.Windows.Forms.Button();
            this.Splitter2 = new System.Windows.Forms.Splitter();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.tryTxtBx = new System.Windows.Forms.TextBox();
            this.tryLbl = new System.Windows.Forms.Label();
            this.letterCountLbl = new System.Windows.Forms.Label();
            this.letterCountTxtBx = new System.Windows.Forms.TextBox();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.Splitter1 = new System.Windows.Forms.Splitter();
            this.GamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grayPnl = new System.Windows.Forms.Panel();
            this.greenPnl = new System.Windows.Forms.Panel();
            this.orangePnl = new System.Windows.Forms.Panel();
            this.grayLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DownPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownPanel
            // 
            this.DownPanel.Controls.Add(this.lettersPanel);
            this.DownPanel.Controls.Add(this.enterBtn);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 350);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(800, 100);
            this.DownPanel.TabIndex = 6;
            // 
            // lettersPanel
            // 
            this.lettersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lettersPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.lettersPanel.Location = new System.Drawing.Point(3, 0);
            this.lettersPanel.Name = "lettersPanel";
            this.lettersPanel.Size = new System.Drawing.Size(794, 68);
            this.lettersPanel.TabIndex = 2;
            // 
            // enterBtn
            // 
            this.enterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBtn.Location = new System.Drawing.Point(3, 74);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(794, 23);
            this.enterBtn.TabIndex = 1;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Splitter2
            // 
            this.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter2.Location = new System.Drawing.Point(0, 345);
            this.Splitter2.Name = "Splitter2";
            this.Splitter2.Size = new System.Drawing.Size(800, 5);
            this.Splitter2.TabIndex = 9;
            this.Splitter2.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.grayLbl);
            this.LeftPanel.Controls.Add(this.orangePnl);
            this.LeftPanel.Controls.Add(this.greenPnl);
            this.LeftPanel.Controls.Add(this.grayPnl);
            this.LeftPanel.Controls.Add(this.tryTxtBx);
            this.LeftPanel.Controls.Add(this.tryLbl);
            this.LeftPanel.Controls.Add(this.letterCountLbl);
            this.LeftPanel.Controls.Add(this.letterCountTxtBx);
            this.LeftPanel.Controls.Add(this.startGameBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 345);
            this.LeftPanel.TabIndex = 12;
            // 
            // tryTxtBx
            // 
            this.tryTxtBx.Location = new System.Drawing.Point(152, 75);
            this.tryTxtBx.Name = "tryTxtBx";
            this.tryTxtBx.Size = new System.Drawing.Size(42, 23);
            this.tryTxtBx.TabIndex = 5;
            this.tryTxtBx.Text = "7";
            // 
            // tryLbl
            // 
            this.tryLbl.AutoSize = true;
            this.tryLbl.Location = new System.Drawing.Point(12, 78);
            this.tryLbl.Name = "tryLbl";
            this.tryLbl.Size = new System.Drawing.Size(113, 15);
            this.tryLbl.TabIndex = 4;
            this.tryLbl.Text = "Anzahl der Versuche";
            // 
            // letterCountLbl
            // 
            this.letterCountLbl.AutoSize = true;
            this.letterCountLbl.Location = new System.Drawing.Point(12, 49);
            this.letterCountLbl.Name = "letterCountLbl";
            this.letterCountLbl.Size = new System.Drawing.Size(137, 15);
            this.letterCountLbl.TabIndex = 3;
            this.letterCountLbl.Text = "Max. Anz. d. Buchstaben";
            // 
            // letterCountTxtBx
            // 
            this.letterCountTxtBx.Location = new System.Drawing.Point(152, 46);
            this.letterCountTxtBx.Name = "letterCountTxtBx";
            this.letterCountTxtBx.Size = new System.Drawing.Size(42, 23);
            this.letterCountTxtBx.TabIndex = 2;
            this.letterCountTxtBx.Text = "5";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(12, 12);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(182, 23);
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "Spiel starten";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // Splitter1
            // 
            this.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter1.Location = new System.Drawing.Point(200, 0);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(5, 345);
            this.Splitter1.TabIndex = 13;
            this.Splitter1.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.AutoScroll = true;
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(205, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(595, 345);
            this.GamePanel.TabIndex = 14;
            // 
            // grayPnl
            // 
            this.grayPnl.BackColor = System.Drawing.Color.Gray;
            this.grayPnl.Location = new System.Drawing.Point(12, 119);
            this.grayPnl.Name = "grayPnl";
            this.grayPnl.Size = new System.Drawing.Size(28, 32);
            this.grayPnl.TabIndex = 6;
            // 
            // greenPnl
            // 
            this.greenPnl.BackColor = System.Drawing.Color.Green;
            this.greenPnl.Location = new System.Drawing.Point(12, 195);
            this.greenPnl.Name = "greenPnl";
            this.greenPnl.Size = new System.Drawing.Size(28, 32);
            this.greenPnl.TabIndex = 7;
            // 
            // orangePnl
            // 
            this.orangePnl.BackColor = System.Drawing.Color.Orange;
            this.orangePnl.Location = new System.Drawing.Point(12, 157);
            this.orangePnl.Name = "orangePnl";
            this.orangePnl.Size = new System.Drawing.Size(28, 32);
            this.orangePnl.TabIndex = 8;
            // 
            // grayLbl
            // 
            this.grayLbl.AutoSize = true;
            this.grayLbl.Location = new System.Drawing.Point(46, 127);
            this.grayLbl.Name = "grayLbl";
            this.grayLbl.Size = new System.Drawing.Size(135, 15);
            this.grayLbl.TabIndex = 9;
            this.grayLbl.Text = "Keine Übereinstimmung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Im Wort enthalten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Übereinstimmung an Stelle";
            // 
            // MasterMindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.Splitter1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Splitter2);
            this.Controls.Add(this.DownPanel);
            this.Name = "MasterMindForm";
            this.Text = "Master Mind";
            this.Resize += new System.EventHandler(this.MasterMindForm_Resize);
            this.DownPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel DownPanel;
        private Button enterBtn;
        private Splitter Splitter2;
        private Panel LeftPanel;
        private Button startGameBtn;
        private Splitter Splitter1;
        private FlowLayoutPanel GamePanel;
        private FlowLayoutPanel lettersPanel;
        private Label letterCountLbl;
        private TextBox letterCountTxtBx;
        private TextBox tryTxtBx;
        private Label tryLbl;
        private Label label3;
        private Label label2;
        private Label grayLbl;
        private Panel orangePnl;
        private Panel greenPnl;
        private Panel grayPnl;
    }
}