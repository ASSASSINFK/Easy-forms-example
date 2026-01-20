using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

             
         string not    = (sayi <= 100 && sayi >=0) ? "yok" :
                         (sayi >= 100 && sayi <=150 ) ? "işlem başarılı" :
                         (sayi >= 150 && sayi <= 200) ? "yok" :
                         (sayi >= 200 && sayi <= 250) ? "yok" : "yok";
            label1.Text = not;
        }
    }
}
