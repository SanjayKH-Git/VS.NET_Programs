namespace Quiz_Form_App
{
    partial class QuizApp
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
            this.Next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ans4 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.qtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.qtn);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.prev);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ans4);
            this.panel1.Controls.Add(this.ans3);
            this.panel1.Controls.Add(this.ans2);
            this.panel1.Controls.Add(this.ans1);
            this.panel1.Location = new System.Drawing.Point(62, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 359);
            this.panel1.TabIndex = 1;
            // 
            // Next
            // 
            this.Next.AccessibleDescription = "Next Question";
            this.Next.AccessibleName = "Next";
            this.Next.Location = new System.Drawing.Point(355, 324);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(56, 32);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(68, 327);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(56, 32);
            this.prev.TabIndex = 4;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Form_App.Properties.Resources.sky;
            this.pictureBox1.Location = new System.Drawing.Point(95, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 181);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(248, 282);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(85, 17);
            this.ans4.TabIndex = 7;
            this.ans4.TabStop = true;
            this.ans4.Text = "radioButton4";
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(119, 282);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(85, 17);
            this.ans3.TabIndex = 6;
            this.ans3.TabStop = true;
            this.ans3.Text = "radioButton3";
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(248, 248);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(85, 17);
            this.ans2.TabIndex = 5;
            this.ans2.TabStop = true;
            this.ans2.Text = "radioButton2";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(119, 248);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(85, 17);
            this.ans1.TabIndex = 4;
            this.ans1.TabStop = true;
            this.ans1.Text = "radioButton1";
            this.ans1.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(276, 371);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(99, 42);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // qtn
            // 
            this.qtn.AccessibleName = "qtn";
            this.qtn.AutoSize = true;
            this.qtn.Location = new System.Drawing.Point(116, 212);
            this.qtn.Name = "qtn";
            this.qtn.Size = new System.Drawing.Size(164, 13);
            this.qtn.TabIndex = 9;
            this.qtn.Text = "1. Who is Prime Minister of India?";
            // 
            // QuizApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 442);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Name = "QuizApp";
            this.Text = "QuizApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.RadioButton ans4;
        private System.Windows.Forms.RadioButton ans3;
        private System.Windows.Forms.RadioButton ans2;
        private System.Windows.Forms.RadioButton ans1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label qtn;
    }
}

