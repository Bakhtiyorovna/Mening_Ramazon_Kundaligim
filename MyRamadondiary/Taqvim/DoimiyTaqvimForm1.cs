using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRamadondiary.Taqvim
{
    public partial class Doimiy_TaqvimForm1 : Form
    {
        public Doimiy_TaqvimForm1()
        {
            InitializeComponent();
        }

        public static DateTime GregorianHijriy(DateTime gregoriandate)
        {
            Calendar UmAlQura = new UmAlQuraCalendar();
            var hijriyYear = UmAlQura.GetYear(gregoriandate);
            var hijriyMonth = UmAlQura.GetMonth(gregoriandate);
            var hijriyDay = UmAlQura.GetDayOfMonth(gregoriandate);
            var hijriyHour = UmAlQura.GetHour(gregoriandate);
            var hijriyMinut = UmAlQura.GetMinute(gregoriandate);
            var hijriySecund = UmAlQura.GetSecond(gregoriandate);
            return new DateTime(hijriyYear, hijriyMonth, hijriyDay, hijriyHour, hijriyMinut, hijriySecund);

        }
        public DateTime HijriyGregorian(string hijriDateString)
        {


            string[] hijriDateParts = hijriDateString.Split('/');
            int hijriYear = int.Parse(hijriDateParts[0]);
            int hijriMonth = int.Parse(hijriDateParts[1]);
            int hijriDay = int.Parse(hijriDateParts[2]);

            HijriCalendar hijriCalendar = new HijriCalendar();
            DateTime gregorianDate = hijriCalendar.ToDateTime(hijriYear, hijriMonth, hijriDay, 0, 0, 0, 0);

            return gregorianDate;

        }

        public string[] Datet(string region, string month, int ii) // bu metod ii sanadan jj sanagacha oraqilda qirqib beradi
        {

            string url = $"https://islomapi.uz/api/monthly?region={region}&month={month}";

            using (WebClient client = new WebClient())
            {
                int Size = 0;

                if (month == "01" || month == "03" || month == "05" || month == "08" || month == "07" || month == "10" || month == "12")
                {
                    Size = 342;
                }
                else if (month == "04" || month == "06" || month == "09" || month == "011")
                {
                    Size = 330;
                }
                else if (month == "02")
                {
                    Size = 310;
                }
                string response = client.DownloadString(url);
                string[] s = response.Split(',');
                string[] ss = new string[Size];
                int j = 0;
                for (int i = 4; i < Size; i++)
                {
                    if (i % 11 == 4 || i % 11 == 5 || i % 11 == 6 || i % 11 == 7 || i % 11 == 8 || i % 11 == 9 || i % 11 == 10)
                    {
                        string[] k = s[i].Split('"');
                        if (j % 7 == 1)
                        {
                            ss[j] = k[5];
                        }
                        else
                        {
                            ss[j] = k[3];
                        }

                        j++;
                    }
                }
                string[] ret = new string[7];
                int cnt = 0;
                for (int i = (ii - 1) * 7; ii * 7 > i; i++)
                {
                    ret[cnt] = ss[i];
                    cnt++;
                }
                return ret;

            }
        }

        private void Doimiy_TaqvimForm1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            string HijriyYear = GregorianHijriy(DateTime.Now).ToString("yyyy");
        
            comboBox2.Items.Add("Toshkent shahri");
            comboBox2.Items.Add("Toshkent viloyati");
            comboBox2.Items.Add("Andijon viloyati");
            comboBox2.Items.Add("Buxoro viloyati");
            comboBox2.Items.Add("Farg'ona viloyati");
            comboBox2.Items.Add("Jizzax viloyati");
            comboBox2.Items.Add("Namangan viloyati");
            comboBox2.Items.Add("Navoiy viloyati");
            comboBox2.Items.Add("Samarqand viloyati");
            comboBox2.Items.Add("Sirdaryo viloyati");
            comboBox2.Items.Add("Surxandaryo viloyati");
            comboBox2.Items.Add("Xorazm viloyati");
            comboBox2.Items.Add("Qashqadaryo viloyati");
            comboBox2.Items.Add("Qoraqalpog'iston Respublikasi");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {

                //   MessageBox.Show("Taqvim yuklanmoqda!","",MessageBoxButtons.OKCancel);
                string[] s = comboBox2.SelectedItem.ToString().Split(' ');
                string location = s[0];
                if (location == "Sirdaryo")
                {
                    location = "Guliston";
                }
                else if (location == "Surxandaryo")
                {
                    location = "Denov";
                }
                else if (location == "Qashqadaryo")
                {
                    location = "qarshi";
                }
                else if (location == "Qoraqalpog'iston")
                {
                    location = "Nukus";
                }
                else if (location == "Xorazm")
                {
                    location = "Xiva";
                }
                if (location == "")
                {
                    MessageBox.Show("Hududni kiriting", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dataGridView2.Rows.Clear();
                    int j = -1;
                    for (int i = 0; i < 210; i += 7)
                    {
                        //hijriy sanani chiqarish algoritmi
                        DateTime datetimenow = DateTime.Now;
                        int temp = 1 * j; j++;
                        DateTime hijriysana = GregorianHijriy(datetimenow.AddDays(temp));
                        string HijriyOy = "";
                        //hijriy oy nomini aniqlash
                        if (hijriysana.ToString("MM") == "01")
                        {
                            HijriyOy = "Muxarram";
                        }
                        else if (hijriysana.ToString("MM") == "02")
                        {
                            HijriyOy = "Safar";
                        }
                        else if (hijriysana.ToString("MM") == "03")
                        {
                            HijriyOy = "Robiul Avval";
                        }
                        else if (hijriysana.ToString("MM") == "04")
                        {
                            HijriyOy = "Robius Soniy";
                        }
                        else if (hijriysana.ToString("MM") == "05")
                        {
                            HijriyOy = "Jumodul Avval";
                        }
                        else if (hijriysana.ToString("MM") == "06")
                        {
                            HijriyOy = "Jumodus Soniy";
                        }
                        else if (hijriysana.ToString("MM") == "07")
                        {
                            HijriyOy = "Rajab";
                        }
                        else if (hijriysana.ToString("MM") == "08")
                        {
                            HijriyOy = "Shabon";
                        }
                        else if (hijriysana.ToString("MM") == "09")
                        {
                            HijriyOy = "Ramazon";
                        }
                        else if (hijriysana.ToString("MM") == "10")
                        {
                            HijriyOy = "Shavvol";
                        }
                        else if (hijriysana.ToString("MM") == "11")
                        {
                            HijriyOy = "Zul qa'da";
                        }
                        else if (hijriysana.ToString("MM") == "12")
                        {
                            HijriyOy = "Zulhijja";
                        }
                        //milodiy sanani chiqarish algoritmi
                        DateTime milodiysana = datetimenow.AddDays(temp);
                        string MilodiyOy = "";
                        int chegara = 0;
                        //milodiy oy nomini aniqlash
                        if (milodiysana.ToString("MM") == "01")
                        {
                            MilodiyOy = "Yanvar";
                            chegara = 31;
                        }
                        else if (milodiysana.ToString("MM") == "02")
                        {
                            MilodiyOy = "Fevral";
                            chegara = 28;
                        }
                        else if (milodiysana.ToString("MM") == "03")
                        {
                            MilodiyOy = "Mart";
                            chegara = 31;
                        }
                        else if (milodiysana.ToString("MM") == "04")
                        {
                            MilodiyOy = "Aprel";
                            chegara = 30;
                        }
                        else if (milodiysana.ToString("MM") == "05")
                        {
                            MilodiyOy = "May";
                            chegara = 31;
                        }
                        else if (milodiysana.ToString("MM") == "06")
                        {
                            MilodiyOy = "Iyun";
                            chegara = 30;
                        }
                        else if (milodiysana.ToString("MM") == "07")
                        {
                            MilodiyOy = "Iyul";
                            chegara = 31;
                        }
                        else if (milodiysana.ToString("MM") == "08")
                        {
                            MilodiyOy = "Avgust";
                            chegara = 31;
                        }
                        else if (milodiysana.ToString("MM") == "09")
                        {
                            MilodiyOy = "Sentabr";
                            chegara = 30;
                        }
                        else if (milodiysana.ToString("MM") == "10")
                        {
                            MilodiyOy = "Oktabr";
                            chegara = 31;
                        }
                        else if (milodiysana.ToString("MM") == "11")
                        {
                            MilodiyOy = "Noyabr";
                            chegara = 30;
                        }
                        else if (milodiysana.ToString("MM") == "12")
                        {
                            MilodiyOy = "Dekabr";
                            chegara = 31;
                        }
                        //hijriy sanani to;girlash
                        string hijriyDay = hijriysana.ToString("dd");
                        if (Int32.Parse(hijriyDay) < 10)
                        {
                            hijriyDay = hijriyDay.Substring(1, 1);
                        }
                        //milodiy sanani togirlash
                        string milodiyDay = milodiysana.ToString("dd");
                        int milodiyDayInt = Int32.Parse(milodiyDay);

                        if (milodiyDayInt < 10)
                        {
                            milodiyDay = milodiyDay.Substring(1, 1);
                        }
                        string HijriySana = " " + hijriyDay + "-" + HijriyOy;
                        string Milodiysana = " " + milodiyDay + "-" + MilodiyOy;
                        //hudud nomini abiqlash

                        string[] sss = Datet(location, milodiysana.ToString("MM"), milodiyDayInt);

                        string haftaDay = sss[0];
                        string SaharTime = sss[1];
                        string IftorTime = sss[5];
                        string BomdodTime = sss[1];
                        string QuyoshTime = sss[2];
                        string PeshinTime = sss[3];
                        string AsrTime = sss[4];
                        string ShomTime = sss[5];
                        string XuftonTime = sss[6];
                        dataGridView2.Rows.Add(HijriySana, Milodiysana, haftaDay, SaharTime, IftorTime, BomdodTime, QuyoshTime, PeshinTime, AsrTime, ShomTime, XuftonTime);
                        for (int ii = 0; ii < dataGridView2.Rows.Count; ii++)
                        {
                            if (ii % 2 == 0)
                            {
                                dataGridView2.Rows[ii].DefaultCellStyle.BackColor = Color.White;
                            }
                            else
                            {
                                dataGridView2.Rows[ii].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

                            }
                        }
                    }

                    //       MessageBox.Show("Taqvim yuklanmoqda!", "", MessageBoxButtons.OKCancel);     
                }
            }
            catch
            {
                MessageBox.Show("Internet tarmog'iga ulanmagansiz!", "Ogohlantirish", MessageBoxButtons.OKCancel);
            }



            
        }
        private Bitmap CaptureDataGridViewAllData()
        {
            // DataGridView o'lchamlarini saqlash
            int width = dataGridView2.Width;
            int height = dataGridView2.Height;

            // DataGridView-ni o'lchamlarini o'zgartirishsiz yaratish
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // DataGridView o'lchamlarini yangilash
            dataGridView2.Refresh();

            // Bitmap obyektini yaratish
            Bitmap bitmap = new Bitmap(width, height);

            // DataGridView-ni rasmga o'zlashtirish
            dataGridView2.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));

            // DataGridView o'lchamlarini avtomatik o'lchashga tiklash
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            return bitmap;
        }
        private void SaveScreenshot(Bitmap screenshot)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rasm fayllari (*.png)|*.png";
            saveFileDialog.Title = "Skreshootni saqlash";
            saveFileDialog.FileName = "datagridview_screenshot.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                screenshot.Save(saveFileDialog.FileName, ImageFormat.Png);
                MessageBox.Show("Taqvim muvaffaqiyatli saqlandi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap screenshot = CaptureDataGridViewAllData();
            SaveScreenshot(screenshot);
        }
    }
}
