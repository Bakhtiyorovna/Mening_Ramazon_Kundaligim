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

namespace MyRamadondiary.umumiy
{
    public partial class MaqsadlarForm1 : Form
    {
        public string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "maqsadlarim.txt";
        public MaqsadlarForm1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string content = richTextBox1.Text;
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("XAtolik yuz berdi." +
                    "Iltimos boshqatdan urunib ko'ring! " + ex.Message);
            }
        }

        private void MaqsadlarForm1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            FileInfo file = new FileInfo(filePath);
            if (!file.Exists)
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Close();
                }
            }
            string Componenta = File.ReadAllText(filePath);
            richTextBox1.Text = Componenta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            richTextBox1.Clear();
        }
    }
}
