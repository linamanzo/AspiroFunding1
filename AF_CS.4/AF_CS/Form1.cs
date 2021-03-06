﻿using System;
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
        private Course_DetailManager coursmanager;
        private Job_ProspectManager jobpmanager;
        private Job_HistoryManager jobhmanager;
        private Financial_DetailsManager financialmanager;
        public Form1()
        {
            InitializeComponent();

        }


      private void Form1_Load(object sender, EventArgs e)
        {   
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {    int id = Convert.ToInt32(textBox10.Text);
            persmanager = new Personnal_DetailsManager(id);
            persmanager.GetPersStat(id);
            coursmanager = new Course_DetailManager(id);
            coursmanager.GetCoursStat(id);
            jobpmanager = new Job_ProspectManager(id);
            jobpmanager.GetJobPStat(id);
            jobhmanager = new Job_HistoryManager(id);
            jobhmanager.GetJobHStat(id);
            financialmanager = new Financial_DetailsManager(id);
            financialmanager.GetFinancialStat(id);
            textBox3.Text = this.persmanager.apersD.maritalStatus;
            textBox4.Text = this.persmanager.apersD.residentialStatus;
            textBox5.Text = Convert.ToString(this.persmanager.apersD.age);

            textBox6.Text = Convert.ToString(this.financialmanager.aFinD.loanOutstanding);
            textBox7.Text = Convert.ToString(this.financialmanager.aFinD.missedRepayment);
            textBox8.Text = Convert.ToString(this.financialmanager.aFinD.ccj);
            textBox9.Text = Convert.ToString(this.financialmanager.aFinD.existingCreditCard);
            textBox18.Text = Convert.ToString(this.coursmanager.acoursD.courseFees);
            textBox19.Text = Convert.ToString(this.coursmanager.acoursD.placeConfirmed);
            textBox20.Text = this.coursmanager.acoursD.partFullTime;
            textBox21.Text = Convert.ToString(this.coursmanager.acoursD.courseDuration);
            textBox11.Text = this.jobhmanager.aJobh.previouslyEmployed;
            textBox12.Text = Convert.ToString(this.jobhmanager.aJobh.previousSalary);
            textBox13.Text = Convert.ToString(this.jobhmanager.aJobh.jobDuration);
            textBox14.Text = Convert.ToString(this.jobpmanager.aJobp.jobConfirmed);
            textBox15.Text = Convert.ToString(this.jobpmanager.aJobp.expectedSalary);
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
