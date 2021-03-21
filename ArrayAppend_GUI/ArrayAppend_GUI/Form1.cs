using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAppend_GUI
{
    public partial class Form1 : Form
    {
        int N1, N2, pos1, pos2;
        string[] arr1, arr2, arr3;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public Form1()
        {
            InitializeComponent();
            Enter_ele1.Visible = false;
            Enter_ele2.Visible = false;
            nxt_btn1.Visible = false;
            nxt_btn2.Visible = false;
            arr1_pos.Visible = false;
            arr2_pos.Visible = false;
            arr1_ele.Visible = false;
            arr2_ele.Visible = false;
            Append.Visible = false;
            Array3.Visible = false;
        }

        private void ele_no1_Click(object sender, EventArgs e)
        {
            arr1_print.Text += "= [ ";
            ele_no1.Enabled = false;
            ele_1.Enabled = false;
            N1 = int.Parse(ele_1.Text);
            arr1 = new string[N1];
            arr1_ele.Visible = true;
            arr1_pos.Visible = true;
            nxt_btn1.Visible = true;
            Enter_ele1.Visible = false;
        }
        private void ele_no2_Click(object sender, EventArgs e)
        {
            arr2_print.Text += "= [ ";
            ele_no2.Enabled = false;
            ele_2.Enabled = false;
            N2 = int.Parse(ele_2.Text);
            arr2 = new string[N2];
            arr2_ele.Visible = true;
            arr2_pos.Visible = true;
            nxt_btn2.Visible = true;
            Enter_ele2.Visible = false;
        }
        private void nxt_btn1_Click_1(object sender, EventArgs e)
        {
            if (arr1_ele.Text == "")
                MessageBox.Show("Please Enter Element!", "ArrayAppendGUI", MessageBoxButtons.OK);
            else
            {
                arr1_pos.Text = "arr[" + pos1 + "]";
                arr1[pos1] = arr1_ele.Text;
                arr1_print.Visible = true;
                arr1_print.Text += arr1[pos1] + ", ";
                if (pos1 < N1 - 1)
                {
                    pos1++;
                    arr1_pos.Text = "arr1[" + pos1 + "]";
                    arr1_ele.Text = "";
                }
                else
                {
                    arr1_ele.Enabled = false;
                    nxt_btn1.Enabled = false;
                    arr1_print.Text += "]";

                }
            }

        }

        private void nxt_btn2_Click(object sender, EventArgs e)
        {
            if (arr2_ele.Text == "")
                MessageBox.Show("Please Enter Element!", "ArrayAppendGUI", MessageBoxButtons.OK);
            else
            {
                arr2_pos.Text = "arr[" + pos2 + "]";
                arr2[pos2] = arr2_ele.Text;
                arr1_print.Visible = true;
                arr2_print.Text += arr2[pos2] + ", ";
                if (pos2 < N2 - 1)
                {
                    pos2++;
                    arr2_pos.Text = "arr2[" + pos2 + "]";
                    arr2_ele.Text = "";
                }
                else
                {
                    arr2_ele.Enabled = false;
                    nxt_btn2.Enabled = false;
                    arr2_print.Text += " ]";
                    Append.Visible = true;
                    Array3.Visible = true;
                }
            }
        }
        private void Append_Click(object sender, EventArgs e)
        {
            arr3 = new string[N1 + N2];
            arr3=arr1.Concat(arr2).ToArray();            
            Array3.Text += "  [ "+string.Join(", ", arr3)+"]";
        }

    }
}