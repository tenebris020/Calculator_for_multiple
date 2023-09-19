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
        private static HashSet<string> set1 = new HashSet<string>();
        private static HashSet<string> set2 = new HashSet<string>();
        private static HashSet<string> universe = new HashSet<string>();
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
        private static bool IsSubset<T>(IEnumerable<T> setA, IEnumerable<T> setB)
        {
            return setA.All(elementA => setB.Contains(elementA));
        }
        static string[] Intersection(string[] set1, string[] set2)
        {
            HashSet<string> hashSetA = new HashSet<string>(set1);
            HashSet<string> hashSetB = new HashSet<string>(set2);
            hashSetA.IntersectWith(hashSetB);
            return hashSetA.ToArray();
        }
        static string[] Union(string[] setA, string[] setB)
        {
            HashSet<string> hashSetA = new HashSet<string>(setA);
            HashSet<string> hashSetB = new HashSet<string>(setB);

            hashSetA.UnionWith(hashSetB);

            return hashSetA.ToArray();
        }
        public static IEnumerable<string> Complement(HashSet<string> setA)
        {
            var complement = universe.Except(setA);
            return complement;
        }
        static string[] SymmetricDifference(HashSet<string> setA, HashSet<string> setB)
        {
            HashSet<string> hashSetA = new HashSet<string>(setA);
            HashSet<string> hashSetB = new HashSet<string>(setB);

            hashSetA.SymmetricExceptWith(hashSetB);

            return hashSetA.ToArray();
        }
        static string[] Divide(HashSet<string> setA, HashSet<string> setB)
        {
            setA.ExceptWith(setB);
            return setA.ToArray();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.Trim();

            if (radioButton1.Checked)
            {
                if (!set1.Contains(inputText))
                {
                    set1.Add(inputText);
                    listBox1.Items.Add(inputText);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Этот элемент уже существует в множестве A ", "Повторение элемента");
                    textBox1.Clear();
                }
            }
            else if (radioButton2.Checked)
            {
                if (!set2.Contains(inputText))
                {
                    set2.Add(inputText);
                    listBox2.Items.Add(inputText);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Этот элемент уже существует в множестве B", "Повторение элемента");
                    textBox1.Clear();
                }
            }
            universe.Clear();
            universe.UnionWith(set1);
            universe.UnionWith(set2);
            listBox3.Items.Clear();
            listBox3.Items.AddRange(universe.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = listBox1.Items.Count.ToString();
        }

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
            int[] set1 = listBox1.Items.Cast<string>().Select(int.Parse).ToArray();
            int[] set2 = listBox2.Items.Cast<string>().Select(int.Parse).ToArray();
            label5.Text = (set1.Length == set1.Length).ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] set1 = listBox1.Items.Cast<string>().Select(int.Parse).ToArray();
            int[] set2 = listBox2.Items.Cast<string>().Select(int.Parse).ToArray();
            label6.Text = (set1.Length != set1.Length).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text= IsSubset(set1, set2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = IsSubset(set2, set1).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] set1 = listBox1.Items.Cast<string>().ToArray();
            string[] set2 = listBox2.Items.Cast<string>().ToArray();
            
            label11.Text = string.Join(", ", Intersection(set1, set2));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] set1 = listBox1.Items.Cast<string>().ToArray();
            string[] set2 = listBox2.Items.Cast<string>().ToArray();
            label12.Text = string.Join(", ", Union(set1, set2));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string result = string.Join(", ", Divide(set1, set2));
            label13.Text = result;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string result = string.Join(", ", Divide(set2, set1));
            label14.Text = result;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string result = string.Join(", ", Complement(set1));
            label15.Text = result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string result = string.Join(", ", Complement(set2));
            label16.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] result = SymmetricDifference(set1, set2);
            string resultString = string.Join(", ", result);
            label17.Text = resultString;
        }
    }
}
