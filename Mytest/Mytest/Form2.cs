using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Mytest
{
    public partial class Form2 : Form
    {

        public Form2(List<string> data,List<Student> data2)
        {
            InitializeComponent();
            NewSpisok = data;
        }

        List<string> NewSpisok = new List<string>();
        List<Student> SpisokStudentov = new List<Student>();
        BinaryFormatter formatter = new BinaryFormatter();
        XmlSerializer formatter2 = new XmlSerializer(typeof(List<string>));

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("XML");
            comboBox1.Items.Add("Binary");
            //comboBox1.Items.Add("Свой способ сериализации");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // File file = new File();
            //File.Create(@"C: \Users\User\source\repos\Mytest\Mytest\bin\Debug");
            if (comboBox1.SelectedIndex == 1)
            {
                using (FileStream fs = new FileStream("Binary.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, NewSpisok);
                    MessageBox.Show("Serialization was successful");
                }
            }
            else
            {
                using (FileStream fs = new FileStream("www.xml", FileMode.OpenOrCreate))
                {
                    formatter2.Serialize(fs, NewSpisok);

                    Console.WriteLine("Объект сериализован");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                using (FileStream fs = new FileStream("Binary.dat", FileMode.OpenOrCreate))
                {
                    List<string> deserilizePeople = (List<string>)formatter.Deserialize(fs);
                    MessageBox.Show("Deserialization was successful");
                    for (int l = 0; l < deserilizePeople.Count; l++)
                    {
                        listBox1.Items.Add(deserilizePeople[l]);
                        if ((l + 1) % 4 == 0)
                        {
                            listBox1.Items.Add("       ");
                        }

                    }
                }
            }
            else
            {
                using (FileStream fs = new FileStream("www.xml", FileMode.OpenOrCreate))
                {
                    List<string> NewSpisok = (List<string>)formatter2.Deserialize(fs);
                    for (int l = 0; l < NewSpisok.Count; l++)
                    {
                        listBox1.Items.Add(NewSpisok[l]);
                        if ((l + 1) % 4 == 0)
                        {
                            listBox1.Items.Add("       ");
                        }

                    }
                }
            }
               
        }
    }
}
