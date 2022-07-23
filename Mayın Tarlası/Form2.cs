using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayın_Tarlası
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form1 yeni = new Form1();
                yeni.Oyna("kolay");
                this.Hide();
            }
            else if(radioButton2.Checked == true)
            {
                Form1 yeni = new Form1();
                yeni.Oyna("orta");
                this.Hide();
            }
            else if (radioButton3.Checked == true)
            {
                Form1 yeni = new Form1();
                yeni.Hide();
                yeni.Oyna("zor");
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zorluk seçiniz!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
