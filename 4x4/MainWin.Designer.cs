
namespace Game
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.c4Down = new System.Windows.Forms.Button();
            this.c3Down = new System.Windows.Forms.Button();
            this.c2Down = new System.Windows.Forms.Button();
            this.c1Down = new System.Windows.Forms.Button();
            this.c1Up = new System.Windows.Forms.Button();
            this.c2Up = new System.Windows.Forms.Button();
            this.c3Up = new System.Windows.Forms.Button();
            this.c4Up = new System.Windows.Forms.Button();
            this.r1Right = new System.Windows.Forms.Button();
            this.r2Right = new System.Windows.Forms.Button();
            this.r3Right = new System.Windows.Forms.Button();
            this.r4Right = new System.Windows.Forms.Button();
            this.r1Left = new System.Windows.Forms.Button();
            this.r2Left = new System.Windows.Forms.Button();
            this.r3Left = new System.Windows.Forms.Button();
            this.r4Left = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdReset = new System.Windows.Forms.ToolStripButton();
            this.cmdShuffle = new System.Windows.Forms.ToolStripButton();
            this.mainContainer.SuspendLayout();
            this.gameBoard.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 3;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainContainer.Controls.Add(this.gameBoard, 1, 1);
            this.mainContainer.Controls.Add(this.toolStrip1, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 2;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Size = new System.Drawing.Size(334, 281);
            this.mainContainer.TabIndex = 1;
            // 
            // gameBoard
            // 
            this.gameBoard.ColumnCount = 8;
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.Controls.Add(this.c4Down, 5, 0);
            this.gameBoard.Controls.Add(this.c3Down, 4, 0);
            this.gameBoard.Controls.Add(this.c2Down, 3, 0);
            this.gameBoard.Controls.Add(this.c1Down, 2, 0);
            this.gameBoard.Controls.Add(this.c1Up, 2, 7);
            this.gameBoard.Controls.Add(this.c2Up, 3, 7);
            this.gameBoard.Controls.Add(this.c3Up, 4, 7);
            this.gameBoard.Controls.Add(this.c4Up, 5, 7);
            this.gameBoard.Controls.Add(this.r1Right, 0, 2);
            this.gameBoard.Controls.Add(this.r2Right, 0, 3);
            this.gameBoard.Controls.Add(this.r3Right, 0, 4);
            this.gameBoard.Controls.Add(this.r4Right, 0, 5);
            this.gameBoard.Controls.Add(this.r1Left, 7, 2);
            this.gameBoard.Controls.Add(this.r2Left, 7, 3);
            this.gameBoard.Controls.Add(this.r3Left, 7, 4);
            this.gameBoard.Controls.Add(this.r4Left, 7, 5);
            this.gameBoard.Controls.Add(this.body, 1, 1);
            this.gameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoard.Location = new System.Drawing.Point(30, 25);
            this.gameBoard.Margin = new System.Windows.Forms.Padding(0);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.RowCount = 8;
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoard.Size = new System.Drawing.Size(274, 256);
            this.gameBoard.TabIndex = 1;
            // 
            // c4Down
            // 
            this.c4Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c4Down.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c4Down.Location = new System.Drawing.Point(171, 1);
            this.c4Down.Margin = new System.Windows.Forms.Padding(1);
            this.c4Down.Name = "c4Down";
            this.c4Down.Size = new System.Drawing.Size(32, 30);
            this.c4Down.TabIndex = 3;
            this.c4Down.UseVisualStyleBackColor = true;
            this.c4Down.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c3Down
            // 
            this.c3Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c3Down.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c3Down.Location = new System.Drawing.Point(137, 1);
            this.c3Down.Margin = new System.Windows.Forms.Padding(1);
            this.c3Down.Name = "c3Down";
            this.c3Down.Size = new System.Drawing.Size(32, 30);
            this.c3Down.TabIndex = 2;
            this.c3Down.UseVisualStyleBackColor = true;
            this.c3Down.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c2Down
            // 
            this.c2Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c2Down.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c2Down.Location = new System.Drawing.Point(103, 1);
            this.c2Down.Margin = new System.Windows.Forms.Padding(1);
            this.c2Down.Name = "c2Down";
            this.c2Down.Size = new System.Drawing.Size(32, 30);
            this.c2Down.TabIndex = 1;
            this.c2Down.UseVisualStyleBackColor = true;
            this.c2Down.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c1Down
            // 
            this.c1Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Down.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c1Down.Location = new System.Drawing.Point(69, 1);
            this.c1Down.Margin = new System.Windows.Forms.Padding(1);
            this.c1Down.Name = "c1Down";
            this.c1Down.Size = new System.Drawing.Size(32, 30);
            this.c1Down.TabIndex = 0;
            this.c1Down.UseVisualStyleBackColor = true;
            this.c1Down.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c1Up
            // 
            this.c1Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Up.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c1Up.Location = new System.Drawing.Point(69, 225);
            this.c1Up.Margin = new System.Windows.Forms.Padding(1);
            this.c1Up.Name = "c1Up";
            this.c1Up.Size = new System.Drawing.Size(32, 30);
            this.c1Up.TabIndex = 4;
            this.c1Up.UseVisualStyleBackColor = true;
            this.c1Up.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c2Up
            // 
            this.c2Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c2Up.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c2Up.Location = new System.Drawing.Point(103, 225);
            this.c2Up.Margin = new System.Windows.Forms.Padding(1);
            this.c2Up.Name = "c2Up";
            this.c2Up.Size = new System.Drawing.Size(32, 30);
            this.c2Up.TabIndex = 5;
            this.c2Up.UseVisualStyleBackColor = true;
            this.c2Up.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c3Up
            // 
            this.c3Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c3Up.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c3Up.Location = new System.Drawing.Point(137, 225);
            this.c3Up.Margin = new System.Windows.Forms.Padding(1);
            this.c3Up.Name = "c3Up";
            this.c3Up.Size = new System.Drawing.Size(32, 30);
            this.c3Up.TabIndex = 6;
            this.c3Up.UseVisualStyleBackColor = true;
            this.c3Up.Click += new System.EventHandler(this.Slide_Click);
            // 
            // c4Up
            // 
            this.c4Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c4Up.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.c4Up.Location = new System.Drawing.Point(171, 225);
            this.c4Up.Margin = new System.Windows.Forms.Padding(1);
            this.c4Up.Name = "c4Up";
            this.c4Up.Size = new System.Drawing.Size(32, 30);
            this.c4Up.TabIndex = 7;
            this.c4Up.UseVisualStyleBackColor = true;
            this.c4Up.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r1Right
            // 
            this.r1Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r1Right.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r1Right.Location = new System.Drawing.Point(1, 65);
            this.r1Right.Margin = new System.Windows.Forms.Padding(1);
            this.r1Right.Name = "r1Right";
            this.r1Right.Size = new System.Drawing.Size(32, 30);
            this.r1Right.TabIndex = 8;
            this.r1Right.UseVisualStyleBackColor = true;
            this.r1Right.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r2Right
            // 
            this.r2Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r2Right.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r2Right.Location = new System.Drawing.Point(1, 97);
            this.r2Right.Margin = new System.Windows.Forms.Padding(1);
            this.r2Right.Name = "r2Right";
            this.r2Right.Size = new System.Drawing.Size(32, 30);
            this.r2Right.TabIndex = 9;
            this.r2Right.UseVisualStyleBackColor = true;
            this.r2Right.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r3Right
            // 
            this.r3Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r3Right.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r3Right.Location = new System.Drawing.Point(1, 129);
            this.r3Right.Margin = new System.Windows.Forms.Padding(1);
            this.r3Right.Name = "r3Right";
            this.r3Right.Size = new System.Drawing.Size(32, 30);
            this.r3Right.TabIndex = 10;
            this.r3Right.UseVisualStyleBackColor = true;
            this.r3Right.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r4Right
            // 
            this.r4Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r4Right.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r4Right.Location = new System.Drawing.Point(1, 161);
            this.r4Right.Margin = new System.Windows.Forms.Padding(1);
            this.r4Right.Name = "r4Right";
            this.r4Right.Size = new System.Drawing.Size(32, 30);
            this.r4Right.TabIndex = 11;
            this.r4Right.UseVisualStyleBackColor = true;
            this.r4Right.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r1Left
            // 
            this.r1Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r1Left.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r1Left.Location = new System.Drawing.Point(239, 65);
            this.r1Left.Margin = new System.Windows.Forms.Padding(1);
            this.r1Left.Name = "r1Left";
            this.r1Left.Size = new System.Drawing.Size(34, 30);
            this.r1Left.TabIndex = 12;
            this.r1Left.UseVisualStyleBackColor = true;
            this.r1Left.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r2Left
            // 
            this.r2Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r2Left.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r2Left.Location = new System.Drawing.Point(239, 97);
            this.r2Left.Margin = new System.Windows.Forms.Padding(1);
            this.r2Left.Name = "r2Left";
            this.r2Left.Size = new System.Drawing.Size(34, 30);
            this.r2Left.TabIndex = 13;
            this.r2Left.UseVisualStyleBackColor = true;
            this.r2Left.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r3Left
            // 
            this.r3Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r3Left.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r3Left.Location = new System.Drawing.Point(239, 129);
            this.r3Left.Margin = new System.Windows.Forms.Padding(1);
            this.r3Left.Name = "r3Left";
            this.r3Left.Size = new System.Drawing.Size(34, 30);
            this.r3Left.TabIndex = 14;
            this.r3Left.UseVisualStyleBackColor = true;
            this.r3Left.Click += new System.EventHandler(this.Slide_Click);
            // 
            // r4Left
            // 
            this.r4Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r4Left.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.r4Left.Location = new System.Drawing.Point(239, 161);
            this.r4Left.Margin = new System.Windows.Forms.Padding(1);
            this.r4Left.Name = "r4Left";
            this.r4Left.Size = new System.Drawing.Size(34, 30);
            this.r4Left.TabIndex = 15;
            this.r4Left.UseVisualStyleBackColor = true;
            this.r4Left.Click += new System.EventHandler(this.Slide_Click);
            // 
            // body
            // 
            this.gameBoard.SetColumnSpan(this.body, 6);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.body.Location = new System.Drawing.Point(34, 32);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.gameBoard.SetRowSpan(this.body, 6);
            this.body.Size = new System.Drawing.Size(204, 192);
            this.body.TabIndex = 16;
            this.body.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // toolStrip1
            // 
            this.mainContainer.SetColumnSpan(this.toolStrip1, 3);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdReset,
            this.cmdShuffle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(334, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdReset
            // 
            this.cmdReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdReset.Image = ((System.Drawing.Image)(resources.GetObject("cmdReset.Image")));
            this.cmdReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(39, 22);
            this.cmdReset.Text = "Reset";
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdShuffle
            // 
            this.cmdShuffle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdShuffle.Image = ((System.Drawing.Image)(resources.GetObject("cmdShuffle.Image")));
            this.cmdShuffle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdShuffle.Name = "cmdShuffle";
            this.cmdShuffle.Size = new System.Drawing.Size(48, 22);
            this.cmdShuffle.Text = "Shuffle";
            this.cmdShuffle.Click += new System.EventHandler(this.cmdShuffle_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.mainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 320);
            this.Name = "MainWin";
            this.Text = "4x4 Colour Dot Puzzle";
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.gameBoard.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.TableLayoutPanel gameBoard;
        private System.Windows.Forms.Button c4Down;
        private System.Windows.Forms.Button c3Down;
        private System.Windows.Forms.Button c2Down;
        private System.Windows.Forms.Button c1Down;
        private System.Windows.Forms.Button c1Up;
        private System.Windows.Forms.Button c2Up;
        private System.Windows.Forms.Button c3Up;
        private System.Windows.Forms.Button c4Up;
        private System.Windows.Forms.Button r1Right;
        private System.Windows.Forms.Button r2Right;
        private System.Windows.Forms.Button r3Right;
        private System.Windows.Forms.Button r4Right;
        private System.Windows.Forms.Button r1Left;
        private System.Windows.Forms.Button r2Left;
        private System.Windows.Forms.Button r3Left;
        private System.Windows.Forms.Button r4Left;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.ToolStripButton cmdReset;
        private System.Windows.Forms.ToolStripButton cmdShuffle;
    }
}

