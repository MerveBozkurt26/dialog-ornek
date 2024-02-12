using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları |*.bmp; *.jpg; *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
             pictureBox1.ImageLocation=ofd.FileName;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            {
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.FullOpen = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    label1.ForeColor = colorDialog.Color;
                }
            }

        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kayıt Silinsin mi?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt Silindi");
            }

        }
    }
    }

