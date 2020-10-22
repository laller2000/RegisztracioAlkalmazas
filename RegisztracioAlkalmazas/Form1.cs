using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Hozzaad_Click(object sender, EventArgs e)
        {
            string ujhobbi = textBox3_ujhobbi.Text.Trim();
            if (String.IsNullOrWhiteSpace(textBox3_ujhobbi.Text.Trim()))
            {
                MessageBox.Show("Az új hobbi mezőben szökőz  található", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3_ujhobbi.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(textBox3_ujhobbi.Text.Trim()))
            {
                MessageBox.Show("Az új hobbi mezőben üres karaktert tartalmaz","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox3_ujhobbi.Focus();
                return;
            }
            else
            {
                listBox1_Kedvenchobbi.Items.Add(ujhobbi);
            }
        }

        private void button2_Mentes_Click(object sender, EventArgs e)
        {
            string nev = textBox1_Nev.Text.Trim();
            if (String.IsNullOrEmpty(textBox1_Nev.Text.Trim()))
            {
                MessageBox.Show("Nem töltöted ki a nev mezőt","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1_Nev.Focus();
                return;
            }
            DateTime szuletes=DateTime.Parse(textBox2_Szuldatum.Text.ToString());
            if (String.IsNullOrEmpty(textBox2_Szuldatum.Text.Trim()))
            {
                MessageBox.Show("nem töltötted ki a szül.dátum mezőt", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2_Szuldatum.Focus();
                return;
            }
            string nem;
            if(radioButton1_F.Checked)
            {
                nem = "F";
            }
            else if(radioButton2_N.Checked)
            {
                nem = "N";
            }
            else
            {
                nem = "E";
            }
            if(listBox1_Kedvenchobbi.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon Hobbit","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.OK==saveFileDialog1.ShowDialog())
            {
                string fajl = saveFileDialog1.FileName;
                using (StreamWriter sw=new StreamWriter(fajl))
                {
                    for (int i = 0; i < listBox1_Kedvenchobbi.Items.Count; i++)
                    {
                        sw.WriteLine((string)listBox1_Kedvenchobbi.Items[i]);
                    }
                    sw.Close();
                }
            }
        }

        private void button3_Beolvas_Click(object sender, EventArgs e)
        {
            listBox1_Kedvenchobbi.Items.Clear();
            if (DialogResult.OK==openFileDialog1.ShowDialog())
            {
                using (StreamReader sr=new StreamReader(openFileDialog1.FileName))
                {
                    
                    while (!sr.EndOfStream)
                    {
                        
                        Hobbi hobbi = new Hobbi(sr.ReadLine());
                        listBox1_Kedvenchobbi.Items.Add(hobbi);
                    }
                    sr.Close();
                }
            }
            
        }
    }
}
