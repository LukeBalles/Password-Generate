using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerate
{
    public partial class Form1 : Form
    {
        int passNum = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            passwordBox.Items.Clear();
            string chars = "abcdefghijklmnopqrstuvwxyz";

            if (uppercase.Checked)
            {
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (number.Checked)
            {
                chars += "0123456789";
            }

            if (symbols.Checked)
            {
                chars += "#$!_-/";
            }

            Random rnd = new Random();

            for(int i = 1; i <= passNum; i++)
            {
                StringBuilder str = new StringBuilder();
                
                for(int j = 1; j <= numberBox.Value; j++)
                {
                    int pos = rnd.Next(0, chars.Length);
                    str.Append(chars[pos].ToString());
                }

                passwordBox.Items.Add(str.ToString());
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
