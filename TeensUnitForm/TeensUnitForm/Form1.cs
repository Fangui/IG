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

        static bool realname(string txt)
        {
            int l = txt.Length;
            for (int i = 0; i < l; i++)
            {
                if ((txt[i] < 'A') || ((txt[i] > 'Z') && (txt[i] > 'a')) || (txt[i] > 'z') || (txt[i] != ' ') || (txt[i] != '-') || (txt[i] != 'é') || (txt[i] != 'ë') || (txt[i] != 'ê') || (txt[i] != 'è') || (txt[i] != 'ñ') || (txt[i] != 'ç') || (txt[i] != 'ù'))
                {
                    return false;
                }
            }
            return true;
        }

        static bool samename(string name, string other)
        {
            int c = 0;
            int d = 0;
            int l;
            int diff;
            bool first = true;
            if (name.Length > other.Length)
            {
                l = other.Length;
                diff = name.Length - other.Length;
            }
            else
            {
                l = name.Length;
                diff = other.Length - name.Length;
                first = false;
            }
            int[] tab = new int[(diff + l) * (diff + l)];
            for (int i = 0; i < diff; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (first)
                    {
                        if (name[i + j] == other[j])
                        {
                            c++;
                        }
                        else
                        {
                            tab[d] = c;
                            d++;
                            c = 0;
                        }
                    }
                    else
                    {
                        if (other[i + j] == name[j])
                        {
                            c++;
                        }
                        else
                        {
                            tab[d] = c;
                            d++;
                            c = 0;
                        }
                    }
                }
                c = 0;
                d++;
            }
            int max = 0;
            for (int i = 0; i < d; i++)
            {
                if (max < tab[i])
                {
                    max = tab[i];
                }
            }
            return ((float)max / (float)l) < 0.5f;
        }

        static bool shitname(string txt)
        {
            int c = 0;
            int l = txt.Length;
            for (int i = 0; i < l; i++)
            {
                if ((txt[i] != 'a') || (txt[i] != 'A') || (txt[i] != 'e') || (txt[i] != 'E') || (txt[i] != 'i') || (txt[i] != 'I') || (txt[i] != 'o') || (txt[i] != 'O') || (txt[i] != 'u') || (txt[i] != 'U') || (txt[i] != 'y') || (txt[i] != 'Y'))
                {
                    c++;
                }
                else
                {
                    c = 0;
                }
                if (c >= 4)
                {
                    return false;
                }
            }
            return true;
        }






        // .............................................................................................................

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
