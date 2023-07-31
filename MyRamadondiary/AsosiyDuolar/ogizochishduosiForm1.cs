using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRamadondiary.AsosiyDuolar
{
    public partial class ogizochishduosiForm1 : Form
    {
        public readonly string wavFilePath2 = "C:\\window_form\\MyRamadondiary\\MyRamadondiary\\AsosiyDuolar\\audiolar\\OgizOchishduosi_3 (2).wav";
          private int buttonClickCount=0;
        public ogizochishduosiForm1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(wavFilePath2);
                Button clickedButton = (Button)sender;
                buttonClickCount++;
                if (buttonClickCount % 2 == 1)
                {
                    //  iconButton1.IconChar = Icon.Play
                    this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pause;
                    player.Play();


                }
                else if (buttonClickCount % 2 == 0)
                {
                    player.Stop();
                    this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;
                    //  btnStop.Image = Image.FromFile(bmp2);
                }

            }
            catch
            {

                MessageBox.Show("Xatolik yuz berdi!", "Ogahlantirish", MessageBoxButtons.OKCancel);
            }
        }
    }
}
