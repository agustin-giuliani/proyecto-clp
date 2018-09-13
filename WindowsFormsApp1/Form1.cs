using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //permite el uso del picture box no tocar
        Graphics lienzo;
        int x = 0, y = 0;
        Image imagen = Image.FromFile("rock.png");
        
        public Form1()
        {
            //permite que el se mueba el objeto
            InitializeComponent();
            lienzo = pitb1.CreateGraphics();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //movimiento de los cuadrados
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (label1.Left >= pitb1.Width)
            {
                label1.Left = 0;
            }
            label1.Left = label1.Left + 8;

            label2.Left = label2.Left + 8;
            if (label2.Left >= pitb1.Width)
            {
                label2.Left = 0;
            }

            label4.Left = label4.Left + 8;
            if (label4.Left >= pitb1.Width)
            {
                label4.Left = 0;
            }

            label5.Left = label5.Left + 8;
            if (label5.Left >= pitb1.Width)
            {
                label5.Left = 0;
            }

            label6.Left = label6.Left + 8;
            if (label6.Left >= pitb1.Width)
            {
                label6.Left = 0;
            }


        }


        //controles del la imagen por botones
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    if(y + imagen.Height+10<pitb1.Height)
                         y += 10;
                    break;

                case Keys.Left:
                    if(x-10>0)
                        x -= 10;  
                    break;

                case Keys.Right:
                    if(x+10+imagen.Width<pitb1.Width)
                         x += 10;
                    break;

                case Keys.Up:
                    if(y-10>0)
                    y -= 10;

                    break;
                default:
                    break;
            }
            lienzo.Clear(pitb1.BackColor);
            lienzo.DrawImage(imagen, x, y);

        }


    }

}
