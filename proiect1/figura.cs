using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace proiect1
{
    abstract class figura
    {
        //variabile
        public int l = 0;
        public int L = 400;
        public int nrfig = 5;

        //metode
        public abstract Point[] daLungime();
        public abstract void deseneaza(Color color,PaintEventArgs e);

    }
    class triunghi : figura
    {
        private Point[] t1=new Point[15]; // reprezinta coordonatele x,y
        public override Point[] daLungime()
        {
            Random random = new Random();
            for(int i = 0; i < 15; i=i+3)
            {
                t1[i] = new Point(random.Next(l, L), random.Next(l,L));
                t1[i+1] = new Point(random.Next(l, L), random.Next(l, L));
                t1[i+2] = new Point(random.Next(l, L), random.Next(l, L));
               
            }
            return t1;
        }
        public override void deseneaza(Color color, PaintEventArgs e)
        {
            Pen pen=new Pen(color,2);
            int index = 0; // nr prin cate puncte am trecut

            t1 = daLungime();

            for(int i=0; i < nrfig ; i++)
            {
                Point[] PuncteDreptunghi ={
                    t1[index],
                    t1[index+1],
                    t1[index+2]
                };
                e.Graphics.DrawPolygon(pen, PuncteDreptunghi);
                index = index + 3;
            }
        }

    }
}
