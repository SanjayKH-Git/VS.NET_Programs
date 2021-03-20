using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abbrevation_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(e.ToString()=="Enter")
                abbreBtn_Click(sender, e);
        }

        private void abbreBtn_Click(object sender, EventArgs e)
        {
            int j = 0;            
            string str = textBox1.Text;
            str = str.ToUpper();
            char[] result = new char[str.Length];
            result[j++] = str[0];
            result[j++] = '.';

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {                    
                        result[j++] = str[i + 1];
                        result[j++] = '.';                    
                }
            }

            AbbrevationLabel.Text = "Abbrevation=  " + new string(result);
            AbbrevationLabel.Visible = true;
        }
    }
}
