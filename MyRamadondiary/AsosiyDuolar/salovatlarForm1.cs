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

namespace MyRamadondiary.AsosiyDuolar
{
    public partial class salovatlarForm1 : Form
    {
        public salovatlarForm1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string content = label4.Text;

                try
                {
                    File.WriteAllText(filePath, content);
                    MessageBox.Show("Salovatlar saqlandi.", "Ogohlantirish", MessageBoxButtons.OKCancel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Faylni saqlashda xatolik yuz berdi" + ex.Message);
                }
            }
        }
    }
}
