using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue
{
    public partial class Form1 : Form
    {
       Stack<string>musteri=new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Push(txtAd.Text);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Push("ilayda");
            musteri.Push("melek");
            musteri.Push("hayrunnisa");
            musteri.Push("kübra");

        }
        private void mustericagır(Label lbl)
        {
            try {
               
            
                lbl.Text = musteri.Pop();
            }
            
            catch (Exception ) {
                MessageBox.Show("aferin bitti  köle...");
            }
        }

        private void btnCagir3_Click(object sender, EventArgs e)
        {
            mustericagır(lblCagir1);
        }

        private void btnCagir2_Click(object sender, EventArgs e)
        {
            mustericagır(lblCagir2);
        }

        private void btnCagir_Click(object sender, EventArgs e)
        {
          

            
            mustericagır(lblCagir3);

        }
    }
}
