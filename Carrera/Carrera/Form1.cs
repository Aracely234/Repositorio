using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Carrera
{
    public partial class Form1 : Form
    {

        int a = 0, b = 0, c = 0, d = 0,f=0;
        //definir los diferentes procesos
        Thread c1;
        Thread c2;
        Thread c3;
        Thread c4;
        Thread c5;

        public void nuevo()
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            c1 = new Thread(new ThreadStart(funcion1));
            c2 = new Thread(new ThreadStart(funcion2));
            c3 = new Thread(new ThreadStart(funcion3));
            c4 = new Thread(new ThreadStart(funcion4));
            c5 = new Thread(new ThreadStart(funcion5));
            //sus.Enabled = true;
            //jo.Enabled = true;
            //res.Enabled = true;
            //ab.Enabled = true;

        }

        

        public Form1()
        {
            InitializeComponent();
          
        }
        
        public void funcion1()
        {
            while (true)
            {
                a++; caballo1.Location = new System.Drawing.Point(a, 0);
                Thread.Sleep(1);
                if ((panel1.Left - caballo1.Right) <-10)
                {
                    this.c1.Abort();
                    break;
                }

            }
        }
        public void funcion2()
        {
            while (true)
            {
                b++; caballo2.Location = new System.Drawing.Point(b, 79);
                Thread.Sleep(30);
                if ((panel1.Left - caballo2.Right) < -10)
                {
                    this.c2.Abort();
                    break;
                }

            }
        }
        public void funcion3()
        {
            while (true)
            {
                c++; caballo3.Location = new System.Drawing.Point(c, 158);
                Thread.Sleep(30);
                if ((panel1.Left - caballo3.Right) < -10)
                {
                    this.c3.Abort();
                    break;
                }

            }
        }
        public void funcion4()
        {
            while (true)
            {
                d++; caballo4.Location = new System.Drawing.Point(d, 237);
                Thread.Sleep(30);
                if ((panel1.Left - caballo4.Right) < -10)
                {
                    this.c4.Abort();
                    break;
                }

            }
        }
        public void funcion5()
        {
            while (true)
            {
                f++; caballo5.Location = new System.Drawing.Point(f, 316);
                Thread.Sleep(30);
                if ((panel1.Left - caballo5.Right) < -10)
                {
                    this.c5.Abort();
                    break;
                }

            }
        }

        private void sus_Click(object sender, EventArgs e)
        {
           
            try
            {
                c1.Suspend();
                c2.Suspend();
                c3.Suspend();
                c4.Suspend();
                c5.Suspend();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void res_Click(object sender, EventArgs e)
        {
            
            try
            {
                c1.Resume();
                c2.Resume();
                c3.Resume();
                c4.Resume();
                c5.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ab_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    c1.Abort();
                    c2.Abort();
                    c3.Abort();
                    c4.Abort();
                    c5.Abort();
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    caballo1.Location = new System.Drawing.Point(0, 0);
                    caballo2.Location = new System.Drawing.Point(0, 79);
                    caballo3.Location = new System.Drawing.Point(0, 158);
                    caballo4.Location = new System.Drawing.Point(0, 237);
                    caballo5.Location = new System.Drawing.Point(0, 316);
                    
                }

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void jo_Click(object sender, EventArgs e)
        {
            try
            {
                c1.Join();
                c2.Join();
                c3.Join();
                c4.Join();
                c5.Join();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Enabled = true; 
            try
            {
                c1.Start();
                c2.Start();
                c3.Start();
                c4.Start();
                c5.Start();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pictureBox5.Enabled = false;
        }

        

    }
}
