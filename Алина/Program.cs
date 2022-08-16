using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace TestLaba6
{
   public partial class Form1 : Form
   {
 
       public Form1()
       {
           InitializeComponent();
           //vx = v * Math.Cos(angle);      //перевод полярной координаты в декартову
           //vy = v * Math.Sin(angle);
       }
 
       double x = 10;
       double y = 10;
       double angle = 0;
       int v = 1;
       int radius = 47;
       double vx;
       double vy;
       List<Rectangle> arr = new List<Rectangle>();
       bool MoveCir = false;
       double oldX, oldY;
 
       private bool Collision(double CirX,double CirY,double CirR, double Cir2X,double Cir2Y,double Cir2R)
       {
           return (Math.Pow((Cir2X - CirX) * (Cir2X - CirX) + (Cir2Y - CirY) * (Cir2Y - CirY),1/2.0) <= (Cir2R/2 + CirR/2));
       }
       private void GamePaint(object sender, PaintEventArgs e)
       {
           e.Graphics.Clear(Color.White);
           for (int i = 0; i < arr.Count(); i++)
           {
               e.Graphics.DrawEllipse(Pens.Black, arr[i].X,arr[i].Y, arr[i].Height,arr[i].Width);
           }
 
           if (checkBox1.Checked)
           {
               e.Graphics.DrawEllipse(Pens.Black, Int32.Parse(Math.Round(x).ToString()), Int32.Parse(Math.Round(y).ToString()), radius, radius);
               e.Graphics.DrawRectangle(Pens.Black, 1, 1, 640, 480);
           }
           else
           {
               e.Graphics.DrawEllipse(Pens.Black, Int32.Parse(Math.Round(x).ToString()), Int32.Parse(Math.Round(y).ToString()), radius, radius);
               e.Graphics.DrawLine(Pens.Black, Int32.Parse(Math.Round(x+(radius/2)).ToString()), Int32.Parse(Math.Round(y+(radius/2)).ToString()), Int32.Parse(Math.Round((x + vx*8+(radius/2))).ToString()), Int32.Parse(Math.Round((y + vy*8+(radius / 2))).ToString()));
               e.Graphics.DrawRectangle(Pens.Black, 1, 1, 640, 480);
           }
       }
 
       private void timer1_Tick(object sender, EventArgs e)
       {
           while (arr.Count() > hScrollBar2.Value)
           {
               arr.RemoveAt(0);
           }
 
 
           if (!checkBox1.Checked)
           {
 
               vx = v * Math.Cos(angle);      //перевод полярной координаты в декартову
               vy = v * Math.Sin(angle);
 
           }
           if (checkBox1.Checked)
           {
               label5.Text = "";
               for (int i = 0; i< arr.Count(); i++)
               {
                   if (Collision(arr[i].X+ arr[i].Height/2, arr[i].Y+arr[i].Height/2, arr[i].Height, x+radius/2+vx,y+radius/2+vy,radius))
                   {
                       double X = x - arr[i].X;
                       double Y = y - arr[i].Y;
                       vx = v * X / Math.Pow(Math.Pow(X, 2) + Math.Pow(Y, 2), 1 / 2.0);
                       vy = v * Y / Math.Pow(Math.Pow(X, 2) + Math.Pow(Y, 2), 1 / 2.0);
                       label5.Text = "Пересечение";
                   }
               }
 
               if(x+vx<=0 || x+vx+radius >= 640)
               {
                   vx = -vx;
               }
 
               if (y + vy <= 0 || y + vy+ radius > 480)
               {
                   vy = -vy;
               }
 
               x += vx;
               y += vy;
           }
           this.Refresh();
       }
 
       private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
       {
           angle = Convert.ToDouble(hScrollBar1.Value) / 2; //  100
       }
 
       private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
       {
           label3.Text = hScrollBar2.Value.ToString();
       }
 
       private void Form1_Load(object sender, EventArgs e)
       {
 
       }
 
       private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
       {
           Rectangle Re = new Rectangle();
           Re.X = e.X - hScrollBar3.Value / 2;
           Re.Y = e.Y - hScrollBar3.Value / 2;
           Re.Width = hScrollBar3.Value;
           Re.Height = hScrollBar3.Value;
           bool collision = true;
           for (int i = 0; i < arr.Count(); i++)
           {
               if (Collision(Re.X + Re.Height / 2, Re.Y + Re.Height / 2, Re.Height,arr[i].X+ arr[i].Height/2, arr[i].Y+arr[i].Height/2,arr[i].Height))
               {
                   collision = false;
 
               }
           }
 
           if (Collision(Re.X+ Re.Height/2, Re.Y+ Re.Height/2, Re.Height, x + radius / 2, y + radius / 2, radius))
           {
               collision = false;
 
           }
 
           if (Re.X <=0 || Re.X+ Re.Height >= 640 || Re.Y  <= 0 || Re.Y + Re.Height >= 480)
           {
               collision = false;
           }
           if (collision)
           {
               arr.Add(Re);
           }
           if(arr.Count() > hScrollBar2.Value)
           {
               arr.RemoveAt(0);
           }
           
       }
 
       private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
       {
           if (!(checkBox1.Checked))
           {
               bool ChangeR = true;
               for (int i = 0; i < arr.Count(); i++)
               {
                   if (Collision(arr[i].X + arr[i].Height / 2, arr[i].Y + arr[i].Height / 2, arr[i].Height, x + hScrollBar4.Value / 2 + vx, y + hScrollBar4.Value / 2 + vy, hScrollBar4.Value))
                   {
                       ChangeR = false;
                   }
               }
 
               if (ChangeR)
               {
                   radius = hScrollBar4.Value;
               }
           }
       }
 
       private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
       {
           if (!checkBox1.Checked)
           {
               if (Collision(e.X, e.Y, 1, x + radius / 2, y + radius / 2, radius))
               {
                   MoveCir = true;
                   oldX = x;
                   oldY = y;
               }
           }
       }
 
       private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
       {
           if (MoveCir && !checkBox1.Checked)
           {
               x = e.X;
               y = e.Y;
           }
       }
 
       private void pictureBox1_Click(object sender, EventArgs e)
       {
 
       }
 
       private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
       {
           if (!checkBox1.Checked)
           {
               MoveCir = false;
 
               for (int i = 0; i < arr.Count(); i++)
               {
                   if (Collision(x + radius / 2, y + radius / 2, radius, arr[i].X + arr[i].Height / 2, arr[i].Y + arr[i].Height / 2, arr[i].Height))
                   {
                       x = oldX;
                       y = oldY;
 
                   }
               }
           }
       }
   }
}
