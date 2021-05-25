using Frontend.Moduły;
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


namespace Frontend
{
    public partial class Panel : Form
    {
        private Items items = new Items();
        public Panel()
        {
            InitializeComponent();
            setupData();

        }
        private void ceny()
        {
            string path2 = @"Ceny.txt";
            string[] Ceny = File.ReadAllLines(path2);
            label2.Text = "Cena: " + Ceny[listBox1.SelectedIndex] + " zł";
        }
        private static int sum;
        private void ceny2()
        {
            string path2 = @"Ceny.txt";
            string[] Ceny = File.ReadAllLines(path2);
            sum += Convert.ToInt32(Ceny[listBox1.SelectedIndex]);
            label3.Text = "Cena całkowita: " + sum.ToString() + " zł";
        }
        private void setupData()
        {
            string path = @"Items.txt";
            string[] Items2 = File.ReadAllLines(path);
                for (int i = 0; Items2.Length > i; i++)
            {
                items.Nazwa = Items2[i];
                listBox1.Items.Add(items.Nazwa);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }

        private int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                i++;
                label1.Text = "Ilość przedmiotów" + " (" + i.ToString() + ")";
            }
            listBox2.Items.Add(listBox1.SelectedItem);
            ceny2();
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Obrazki\" + listBox1.Text + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ceny();
            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
                MessageBox.Show("Zakupiono wybrane przedmioty.");
                this.Close();
        }
    }
}
