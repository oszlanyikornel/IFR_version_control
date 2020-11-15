using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08.entitie
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("images/car.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
