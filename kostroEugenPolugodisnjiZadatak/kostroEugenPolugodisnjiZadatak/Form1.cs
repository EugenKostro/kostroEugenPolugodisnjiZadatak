using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenPolugodisnjiZadatak
{
    public partial class Form1 : Form
    {
        List<Ucenik> ListaUcenik = new List<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {


            string Ime = txtbxIme.Text;
            string Prezime = txtbxPrezime.Text;
            string Godina = txtbxGodina.Text;
            string Razred = cmbxRazred.Text;

            ListaUcenik.Add(new Ucenik(Ime, Prezime, Godina, Razred));

            if (string.IsNullOrWhiteSpace(Ime))
            {
                MessageBox.Show("Nema unosa!");
            }
            if (string.IsNullOrWhiteSpace(Prezime))
            {
                MessageBox.Show("Nema unosa!");
            }
            if (string.IsNullOrWhiteSpace(Godina))
            {
                MessageBox.Show("Nema unosa!");
            }
            if (string.IsNullOrWhiteSpace(Razred))
            {
                MessageBox.Show("Nema unosa!");
            }

            
            

        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach(Ucenik ucenik in ListaUcenik)
            {
                richTextBox1.Text += ucenik.Ispis() + Environment.NewLine;
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaUcenik.Count; i++)
            {
                if (cmbxRazred.Text == "1.a" || cmbxRazred.Text == "2.a" || cmbxRazred.Text == "3.a" || cmbxRazred.Text == "4.a")
                {
                    ListaUcenik[i].Smjer1 = "Matematička";
                }
                if (cmbxRazred.Text == "1.b" || cmbxRazred.Text == "2.b" || cmbxRazred.Text == "3.b" || cmbxRazred.Text == "4.b")
                {
                    ListaUcenik[i].Smjer1 = "Opća";
                }
                if (cmbxRazred.Text == "1.c" || cmbxRazred.Text == "2.c" || cmbxRazred.Text == "3.c" || cmbxRazred.Text == "4.c")
                {
                    ListaUcenik[i].Smjer1 = "Ekonomska";
                }
                if (cmbxRazred.Text == "1.d" || cmbxRazred.Text == "2.d" || cmbxRazred.Text == "3.d" || cmbxRazred.Text == "4.d")
                {
                    ListaUcenik[i].Smjer1 = "Tehničar";
                }
            }
        }
    }
}
