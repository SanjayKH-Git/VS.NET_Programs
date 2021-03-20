
namespace Abbrevation_Form
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
            this.Enter_Name = new System.Windows.Forms.Label();
            this.AbbrevationLabel = new System.Windows.Forms.Label();
            this.abbreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Enter_Name
            // 
            this.Enter_Name.AutoSize = true;
            this.Enter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Name.Location = new System.Drawing.Point(38, 155);
            this.Enter_Name.Name = "Enter_Name";
            this.Enter_Name.Size = new System.Drawing.Size(89, 16);
            this.Enter_Name.TabIndex = 1;
            this.Enter_Name.Text = "Enter Name";
            this.Enter_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // AbbrevationLabel
            // 
            this.AbbrevationLabel.AutoSize = true;
            this.AbbrevationLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbbrevationLabel.Location = new System.Drawing.Point(38, 222);
            this.AbbrevationLabel.Name = "AbbrevationLabel";
            this.AbbrevationLabel.Size = new System.Drawing.Size(122, 19);
            this.AbbrevationLabel.TabIndex = 2;
            this.AbbrevationLabel.Text = "Abbrevation  is";
            this.AbbrevationLabel.UseMnemonic = false;
            this.AbbrevationLabel.Visible = false;
            this.AbbrevationLabel.Click += new System.EventHandler(this.AbbrevationLabel_Click);
            // 
            // abbreBtn
            // 
            this.abbreBtn.BackColor = System.Drawing.Color.Gray;
            this.abbreBtn.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abbreBtn.ForeColor = System.Drawing.Color.Blue;
            this.abbreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abbreBtn.Location = new System.Drawing.Point(309, 148);
            this.abbreBtn.Name = "abbreBtn";
            this.abbreBtn.Size = new System.Drawing.Size(70, 31);
            this.abbreBtn.TabIndex = 3;
            this.abbreBtn.Text = "abrevate";
            this.abbreBtn.UseVisualStyleBackColor = false;
            this.abbreBtn.Click += new System.EventHandler(this.abbreBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 572);
            this.Controls.Add(this.abbreBtn);
            this.Controls.Add(this.AbbrevationLabel);
            this.Controls.Add(this.Enter_Name);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Enter_Name;
        private System.Windows.Forms.Label AbbrevationLabel;
        private System.Windows.Forms.Button abbreBtn;
    }
}

