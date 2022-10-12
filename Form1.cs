using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RidiciStruktury08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] radky = textBox1.Lines;
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < radky.Length; i++)
                {
                    string radek = radky[i];

                    radek = char.ToUpper(radek[0]) + radek.Substring(1);

                    radky[i] = radek;

                }
                textBox1.Lines = radky;
            }

            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < radky.Length; i++)
                {
                    string radek = radky[i];

                    if (radek[radek.Length - 1] != '.')
                    {
                        radek += ".";
                    }
                    else
                    {
                        while (radek[radek.Length - 2] == '.')
                        { 
                            radek = radek.Remove(radek.Length - 2, 1);
                        }
                    }
                    radky[i] = radek;
                }
                textBox1.Lines = radky;
            }
        }
    }
}
