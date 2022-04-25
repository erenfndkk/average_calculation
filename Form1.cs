using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float vize;
        float final;
        float odev1;
        float odev2;
        float odev3;
        float ortalama;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_orthesaplama_Click(object sender, EventArgs e)
        {
            vize = float.Parse(text_vize.Text);
            odev1= float.Parse(text_odev1.Text);
            odev2 = float.Parse(text_odev2.Text);
            odev3 = float.Parse(text_odev3.Text);
            final = float.Parse(text_final.Text);

            float yuzdeVize = (vize*25) /100;
            float yuzdeOdev1 = odev1*10/100;
            float yuzdeOdev2 = (odev2 * 10) / 100;
            float yuzdeOdev3 = (odev3 * 10) / 100;
            float yuzdeFinal = (final * 45) / 100;

            ortalama = yuzdeVize + yuzdeOdev1+ yuzdeOdev2 + yuzdeOdev3 + yuzdeFinal;
            lbl_ortalama.Text = ortalama.ToString();

            if (ortalama <=100 && ortalama>85)
            {
                lbl___harfnotu.Text = "AA";
            }

            else if (ortalama <= 85 && ortalama > 70)
            {
                lbl___harfnotu.Text = "BB";
            }
            else if (ortalama <= 70 && ortalama > 50)
            {
                lbl___harfnotu.Text = "CC";
            }
            else if (ortalama <= 50)
            {
                lbl___harfnotu.Text = "DD";
            }
        }
    }
}
