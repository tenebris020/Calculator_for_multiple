using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mnojestvo
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text = "";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label17.Text = " ";
            

        }
        

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!(listBox3.Items.Contains(textBox1.Text))) { listBox3.Items.Add(textBox1.Text); }
                else
                {
                    MessageBox.Show("Элемент уже находится в универсуме!");
                }
            }
            else { MessageBox.Show("Введите значение!"); }
            textBox1.Clear();
        }
        // Мощность A
        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = listBox1.Items.Count.ToString();
        }
        // Мощность B
        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = listBox2.Items.Count.ToString();
        }
       

        private void reset_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != listBox2.Items.Count)
            {
                label5.Text = "False";
            }
            else
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (!(listBox2.Items.Contains(listBox1.Items[i]))) { label5.Text = "False"; break; } else { label5.Text = "True"; }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = (listBox1.Items.Count == listBox2.Items.Count).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool flag;
            if (listBox1.Items.Count <= listBox2.Items.Count)
            {
                flag = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox2.Items.Contains(listBox1.Items[i])) { flag = true; } else { flag = false; break; }
                }
                if (flag) { label7.Text = "True"; } else { label7.Text = "False"; }
            }
            else { label7.Text = "False"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool flag;
            if (listBox2.Items.Count <= listBox1.Items.Count)
            {
                flag = false;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (listBox1.Items.Contains(listBox2.Items[i])) { flag = true; } else { flag = false; break; }
                }
                if (flag) { label8.Text = "True"; } else { label8.Text = "False"; }
            }
            else { label8.Text = "False"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                answer.Add(listBox1.Items[i].ToString());
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (!(answer.Contains(listBox2.Items[i]))) { answer.Add(listBox2.Items[i].ToString()); }
            }

            foreach (string item in answer) { glob += item + " "; }
            label11.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";

            if (listBox1.Items.Count > listBox2.Items.Count)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (listBox1.Items.Contains(listBox2.Items[i])) { answer.Add(listBox2.Items[i].ToString()); }
                }
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox2.Items.Contains(listBox1.Items[i])) { answer.Add(listBox1.Items[i].ToString()); }
                }
            }

            foreach (string item in answer) { glob += item + " "; }
            label12.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (!listBox2.Items.Contains(listBox1.Items[i])) { answer.Add(listBox1.Items[i].ToString()); }
            }

            foreach (string item in answer) { glob += item + " "; }
            label13.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";
            
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (!listBox1.Items.Contains(listBox2.Items[i])) { answer.Add(listBox2.Items[i].ToString()); }
            }

            foreach (string item in answer) { glob += item + " "; }
            label14.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";

            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                if (!(listBox1.Items.Contains(listBox3.Items[i]))) { answer.Add(listBox3.Items[i].ToString()); }
            }

            foreach (string item in answer) { glob += item + " "; }
            label15.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";

            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                if (!(listBox2.Items.Contains(listBox3.Items[i]))) { answer.Add(listBox3.Items[i].ToString()); }
            }

            foreach (string item in answer) { glob += item + " "; }
            label16.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> answer = new List<string>();
            string glob = "";

            foreach (string item in listBox1.Items)
            {
                if (!(answer.Contains(item)) && !(listBox2.Items.Contains(item))) { answer.Add(item); }
            }

            foreach (string item in listBox2.Items)
            {
                if (!(answer.Contains(item)) && !(listBox1.Items.Contains(item))) { answer.Add(item); }
            }

            foreach (string item in answer) { glob += item + " "; }
            label17.Text = "{ " + glob + " } Мощность множества - " + answer.Count;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBox1.Items.Contains(listBox3.SelectedItem)) { listBox1.Items.Add(listBox3.SelectedItem); } else { MessageBox.Show("Элемент уже находится в множестве A!"); }
            }
            catch (Exception) { MessageBox.Show("Выберите нужный элемент из универсума!"); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBox2.Items.Contains(listBox3.SelectedItem)) { listBox2.Items.Add(listBox3.SelectedItem); } else { MessageBox.Show("Элемент уже находится в множестве B!"); }
            }
            catch (Exception) { MessageBox.Show("Выберите нужный элемент из универсума!"); }
        }
    }
}
