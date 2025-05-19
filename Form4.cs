using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Original1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


        }
        private void btnGo_Click(object sender, EventArgs e)

        {

            string[] allLines = textBox2.Text.Split('\n');



            lblOutput1.Text = "";

            foreach (string text in allLines)

            {

                string trimmed = text.Trim(); // Remove extra spaces or newlines

                if (trimmed != "10")

                {
                    lblOutput1.Text = "??";
                    lblCheckResult.Text = "Wrong!";
                }
                else
                {
                    lblOutput1.Text = String.Format("{0}{1}\n", lblOutput1.Text, text);

                    lblCheckResult.Text = "Correct!";
                }
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;


            textBox1.Text = "A variable is a like container that we can store data in." + Environment.NewLine + "" + Environment.NewLine + "" + Environment.NewLine +
            "In C#, there are different types of variables (defined with different keywords), for example:" + Environment.NewLine + "" + Environment.NewLine +
            "int -stores integers(whole numbers), without decimals, such as 123 or - 123" + Environment.NewLine + "" + Environment.NewLine +
            "double -stores floating point numbers, with decimals, such as 19.99 or - 19.99" + Environment.NewLine + "" + Environment.NewLine +
            "char -stores single characters, such as 'a' or 'B'.Char values are surrounded by single quotes" + Environment.NewLine + "" + Environment.NewLine +
            "string -stores text, such as Hello World.String values are surrounded by double quotes" + Environment.NewLine + "" + Environment.NewLine +
            "bool -stores values with two states: true or false" + Environment.NewLine + "For example" + Environment.NewLine + "" + Environment.NewLine +
            "We will mainly be using string and int variable for the task" + Environment.NewLine + "" + Environment.NewLine + "string name = \"John\";" + Environment.NewLine + "Console.WriteLine(name);"
            + Environment.NewLine + "" + Environment.NewLine + "Result: John";

            textBox3.Text = "Question 1" + Environment.NewLine + "" + Environment.NewLine + "The variable \"Number\" below is assigned the value of 10" + Environment.NewLine + "int Number = 10;" +
            Environment.NewLine + "Console.WriteLine("+ textBox2.Text + ");" + Environment.NewLine + "Result: 10" + Environment.NewLine + "" + Environment.NewLine + "What should be put in ??? for the result to be 10?";

        }
        private void BackTutorial1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Hide();
        }






        
        }

    }


    

