using System;
using System.IO;
using System.Windows.Forms;

namespace StreamToCharFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog File_Selector_Dialog = new OpenFileDialog();
            File_Selector_Dialog.InitialDirectory = "C:\\Users\\Sanjay-PC\\Desktop\\";
            File_Selector_Dialog.Filter = "Select any(*.txt)|*.txt";
            DialogResult result = File_Selector_Dialog.ShowDialog();
            string path = File_Selector_Dialog.FileName;
            File_stream.Text = path;
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);//Reading Data Stream
                ReadData_lb.Text += text;
                using (Stream s = new FileStream(path, FileMode.Open))
                {
                    int read;
                    while ((read = s.ReadByte()) != -1)
                    {
                        Display_lb.Text += (char)read + " ";//Casting in Char Data Type
                    }
                }
            }
            else
            {
                MessageBox.Show("please Select any valid .txt File", "DataStreamApp");
            }
        }
    }
}
