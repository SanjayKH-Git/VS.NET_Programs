namespace Note_Taking_App
{
    partial class Note_Taking_App
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
            this.Title_LB = new System.Windows.Forms.Label();
            this.Message_LB = new System.Windows.Forms.Label();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.Message_txt = new System.Windows.Forms.TextBox();
            this.Title_List_DGV = new System.Windows.Forms.DataGridView();
            this.New = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title_List_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_LB
            // 
            this.Title_LB.AutoSize = true;
            this.Title_LB.Location = new System.Drawing.Point(23, 60);
            this.Title_LB.Name = "Title_LB";
            this.Title_LB.Size = new System.Drawing.Size(27, 13);
            this.Title_LB.TabIndex = 11;
            this.Title_LB.Text = "Title";
            // 
            // Message_LB
            // 
            this.Message_LB.AutoSize = true;
            this.Message_LB.Location = new System.Drawing.Point(12, 110);
            this.Message_LB.Name = "Message_LB";
            this.Message_LB.Size = new System.Drawing.Size(50, 13);
            this.Message_LB.TabIndex = 10;
            this.Message_LB.Text = "Message";
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(68, 57);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(318, 20);
            this.Title_txt.TabIndex = 2;
            // 
            // Message_txt
            // 
            this.Message_txt.Location = new System.Drawing.Point(68, 107);
            this.Message_txt.Multiline = true;
            this.Message_txt.Name = "Message_txt";
            this.Message_txt.Size = new System.Drawing.Size(318, 254);
            this.Message_txt.TabIndex = 3;
            // 
            // Title_List_DGV
            // 
            this.Title_List_DGV.AllowUserToAddRows = false;
            this.Title_List_DGV.AllowUserToDeleteRows = false;
            this.Title_List_DGV.AllowUserToResizeColumns = false;
            this.Title_List_DGV.AllowUserToResizeRows = false;
            this.Title_List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Title_List_DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Title_List_DGV.Location = new System.Drawing.Point(426, 57);
            this.Title_List_DGV.Name = "Title_List_DGV";
            this.Title_List_DGV.ReadOnly = true;
            this.Title_List_DGV.RowHeadersVisible = false;
            this.Title_List_DGV.ShowCellErrors = false;
            this.Title_List_DGV.ShowCellToolTips = false;
            this.Title_List_DGV.ShowEditingIcon = false;
            this.Title_List_DGV.ShowRowErrors = false;
            this.Title_List_DGV.Size = new System.Drawing.Size(200, 304);
            this.Title_List_DGV.TabIndex = 5;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(68, 400);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(76, 23);
            this.New.TabIndex = 1;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(311, 400);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(426, 400);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(75, 23);
            this.Read.TabIndex = 6;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(591, 400);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Note_Taking_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Title_List_DGV);
            this.Controls.Add(this.Message_txt);
            this.Controls.Add(this.Title_txt);
            this.Controls.Add(this.Message_LB);
            this.Controls.Add(this.Title_LB);
            this.Name = "Note_Taking_App";
            this.Text = "Note Takin App";
            this.Load += new System.EventHandler(this.Note_Taking_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Title_List_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_LB;
        private System.Windows.Forms.Label Message_LB;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox Message_txt;
        private System.Windows.Forms.DataGridView Title_List_DGV;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Delete;
    }
}

