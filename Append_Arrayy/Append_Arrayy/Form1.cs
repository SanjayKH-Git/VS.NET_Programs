using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Append_Arrayy
{
    public partial class Form1 : Form
    {
        string[] arr1, arr2,arr3;        
        public Form1()
        {
            InitializeComponent();
            Array3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Array1.Text != "" && Array2.Text != "")
            {
                Array1.Text = Regex.Replace(Array1.Text.Trim()," +", " ");
                Array2.Text = Regex.Replace(Array2.Text.Trim(), " +", " ");
                arr1 = Array1.Text.Split(' ');
                arr2 = Array2.Text.Split(' ');
                arr3 = arr1.Concat(arr2).ToArray();
                Array3.Text = "Array3 =[" + string.Join(", ", arr3) + "]";
                Array3.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Elements", "Array_Append_GUI", MessageBoxButtons.OK);
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Array3.Visible = false;
            Array1.Clear();
            Array2.Clear();
        }
    }
}
