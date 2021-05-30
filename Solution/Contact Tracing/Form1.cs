using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        private int zähler;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hinzufügen_Click(object sender, EventArgs e)
        {
          txt_Liste.Text = txt_Liste.Text + txt_Vorname.Text + " " + txt_Nachname.Text + "\r\n";
            zähler++;
            UptadeGUI();
            txt_Vorname.Text = " ";
            txt_Vorname.Text = " ";
        }

        private void btn_ListeLöschen_Click(object sender, EventArgs e)
        {

        }

        private void UpdateGUI()
        {
            .Text = zähler.ToString() + " Personen sind anwesend";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void lbl_Anwesenheit(object sender, EventArgs e)
        {

        }
    }
}
