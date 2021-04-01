using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taking_App
{
    public partial class Note_Taking_App : Form
    {
        DataTable table;
        public Note_Taking_App()
        {
            InitializeComponent();
        }

        private void Note_Taking_App_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            Title_List_DGV.DataSource = table;
            Title_List_DGV.Columns["Messages"].Visible = false;
            Title_List_DGV.Columns["Title"].Width = 200;
        }

        private void New_Click(object sender, EventArgs e)
        {
            Title_txt.Clear();
            Message_txt.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Title_txt.Text != "")
            {
                table.Rows.Add(Title_txt.Text, Message_txt.Text);
                Title_txt.Clear();
                Message_txt.Clear();
            }
            else
                MessageBox.Show("Please Enter Title!", "Note Taking App");

        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            { 
                int index = Title_List_DGV.CurrentCell.RowIndex;
                if (index > -1)
                {
                    Title_txt.Text = table.Rows[index].ItemArray[0].ToString();
                    Message_txt.Text = table.Rows[index].ItemArray[1].ToString();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Please Select any Title!", "Note Taking App");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Title_List_DGV.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please Select any Title!", "Note Taking App");

            }
        }
    }
}
