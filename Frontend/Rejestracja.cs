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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path2 = @"Login.txt";
            string[] dataLogin = File.ReadAllLines(path2);
            TextWriter nowyLogin = new StreamWriter(@"Login.txt", true);
            TextWriter noweHaslo = new StreamWriter(@"Haslo.txt", true);

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola");
            }
            else if(dataLogin.Contains(textBox1.Text))
            {
                MessageBox.Show("Użytkownik o podanym loginie już istnieje");
            }
            else {
                noweHaslo.WriteLine(textBox2.Text);
                nowyLogin.WriteLine(textBox1.Text);
                noweHaslo.Close();
                nowyLogin.Close();
                this.Close();
                Logowanie logowanie = new Logowanie();
                logowanie.Show();
                MessageBox.Show("Pomyślnie utworzono konto");
                }
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
