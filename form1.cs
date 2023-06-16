using System;
using System.Drawing;
using System.Windows.Forms;

namespace homework4
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            label2.Text = openFileDialog.FileName;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(openFileDialog.FileName);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Play")
            {
                button2.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                button2.Text = "Play";
                timer1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 0) listBox1.Items.RemoveAt(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 0) listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedIndex.ToString();
            if (listBox1.Items.Count > 0)
            {
                if (counter < listBox1.Items.Count)
                {
                    String fileName = listBox1.Items[counter].ToString();
                    Bitmap bitmap = new Bitmap(fileName);
                    pictureBox1.Image = bitmap;
                }

                counter++;
                if (counter > listBox1.Items.Count - 1) counter = 0;
            }
        }
    }
}
