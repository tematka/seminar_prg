namespace malovani
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.buttonElips = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.checkBoxFilling = new System.Windows.Forms.CheckBox();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.numericUpDownObjectWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownObjectHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRubber = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonBackWhite = new System.Windows.Forms.Button();
            this.buttonBackBlack = new System.Windows.Forms.Button();
            this.buttonBackPurple = new System.Windows.Forms.Button();
            this.buttonBackBlue = new System.Windows.Forms.Button();
            this.buttonBackCoral = new System.Windows.Forms.Button();
            this.buttonBackMagenta = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 373);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(22, 13);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "nový";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "šířka pera";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(92, 58);
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownWidth.TabIndex = 3;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonElips
            // 
            this.buttonElips.Location = new System.Drawing.Point(313, 12);
            this.buttonElips.Name = "buttonElips";
            this.buttonElips.Size = new System.Drawing.Size(60, 23);
            this.buttonElips.TabIndex = 12;
            this.buttonElips.Text = "elipsa";
            this.buttonElips.UseVisualStyleBackColor = true;
            this.buttonElips.Click += new System.EventHandler(this.buttonElips_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(313, 41);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(60, 23);
            this.buttonRectangle.TabIndex = 13;
            this.buttonRectangle.Text = "obdélník";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // checkBoxFilling
            // 
            this.checkBoxFilling.AutoSize = true;
            this.checkBoxFilling.Location = new System.Drawing.Point(322, 77);
            this.checkBoxFilling.Name = "checkBoxFilling";
            this.checkBoxFilling.Size = new System.Drawing.Size(51, 17);
            this.checkBoxFilling.TabIndex = 14;
            this.checkBoxFilling.Text = "výplň";
            this.checkBoxFilling.UseVisualStyleBackColor = true;
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(180, 98);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(62, 23);
            this.buttonPaint.TabIndex = 15;
            this.buttonPaint.Text = "kreslení";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // numericUpDownObjectWidth
            // 
            this.numericUpDownObjectWidth.Location = new System.Drawing.Point(427, 14);
            this.numericUpDownObjectWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownObjectWidth.Name = "numericUpDownObjectWidth";
            this.numericUpDownObjectWidth.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownObjectWidth.TabIndex = 16;
            this.numericUpDownObjectWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownObjectHeight
            // 
            this.numericUpDownObjectHeight.Location = new System.Drawing.Point(427, 44);
            this.numericUpDownObjectHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownObjectHeight.Name = "numericUpDownObjectHeight";
            this.numericUpDownObjectHeight.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownObjectHeight.TabIndex = 17;
            this.numericUpDownObjectHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "šířka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "výška";
            // 
            // buttonRubber
            // 
            this.buttonRubber.Location = new System.Drawing.Point(599, 98);
            this.buttonRubber.Name = "buttonRubber";
            this.buttonRubber.Size = new System.Drawing.Size(62, 23);
            this.buttonRubber.TabIndex = 20;
            this.buttonRubber.Text = "guma";
            this.buttonRubber.UseVisualStyleBackColor = true;
            this.buttonRubber.Click += new System.EventHandler(this.buttonRubber_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(180, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(23, 23);
            this.buttonRed.TabIndex = 21;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOrange.Location = new System.Drawing.Point(238, 13);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(23, 23);
            this.buttonOrange.TabIndex = 22;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(266, 13);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(23, 23);
            this.buttonYellow.TabIndex = 23;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGreen.Location = new System.Drawing.Point(180, 39);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(23, 23);
            this.buttonGreen.TabIndex = 24;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonBlue.Location = new System.Drawing.Point(209, 39);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(23, 23);
            this.buttonBlue.TabIndex = 25;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Indigo;
            this.buttonPurple.Location = new System.Drawing.Point(238, 39);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(22, 23);
            this.buttonPurple.TabIndex = 26;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(267, 39);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(22, 23);
            this.buttonBlack.TabIndex = 27;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPink.Location = new System.Drawing.Point(209, 12);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(23, 23);
            this.buttonPink.TabIndex = 28;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.buttonPink_Click);
            // 
            // buttonBackWhite
            // 
            this.buttonBackWhite.BackColor = System.Drawing.Color.White;
            this.buttonBackWhite.Location = new System.Drawing.Point(587, 41);
            this.buttonBackWhite.Name = "buttonBackWhite";
            this.buttonBackWhite.Size = new System.Drawing.Size(25, 23);
            this.buttonBackWhite.TabIndex = 29;
            this.buttonBackWhite.UseVisualStyleBackColor = false;
            this.buttonBackWhite.Click += new System.EventHandler(this.buttonBackWhite_Click);
            // 
            // buttonBackBlack
            // 
            this.buttonBackBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBackBlack.Location = new System.Drawing.Point(618, 40);
            this.buttonBackBlack.Name = "buttonBackBlack";
            this.buttonBackBlack.Size = new System.Drawing.Size(25, 25);
            this.buttonBackBlack.TabIndex = 30;
            this.buttonBackBlack.Text = "button2";
            this.buttonBackBlack.UseVisualStyleBackColor = false;
            this.buttonBackBlack.Click += new System.EventHandler(this.buttonBackBlack_Click);
            // 
            // buttonBackPurple
            // 
            this.buttonBackPurple.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonBackPurple.Location = new System.Drawing.Point(649, 39);
            this.buttonBackPurple.Name = "buttonBackPurple";
            this.buttonBackPurple.Size = new System.Drawing.Size(23, 24);
            this.buttonBackPurple.TabIndex = 31;
            this.buttonBackPurple.UseVisualStyleBackColor = false;
            this.buttonBackPurple.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBackBlue
            // 
            this.buttonBackBlue.BackColor = System.Drawing.Color.LightBlue;
            this.buttonBackBlue.Location = new System.Drawing.Point(587, 68);
            this.buttonBackBlue.Name = "buttonBackBlue";
            this.buttonBackBlue.Size = new System.Drawing.Size(25, 23);
            this.buttonBackBlue.TabIndex = 32;
            this.buttonBackBlue.UseVisualStyleBackColor = false;
            this.buttonBackBlue.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonBackCoral
            // 
            this.buttonBackCoral.BackColor = System.Drawing.Color.Coral;
            this.buttonBackCoral.Location = new System.Drawing.Point(618, 69);
            this.buttonBackCoral.Name = "buttonBackCoral";
            this.buttonBackCoral.Size = new System.Drawing.Size(25, 23);
            this.buttonBackCoral.TabIndex = 33;
            this.buttonBackCoral.UseVisualStyleBackColor = false;
            this.buttonBackCoral.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonBackMagenta
            // 
            this.buttonBackMagenta.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonBackMagenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBackMagenta.Location = new System.Drawing.Point(649, 69);
            this.buttonBackMagenta.Name = "buttonBackMagenta";
            this.buttonBackMagenta.Size = new System.Drawing.Size(23, 23);
            this.buttonBackMagenta.TabIndex = 34;
            this.buttonBackMagenta.UseVisualStyleBackColor = false;
            this.buttonBackMagenta.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(180, 68);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(23, 23);
            this.buttonWhite.TabIndex = 36;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "barva pozadí";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonBackMagenta);
            this.Controls.Add(this.buttonBackCoral);
            this.Controls.Add(this.buttonBackBlue);
            this.Controls.Add(this.buttonBackPurple);
            this.Controls.Add(this.buttonBackBlack);
            this.Controls.Add(this.buttonBackWhite);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonPink);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonRubber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownObjectHeight);
            this.Controls.Add(this.numericUpDownObjectWidth);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.checkBoxFilling);
            this.Controls.Add(this.buttonElips);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Button buttonElips;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.CheckBox checkBoxFilling;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.NumericUpDown numericUpDownObjectWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownObjectHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRubber;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonBackWhite;
        private System.Windows.Forms.Button buttonBackBlack;
        private System.Windows.Forms.Button buttonBackPurple;
        private System.Windows.Forms.Button buttonBackBlue;
        private System.Windows.Forms.Button buttonBackCoral;
        private System.Windows.Forms.Button buttonBackMagenta;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Label label4;
    }
}

