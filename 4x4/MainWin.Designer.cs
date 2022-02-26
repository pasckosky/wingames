
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
            this.d00 = new System.Windows.Forms.Label();
            this.d10 = new System.Windows.Forms.Label();
            this.d20 = new System.Windows.Forms.Label();
            this.d30 = new System.Windows.Forms.Label();
            this.d40 = new System.Windows.Forms.Label();
            this.d50 = new System.Windows.Forms.Label();
            this.d01 = new System.Windows.Forms.Label();
            this.d11 = new System.Windows.Forms.Label();
            this.d21 = new System.Windows.Forms.Label();
            this.d31 = new System.Windows.Forms.Label();
            this.d41 = new System.Windows.Forms.Label();
            this.d51 = new System.Windows.Forms.Label();
            this.d02 = new System.Windows.Forms.Label();
            this.d12 = new System.Windows.Forms.Label();
            this.d22 = new System.Windows.Forms.Label();
            this.d32 = new System.Windows.Forms.Label();
            this.d42 = new System.Windows.Forms.Label();
            this.d52 = new System.Windows.Forms.Label();
            this.d03 = new System.Windows.Forms.Label();
            this.d13 = new System.Windows.Forms.Label();
            this.d23 = new System.Windows.Forms.Label();
            this.d33 = new System.Windows.Forms.Label();
            this.d43 = new System.Windows.Forms.Label();
            this.d53 = new System.Windows.Forms.Label();
            this.d04 = new System.Windows.Forms.Label();
            this.d24 = new System.Windows.Forms.Label();
            this.d34 = new System.Windows.Forms.Label();
            this.d44 = new System.Windows.Forms.Label();
            this.d54 = new System.Windows.Forms.Label();
            this.d05 = new System.Windows.Forms.Label();
            this.d25 = new System.Windows.Forms.Label();
            this.d14 = new System.Windows.Forms.Label();
            this.d15 = new System.Windows.Forms.Label();
            this.d35 = new System.Windows.Forms.Label();
            this.d45 = new System.Windows.Forms.Label();
            this.d55 = new System.Windows.Forms.Label();
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
            this.gameBoard.Controls.Add(this.d00, 1, 1);
            this.gameBoard.Controls.Add(this.d10, 2, 1);
            this.gameBoard.Controls.Add(this.d20, 3, 1);
            this.gameBoard.Controls.Add(this.d30, 4, 1);
            this.gameBoard.Controls.Add(this.d40, 5, 1);
            this.gameBoard.Controls.Add(this.d50, 6, 1);
            this.gameBoard.Controls.Add(this.d01, 1, 2);
            this.gameBoard.Controls.Add(this.d11, 2, 2);
            this.gameBoard.Controls.Add(this.d21, 3, 2);
            this.gameBoard.Controls.Add(this.d31, 4, 2);
            this.gameBoard.Controls.Add(this.d41, 5, 2);
            this.gameBoard.Controls.Add(this.d51, 6, 2);
            this.gameBoard.Controls.Add(this.d02, 1, 3);
            this.gameBoard.Controls.Add(this.d12, 2, 3);
            this.gameBoard.Controls.Add(this.d22, 3, 3);
            this.gameBoard.Controls.Add(this.d32, 4, 3);
            this.gameBoard.Controls.Add(this.d42, 5, 3);
            this.gameBoard.Controls.Add(this.d52, 6, 3);
            this.gameBoard.Controls.Add(this.d03, 1, 4);
            this.gameBoard.Controls.Add(this.d13, 2, 4);
            this.gameBoard.Controls.Add(this.d23, 3, 4);
            this.gameBoard.Controls.Add(this.d33, 4, 4);
            this.gameBoard.Controls.Add(this.d43, 5, 4);
            this.gameBoard.Controls.Add(this.d53, 6, 4);
            this.gameBoard.Controls.Add(this.d04, 1, 5);
            this.gameBoard.Controls.Add(this.d24, 3, 5);
            this.gameBoard.Controls.Add(this.d34, 4, 5);
            this.gameBoard.Controls.Add(this.d44, 5, 5);
            this.gameBoard.Controls.Add(this.d54, 6, 5);
            this.gameBoard.Controls.Add(this.d05, 1, 6);
            this.gameBoard.Controls.Add(this.d25, 3, 6);
            this.gameBoard.Controls.Add(this.d14, 2, 5);
            this.gameBoard.Controls.Add(this.d15, 2, 6);
            this.gameBoard.Controls.Add(this.d35, 4, 6);
            this.gameBoard.Controls.Add(this.d45, 5, 6);
            this.gameBoard.Controls.Add(this.d55, 6, 6);
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
            // d00
            // 
            this.d00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d00.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d00.Location = new System.Drawing.Point(34, 32);
            this.d00.Margin = new System.Windows.Forms.Padding(0);
            this.d00.Name = "d00";
            this.d00.Size = new System.Drawing.Size(34, 32);
            this.d00.TabIndex = 16;
            this.d00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d00.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d10
            // 
            this.d10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d10.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d10.Location = new System.Drawing.Point(68, 32);
            this.d10.Margin = new System.Windows.Forms.Padding(0);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(34, 32);
            this.d10.TabIndex = 17;
            this.d10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d10.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d20
            // 
            this.d20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d20.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d20.Location = new System.Drawing.Point(102, 32);
            this.d20.Margin = new System.Windows.Forms.Padding(0);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(34, 32);
            this.d20.TabIndex = 18;
            this.d20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d20.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d30
            // 
            this.d30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d30.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d30.Location = new System.Drawing.Point(136, 32);
            this.d30.Margin = new System.Windows.Forms.Padding(0);
            this.d30.Name = "d30";
            this.d30.Size = new System.Drawing.Size(34, 32);
            this.d30.TabIndex = 19;
            this.d30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d30.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d40
            // 
            this.d40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d40.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d40.Location = new System.Drawing.Point(170, 32);
            this.d40.Margin = new System.Windows.Forms.Padding(0);
            this.d40.Name = "d40";
            this.d40.Size = new System.Drawing.Size(34, 32);
            this.d40.TabIndex = 20;
            this.d40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d40.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d50
            // 
            this.d50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d50.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d50.Location = new System.Drawing.Point(204, 32);
            this.d50.Margin = new System.Windows.Forms.Padding(0);
            this.d50.Name = "d50";
            this.d50.Size = new System.Drawing.Size(34, 32);
            this.d50.TabIndex = 21;
            this.d50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d50.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d01
            // 
            this.d01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d01.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d01.Location = new System.Drawing.Point(34, 64);
            this.d01.Margin = new System.Windows.Forms.Padding(0);
            this.d01.Name = "d01";
            this.d01.Size = new System.Drawing.Size(34, 32);
            this.d01.TabIndex = 22;
            this.d01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d01.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d11
            // 
            this.d11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d11.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d11.Location = new System.Drawing.Point(68, 64);
            this.d11.Margin = new System.Windows.Forms.Padding(0);
            this.d11.Name = "d11";
            this.d11.Size = new System.Drawing.Size(34, 32);
            this.d11.TabIndex = 23;
            this.d11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d11.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d21
            // 
            this.d21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d21.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d21.Location = new System.Drawing.Point(102, 64);
            this.d21.Margin = new System.Windows.Forms.Padding(0);
            this.d21.Name = "d21";
            this.d21.Size = new System.Drawing.Size(34, 32);
            this.d21.TabIndex = 24;
            this.d21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d21.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d31
            // 
            this.d31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d31.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d31.Location = new System.Drawing.Point(136, 64);
            this.d31.Margin = new System.Windows.Forms.Padding(0);
            this.d31.Name = "d31";
            this.d31.Size = new System.Drawing.Size(34, 32);
            this.d31.TabIndex = 25;
            this.d31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d31.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d41
            // 
            this.d41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d41.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d41.Location = new System.Drawing.Point(170, 64);
            this.d41.Margin = new System.Windows.Forms.Padding(0);
            this.d41.Name = "d41";
            this.d41.Size = new System.Drawing.Size(34, 32);
            this.d41.TabIndex = 26;
            this.d41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d41.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d51
            // 
            this.d51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d51.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d51.Location = new System.Drawing.Point(204, 64);
            this.d51.Margin = new System.Windows.Forms.Padding(0);
            this.d51.Name = "d51";
            this.d51.Size = new System.Drawing.Size(34, 32);
            this.d51.TabIndex = 27;
            this.d51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d51.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d02
            // 
            this.d02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d02.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d02.Location = new System.Drawing.Point(34, 96);
            this.d02.Margin = new System.Windows.Forms.Padding(0);
            this.d02.Name = "d02";
            this.d02.Size = new System.Drawing.Size(34, 32);
            this.d02.TabIndex = 28;
            this.d02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d02.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d12
            // 
            this.d12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d12.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d12.Location = new System.Drawing.Point(68, 96);
            this.d12.Margin = new System.Windows.Forms.Padding(0);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(34, 32);
            this.d12.TabIndex = 29;
            this.d12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d12.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d22
            // 
            this.d22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d22.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d22.Location = new System.Drawing.Point(102, 96);
            this.d22.Margin = new System.Windows.Forms.Padding(0);
            this.d22.Name = "d22";
            this.d22.Size = new System.Drawing.Size(34, 32);
            this.d22.TabIndex = 30;
            this.d22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d22.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d32
            // 
            this.d32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d32.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d32.Location = new System.Drawing.Point(136, 96);
            this.d32.Margin = new System.Windows.Forms.Padding(0);
            this.d32.Name = "d32";
            this.d32.Size = new System.Drawing.Size(34, 32);
            this.d32.TabIndex = 31;
            this.d32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d32.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d42
            // 
            this.d42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d42.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d42.Location = new System.Drawing.Point(170, 96);
            this.d42.Margin = new System.Windows.Forms.Padding(0);
            this.d42.Name = "d42";
            this.d42.Size = new System.Drawing.Size(34, 32);
            this.d42.TabIndex = 32;
            this.d42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d42.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d52
            // 
            this.d52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d52.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d52.Location = new System.Drawing.Point(204, 96);
            this.d52.Margin = new System.Windows.Forms.Padding(0);
            this.d52.Name = "d52";
            this.d52.Size = new System.Drawing.Size(34, 32);
            this.d52.TabIndex = 33;
            this.d52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d52.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d03
            // 
            this.d03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d03.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d03.Location = new System.Drawing.Point(34, 128);
            this.d03.Margin = new System.Windows.Forms.Padding(0);
            this.d03.Name = "d03";
            this.d03.Size = new System.Drawing.Size(34, 32);
            this.d03.TabIndex = 34;
            this.d03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d03.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d13
            // 
            this.d13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d13.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d13.Location = new System.Drawing.Point(68, 128);
            this.d13.Margin = new System.Windows.Forms.Padding(0);
            this.d13.Name = "d13";
            this.d13.Size = new System.Drawing.Size(34, 32);
            this.d13.TabIndex = 35;
            this.d13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d13.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d23
            // 
            this.d23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d23.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d23.Location = new System.Drawing.Point(102, 128);
            this.d23.Margin = new System.Windows.Forms.Padding(0);
            this.d23.Name = "d23";
            this.d23.Size = new System.Drawing.Size(34, 32);
            this.d23.TabIndex = 36;
            this.d23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d23.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d33
            // 
            this.d33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d33.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d33.Location = new System.Drawing.Point(136, 128);
            this.d33.Margin = new System.Windows.Forms.Padding(0);
            this.d33.Name = "d33";
            this.d33.Size = new System.Drawing.Size(34, 32);
            this.d33.TabIndex = 37;
            this.d33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d33.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d43
            // 
            this.d43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d43.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d43.Location = new System.Drawing.Point(170, 128);
            this.d43.Margin = new System.Windows.Forms.Padding(0);
            this.d43.Name = "d43";
            this.d43.Size = new System.Drawing.Size(34, 32);
            this.d43.TabIndex = 38;
            this.d43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d43.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d53
            // 
            this.d53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d53.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d53.Location = new System.Drawing.Point(204, 128);
            this.d53.Margin = new System.Windows.Forms.Padding(0);
            this.d53.Name = "d53";
            this.d53.Size = new System.Drawing.Size(34, 32);
            this.d53.TabIndex = 39;
            this.d53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d53.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d04
            // 
            this.d04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d04.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d04.Location = new System.Drawing.Point(34, 160);
            this.d04.Margin = new System.Windows.Forms.Padding(0);
            this.d04.Name = "d04";
            this.d04.Size = new System.Drawing.Size(34, 32);
            this.d04.TabIndex = 40;
            this.d04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d04.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d24
            // 
            this.d24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d24.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d24.Location = new System.Drawing.Point(102, 160);
            this.d24.Margin = new System.Windows.Forms.Padding(0);
            this.d24.Name = "d24";
            this.d24.Size = new System.Drawing.Size(34, 32);
            this.d24.TabIndex = 42;
            this.d24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d24.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d34
            // 
            this.d34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d34.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d34.Location = new System.Drawing.Point(136, 160);
            this.d34.Margin = new System.Windows.Forms.Padding(0);
            this.d34.Name = "d34";
            this.d34.Size = new System.Drawing.Size(34, 32);
            this.d34.TabIndex = 43;
            this.d34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d34.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d44
            // 
            this.d44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d44.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d44.Location = new System.Drawing.Point(170, 160);
            this.d44.Margin = new System.Windows.Forms.Padding(0);
            this.d44.Name = "d44";
            this.d44.Size = new System.Drawing.Size(34, 32);
            this.d44.TabIndex = 44;
            this.d44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d44.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d54
            // 
            this.d54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d54.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d54.Location = new System.Drawing.Point(204, 160);
            this.d54.Margin = new System.Windows.Forms.Padding(0);
            this.d54.Name = "d54";
            this.d54.Size = new System.Drawing.Size(34, 32);
            this.d54.TabIndex = 45;
            this.d54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d54.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d05
            // 
            this.d05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d05.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d05.Location = new System.Drawing.Point(34, 192);
            this.d05.Margin = new System.Windows.Forms.Padding(0);
            this.d05.Name = "d05";
            this.d05.Size = new System.Drawing.Size(34, 32);
            this.d05.TabIndex = 46;
            this.d05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d05.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d25
            // 
            this.d25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d25.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d25.Location = new System.Drawing.Point(102, 192);
            this.d25.Margin = new System.Windows.Forms.Padding(0);
            this.d25.Name = "d25";
            this.d25.Size = new System.Drawing.Size(34, 32);
            this.d25.TabIndex = 48;
            this.d25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d25.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d14
            // 
            this.d14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d14.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d14.Location = new System.Drawing.Point(68, 160);
            this.d14.Margin = new System.Windows.Forms.Padding(0);
            this.d14.Name = "d14";
            this.d14.Size = new System.Drawing.Size(34, 32);
            this.d14.TabIndex = 41;
            this.d14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d14.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d15
            // 
            this.d15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d15.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d15.Location = new System.Drawing.Point(68, 192);
            this.d15.Margin = new System.Windows.Forms.Padding(0);
            this.d15.Name = "d15";
            this.d15.Size = new System.Drawing.Size(34, 32);
            this.d15.TabIndex = 47;
            this.d15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d15.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d35
            // 
            this.d35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d35.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d35.Location = new System.Drawing.Point(136, 192);
            this.d35.Margin = new System.Windows.Forms.Padding(0);
            this.d35.Name = "d35";
            this.d35.Size = new System.Drawing.Size(34, 32);
            this.d35.TabIndex = 49;
            this.d35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d35.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d45
            // 
            this.d45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d45.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d45.Location = new System.Drawing.Point(170, 192);
            this.d45.Margin = new System.Windows.Forms.Padding(0);
            this.d45.Name = "d45";
            this.d45.Size = new System.Drawing.Size(34, 32);
            this.d45.TabIndex = 50;
            this.d45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d45.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
            // 
            // d55
            // 
            this.d55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d55.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.d55.Location = new System.Drawing.Point(204, 192);
            this.d55.Margin = new System.Windows.Forms.Padding(0);
            this.d55.Name = "d55";
            this.d55.Size = new System.Drawing.Size(34, 32);
            this.d55.TabIndex = 51;
            this.d55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d55.Paint += new System.Windows.Forms.PaintEventHandler(this.dotPaint);
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
        private System.Windows.Forms.Label d10;
        private System.Windows.Forms.Label d00;
        private System.Windows.Forms.Label d20;
        private System.Windows.Forms.Label d30;
        private System.Windows.Forms.Label d40;
        private System.Windows.Forms.Label d50;
        private System.Windows.Forms.Label d01;
        private System.Windows.Forms.Label d11;
        private System.Windows.Forms.Label d21;
        private System.Windows.Forms.Label d31;
        private System.Windows.Forms.Label d41;
        private System.Windows.Forms.Label d51;
        private System.Windows.Forms.Label d02;
        private System.Windows.Forms.Label d12;
        private System.Windows.Forms.Label d22;
        private System.Windows.Forms.Label d32;
        private System.Windows.Forms.Label d42;
        private System.Windows.Forms.Label d52;
        private System.Windows.Forms.Label d03;
        private System.Windows.Forms.Label d13;
        private System.Windows.Forms.Label d23;
        private System.Windows.Forms.Label d33;
        private System.Windows.Forms.Label d43;
        private System.Windows.Forms.Label d53;
        private System.Windows.Forms.Label d04;
        private System.Windows.Forms.Label d24;
        private System.Windows.Forms.Label d34;
        private System.Windows.Forms.Label d44;
        private System.Windows.Forms.Label d54;
        private System.Windows.Forms.Label d05;
        private System.Windows.Forms.Label d25;
        private System.Windows.Forms.Label d14;
        private System.Windows.Forms.Label d15;
        private System.Windows.Forms.Label d35;
        private System.Windows.Forms.Label d45;
        private System.Windows.Forms.Label d55;
        private System.Windows.Forms.ToolStripButton cmdReset;
        private System.Windows.Forms.ToolStripButton cmdShuffle;
    }
}

