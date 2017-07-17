using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("sinan"); //büyük kucuk harflere duyarlıdır.
            listBox1.Items.Add("batuhan");
            listBox1.Items.Add("umutcan");
            listBox1.Items.Add("ibrahim");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((listBox1.Items.IndexOf(textBox1.Text) + 1).ToString() + ". sıradadır.");

          
            if (textBox1.Text == String.Empty)
            {
                return;
            }

            // metni ListBox içinde arayıp geriye index numarasını dönderir
            int index = listBox1.FindString(textBox1.Text);

            // aranan metin ListBox içinde bulunamazsa geriye -1 döner
            if (index != -1)
                listBox1.SetSelected(index, true);
            else
                MessageBox.Show("Aranılan metin ListBox içinde bulunamadı.");
        }
    }
}