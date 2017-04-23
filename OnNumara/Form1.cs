using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnNumara
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox[] txtKolon = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

        }

        Random rastgele = new Random();
        int sayi = 0;
        int[] kolon = new int[] { 0 };
        int[] numaralar = new int[22];
        int kac = 0;

        TextBox[] txtKolon = new TextBox[10] ;
        Label[] sonuc = new Label[22];


        private void btnBilgisayar_Click(object sender, EventArgs e)
        {
            TextBox[] txtKolon = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            for (int i =0; i<=9; i++)
            {
                sayi = rastgele.Next(0, 80);
                txtKolon[i].Text = Convert.ToString(sayi);

            }
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {

            if (txt1.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ","Uyarı",MessageBoxButtons.OK);
                txt1.Focus();
            }
            else if (txt2.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt2.Focus();
            }
            else if (txt3.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt3.Focus();
            }
            else if (txt4.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt4.Focus();
            }
            else if (txt5.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt5.Focus();
            }
            else if (txt6.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt6.Focus();
            }
            else if (txt7.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt7.Focus();
            }
            else if (txt8.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt8.Focus();
            }
            else if (txt9.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt9.Focus();
            }
            else if (txt10.Text == "")
            {
                MessageBox.Show("Lütfen kolonunuzu tam bir şekilde doldurunuz ! ", "Uyarı", MessageBoxButtons.OK);
                txt10.Focus();
            }
            else
            {
                 Label[] sonuc = { lblNumara1, lblNumara2, lblNumara3, lblNumara4, lblNumara5, lblNumara6, lblNumara7, lblNumara8, lblNumara9, lblNumara10,
                                lblNumara11, lblNumara12,lblNumara13,lblNumara14,lblNumara15,lblNumara16,lblNumara17,lblNumara18,lblNumara19,lblNumara20,
                                lblNumara21,lblNumara22}; TextBox[] txtKolon = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };
                for (int i = 0; i <= 21; i++)
                {
                    sayi = rastgele.Next(0, 80);
                    numaralar[i] = sayi;
                    sonuc[i].Text = Convert.ToString(sayi);

                }


                int[] kolon = {
                Convert.ToInt16(txt1.Text) ,
                Convert.ToInt16(txt2.Text) ,
                Convert.ToInt16(txt3.Text) ,
                Convert.ToInt16(txt4.Text) ,
                Convert.ToInt16(txt5.Text) ,
                Convert.ToInt16(txt6.Text) ,
                Convert.ToInt16(txt7.Text) ,
                Convert.ToInt16(txt8.Text) ,
                Convert.ToInt16(txt9.Text) ,
                Convert.ToInt16(txt10.Text)};
                kontrol(kolon, numaralar);


            }


        }

        private void kontrol(int[] kolon, int[] numaralar)
        {


            Label[] sonuc = { lblNumara1, lblNumara2, lblNumara3, lblNumara4, lblNumara5, lblNumara6, lblNumara7, lblNumara8, lblNumara9, lblNumara10,
                                lblNumara11, lblNumara12,lblNumara13,lblNumara14,lblNumara15,lblNumara16,lblNumara17,lblNumara18,lblNumara19,lblNumara20,
                                lblNumara21,lblNumara22}; kac = 0;
            for (int k=0; k<=9;k++)
            {
                for(int l =0; l <= 21; l++)
                {
                    if (kolon[k] == numaralar[l])
                    {
                        kac++;
                        if (sonuc[l].ForeColor == System.Drawing.Color.Gray)
                        {
                            sonuc[l].ForeColor = System.Drawing.Color.Green;
                        }


                    }
                    else
                    {
                        if (sonuc[l].ForeColor == System.Drawing.Color.Green)
                        {
                            sonuc[l].ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            sonuc[l].ForeColor = System.Drawing.Color.Red;
                        }
                       
                    }

                }

            }
            lblSonuc.Text = kac.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Label[] sonuc = { lblNumara1, lblNumara2, lblNumara3, lblNumara4, lblNumara5, lblNumara6, lblNumara7, lblNumara8, lblNumara9, lblNumara10,
                                lblNumara11, lblNumara12,lblNumara13,lblNumara14,lblNumara15,lblNumara16,lblNumara17,lblNumara18,lblNumara19,lblNumara20,
                                lblNumara21,lblNumara22};
            TextBox[] txtKolon = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            kac = 0;
            int[] kolon = { 0 };
            int[] numaralar = { 0 };

            for(int i=0; i<=9; i++)
            {

                txtKolon[i].Text = "";
            }
            for (int i = 0; i <= 21; i++)
            {
                sonuc[i].Text = "--";

            }

        }


    }
}
