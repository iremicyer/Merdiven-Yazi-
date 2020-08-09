using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merdiven_Yazdırma_Console    // HEM AŞAĞIYA DOĞRU HEM DE SAĞA DOĞRU BİR ARTMA OLACAĞI İÇİN İKİ BOYUTLU DİZİ KULLANILDI.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYazdır_Click(object sender, EventArgs e)
        {

            string[,] kelime = new string[textBox1.Text.Length, textBox1.Text.Length]; //iki boyutlu dizinin, kelimenin boyutu kadar olmasını sağlandı.
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    kelime[i, j] = textBox1.Text[j].ToString();

                }
            }

            listBox1.Text = ""; // listbox' ı temizliyoruz.




            for (int i = 0; i < textBox1.Text.Length; i++) 
            {
                string s = "";
                for (int j = 0; j <= i; j++)
                {
                    s += kelime[i, j];

                }
                listBox1.Items.Insert(i, s);
            }

        }
    }
}
