using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AF_CS_BLL;


namespace AF_CS
{
    public partial class Form1 : Form
    {
        private Personnal_DetailsManager persmanager;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                int id = Convert.ToInt32(textBox2.Text);
                persmanager = new Personnal_DetailsManager( id);
               
                int score = persmanager.GetScore(id);
                textBox1.Text = String.Format("{0:C}", score);
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ca marche pas");
            }
        }
    }
}
