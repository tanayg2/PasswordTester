using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerationFormsClient
{
    public partial class Form1 : Form
    {
        private localhost.Service1 service;
        public Form1()
        {
            InitializeComponent();
            service = new localhost.Service1();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = this.textBox1.Text;

            //Get values from service
            bool idk;
            int numVowels, numUpper;
            string reverse;
            service.VowelCount(word, out numVowels, out idk);
            service.UpperCaseCount(word, out numUpper, out idk);
            reverse = service.Reverse(word);

            //Modify labels
            this.vowelCtOutputLabel.Text = numVowels.ToString();
            this.upperCtOutputLabel.Text = numUpper.ToString();
            this.reverseOutputLabel.Text = reverse;
        }
    }
}
