using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace microheros
{
    class SuperHero
    {
        //VARS
        protected static ContentManager con;

        protected int xSpeed = 4;
        protected Rectangle rec;
        protected Texture2D pic;
        public static int Position = 0;

        //METHODS
        public static ContentManager Con
        {
            set { con = value; }
        }

        public SuperHero(string name = "widow")
        {
            pic = con.Load<Texture2D>(name);
            rec = new Rectangle(Position, 600, 621, 480);
            Position -= (2000/7);
        }

        public virtual void Move()
        {
            rec.X += xSpeed;
            if (rec.X > 1750)
            {
                rec.X = -250;
            }
        }
        public virtual void Draw(SpriteBatch sB)
        {
            sB.Draw(pic, rec, Color.White);
            Move();
        }
    }
}
