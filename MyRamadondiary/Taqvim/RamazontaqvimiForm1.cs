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
    public partial class RamazontaqvimiForm1 : Form
    {
        public RamazontaqvimiForm1()
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
        private void RamazontaqvimiForm1_Load(object sender, EventArgs e)
        {
           
            
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
        private async void guna2Button1_Click(object sender, EventArgs e)
        {

            string hudud = comboBox2.SelectedItem.ToString();
            string[] s = hudud.ToString().Split(' ');
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
            if (hudud == "")
            {
                MessageBox.Show("Hududni kiriting!", "Ogohlantirish", MessageBoxButtons.OKCancel);
            }
            try
            {


                dataGridView2.Rows.Clear();
                int j = 0;
                for (int i = 0; i < 210; i += 7)
                {
                    string year = GregorianHijriy(DateTime.Now).ToString("yyyy");
                    string date = year + "/09/01";
                    DateTime Ramazontime = HijriyGregorian(date);
                    int temp = 1 * j; j++;

                    string HijriyOy = "Ramazon";
                    //milodiy sanani chiqarish algoritmi
                    DateTime milodiysana = Ramazontime.AddDays(temp);
                    string MilodiyOy = "";
                    //milodiy oy nomini aniqlash
                    if (milodiysana.ToString("MM") == "01")
                    {
                        MilodiyOy = "Yanvar";
                    }
                    else if (milodiysana.ToString("MM") == "02")
                    {
                        MilodiyOy = "Fevral";
                    }
                    else if (milodiysana.ToString("MM") == "03")
                    {
                        MilodiyOy = "Mart";
                    }
                    else if (milodiysana.ToString("MM") == "04")
                    {
                        MilodiyOy = "Aprel";
                    }
                    else if (milodiysana.ToString("MM") == "05")
                    {
                        MilodiyOy = "May";
                    }
                    else if (milodiysana.ToString("MM") == "06")
                    {
                        MilodiyOy = "Iyun";
                    }
                    else if (milodiysana.ToString("MM") == "07")
                    {
                        MilodiyOy = "Iyul";
                    }
                    else if (milodiysana.ToString("MM") == "08")
                    {
                        MilodiyOy = "Avgust";
                    }
                    else if (milodiysana.ToString("MM") == "09")
                    {
                        MilodiyOy = "Sentabr";
                    }
                    else if (milodiysana.ToString("MM") == "10")
                    {
                        MilodiyOy = "Oktabr";
                    }
                    else if (milodiysana.ToString("MM") == "11")
                    {
                        MilodiyOy = "Noyabr";
                    }
                    else if (milodiysana.ToString("MM") == "12")
                    {
                        MilodiyOy = "Dekabr";
                    }
                    //hijriy sanani to;girlash


                    string milodiyDay = milodiysana.ToString("dd");
                    int milodiyDayInt = Int32.Parse(milodiyDay);

                    if (milodiyDayInt < 10)
                    {
                        milodiyDay = milodiyDay.Substring(1, 1);
                    }
                    string Milodiysana = " " + milodiyDay + "-" + MilodiyOy;
                    //hudud nomini abiqlash


                    string[] sss = await Datet(location, milodiysana.ToString("MM"), Convert.ToInt32(milodiyDay));

                    string haftaDay = sss[0];
                    string SaharTime = sss[1];
                    string IftorTime = sss[5];
                    string BomdodTime = sss[1];
                    string QuyoshTime = sss[2];
                    string PeshinTime = sss[3];
                    string AsrTime = sss[4];
                    string ShomTime = sss[5];
                    string XuftonTime = sss[6];

                    dataGridView2.Rows.Add(j + "-" + HijriyOy, Milodiysana, haftaDay, SaharTime, IftorTime, BomdodTime, QuyoshTime, PeshinTime, AsrTime, ShomTime, XuftonTime);
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
            }

            catch
            {
                MessageBox.Show("Internet tarmog'iga ulanmagansiz!", "Ogohlantirish", MessageBoxButtons.OKCancel);
            }
        }
        public async Task<string[]> Datet(string region, string month, int ii) // bu metod ii sanadan jj sanagacha oraqilda qirqib beradi
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
                string response = "";
                await Task.Run(() =>
                {
                    response = client.DownloadString(url);
                });
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
