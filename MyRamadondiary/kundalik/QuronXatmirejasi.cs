using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRamadondiary.kundalik
{
    public partial class QuronXatmiRejasiForm1 : Form
    {
        public readonly string pathcheck = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Kcheckbox.txt";
        public readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Rejaasosidaoqilganlar.txt";
        public readonly string pathditetime = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Kitob_rejasi_asosida_oqish_datetime.txt";

        public QuronXatmiRejasiForm1()
        {
            InitializeComponent();
        }

        private void QuronXatmiRejasiForm1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            if (!File.Exists(pathcheck))
            {
                using (StreamWriter sw = new StreamWriter(pathcheck))
                {
                    sw.Close();
                }
            }
            if (!File.Exists(pathditetime))
            {
                using (StreamWriter sw = new StreamWriter(pathditetime))
                {
                    sw.Close();
                }
            }
            string tempp = File.ReadAllText(pathcheck);
            string datetimes = File.ReadAllText(pathditetime);
            string[] datetime = datetimes.Split('_');
            if (datetimes != "")
            {
                dateTimePicker1.Value = DateTime.Parse(datetime[0]);
                dateTimePicker2.Value = DateTime.Parse(datetime[1]);
                dateTimePicker5.Value = DateTime.Parse(datetime[2]);
                dateTimePicker4.Value = DateTime.Parse(datetime[3]);
                dateTimePicker3.Value = DateTime.Parse(datetime[4]);
                dateTimePicker10.Value = DateTime.Parse(datetime[5]);
                dateTimePicker9.Value = DateTime.Parse(datetime[6]);
                dateTimePicker6.Value = DateTime.Parse(datetime[7]);
                dateTimePicker7.Value = DateTime.Parse(datetime[8]);
                dateTimePicker8.Value = DateTime.Parse(datetime[9]);
                dateTimePicker15.Value = DateTime.Parse(datetime[10]);
                dateTimePicker14.Value = DateTime.Parse(datetime[11]);
                dateTimePicker11.Value = DateTime.Parse(datetime[12]);
                dateTimePicker12.Value = DateTime.Parse(datetime[13]);
                dateTimePicker13.Value = DateTime.Parse(datetime[14]);
                dateTimePicker30.Value = DateTime.Parse(datetime[15]);
                dateTimePicker29.Value = DateTime.Parse(datetime[16]);
                dateTimePicker26.Value = DateTime.Parse(datetime[17]);
                dateTimePicker27.Value = DateTime.Parse(datetime[18]);
                dateTimePicker28.Value = DateTime.Parse(datetime[19]);
                dateTimePicker25.Value = DateTime.Parse(datetime[20]);
                dateTimePicker24.Value = DateTime.Parse(datetime[21]);
                dateTimePicker21.Value = DateTime.Parse(datetime[22]);
                dateTimePicker22.Value = DateTime.Parse(datetime[23]);
                dateTimePicker23.Value = DateTime.Parse(datetime[24]);
                dateTimePicker20.Value = DateTime.Parse(datetime[25]);
                dateTimePicker19.Value = DateTime.Parse(datetime[26]);
                dateTimePicker16.Value = DateTime.Parse(datetime[27]);
                dateTimePicker17.Value = DateTime.Parse(datetime[28]);
                dateTimePicker18.Value = DateTime.Parse(datetime[29]);
            }
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
                    checkBox6.Checked = true;
                }
                if (tempp[2] == '1')
                {
                    checkBox5.Checked = true;
                }
                if (tempp[3] == '1')
                {
                    checkBox9.Checked = true;
                }
                if (tempp[4] == '1')
                {
                    checkBox7.Checked = true;
                }
                if (tempp[5] == '1')
                {
                    checkBox8.Checked = true;
                }
                if (tempp[6] == '1')
                {
                    checkBox15.Checked = true;
                }
                if (tempp[7] == '1')
                {
                    checkBox13.Checked = true;
                }
                if (tempp[8] == '1')
                {
                    checkBox14.Checked = true;
                }
                if (tempp[9] == '1')
                {
                    checkBox12.Checked = true;
                }
                if (tempp[10] == '1')
                {
                    checkBox10.Checked = true;
                }
                if (tempp[11] == '1')
                {
                    checkBox11.Checked = true;
                }
                if (tempp[12] == '1')
                {
                    checkBox27.Checked = true;
                }
                if (tempp[13] == '1')
                {
                    checkBox25.Checked = true;
                }
                if (tempp[14] == '1')
                {
                    checkBox26.Checked = true;
                }
                if (tempp[15] == '1')
                {
                    checkBox24.Checked = true;
                }
                if (tempp[16] == '1')
                {
                    checkBox22.Checked = true;
                }
                if (tempp[17] == '1')
                {
                    checkBox23.Checked = true;
                }
                if (tempp[18] == '1')
                {
                    checkBox21.Checked = true;
                }
                if (tempp[19] == '1')
                {
                    checkBox19.Checked = true;
                }
                if (tempp[20] == '1')
                {
                    checkBox20.Checked = true;
                }
                if (tempp[21] == '1')
                {
                    checkBox18.Checked = true;
                }
                if (tempp[22] == '1')
                {
                    checkBox16.Checked = true;
                }
                if (tempp[23] == '1')
                {
                    checkBox17.Checked = true;
                }
                if (tempp[24] == '1')
                {
                    checkBox30.Checked = true;
                }
                if (tempp[25] == '1')
                {
                    checkBox28.Checked = true;
                }
                if (tempp[26] == '1')
                {
                    checkBox29.Checked = true;
                }
                if (tempp[27] == '1')
                {
                    checkBox4.Checked = true;
                }
                if (tempp[28] == '1')
                {
                    checkBox2.Checked = true;
                }
                if (tempp[29] == '1')
                {
                    checkBox3.Checked = true;
                }
                if (tempp[30] == '1')
                {
                    checkBox60.Checked = true;
                }
                if (tempp[31] == '1')
                {
                    checkBox58.Checked = true;
                }
                if (tempp[32] == '1')
                {
                    checkBox59.Checked = true;
                }
                if (tempp[33] == '1')
                {
                    checkBox57.Checked = true;
                }
                if (tempp[34] == '1')
                {
                    checkBox55.Checked = true;
                }
                if (tempp[35] == '1')
                {
                    checkBox56.Checked = true;
                }
                if (tempp[36] == '1')
                {
                    checkBox54.Checked = true;
                }
                if (tempp[37] == '1')
                {
                    checkBox52.Checked = true;
                }
                if (tempp[38] == '1')
                {
                    checkBox53.Checked = true;
                }
                if (tempp[39] == '1')
                {
                    checkBox51.Checked = true;
                }
                if (tempp[40] == '1')
                {
                    checkBox49.Checked = true;
                }


                ////
                if (tempp[41] == '1')
                {
                    checkBox50.Checked = true;
                }

                if (tempp[42] == '1')
                {
                    checkBox48.Checked = true;
                }
                if (tempp[43] == '1')
                {
                    checkBox46.Checked = true;
                }
                if (tempp[44] == '1')
                {
                    checkBox47.Checked = true;
                }
                if (tempp[45] == '1')
                {
                    checkBox45.Checked = true;
                }
                if (tempp[46] == '1')
                {
                    checkBox43.Checked = true;
                }
                if (tempp[47] == '1')
                {
                    checkBox44.Checked = true;
                }
                if (tempp[48] == '1')
                {
                    checkBox42.Checked = true;
                }
                if (tempp[49] == '1')
                {
                    checkBox40.Checked = true;
                }
                if (tempp[50] == '1')
                {
                    checkBox41.Checked = true;
                }
                if (tempp[51] == '1')
                {
                    checkBox39.Checked = true;
                }
                if (tempp[52] == '1')
                {
                    checkBox37.Checked = true;
                }
                if (tempp[53] == '1')
                {
                    checkBox38.Checked = true;
                }
                if (tempp[54] == '1')
                {
                    checkBox36.Checked = true;
                }
                if (tempp[55] == '1')
                {
                    checkBox34.Checked = true;
                }
                if (tempp[56] == '1')
                {
                    checkBox35.Checked = true;
                }
                if (tempp[57] == '1')
                {
                    checkBox33.Checked = true;
                }
                if (tempp[58] == '1')
                {
                    checkBox31.Checked = true;
                }
                if (tempp[59] == '1')
                {
                    checkBox32.Checked = true;
                }
                if (tempp[60] == '1')
                {
                    checkBox90.Checked = true;
                }
                if (tempp[61] == '1')
                {
                    checkBox88.Checked = true;
                }
                if (tempp[62] == '1')
                {
                    checkBox89.Checked = true;
                }
                if (tempp[63] == '1')
                {
                    checkBox87.Checked = true;
                }
                if (tempp[64] == '1')
                {
                    checkBox85.Checked = true;
                }
                if (tempp[65] == '1')
                {
                    checkBox86.Checked = true;
                }
                if (tempp[66] == '1')
                {
                    checkBox84.Checked = true;
                }
                if (tempp[67] == '1')
                {
                    checkBox82.Checked = true;
                }
                if (tempp[68] == '1')
                {
                    checkBox83.Checked = true;
                }
                if (tempp[69] == '1')
                {
                    checkBox81.Checked = true;
                }
                if (tempp[70] == '1')
                {
                    checkBox79.Checked = true;
                }
                if (tempp[71] == '1')
                {
                    checkBox80.Checked = true;
                }
                if (tempp[72] == '1')
                {
                    checkBox78.Checked = true;
                }
                if (tempp[73] == '1')
                {
                    checkBox76.Checked = true;
                }
                if (tempp[74] == '1')
                {
                    checkBox77.Checked = true;
                }
                if (tempp[75] == '1')
                {
                    checkBox75.Checked = true;
                }

                if (tempp[76] == '1')
                {
                    checkBox73.Checked = true;
                }
                if (tempp[77] == '1')
                {
                    checkBox74.Checked = true;
                }
                if (tempp[78] == '1')
                {
                    checkBox72.Checked = true;
                }
                if (tempp[79] == '1')
                {
                    checkBox70.Checked = true;
                }
                if (tempp[80] == '1')
                {
                    checkBox71.Checked = true;
                }
                if (tempp[81] == '1')
                {
                    checkBox69.Checked = true;
                }
                if (tempp[82] == '1')
                {
                    checkBox67.Checked = true;
                }
                if (tempp[83] == '1')
                {
                    checkBox68.Checked = true;
                }
                //
                if (tempp[84] == '1')
                {
                    checkBox66.Checked = true;
                }
                if (tempp[85] == '1')
                {
                    checkBox64.Checked = true;
                }
                if (tempp[86] == '1')
                {
                    checkBox65.Checked = true;
                }
                if (tempp[87] == '1')
                {
                    checkBox63.Checked = true;
                }
                if (tempp[88] == '1')
                {
                    checkBox61.Checked = true;
                }
                if (tempp[89] == '1')
                {
                    checkBox62.Checked = true;
                }
            }
        }
        public static string chekbox(CheckBox chec1, CheckBox check2, CheckBox check3)
        {
            try
            {
                string cnt = "";
                if (chec1.Checked)
                {
                    cnt += "O'qilgan / ";
                }
                if (check2.Checked)
                {
                    cnt += "Tafsiri o'qilgan / ";
                }
                if (check3.Checked)
                {
                    cnt += "Yod olingan / ";
                }
                return cnt + "\n";
            }
            catch
            {
                return "";
            }
        }

        public static string Sum(string text, string time)
        {
            try
            {
                string Natija = "Kitob rejasi asosida xatm qilish : " + time + " Sanada " + " Qur'onning " + text + " qismlari ";
                return Natija;
            }
            catch
            {
                return "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> strings = new List<string>();
                strings.Add(label8.Text);
                strings.Add(label9.Text);
                strings.Add(label11.Text);
                strings.Add(label10.Text);
                strings.Add(label15.Text);
                strings.Add(label14.Text);
                strings.Add(label13.Text);
                strings.Add(label12.Text);
                strings.Add(label17.Text);
                strings.Add(label16.Text);
                strings.Add(label27.Text);
                strings.Add(label26.Text);
                strings.Add(label25.Text);
                strings.Add(label24.Text);
                strings.Add(label23.Text);
                strings.Add(label22.Text);
                strings.Add(label21.Text);
                strings.Add(label20.Text);
                strings.Add(label19.Text);
                strings.Add(label18.Text);
                strings.Add(label42.Text);
                strings.Add(label41.Text);
                strings.Add(label40.Text);
                strings.Add(label39.Text);
                strings.Add(label38.Text);
                strings.Add(label37.Text);
                strings.Add(label36.Text);
                strings.Add(label35.Text);
                strings.Add(label34.Text);
                strings.Add(label33.Text);

                List<string> times = new List<string>();
                times.Add(dateTimePicker1.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker2.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker5.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker4.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker3.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker10.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker9.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker6.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker7.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker8.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker15.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker14.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker11.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker12.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker13.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker30.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker29.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker26.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker27.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker28.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker25.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker24.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker21.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker22.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker23.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker20.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker19.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker16.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker17.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                times.Add(dateTimePicker18.Value.ToString("MM" + "/" + "dd" + "/" + "yyyy"));
                File.WriteAllText(pathditetime, "");
                foreach (var time in times)
                {
                    File.AppendAllText(pathditetime, time + "_");
                }
                File.WriteAllText(path, "");
                if (chekbox(checkBox1, checkBox6, checkBox5) != "")
                {
                    string cnt1 = Sum(strings[0], times[0]) + chekbox(checkBox1, checkBox6, checkBox5);
                    File.AppendAllText(path, cnt1);
                }
                if (chekbox(checkBox9, checkBox7, checkBox8) != "")
                {
                    string cnt2 = Sum(strings[1], times[1]) + chekbox(checkBox9, checkBox7, checkBox8);
                    File.AppendAllText(path, cnt2);
                }
                if (chekbox(checkBox15, checkBox13, checkBox14) != "")
                {
                    string cnt3 = Sum(strings[2], times[2]) + chekbox(checkBox15, checkBox13, checkBox14);
                    File.AppendAllText(path, cnt3);
                }

                if (chekbox(checkBox12, checkBox10, checkBox11) != "")
                {
                    string cnt4 = Sum(strings[3], times[3]) + chekbox(checkBox12, checkBox10, checkBox11);
                    File.AppendAllText(path, cnt4);
                }
                if (chekbox(checkBox27, checkBox25, checkBox26) != "")
                {
                    string cnt5 = Sum(strings[4], times[4]) + chekbox(checkBox27, checkBox25, checkBox26);
                    File.AppendAllText(path, cnt5);
                }
                if (chekbox(checkBox24, checkBox22, checkBox23) != "")
                {
                    string cnt6 = Sum(strings[5], times[5]) + chekbox(checkBox24, checkBox22, checkBox23);
                    File.AppendAllText(path, cnt6);
                }
                if (chekbox(checkBox21, checkBox19, checkBox20) != "")
                {
                    string cnt7 = Sum(strings[6], times[6]) + chekbox(checkBox21, checkBox19, checkBox20);
                    File.AppendAllText(path, cnt7);
                }
                if (chekbox(checkBox18, checkBox16, checkBox17) != "")
                {
                    string cnt8 = Sum(strings[7], times[7]) + chekbox(checkBox18, checkBox16, checkBox17);
                    File.AppendAllText(path, cnt8);
                }
                if (chekbox(checkBox30, checkBox28, checkBox29) != "")
                {
                    string cnt9 = Sum(strings[8], times[8]) + chekbox(checkBox30, checkBox28, checkBox29);
                    File.AppendAllText(path, cnt9);
                }
                if (chekbox(checkBox4, checkBox2, checkBox3) != "")
                {
                    string cnt10 = Sum(strings[9], times[9]) + chekbox(checkBox4, checkBox2, checkBox3);
                    File.AppendAllText(path, cnt10);
                }
                if (chekbox(checkBox60, checkBox58, checkBox59) != "")
                {
                    string cnt11 = Sum(strings[10], times[10]) + chekbox(checkBox60, checkBox58, checkBox59);
                    File.AppendAllText(path, cnt11);
                }
                if (chekbox(checkBox57, checkBox55, checkBox56) != "")
                {
                    string cnt12 = Sum(strings[11], times[11]) + chekbox(checkBox57, checkBox55, checkBox56);
                    File.AppendAllText(path, cnt12);
                }
                if (chekbox(checkBox54, checkBox52, checkBox53) != "")
                {
                    string cnt13 = Sum(strings[12], times[12]) + chekbox(checkBox54, checkBox52, checkBox53);
                    File.AppendAllText(path, cnt13);
                }
                if (chekbox(checkBox51, checkBox49, checkBox50) != "")
                {
                    string cnt14 = Sum(strings[13], times[13]) + chekbox(checkBox51, checkBox49, checkBox50);
                    File.AppendAllText(path, cnt14);
                }
                if (chekbox(checkBox48, checkBox46, checkBox47) != "")
                {
                    string cnt15 = Sum(strings[14], times[14]) + chekbox(checkBox48, checkBox46, checkBox47);
                    File.AppendAllText(path, cnt15);
                }
                if (chekbox(checkBox45, checkBox43, checkBox44) != "")
                {
                    string cnt16 = Sum(strings[15], times[15]) + chekbox(checkBox45, checkBox43, checkBox44);
                    File.AppendAllText(path, cnt16);
                }
                if (chekbox(checkBox42, checkBox40, checkBox41) != "")
                {
                    string cnt17 = Sum(strings[16], times[16]) + chekbox(checkBox42, checkBox40, checkBox41);
                    File.AppendAllText(path, cnt17);
                }
                if (chekbox(checkBox39, checkBox37, checkBox38) != "")
                {
                    string cnt18 = Sum(strings[17], times[17]) + chekbox(checkBox39, checkBox37, checkBox38);
                    File.AppendAllText(path, cnt18);
                }
                if (chekbox(checkBox36, checkBox34, checkBox35) != "")
                {
                    string cnt19 = Sum(strings[18], times[18]) + chekbox(checkBox36, checkBox34, checkBox35);
                    File.AppendAllText(path, cnt19);
                }
                if (chekbox(checkBox33, checkBox31, checkBox32) != "")
                {
                    string cnt20 = Sum(strings[19], times[19]) + chekbox(checkBox33, checkBox31, checkBox32);
                    File.AppendAllText(path, cnt20);
                }
                if (chekbox(checkBox90, checkBox88, checkBox89) != "")
                {
                    string cnt21 = Sum(strings[20], times[20]) + chekbox(checkBox90, checkBox88, checkBox89);
                    File.AppendAllText(path, cnt21);
                }
                if (chekbox(checkBox87, checkBox85, checkBox86) != "")
                {
                    string cnt22 = Sum(strings[21], times[21]) + chekbox(checkBox87, checkBox85, checkBox86);
                    File.AppendAllText(path, cnt22);
                }
                if (chekbox(checkBox84, checkBox82, checkBox83) != "")
                {
                    string cnt23 = Sum(strings[22], times[22]) + chekbox(checkBox84, checkBox82, checkBox83);
                    File.AppendAllText(path, cnt23);
                }
                if (chekbox(checkBox81, checkBox79, checkBox80) != "")
                {
                    string cnt24 = Sum(strings[23], times[23]) + chekbox(checkBox81, checkBox79, checkBox80);
                    File.AppendAllText(path, cnt24);
                }
                if (chekbox(checkBox78, checkBox76, checkBox77) != "")
                {
                    string cnt25 = Sum(strings[24], times[24]) + chekbox(checkBox78, checkBox76, checkBox77);
                    File.AppendAllText(path, cnt25);
                }
                if (chekbox(checkBox75, checkBox73, checkBox74) != "")
                {
                    string cnt26 = Sum(strings[25], times[25]) + chekbox(checkBox75, checkBox73, checkBox74);
                    File.AppendAllText(path, cnt26);
                }
                if (chekbox(checkBox72, checkBox70, checkBox71) != "")
                {
                    string cnt27 = Sum(strings[26], times[26]) + chekbox(checkBox72, checkBox70, checkBox71);
                    File.AppendAllText(path, cnt27);
                }
                if (chekbox(checkBox69, checkBox67, checkBox68) != "")
                {
                    string cnt28 = Sum(strings[27], times[27]) + chekbox(checkBox69, checkBox67, checkBox68);
                    File.AppendAllText(path, cnt28);
                }
                if (chekbox(checkBox66, checkBox64, checkBox65) != "")
                {
                    string cnt29 = Sum(strings[28], times[28]) + chekbox(checkBox66, checkBox64, checkBox65);
                    File.AppendAllText(path, cnt29);
                }
                if (chekbox(checkBox63, checkBox61, checkBox62) != "")
                {
                    string cnt30 = Sum(strings[29], times[29]) + chekbox(checkBox63, checkBox61, checkBox62);
                    File.AppendAllText(path, cnt30);


                }
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
                if (checkBox6.Checked)
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
                if (checkBox9.Checked)
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

                if (checkBox15.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
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
                //
                if (checkBox12.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
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
                //
                if (checkBox27.Checked)
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
                if (checkBox26.Checked)
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
                if (checkBox22.Checked)
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
                //
                if (checkBox21.Checked)
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
                if (checkBox20.Checked)
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
                if (checkBox16.Checked)
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
                //
                if (checkBox30.Checked)
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
                if (checkBox29.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox4.Checked)
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
                //
                if (checkBox60.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox58.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox59.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox57.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox55.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox56.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox54.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox52.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox53.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox51.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox49.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox50.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox48.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox46.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox47.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox45.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox43.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox44.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox42.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox40.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox41.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox39.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox37.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox38.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox36.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox34.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox35.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox33.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox31.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox32.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox90.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox88.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox89.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox87.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox85.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox86.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox84.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox82.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox83.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox81.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox79.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox80.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox78.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox76.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox77.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox75.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox73.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox74.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox72.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox70.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox71.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox69.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox67.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox68.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                //
                if (checkBox66.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox64.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox65.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox63.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox61.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
                if (checkBox62.Checked)
                {
                    File.AppendAllText(pathcheck, "1");
                }
                else
                {
                    File.AppendAllText(pathcheck, "0");
                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            File.WriteAllText(pathditetime, "");
            if (File.ReadAllText(pathditetime) == "")
            {


                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker5.Value = DateTime.Now;
                dateTimePicker4.Value = DateTime.Now;
                dateTimePicker3.Value = DateTime.Now;
                dateTimePicker10.Value = DateTime.Now;
                dateTimePicker9.Value = DateTime.Now;
                dateTimePicker6.Value = DateTime.Now;
                dateTimePicker7.Value = DateTime.Now;
                dateTimePicker8.Value = DateTime.Now;
                dateTimePicker15.Value = DateTime.Now;
                dateTimePicker14.Value = DateTime.Now;
                dateTimePicker11.Value = DateTime.Now;
                dateTimePicker12.Value = DateTime.Now;
                dateTimePicker13.Value = DateTime.Now;
                dateTimePicker30.Value = DateTime.Now;
                dateTimePicker29.Value = DateTime.Now;
                dateTimePicker26.Value = DateTime.Now;
                dateTimePicker27.Value = DateTime.Now;
                dateTimePicker28.Value = DateTime.Now;
                dateTimePicker25.Value = DateTime.Now;
                dateTimePicker24.Value = DateTime.Now;
                dateTimePicker21.Value = DateTime.Now;
                dateTimePicker22.Value = DateTime.Now;
                dateTimePicker23.Value = DateTime.Now;
                dateTimePicker20.Value = DateTime.Now;
                dateTimePicker19.Value = DateTime.Now;
                dateTimePicker16.Value = DateTime.Now;
                dateTimePicker17.Value = DateTime.Now;
                dateTimePicker18.Value = DateTime.Now;


            }
            File.WriteAllText(path, "");
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
                checkBox60.Checked = false;
                checkBox58.Checked = false;
                checkBox59.Checked = false;
                checkBox57.Checked = false;
                checkBox55.Checked = false;
                checkBox56.Checked = false;
                checkBox54.Checked = false;
                checkBox52.Checked = false;
                checkBox53.Checked = false;
                checkBox51.Checked = false;
                checkBox49.Checked = false;
                checkBox50.Checked = false;
                checkBox48.Checked = false;
                checkBox46.Checked = false;
                checkBox47.Checked = false;
                checkBox45.Checked = false;
                checkBox43.Checked = false;
                checkBox44.Checked = false;
                checkBox42.Checked = false;
                checkBox40.Checked = false;
                checkBox41.Checked = false;
                checkBox39.Checked = false;
                checkBox37.Checked = false;
                checkBox38.Checked = false;
                checkBox36.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
                checkBox33.Checked = false;
                checkBox31.Checked = false;
                checkBox32.Checked = false;
                checkBox90.Checked = false;
                checkBox88.Checked = false;
                checkBox89.Checked = false;
                checkBox87.Checked = false;
                checkBox85.Checked = false;
                checkBox86.Checked = false;
                checkBox84.Checked = false;
                checkBox82.Checked = false;
                checkBox83.Checked = false;
                checkBox81.Checked = false;
                checkBox79.Checked = false;
                checkBox80.Checked = false;
                checkBox78.Checked = false;
                checkBox76.Checked = false;
                checkBox77.Checked = false;
                checkBox75.Checked = false;
                checkBox73.Checked = false;
                checkBox74.Checked = false;
                checkBox72.Checked = false;
                checkBox70.Checked = false;
                checkBox71.Checked = false;
                checkBox69.Checked = false;
                checkBox67.Checked = false;
                checkBox68.Checked = false;
                checkBox66.Checked = false;
                checkBox64.Checked = false;
                checkBox65.Checked = false;
                checkBox63.Checked = false;
                checkBox61.Checked = false;
                checkBox62.Checked = false;
            }
        }
    }
}
