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
            this.enterBtn = new System.Windows.Forms.Button();
            this.wordTxtBx = new System.Windows.Forms.TextBox();
            this.Splitter2 = new System.Windows.Forms.Splitter();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.infoLbl = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.Splitter1 = new System.Windows.Forms.Splitter();
            this.GamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DownPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownPanel
            // 
            this.DownPanel.Controls.Add(this.enterBtn);
            this.DownPanel.Controls.Add(this.wordTxtBx);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 350);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(800, 100);
            this.DownPanel.TabIndex = 6;
            // 
            // enterBtn
            // 
            this.enterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBtn.Location = new System.Drawing.Point(713, 35);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 1;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // wordTxtBx
            // 
            this.wordTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wordTxtBx.Location = new System.Drawing.Point(499, 6);
            this.wordTxtBx.Name = "wordTxtBx";
            this.wordTxtBx.Size = new System.Drawing.Size(289, 23);
            this.wordTxtBx.TabIndex = 0;
            this.wordTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordTxtBx_KeyDown);
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
            this.LeftPanel.Controls.Add(this.infoLbl);
            this.LeftPanel.Controls.Add(this.startGameBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 345);
            this.LeftPanel.TabIndex = 12;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(12, 49);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 15);
            this.infoLbl.TabIndex = 1;
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
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(205, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(595, 345);
            this.GamePanel.TabIndex = 14;
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
            this.DownPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel DownPanel;
        private Button enterBtn;
        private TextBox wordTxtBx;
        private Splitter Splitter2;
        private Panel LeftPanel;
        private Label infoLbl;
        private Button startGameBtn;
        private Splitter Splitter1;
        private FlowLayoutPanel GamePanel;
    }
}