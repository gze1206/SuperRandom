using System;
using System.Windows.Forms;

/*
Write by gze1206
이걸로 포폴만들어서 입사하면 1 크레딧 주세요!
*/

namespace SuperRandomProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Text = new Random().Next().ToString();

            Random rdm = new Random(int.Parse(textBox1.Text));

            if (checkBox2.Checked)
                textBox2.Text = rdm.Next(0, 23).ToString();

            int max = int.Parse(textBox2.Text);
            for (int i = 0; i < max; i++)
            {
                ListViewItem LVI = new ListViewItem(i.ToString());
                string str = listView2.Items[rdm.Next(0, listView2.Items.Count)].SubItems[0].Text;
                LVI.SubItems.Add(str);
                listView1.Items.Add(LVI);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Add(new ListViewItem(textBox3.Text));
            textBox3.Clear();
        }
    }
}
