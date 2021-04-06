namespace Mouse_KeyBoard_Events
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mouse_Message_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear_All = new System.Windows.Forms.Button();
            this.Moving_lb = new System.Windows.Forms.Label();
            this.Enter_lb = new System.Windows.Forms.Label();
            this.Mouse_Hover = new System.Windows.Forms.Label();
            this.KB_ev = new System.Windows.Forms.Label();
            this.KB_Msg = new System.Windows.Forms.Label();
            this.KB_up_dwn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 154);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // Mouse_Message_lb
            // 
            this.Mouse_Message_lb.AutoSize = true;
            this.Mouse_Message_lb.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mouse_Message_lb.Location = new System.Drawing.Point(253, 51);
            this.Mouse_Message_lb.Name = "Mouse_Message_lb";
            this.Mouse_Message_lb.Size = new System.Drawing.Size(0, 18);
            this.Mouse_Message_lb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mouse Event Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "KeyBoard Event Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 4;
            // 
            // Clear_All
            // 
            this.Clear_All.Location = new System.Drawing.Point(31, 295);
            this.Clear_All.Name = "Clear_All";
            this.Clear_All.Size = new System.Drawing.Size(75, 23);
            this.Clear_All.TabIndex = 5;
            this.Clear_All.Text = "Clear All";
            this.Clear_All.UseVisualStyleBackColor = true;
            this.Clear_All.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // Moving_lb
            // 
            this.Moving_lb.AutoSize = true;
            this.Moving_lb.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moving_lb.Location = new System.Drawing.Point(26, 9);
            this.Moving_lb.Name = "Moving_lb";
            this.Moving_lb.Size = new System.Drawing.Size(0, 14);
            this.Moving_lb.TabIndex = 6;
            // 
            // Enter_lb
            // 
            this.Enter_lb.AutoSize = true;
            this.Enter_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_lb.Location = new System.Drawing.Point(26, 242);
            this.Enter_lb.Name = "Enter_lb";
            this.Enter_lb.Size = new System.Drawing.Size(10, 15);
            this.Enter_lb.TabIndex = 7;
            this.Enter_lb.Text = ":";
            // 
            // Mouse_Hover
            // 
            this.Mouse_Hover.AutoSize = true;
            this.Mouse_Hover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mouse_Hover.Location = new System.Drawing.Point(26, 217);
            this.Mouse_Hover.Name = "Mouse_Hover";
            this.Mouse_Hover.Size = new System.Drawing.Size(10, 15);
            this.Mouse_Hover.TabIndex = 8;
            this.Mouse_Hover.Text = ":";
            // 
            // KB_ev
            // 
            this.KB_ev.AutoSize = true;
            this.KB_ev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_ev.Location = new System.Drawing.Point(494, 9);
            this.KB_ev.Name = "KB_ev";
            this.KB_ev.Size = new System.Drawing.Size(10, 15);
            this.KB_ev.TabIndex = 9;
            this.KB_ev.Text = ":";
            // 
            // KB_Msg
            // 
            this.KB_Msg.AutoSize = true;
            this.KB_Msg.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_Msg.Location = new System.Drawing.Point(512, 54);
            this.KB_Msg.Name = "KB_Msg";
            this.KB_Msg.Size = new System.Drawing.Size(0, 20);
            this.KB_Msg.TabIndex = 10;
            // 
            // KB_up_dwn
            // 
            this.KB_up_dwn.AutoSize = true;
            this.KB_up_dwn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_up_dwn.Location = new System.Drawing.Point(607, 9);
            this.KB_up_dwn.Name = "KB_up_dwn";
            this.KB_up_dwn.Size = new System.Drawing.Size(10, 15);
            this.KB_up_dwn.TabIndex = 11;
            this.KB_up_dwn.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 393);
            this.Controls.Add(this.KB_up_dwn);
            this.Controls.Add(this.KB_Msg);
            this.Controls.Add(this.KB_ev);
            this.Controls.Add(this.Mouse_Hover);
            this.Controls.Add(this.Enter_lb);
            this.Controls.Add(this.Moving_lb);
            this.Controls.Add(this.Clear_All);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mouse_Message_lb);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Mouse_Message_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear_All;
        private System.Windows.Forms.Label Moving_lb;
        private System.Windows.Forms.Label Enter_lb;
        private System.Windows.Forms.Label Mouse_Hover;
        private System.Windows.Forms.Label KB_ev;
        private System.Windows.Forms.Label KB_Msg;
        private System.Windows.Forms.Label KB_up_dwn;
    }
}

