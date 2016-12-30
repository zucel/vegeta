using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vegetavideoju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (p1.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p1.Visible = false;
            } if (p2.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p2.Visible = false;
            }
            if (p3.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p3.Visible = false;
            }
            if (p4.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p4.Visible = false;
            }
            if (p5.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p5.Visible = false;
            }
            if (p6.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p6.Visible = false;
            }
            if (p7.Bounds.IntersectsWith(vegetaLeft.Bounds))
            {
                p7.Visible = false;
            }


             switch (e.KeyData)
              {
                
                  case Keys.Left:
                 
                     vegetaLeft.Left -= 50;  //mueve la image 
                      break;



                  case Keys.Right:
                     
                      vegetaLeft.Left += 60;
                      break;



                 case Keys.Up:
                      
                      vegetaLeft.Top -= 60;                      
                      break;



                 case Keys.Down:
                      
                     vegetaLeft.Top += 60;
                      break;
            
              }
        }

        private void vegetaLeft_Click(object sender, EventArgs e)
        {

        }

        private void vegetaRigth_Click(object sender, EventArgs e)
        {
         
         
                  


            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                p1.Top = p1.Top + 10;
                p2.Top = p1.Top + 10;
                p3.Top = p1.Top + 10;
                p4.Top = p1.Top + 10;
                p5.Top = p1.Top + 10;
                p6.Top = p1.Top + 10;
                p7.Top = p1.Top + 10;   
            } while (x > 1);



        }

        private void p3_Click(object sender, EventArgs e)
        {

        }
        }
    }

