namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEsclipse = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.colorpicker = new System.Windows.Forms.PictureBox();
            this.btnPicColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorpicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.colorpicker);
            this.panel1.Controls.Add(this.btnPicColor);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Controls.Add(this.btnLine);
            this.panel3.Controls.Add(this.btnFill);
            this.panel3.Controls.Add(this.btnRectangle);
            this.panel3.Controls.Add(this.btnEsclipse);
            this.panel3.Controls.Add(this.btnPencil);
            this.panel3.Controls.Add(this.btnEraser);
            this.panel3.Location = new System.Drawing.Point(438, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 109);
            this.panel3.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(600, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 72);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Gray;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = global::Paint.Properties.Resources.color;
            this.btnColor.Location = new System.Drawing.Point(12, 21);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(76, 72);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "  Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Gray;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.Image = global::Paint.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(525, 21);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(69, 72);
            this.btnLine.TabIndex = 11;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Gray;
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Image = global::Paint.Properties.Resources.bucket;
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFill.Location = new System.Drawing.Point(94, 21);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(82, 72);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Fill";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Gray;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.ForeColor = System.Drawing.Color.White;
            this.btnRectangle.Image = global::Paint.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(431, 21);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(88, 72);
            this.btnRectangle.TabIndex = 9;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEsclipse
            // 
            this.btnEsclipse.BackColor = System.Drawing.Color.Gray;
            this.btnEsclipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEsclipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEsclipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsclipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsclipse.ForeColor = System.Drawing.Color.White;
            this.btnEsclipse.Image = global::Paint.Properties.Resources.circle;
            this.btnEsclipse.Location = new System.Drawing.Point(352, 21);
            this.btnEsclipse.Name = "btnEsclipse";
            this.btnEsclipse.Size = new System.Drawing.Size(73, 72);
            this.btnEsclipse.TabIndex = 10;
            this.btnEsclipse.Text = "Esclipe";
            this.btnEsclipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEsclipse.UseVisualStyleBackColor = false;
            this.btnEsclipse.Click += new System.EventHandler(this.btnEsclipse_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.Gray;
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPencil.ForeColor = System.Drawing.Color.White;
            this.btnPencil.Image = global::Paint.Properties.Resources.pencil;
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPencil.Location = new System.Drawing.Point(182, 21);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(83, 72);
            this.btnPencil.TabIndex = 6;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Gray;
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEraser.ForeColor = System.Drawing.Color.White;
            this.btnEraser.Image = global::Paint.Properties.Resources.eraser;
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEraser.Location = new System.Drawing.Point(271, 21);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(75, 72);
            this.btnEraser.TabIndex = 7;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // colorpicker
            // 
            this.colorpicker.Image = global::Paint.Properties.Resources.color_palette;
            this.colorpicker.Location = new System.Drawing.Point(3, 3);
            this.colorpicker.Name = "colorpicker";
            this.colorpicker.Size = new System.Drawing.Size(328, 103);
            this.colorpicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorpicker.TabIndex = 12;
            this.colorpicker.TabStop = false;
            this.colorpicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorpicker_MouseClick);
            // 
            // btnPicColor
            // 
            this.btnPicColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicColor.BackColor = System.Drawing.Color.White;
            this.btnPicColor.Location = new System.Drawing.Point(355, 34);
            this.btnPicColor.Name = "btnPicColor";
            this.btnPicColor.Size = new System.Drawing.Size(54, 46);
            this.btnPicColor.TabIndex = 3;
            this.btnPicColor.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 19);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 28);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1119, 506);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorpicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPicColor;
        private System.Windows.Forms.PictureBox colorpicker;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEsclipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
    }
}

