using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testgit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello git");
            MessageBox.Show("yeni bir işlem bilgisi");
            
            //bunu webten ekledim
            int a=5;
            MessageBox.Show("aaaaaaaa=" + a.ToString());


            //bende ekledim extra açıklama
        }
    }
}
