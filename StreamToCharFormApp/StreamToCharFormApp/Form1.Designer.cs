namespace StreamToCharFormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.File_stream = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.ReadData_lb = new System.Windows.Forms.Label();
            this.Display_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Path and File Name";
            // 
            // File_stream
            // 
            this.File_stream.Location = new System.Drawing.Point(33, 82);
            this.File_stream.Name = "File_stream";
            this.File_stream.Size = new System.Drawing.Size(372, 20);
            this.File_stream.TabIndex = 1;
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.Location = new System.Drawing.Point(166, 120);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 2;
            this.Select.Text = "Select File";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // ReadData_lb
            // 
            this.ReadData_lb.AutoSize = true;
            this.ReadData_lb.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadData_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ReadData_lb.Location = new System.Drawing.Point(30, 186);
            this.ReadData_lb.Name = "ReadData_lb";
            this.ReadData_lb.Size = new System.Drawing.Size(123, 30);
            this.ReadData_lb.TabIndex = 3;
            this.ReadData_lb.Text = "Read Data Stream:\r\n\r\n";
            // 
            // Display_lb
            // 
            this.Display_lb.AutoSize = true;
            this.Display_lb.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Display_lb.Location = new System.Drawing.Point(426, 186);
            this.Display_lb.Name = "Display_lb";
            this.Display_lb.Size = new System.Drawing.Size(160, 30);
            this.Display_lb.TabIndex = 4;
            this.Display_lb.Text = "Display Data (in Chars) :\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 541);
            this.Controls.Add(this.Display_lb);
            this.Controls.Add(this.ReadData_lb);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.File_stream);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox File_stream;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label ReadData_lb;
        private System.Windows.Forms.Label Display_lb;
    }
}

