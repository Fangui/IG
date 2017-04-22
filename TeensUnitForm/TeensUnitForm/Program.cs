using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeensUnitForm
{
    static class Program
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
