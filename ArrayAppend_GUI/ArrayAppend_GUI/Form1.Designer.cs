namespace ArrayAppend_GUI
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
            this.arr1_print = new System.Windows.Forms.Label();
            this.ele_no1 = new System.Windows.Forms.Button();
            this.ele_1 = new System.Windows.Forms.TextBox();
            this.arr1_ele = new System.Windows.Forms.TextBox();
            this.arr1_pos = new System.Windows.Forms.Label();
            this.Enter_ele1 = new System.Windows.Forms.Label();
            this.ele1 = new System.Windows.Forms.Label();
            this.nxt_btn1 = new System.Windows.Forms.Button();
            this.arr2_print = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ele_2 = new System.Windows.Forms.TextBox();
            this.Enter_ele2 = new System.Windows.Forms.Label();
            this.arr2_pos = new System.Windows.Forms.Label();
            this.arr2_ele = new System.Windows.Forms.TextBox();
            this.nxt_btn2 = new System.Windows.Forms.Button();
            this.ele_no2 = new System.Windows.Forms.Button();
            this.Append = new System.Windows.Forms.Button();
            this.Array3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arr1_print
            // 
            this.arr1_print.AutoSize = true;
            this.arr1_print.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr1_print.Location = new System.Drawing.Point(16, 9);
            this.arr1_print.Name = "arr1_print";
            this.arr1_print.Size = new System.Drawing.Size(69, 12);
            this.arr1_print.TabIndex = 15;
            this.arr1_print.Text = "Array1  ";
            // 
            // ele_no1
            // 
            this.ele_no1.Location = new System.Drawing.Point(136, 34);
            this.ele_no1.Name = "ele_no1";
            this.ele_no1.Size = new System.Drawing.Size(29, 20);
            this.ele_no1.TabIndex = 2;
            this.ele_no1.Text = ">";
            this.ele_no1.UseVisualStyleBackColor = true;
            this.ele_no1.Click += new System.EventHandler(this.ele_no1_Click);
            // 
            // ele_1
            // 
            this.ele_1.Location = new System.Drawing.Point(102, 34);
            this.ele_1.Name = "ele_1";
            this.ele_1.Size = new System.Drawing.Size(28, 20);
            this.ele_1.TabIndex = 1;
            // 
            // arr1_ele
            // 
            this.arr1_ele.Location = new System.Drawing.Point(80, 113);
            this.arr1_ele.Name = "arr1_ele";
            this.arr1_ele.Size = new System.Drawing.Size(50, 20);
            this.arr1_ele.TabIndex = 3;
            // 
            // arr1_pos
            // 
            this.arr1_pos.AutoSize = true;
            this.arr1_pos.Location = new System.Drawing.Point(32, 117);
            this.arr1_pos.Name = "arr1_pos";
            this.arr1_pos.Size = new System.Drawing.Size(42, 13);
            this.arr1_pos.TabIndex = 17;
            this.arr1_pos.Text = "array[0]";
            // 
            // Enter_ele1
            // 
            this.Enter_ele1.AutoSize = true;
            this.Enter_ele1.Location = new System.Drawing.Point(7, 88);
            this.Enter_ele1.Name = "Enter_ele1";
            this.Enter_ele1.Size = new System.Drawing.Size(123, 13);
            this.Enter_ele1.TabIndex = 18;
            this.Enter_ele1.Tag = "";
            this.Enter_ele1.Text = "Enter Elements for Aray1";
            // 
            // ele1
            // 
            this.ele1.AutoSize = true;
            this.ele1.Location = new System.Drawing.Point(15, 42);
            this.ele1.Name = "ele1";
            this.ele1.Size = new System.Drawing.Size(82, 13);
            this.ele1.TabIndex = 10;
            this.ele1.Text = "No. of Elements";
            // 
            // nxt_btn1
            // 
            this.nxt_btn1.Location = new System.Drawing.Point(136, 113);
            this.nxt_btn1.Name = "nxt_btn1";
            this.nxt_btn1.Size = new System.Drawing.Size(29, 20);
            this.nxt_btn1.TabIndex = 4;
            this.nxt_btn1.Text = ">>";
            this.nxt_btn1.UseVisualStyleBackColor = true;
            this.nxt_btn1.Click += new System.EventHandler(this.nxt_btn1_Click_1);
            // 
            // arr2_print
            // 
            this.arr2_print.AutoSize = true;
            this.arr2_print.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr2_print.Location = new System.Drawing.Point(385, 9);
            this.arr2_print.Name = "arr2_print";
            this.arr2_print.Size = new System.Drawing.Size(69, 11);
            this.arr2_print.TabIndex = 12;
            this.arr2_print.Text = "Array2  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "No. of Elements";
            // 
            // ele_2
            // 
            this.ele_2.Location = new System.Drawing.Point(472, 35);
            this.ele_2.Name = "ele_2";
            this.ele_2.Size = new System.Drawing.Size(28, 20);
            this.ele_2.TabIndex = 5;
            // 
            // Enter_ele2
            // 
            this.Enter_ele2.AutoSize = true;
            this.Enter_ele2.Location = new System.Drawing.Point(384, 88);
            this.Enter_ele2.Name = "Enter_ele2";
            this.Enter_ele2.Size = new System.Drawing.Size(123, 13);
            this.Enter_ele2.TabIndex = 16;
            this.Enter_ele2.Tag = "";
            this.Enter_ele2.Text = "Enter Elements for Aray1";
            // 
            // arr2_pos
            // 
            this.arr2_pos.AutoSize = true;
            this.arr2_pos.Location = new System.Drawing.Point(402, 116);
            this.arr2_pos.Name = "arr2_pos";
            this.arr2_pos.Size = new System.Drawing.Size(42, 13);
            this.arr2_pos.TabIndex = 17;
            this.arr2_pos.Text = "array[0]";
            // 
            // arr2_ele
            // 
            this.arr2_ele.Location = new System.Drawing.Point(450, 113);
            this.arr2_ele.Name = "arr2_ele";
            this.arr2_ele.Size = new System.Drawing.Size(50, 20);
            this.arr2_ele.TabIndex = 7;
            // 
            // nxt_btn2
            // 
            this.nxt_btn2.Location = new System.Drawing.Point(506, 112);
            this.nxt_btn2.Name = "nxt_btn2";
            this.nxt_btn2.Size = new System.Drawing.Size(29, 20);
            this.nxt_btn2.TabIndex = 8;
            this.nxt_btn2.Text = ">>";
            this.nxt_btn2.UseVisualStyleBackColor = true;
            this.nxt_btn2.Click += new System.EventHandler(this.nxt_btn2_Click);
            // 
            // ele_no2
            // 
            this.ele_no2.Location = new System.Drawing.Point(506, 35);
            this.ele_no2.Name = "ele_no2";
            this.ele_no2.Size = new System.Drawing.Size(29, 20);
            this.ele_no2.TabIndex = 6;
            this.ele_no2.Text = ">";
            this.ele_no2.UseVisualStyleBackColor = true;
            this.ele_no2.Click += new System.EventHandler(this.ele_no2_Click);
            // 
            // Append
            // 
            this.Append.Location = new System.Drawing.Point(272, 182);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(71, 21);
            this.Append.TabIndex = 10;
            this.Append.Text = "Append";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // Array3
            // 
            this.Array3.AutoSize = true;
            this.Array3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Array3.Location = new System.Drawing.Point(152, 237);
            this.Array3.Name = "Array3";
            this.Array3.Size = new System.Drawing.Size(74, 17);
            this.Array3.TabIndex = 19;
            this.Array3.Text = "Array3=  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 502);
            this.Controls.Add(this.Array3);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.ele_no2);
            this.Controls.Add(this.nxt_btn2);
            this.Controls.Add(this.arr2_ele);
            this.Controls.Add(this.arr2_pos);
            this.Controls.Add(this.Enter_ele2);
            this.Controls.Add(this.ele_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arr2_print);
            this.Controls.Add(this.nxt_btn1);
            this.Controls.Add(this.ele1);
            this.Controls.Add(this.Enter_ele1);
            this.Controls.Add(this.arr1_pos);
            this.Controls.Add(this.arr1_ele);
            this.Controls.Add(this.ele_1);
            this.Controls.Add(this.ele_no1);
            this.Controls.Add(this.arr1_print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label arr1_print;
        private System.Windows.Forms.Button ele_no1;
        private System.Windows.Forms.TextBox ele_1;
        private System.Windows.Forms.TextBox arr1_ele;
        private System.Windows.Forms.Label arr1_pos;
        private System.Windows.Forms.Label Enter_ele1;
        private System.Windows.Forms.Label ele1;
        private System.Windows.Forms.Button nxt_btn1;
        private System.Windows.Forms.Label arr2_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ele_2;
        private System.Windows.Forms.Label Enter_ele2;
        private System.Windows.Forms.Label arr2_pos;
        private System.Windows.Forms.TextBox arr2_ele;
        private System.Windows.Forms.Button nxt_btn2;
        private System.Windows.Forms.Button ele_no2;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.Label Array3;
    }
}

