using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing.Drawing2D;
using System.Threading;

namespace oggetto
{
    public partial class Form1 : Form
    {
        double DEF;
        int nRipetizioni, Gpenna, Npixel, scelta, elevazioniZ, n34, n12, n14;//3/4 di Npixel,2/4 di Npixel ,1/4 di Npixel; 
        Bitmap b1, b2, b3, b4, b5, b6, b7, b8;
        Thread t1, t2, t3, t4, t5, t6, t7, t8;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DEF = (double)nUD_2.Value;

            if (rd3.Checked == true)
                Npixel = 80;
            else if (rd4.Checked == true)
                Npixel = 200;
            else
                Npixel = 400;

            if (rdb_t1.Checked)
            {
                elevazioniZ = (int)nUD_3.Value;
                nRipetizioni = (int)nUD_1.Value;
                scelta = 1;
            }
            else if (rdb_t2.Checked)
                scelta = 2;
            else if (rdb_t3.Checked)
                scelta = 3;
            else if (rdb_t4.Checked)
                scelta = 4;
            else if (rdb_t5.Checked)
                scelta = 5;
            else if (rdb_t6.Checked)
                scelta = 6;

            pnl_Dati.Visible = false;
            pnl.Visible = true;

            Gpenna = 400 / Npixel;
            pnl.Width = 1200 + Gpenna;
            pnl.Height = 800 + Gpenna;
            pnl.Left = 12;
            pnl.Top = 49;
            pnl.Visible = true;
            //Mi salvo le unità perchè le uso spesso in seguito
            n14 = Npixel >> 2;
            n12 = Npixel >> 1;
            n34 = ((Npixel<<1)+Npixel) >> 2;//moltiplico per 2, aggiungo 1 unità (moltiplicato per 3), divido per 4

            SmistaTread(); //Calcolo della frattale
            btn_Restart.Visible = true;
            btn_Ridisegna.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (pnl.Visible == true)
                AggiornaGrafica();
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            pnl.Visible = false;
            pnl_Dati.Visible = true;
            btn_Restart.Visible = false;
            btn_Ridisegna.Visible = false;
        }
        private void rdb_t1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_t1.Checked == true)
                pnl_FrattSemplice.Visible = true;
            else
                pnl_FrattSemplice.Visible = false;
        }

        private void AggiornaGrafica(object sender, EventArgs e)
        {
            AggiornaGrafica();
        }

        void AggiornaGrafica()
        {
            if(b1 != null)
                pnl.CreateGraphics().DrawImage(b1, 0, 0);
            if (b2 != null)
                pnl.CreateGraphics().DrawImage(b2, 0, 0);
            if (b3 != null)
                pnl.CreateGraphics().DrawImage(b3, 0, 0);
            if (b4 != null)
                pnl.CreateGraphics().DrawImage(b4, 0, 0);
            if (b5 != null)
                pnl.CreateGraphics().DrawImage(b5, 0, 0);
            if (b6 != null)
                pnl.CreateGraphics().DrawImage(b6, 0, 0);
            if (b7 != null)
                pnl.CreateGraphics().DrawImage(b7, 0, 0);
            if (b8 != null)
                pnl.CreateGraphics().DrawImage(b8, 0, 0);  
        }

        void Procedimento(int i, ref Graphics graph)
        {
            int t, x, y;
            for (int r = -(Npixel<<1); r < Npixel; r++)
            {
                t = Calcolo(new Complex((double)r / (double)Npixel, (double)i / (double)Npixel));
                y = (Npixel + 1 - i) * Gpenna;
                x = (r + (Npixel<<1)) * Gpenna;
                graph.DrawLine(new Pen(Color.FromArgb(t, t, t), Gpenna), new Point(x, y), new Point(x + Gpenna + 1, y));
            }
            return;
        }

        int Calcolo(Complex c)
        {
            int valore = 0;

            switch(scelta)
            {
                case 1:
                    valore = Tipo1(c);
                    break;
                case 2:
                    valore = Tipo2(c);
                    break;
                case 3:
                    valore = Tipo3(c);
                    break;
                case 4:
                    valore = Tipo4(c);
                    break;
                case 5:
                    valore = Tipo5(c);
                    break;
                case 6:
                    valore = Tipo6(c);
                    break;
                case 7:
                    valore = Tipo1(c);
                    break;
                case 8:
                    valore = Tipo1(c);
                    break;
                case 9:
                    valore = Tipo1(c);
                    break;
                case 10:
                    valore = Tipo1(c);
                    break;
                case 11:
                    valore = Tipo1(c);
                    break;
                case 12:
                    valore = Tipo1(c);
                    break;
            }

            if (valore > 255)
                valore = 255;
            else if (valore < 0)
                valore = 0;

            return valore;
        }

        int Tipo1(Complex c)
        {
            //Insieme di Mandelbrot
            //Verisone rivisitata
            Complex z = new Complex(0, 0);
            for (int i = 0; i < nRipetizioni; i++)
            {
                z = Complex.Pow(z, elevazioniZ);
                z += c;
            }
            return (int)z.Magnitude * 10;

        }

        int Tipo2(Complex c)
        {
            Complex z = new Complex(1, 1);

            for (int i = 0; i < 200; i++)
                z = Complex.Pow(Math.E, (Complex.Pow(z, 2) + z) / Complex.Sqrt(Complex.Pow(c, 3)));

            return (int)z.Magnitude * 10;
        }

        int Tipo3(Complex c)
        {
            Complex z = new Complex(0, 1);

            for (int i = 0; i < 15; i++)
                z = Complex.Pow(Math.E, (Complex.Pow(z, 2) - z) / Complex.Sqrt(Complex.Pow(c, 3)));

            return (int)z.Magnitude * 10;
        }

        int Tipo4(Complex c)
        {
            Complex z = new Complex(1, 0);

            for (int i = 0; i < 7; i++)
                z = Complex.Sin(Complex.Pow(c, 2) * z);

            return (int)z.Magnitude * 10;
        }

        int Tipo5(Complex c)
        {
            Complex z = new Complex(0, 1);

            for (int i = 0; i < 5; i++)
                z = Complex.Sin(Complex.Pow(c, 2) * z);

            return (int)z.Magnitude * 10;
        }

        int Tipo6(Complex c)
        {
            //Insieme di Mandelbrot
            //Verisone originale

            Complex z = new Complex(0, 0);
            int i = 0;
            while(i < 100 && z.Magnitude <= 2)
            {
                z = Complex.Pow(z, 2);
                z += c;
                ++i;
            }


            if (z.Magnitude <= 2)
                return 255;
            else if(i < 10)
                return 60;
            else if(i < 30)
                return 120;

            return 180;

            //return (int)z.Magnitude * 10;
        }




        /*int CalcoloStella(Complex c)
        {
            Complex z = new Complex(1, 1);
            //Complex app;

            for (int i = 0; i < nRipetizioni; i++)
            {

                // app = Complex.Sqrt(Complex.Sqrt(c));
                //z = Complex.Pow(Math.E, (Complex.Pow(z, 2) + z)/ Complex.Pow(app, 2));

                z = Complex.Pow(Math.E, (Complex.Pow(z, 2) + z) / Complex.Sqrt(Complex.Pow(c, 3)));
            }
            //Se elevo alla terza o alla quarta o piu z vengono fuori altre frattali

            int t = (int)z.Magnitude * 10;

            if (t > 255)
                t = 255;
            else if (t < 0)
                t = 0;

            return t;
        }*/

        //*******************************************************************************
        void SmistaTread()
        {
            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = null;
            t1 = new Thread(T1);
            t2 = new Thread(T2);
            t3 = new Thread(T3);
            t4 = new Thread(T4);
            t5 = new Thread(T5);
            t6 = new Thread(T6);
            t7 = new Thread(T7);
            t8 = new Thread(T8);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();

            while (t1.IsAlive || t2.IsAlive || t3.IsAlive || t4.IsAlive || t5.IsAlive || t6.IsAlive || t7.IsAlive || t8.IsAlive)
                Thread.Sleep(50);
            AggiornaGrafica();
            return;
        }

        void T1()
        {
            
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel; i > Npixel - n14; i--)
                Procedimento(i,ref g);
            b1 = b;
        }
        void T2()
        {
            b2 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel - n14; i > Npixel - n12; i--)
                Procedimento(i,ref  g);
            b2 = b;
        }
        void T3()
        {
            b3 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel - n12; i > Npixel - n34; i--)
                Procedimento(i, ref g);
            b3 = b;
        }
        void T4()
        {
            b4 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel - n34; i > 0; i--)
                Procedimento(i, ref g);
            b4 = b;
        }
        void T5()
        {
            b5 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = 0; i > -n14; i--)
                Procedimento(i,ref g);
            b5 = b;
        }
        void T6()
        {
            b6 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = -14; i > -n12; i--)
                Procedimento(i, ref g);
            b6 = b;
        }
        void T7()
        {
            b7 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = -n12; i > -n34; i--)
                Procedimento(i, ref g);
            b7 = b;
        }
        void T8()
        {
            b8 = null;
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = -n34; i > -Npixel; i--)
                Procedimento(i, ref g);
            b8 = b;
        }
    }
}
