using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mytest
{
    public partial class Form1 : Form
    {

        University un = new University();
        Student student1 = new Student();
        List<string> spisok = new List<string>();

        List<Student> ta = new List<Student>();
        int counter = 0;
        int realcount2;

        public Form1()
        {
            InitializeComponent();           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Test_list t = new Test_list();
            un.UFaculties = "asd";
            un.Uname = "zxc";
            List<string> tspisok = new List<string>();           
            Student test_student = new Student(ref un);
            student1 = test_student;
            CreateObj createObj = new CreateObj();
            student1 = createObj.Cr(student1,ref un);
            spisok.Add(student1.Name);
            spisok.Add(Convert.ToString(student1.Age));
            spisok.Add(student1.Gender);
            spisok.Add(student1.university.Uname);
            counter = counter + 1;
            listBox1.Items.Clear();

            for (int l = 0; l < spisok.Count; l++)
            {
                listBox1.Items.Add(spisok[l]);
                if ((l + 1) % 4 == 0)
                {
                    listBox1.Items.Add("       ");
                }

            }
            ta.Add(student1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                string smt = richTextBox1.Text;
                int SizeOfUnitSpisok = spisok.Count / counter;
                int Index = int.Parse(smt);
                int SecIndex = Index * SizeOfUnitSpisok;
                for (int i = 0; i < SizeOfUnitSpisok; i++)
                {
                    if (Index == 1)
                    {
                        spisok.RemoveAt(SizeOfUnitSpisok - (i + 1));
                    }
                    else
                    {
                        spisok.RemoveAt(SecIndex - (i + 1));
                    }

                }
                counter = counter - 1;
            }
            catch
            {
                MessageBox.Show("Enter index of Object");
            }

            listBox1.Items.Clear();

            for (int l = 0; l < spisok.Count; l++)
            {
                listBox1.Items.Add(spisok[l]);
                if ((l + 1) % 4 == 0)
                {
                    listBox1.Items.Add("       ");
                }

            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {

            for (int l = 0; l < spisok.Count; l++)
            {
                listBox1.Items.Add(spisok[l]);
                if ((l + 1) % 4 == 0)
                {
                    listBox1.Items.Add("       ");
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string count2 = richTextBox2.Text;
                string l;
                realcount2 = Convert.ToInt32(count2);
                richTextBox2.Clear();
                int temp = realcount2 * 4;
                temp = temp - 4;
                for (int i = 0; i < 4; i++)
                {
                    if (realcount2 == 1)
                    {
                        l = spisok[(0) + i];
                        textBox1.Text += l.ToString() + "\r\n";
                    }
                    else

                    if (realcount2 == 2)
                    {
                        l = spisok[(4) + i];
                        textBox1.Text += l.ToString() + "\r\n";
                    }
                    else

                    {
                        l = spisok[(temp + i)];
                        textBox1.Text += l.ToString() + "\r\n";

                    }

                }

                /* for (int i = 0; i < 3;i++)
                 {
                     l = listBox2.Items[i].ToString();
                     textBox1.Text += l.ToString() + "\r\n";
                 }*/


            }

            catch
            {
                MessageBox.Show("Enter index of Object");
            }


        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            int a = realcount2;
            int index = a;
            a = a * 4;
            int AmountOfUnit = 4;
            
            for (int i = 0; i < 4; i++)
            {
                if (index == 1)
                {
                    spisok.RemoveAt(AmountOfUnit - (i+1));
                }
                else
                {
                    spisok.RemoveAt((AmountOfUnit*realcount2)- (i+1));
                }

            }
           /* if (a == 4)
            {
                spisok.RemoveAt(a - 4);
                spisok.RemoveAt(a - 3);
                spisok.RemoveAt(a - 2);
                spisok.RemoveAt(a - 1);

            }
            else
            {
                spisok.RemoveAt(a - 1);
                spisok.RemoveAt(a - 2);
                spisok.RemoveAt(a - 3);
                spisok.RemoveAt(a-4);
            }*/
            for (int i = 0; i < 4; i++)
            {
                String[] s = textBox1.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                spisok.Add(s[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this.spisok,this.ta);
            newForm.ShowDialog();
        }
    }
}
