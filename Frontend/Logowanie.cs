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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        public void logowanie()
        {
            // read file content into a string
            string path = @"Haslo.txt";
            string path2 = @"Login.txt";
            string[] dataHaslo = File.ReadAllLines(path);
            string[] dataLogin = File.ReadAllLines(path2);
            // compare TextBox content with file content
            if (dataHaslo.Contains(textBox2.Text) && dataLogin.Contains(textBox1.Text) && Array.IndexOf(dataHaslo, textBox1.Text) == Array.IndexOf(dataLogin, textBox2.Text))
            {
                Panel panel = new Panel();
                panel.Show();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            logowanie();
        }
    }
}
