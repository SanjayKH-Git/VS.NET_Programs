
namespace Append_Arrayy
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
            this.Array1_lb = new System.Windows.Forms.Label();
            this.Array2_lb = new System.Windows.Forms.Label();
            this.Array1 = new System.Windows.Forms.TextBox();
            this.Array2 = new System.Windows.Forms.TextBox();
            this.Append = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Array3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Array1_lb
            // 
            this.Array1_lb.AccessibleName = "Array1_lb";
            this.Array1_lb.AutoSize = true;
            this.Array1_lb.Location = new System.Drawing.Point(64, 70);
            this.Array1_lb.Name = "Array1_lb";
            this.Array1_lb.Size = new System.Drawing.Size(37, 13);
            this.Array1_lb.TabIndex = 0;
            this.Array1_lb.Text = "Array1";
            // 
            // Array2_lb
            // 
            this.Array2_lb.AccessibleName = "Array2_lb";
            this.Array2_lb.AutoSize = true;
            this.Array2_lb.Location = new System.Drawing.Point(64, 119);
            this.Array2_lb.Name = "Array2_lb";
            this.Array2_lb.Size = new System.Drawing.Size(37, 13);
            this.Array2_lb.TabIndex = 1;
            this.Array2_lb.Text = "Array2";
            // 
            // Array1
            // 
            this.Array1.AccessibleName = "Array1";
            this.Array1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Array1.Location = new System.Drawing.Point(107, 67);
            this.Array1.Name = "Array1";
            this.Array1.Size = new System.Drawing.Size(283, 22);
            this.Array1.TabIndex = 2;
            // 
            // Array2
            // 
            this.Array2.AccessibleName = "Array2";
            this.Array2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Array2.Location = new System.Drawing.Point(107, 116);
            this.Array2.Name = "Array2";
            this.Array2.Size = new System.Drawing.Size(283, 22);
            this.Array2.TabIndex = 3;
            // 
            // Append
            // 
            this.Append.AccessibleName = "Append";
            this.Append.Location = new System.Drawing.Point(171, 165);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(84, 23);
            this.Append.TabIndex = 4;
            this.Append.Text = "Append";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.AccessibleName = "clear";
            this.clear.Location = new System.Drawing.Point(296, 165);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(55, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Array3
            // 
            this.Array3.AccessibleName = "Array3";
            this.Array3.AutoSize = true;
            this.Array3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Array3.Location = new System.Drawing.Point(43, 227);
            this.Array3.Name = "Array3";
            this.Array3.Size = new System.Drawing.Size(72, 15);
            this.Array3.TabIndex = 6;
            this.Array3.Text = "Array3= [";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.Array3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.Array2);
            this.Controls.Add(this.Array1);
            this.Controls.Add(this.Array2_lb);
            this.Controls.Add(this.Array1_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Array1_lb;
        private System.Windows.Forms.Label Array2_lb;
        private System.Windows.Forms.TextBox Array1;
        private System.Windows.Forms.TextBox Array2;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label Array3;
    }
}

