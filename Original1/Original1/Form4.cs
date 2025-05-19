using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Original1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Multiline = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(300, 70);
          
            textBox1.Text = "A variable is a container that we can store data in, For example: \n int";
        }
        private void BackTutorial1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Hide();
        }






        private void btnGo_Click(object sender, EventArgs e)

        {

            string[] allLines = textBox2.Text.Split('\n');



            lblOutput.Text = "";

            foreach (string text in allLines)

            {

                string trimmed = text.Trim(); // Remove extra spaces or newlines

                if (trimmed != "10")

                {
                    lblOutput.Text = "??";
                    lblCheckResult.Text = "Wrong!";
                }
                else
                {
                    lblOutput.Text = String.Format("{0}{1}\n", lblOutput.Text, text);

                    lblCheckResult.Text = "Correct!";
                }
            }
        }

    }
}

    

