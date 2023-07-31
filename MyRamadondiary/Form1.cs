using System;
using MyRamadondiary.kundalik;
using MyRamadondiary.Taqvim;
using MyRamadondiary.AsosiyDuolar;
using MyRamadondiary.umumiy;
using MyRamadondiary.Asosiy;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRamadondiary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelkundalik.Visible = false;
            panelasosiyduolar.Visible=false;
            paneltaqvim.Visible = false;
            panelumumiy.Visible=false;  
        }
        private void hidesubmenu()
        {
            if (panelkundalik.Visible == true)
            {
                panelkundalik.Visible=false;
            }
            if(panelasosiyduolar.Visible == true)
            {
                panelasosiyduolar.Visible = false;
            }
            if (paneltaqvim.Visible)
            {
                paneltaqvim.Visible=false;  
            }
            if (panelumumiy.Visible)
            {
                panelumumiy.Visible = false;
            }
        }
        private void Showmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true; 
            }
            else
            {
                submenu.Visible = false;
            }
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            string HijriyYear = GregorianHijriy(DateTime.Now).ToString("yyyy");
            string HijriyMonth = GregorianHijriy(DateTime.Now).ToString("MM");
            string HijriyDay = GregorianHijriy(DateTime.Now).ToString("dd");
            string Year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            string Hour = DateTime.Now.ToString("HH");
            string minut = DateTime.Now.ToString("mm");
            string sekund = DateTime.Now.ToString("ss");

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 sekund
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

         //   labeltime.Text = DateTime.Now.ToString("T");
           labeltime.Text = "Milodiy sana : "+month+"."+day+"."+Year+"\n"+"Hijriy sana : "+ HijriyMonth + "." + HijriyDay + "." +HijriyYear;
         //  labeldate.Text =DateTime.Now.ToString("T"); ;
        }

        private void btnkundalik_Click(object sender, EventArgs e)
        {
            Showmenu(panelkundalik);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            lbltema.Text = iconButton2.Text;
            Showmenu(panelasosiyduolar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltema.Text = button1.Text;
            hidesubmenu();
            Openmainpanel(new RamazonsarhisobiForm1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbltema.Text = button2.Text;
            hidesubmenu();
            Openmainpanel(new QuronXatmiRejasiForm1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbltema.Text = button3.Text;
            hidesubmenu();
            Openmainpanel(new MustaqilxatmirejasiForm1());
            this.button1.Size = new System.Drawing.Size(197, 35);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbltema.Text = button4.Text;
            hidesubmenu();
            Openmainpanel(new ogizochishduosiForm1());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbltema.Text = button5.Text;
            hidesubmenu();
            Openmainpanel(new ogizyopishduosiForm1());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbltema.Text = button6.Text;
            hidesubmenu();
            Openmainpanel(new salovatlarForm1());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
          
            Showmenu(paneltaqvim);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbltema.Text = button7.Text;
            hidesubmenu();
            Openmainpanel(new Doimiy_TaqvimForm1());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbltema.Text = button8.Text;
            hidesubmenu();
            Openmainpanel(new RamazontaqvimiForm1());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
           
            Showmenu(panelumumiy);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbltema.Text = button9.Text;
            hidesubmenu();
            Openmainpanel(new MaqsadlarForm1());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lbltema.Text = button10.Text;
            hidesubmenu();
            Openmainpanel(new EslatmalarForm1());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lbltema.Text = button11.Text;
            hidesubmenu();
            Openmainpanel(new RamazonxotimasiForm1());
        }

        private void lbltema_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            lbltema.Text = iconButton1.Text;
            Openmainpanel(new AsosiyyForm1());
        }
        private Form activeForm=null;   
        private void Openmainpanel(Form MainForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = MainForm;
            MainForm.TopLevel = false;
            MainForm.FormBorderStyle = FormBorderStyle.None;
            MainForm.Dock = DockStyle.Fill;
            panelmain.Controls.Add(MainForm);
            MainForm.Tag = MainForm;
            MainForm.BringToFront();
            MainForm.Show();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            labeldate.Text = DateTime.Now.ToString("T");
        }
        private void btnexitt_MouseEnter(object sender, EventArgs e)
        {
           // btnexitt.BackColor = Color.FromArgb(2,22,83);
        }

        private void btnexitt_MouseHover(object sender, EventArgs e)
        {
            //btnexitt.BackColor = Color.Red;
        }

        private void btnexitt_MouseDown(object sender, MouseEventArgs e)
        {
          //  btnexitt.BackColor = Color.Red;
        }

        private void btnexitt_MouseLeave(object sender, EventArgs e)
        {
         //   btnexitt.BackColor = Color.Red;
        }

        private void btnexitt_MouseClick(object sender, MouseEventArgs e)
        {
           // btnexitt.BackColor = Color.Red;
        }

        private void btnexitt_MouseMove(object sender, MouseEventArgs e)
        {
         //   btnexitt.BackColor = Color.Red;
        }

        private void btnexitt_MouseUp(object sender, MouseEventArgs e)
        {
           // btnexitt.BackColor = Color.Red;
        }

        private void btnexitt_MouseCaptureChanged(object sender, EventArgs e)
        {
            //btnexitt.BackColor = Color.Red;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnexitt_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }

        private void labeltime_Click_1(object sender, EventArgs e)
        {

        }
    }
}
