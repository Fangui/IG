using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeensUnitForm
{
    public partial class Form1 : Form
    {
        public static bool checkBirth(string s1, string s2, string s3, short y, short m, short d)
        {
            if (s1 == "" || s2 == "" || s3 == "")
                return false;

            short Y = short.Parse(s1);
            short M = short.Parse(s2);
            short D = short.Parse(s3);

            if (m == 2 && D > 27)
                return false;

            if (m > 12 || m < 0 || D < 0 || D > 31)
                return false;

            if ((m == 4 || m == 6 || m == 9 || m == 11 && D > 30))
                return false;

            if (y - 24 > Y && y - 13 < Y)
                return false;

            if (y - 24 < Y && y - 13 > Y)
                return true;


            if (y - 24 == Y)
            {
                if (m != M)
                    return m > M;
                return d > D;
            }

            if (m != M)
                return m < M;
            return d <= D;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
