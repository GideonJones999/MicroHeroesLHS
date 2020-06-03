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
    class ShrinkHero: SuperHero
    {
        //VARS
        private int counter;

        //METHODS


        public ShrinkHero(string name) :base(name)
        {
            
        }

        public override void Move()
        {
            if (counter % 100 >= 50)
                rec.Inflate(4, 3);
            else
            rec.Inflate(-4, -3);

            counter++;
        base.Move();
        }
    }
}
