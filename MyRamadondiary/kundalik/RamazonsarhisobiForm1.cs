using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRamadondiary.kundalik
{
    public partial class RamazonsarhisobiForm1 : Form
    {
        public string pathcheck = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ramazonsarhisobi.txt";
        public RamazonsarhisobiForm1()
        {
            InitializeComponent();
        }

        private void RamazonsarhisobiForm1_Load(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(pathcheck);
            if (!file.Exists)
            {
                using (StreamWriter sw = new StreamWriter(pathcheck))
                {
                    sw.Close();
                }
            }

            this.StartPosition = FormStartPosition.CenterScreen;
            string tempp = File.ReadAllText(pathcheck);
            if (tempp == "")
            {

            }
            else
            {
                if (tempp[0] == '1')
                {
                    checkBox1.Checked = true;
                }
                if (tempp[1] == '1')
                {
                    checkBox2.Checked = true;
                }
                if (tempp[2] == '1')
                {
                    checkBox3.Checked = true;
                }
                if (tempp[3] == '1')
                {
                    checkBox4.Checked = true;
                }
                if (tempp[4] == '1')
                {
                    checkBox5.Checked = true;
                }
                if (tempp[5] == '1')
                {
                    checkBox6.Checked = true;
                }
                if (tempp[6] == '1')
                {
                    checkBox7.Checked = true;
                }
                if (tempp[7] == '1')
                {
                    checkBox8.Checked = true;
                }
                if (tempp[8] == '1')
                {
                    checkBox9.Checked = true;
                }
                if (tempp[9] == '1')
                {
                    checkBox10.Checked = true;
                }
                if (tempp[10] == '1')
                {
                    checkBox11.Checked = true;
                }
                if (tempp[11] == '1')
                {
                    checkBox12.Checked = true;
                }
                if (tempp[12] == '1')
                {
                    checkBox13.Checked = true;
                }
                if (tempp[13] == '1')
                {
                    checkBox14.Checked = true;
                }
                if (tempp[14] == '1')
                {
                    checkBox15.Checked = true;
                }
                if (tempp[15] == '1')
                {
                    checkBox30.Checked = true;
                }
                if (tempp[16] == '1')
                {
                    checkBox29.Checked = true;
                }
                if (tempp[17] == '1')
                {
                    checkBox28.Checked = true;
                }
                if (tempp[18] == '1')
                {
                    checkBox27.Checked = true;
                }
                //
                if (tempp[16] == '1')
                {
                    checkBox26.Checked = true;
                }
                if (tempp[17] == '1')
                {
                    checkBox25.Checked = true;
                }
                if (tempp[18] == '1')
                {
                    checkBox24.Checked = true;
                }
                //
                if (tempp[16] == '1')
                {
                    checkBox23.Checked = true;
                }
                if (tempp[17] == '1')
                {
                    checkBox22.Checked = true;
                }
                if (tempp[18] == '1')
                {
                    checkBox21.Checked = true;
                }
                if (tempp[16] == '1')
                {
                    checkBox20.Checked = true;
                }
                if (tempp[17] == '1')
                {
                    checkBox19.Checked = true;
                }
                if (tempp[18] == '1')
                {
                    checkBox18.Checked = true;
                }
                //
                if (tempp[16] == '1')
                {
                    checkBox17.Checked = true;
                }
                if (tempp[17] == '1')
                {
                    checkBox16.Checked = true;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            File.WriteAllText(pathcheck, "");
            if (File.ReadAllText(pathcheck) == "")
            {
                checkBox1.Checked = false;
                checkBox6.Checked = false;
                checkBox5.Checked = false;
                checkBox9.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox15.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox12.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox27.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox24.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox21.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox18.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox30.Checked = false;
                checkBox28.Checked = false;
                checkBox29.Checked = false;
                checkBox4.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(pathcheck, "");

            File.WriteAllText(pathcheck, "");
            if (checkBox1.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox2.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox3.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }

            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox4.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox5.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox6.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }

            if (checkBox7.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox8.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox9.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox10.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox11.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox12.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox13.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox14.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox15.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox30.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox29.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox28.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox27.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox26.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox25.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox24.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox23.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox22.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox21.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox20.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox19.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            //
            if (checkBox18.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox17.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }
            if (checkBox16.Checked)
            {
                File.AppendAllText(pathcheck, "1");
            }
            else
            {
                File.AppendAllText(pathcheck, "0");
            }


        }

      
        
    }
}
