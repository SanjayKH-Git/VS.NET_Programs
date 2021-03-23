using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Form_App
{
    public partial class QuizApp : Form
    {
        int[] score_arr=new int[6];
        int qtn_no;
        public QuizApp()
        {
            InitializeComponent();
            panel1.Visible = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
      
        private void start_Click(object sender, EventArgs e)
        {
            prev.Visible = false;
            panel1.Visible = true;
            start.Visible = false;          
            qtn_no = 1;
            askQuestion(qtn_no);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            RadioButton[] corrct_Ans = {null,ans2,ans3,ans4,ans3,ans1};
            
            if (corrct_Ans[qtn_no].Checked)
                score_arr[qtn_no] = 10;
            
            if (qtn_no < 5)
            {
                for (int i = 1; i < corrct_Ans.Length; i++)
                    corrct_Ans[i].Checked = false;
                askQuestion(++qtn_no);
            }
            else
                submit();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            Next.Visible = true;
            askQuestion(--qtn_no);
        }
        private void askQuestion(int qtn_no)
        {
            switch(qtn_no)
            {
                case 1:
                    prev.Visible = false;
                    pictureBox1.Image=new Bitmap("C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\Quiz_Form_App\\Quiz_Images\\prime.png") ;
                    qtn.Text = "1. Who is the current Prime Minister of India?";
                    ans1.Text = "Rahul Gandhi";
                    ans2.Text = "Narendra Modi";
                    ans3.Text = "Hemanth raj";
                    ans4.Text = "Priyanka Gandhi";
                    break;
                case 2:
                    prev.Visible = true;
                    pictureBox1.Image = new Bitmap("C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\Quiz_Form_App\\Quiz_Images\\AlbertEinstein.png");
                    qtn.Text = "2. Name of the Scientist";
                    ans1.Text = "Vijay Vincent";
                    ans2.Text = "Rajath Mams";
                    ans3.Text = "Einstien";
                    ans4.Text = "Newton";
                    break;
                case 3:
                    pictureBox1.Image = new Bitmap("C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\Quiz_Form_App\\Quiz_Images\\solveIt.png");
                    qtn.Text = "3. Answer = ";
                    ans1.Text = "10";
                    ans2.Text = "9";
                    ans3.Text = "0";
                    ans4.Text = "1";
                    break;
                case 4:
                    pictureBox1.Image = new Bitmap("C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\Quiz_Form_App\\Quiz_Images\\2011.png");
                    qtn.Text = "4. Who Won the ICC Worldcup 2011? ";
                    ans1.Text = "RCB";
                    ans2.Text = "Australia";
                    ans3.Text = "India";
                    ans4.Text = "England";
                    break;
                case 5:         
                    Next.Text= "submit";
                    pictureBox1.Image = new Bitmap("C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\Quiz_Form_App\\Quiz_Images\\sky.png");
                    qtn.Text = "5. wWhat is the Color of Sky? ";
                    ans1.Text = "Blue";
                    ans2.Text = "green";
                    ans3.Text = "Orange";
                    ans4.Text = "Red";
                    break;
            }
        }

        private void submit()
        {
            panel1.Visible = false;
            int score = score_arr.Sum();
            Label res =new Label();
            res.Size = new Size(500, 200);
            res.Location = new Point(this.Height/2, this.Width/2);
            res.Font = new Font("Ariel", 20, FontStyle.Bold);
            res.Text = "Your Score is " + score+" /50";
            this.Controls.Add(res);            
        }
    }
}
