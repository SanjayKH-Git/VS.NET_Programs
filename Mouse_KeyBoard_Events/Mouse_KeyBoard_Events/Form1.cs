using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_KeyBoard_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Mouse_Message_lb.Text +="Mouse Clicked (Left)\n";
            else
                Mouse_Message_lb.Text += "Mouse Clicked (Right)\n";
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                Mouse_Message_lb.Text += "Mouse Double Clicked\n";
        }
        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
                Mouse_Message_lb.Text += "Mouse Up\n";
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
                Mouse_Message_lb.Text += "Mouse Down (Left)\n";
            else
                Mouse_Message_lb.Text += "Mouse Down (Right)\n";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            Enter_lb.Text = "Mouse Entered\n";
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            Mouse_Hover.Text = "Mouse Hovered";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Enter_lb.Text = "Mouse Left\n";
            Moving_lb.Text = "";
            Mouse_Hover.Text = "";
        }       

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Moving_lb.Text = "Mouse Moving @ Location(" + e.X+","+e.Y+")";           
        }
        
        private void Clear_All_Click(object sender, EventArgs e)
        {
            Mouse_Message_lb.Text = "";
            Enter_lb.Text = "";
            KB_Msg.Text="";
            KB_ev.Text = "";
            KB_up_dwn.Text = "";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KB_ev.Text = "Key Pressed";
            KB_Msg.Text ="\'"+e.KeyChar.ToString()+"\' key Pressed\n";
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            KB_up_dwn.Text = "Key Down";
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            KB_up_dwn.Text = "Key UP";
            KB_ev.Text = "";
        }
    }
}
