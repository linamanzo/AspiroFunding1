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
        public UserManager usermanager;
        public Form1()
        {
            InitializeComponent();

        }


      private void Form1_Load(object sender, EventArgs e)
        {
            usermanager = new UserManager();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {    int id = Convert.ToInt32(textBox10.Text);
           textBox3.Text =  usermanager.GetStatusbyId(id);
           textBox4.Text = usermanager.GetResStatus(id);
        


        }

       public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox2.Text);
                persmanager = new Personnal_DetailsManager(id);

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
